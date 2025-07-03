using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Services;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class MainForm : Form
    {
        private          CancellationTokenSource _pollCancellation = new();
        private readonly IConfiguration          _configuration;
        private readonly ILogger<MainForm>       _logger;
        private readonly IServiceProvider        _serviceProvider;
        public AppState AppState { get; set; }

        private MachineInterface _machineInterface;

        public MainForm(
            IConfiguration configuration,
            ILogger<MainForm> logger,
            IServiceProvider serviceProvider)
        {
            _configuration = configuration;
            _logger = logger;
            _serviceProvider = serviceProvider;
            AppState = new AppState
            {
                Connected = false,
                ApiBaseUrl = null,
                DbConnectionString = null,
                SelectedJobTemplate = null,
                WorkflowSchedulerStatus = WorkflowSchedulerStatus.Stopped
            };
            InitializeComponent();
        }

        private void OpenSuspendedWorkflowsForm()
        {
            var handler = _serviceProvider.GetRequiredService<WebhooksHandler>();
            handler.MessageReceived += (_, e) =>
            {
                if (e.MessageType is MessageType.FeederEmpty)
                {
                    Task.Run(() =>
                    {
                        var result = UiThreadExec(() =>
                        {
                            const MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                            return MessageBox.Show("Feeder empty. Please reload the machine and press ok.", "Feeder Empty", buttons);
                        });
                        switch (result)
                        {
                            case DialogResult.Retry:
                                Task.Run(async () => await _machineInterface.ResumeSchedulerAsync().ConfigureAwait(false));
                                break;
                            case DialogResult.Cancel:
                                Task.Run(async () => await _machineInterface.StopPersonalizationCycleAsync().ConfigureAwait(false));
                                break;
                        }
                    });
                }
            };
            handler.ApiBaseUrl = AppState.ApiBaseUrl;
        }

        private void OpenJobsStatusForm()
        {
            var form = new JobStatusForm(AppState, new MachineInterface(TxtIpAddress.Text, TxtConnectionString.Text, _configuration));
            form.Show();
        }


        /// <summary>
        /// Handles the click event for the "Connect" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// When the user presses the connect button, the application does the following:
        /// <para>
        /// Checks if the machine can be reached via HTTP
        /// </para>
        /// <para>
        /// Opens a connection to the PostgreSQL instance hosted by the machine
        /// </para>
        /// <para>
        /// Starts a background thread to poll the Workflow Scheduler State. The workflow
        /// scheduler state indicates if the machine is looking for data in data exchange tables
        /// for a particular job template
        /// </para>
        /// </remarks>
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (sender is not Control btn)
                return;
            btn.Enabled = false;
            try
            {
                var defaultTimeout = TimeSpan.FromSeconds(1);

                // Get connection information from the UI
                AppState.ApiBaseUrl = TxtIpAddress.Text.TrimEnd('/');
                AppState.DbConnectionString = TxtConnectionString.Text;
                // Create an instance of the machine interface class.
                _machineInterface = new MachineInterface(TxtIpAddress.Text, TxtConnectionString.Text, _configuration);
                _machineInterface.WorkflowSchedulerStateChanged += WorkflowScheduler_StateChanged;
                _machineInterface.ConnectionStateChanged += MachineInterface_ConnectionStateChanged;
                // Connect async checks if the machine API can be reached by invoking GetWorkflowSchedulerState and
                // tries to establish a connection to the hosted database. If any of those operations fail an exception
                // will be thrown.
                await _machineInterface.ConnectAsync(timeout: defaultTimeout);
                _machineInterface.StartPollingState();

                //retrieve the list of JobTemplates to allow the users to choose the JobTemplate they'll be working with
                var jobTemplates = await _machineInterface.GetAvailableJobTemplatesAsync();
                jobTemplates = jobTemplates.ToList();

                var workflows        = await _machineInterface.GetWorkflowsAsync();
                var workflowItems    = workflows.Select(wf => new WorkflowItem(wf.Name, wf.DisplayName)).ToArray();
                var jobTemplateItems = jobTemplates.Select(jt => new JobTemplateItem(jt.Id!.Value, jt.Name, jt.Description)).ToArray();

                UiThreadExec(() =>
                {
                    cmbBoxWorkflows.Items.AddRange(workflowItems as WorkflowItem[] ?? []);
                    cmbJobTemplates.Items.AddRange(jobTemplateItems as JobTemplateItem[] ?? []);

                    if (_machineInterface.WorkflowSchedulerState is null)
                        return;

                    if (_machineInterface.WorkflowSchedulerState.Status == WorkflowSchedulerStatus.Running)
                    {
                        var selectedJobTemplate = jobTemplateItems.First(item => item.Id == _machineInterface.WorkflowSchedulerState.CurrentJobTemplateId);
                        var selectedWorkflow    = workflowItems.First(item => item.TypeName == _machineInterface.WorkflowSchedulerState.WorkflowTypeName);
                        cmbJobTemplates.SelectedItem = selectedJobTemplate;
                        cmbBoxWorkflows.SelectedItem = selectedWorkflow;
                        UpdateUi(_machineInterface.WorkflowSchedulerState.Status);
                    }
                    else
                    {
                        if (cmbBoxWorkflows.Items.Count > 0) cmbBoxWorkflows.SelectedItem = cmbBoxWorkflows.Items[0];
                        if (cmbJobTemplates.Items.Count > 0) cmbJobTemplates.SelectedItem = cmbJobTemplates.Items[0];
                    }

                    grpBoxConnections.Enabled = false;
                    pnlJobTemplate.Enabled = true;
                    OpenSuspendedWorkflowsForm();
                    OpenJobsStatusForm();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Connection Failed");
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void Disconnect() { _machineInterface.StopPollingState(); }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //PLEASE NOTE:
            //This part was to have a ready-to-use interface to input personalization data
            //In a typical integration this part should be replaced with a connector to your data source that pulls personalization data
            //and writes it into the Exchange database

            //Retrieves the list of entities to allow the insertion of a new record
            var entities = _machineInterface.GetEntitiesPerJobTemplate(((JobTemplateItem)cmbJobTemplates.SelectedItem).Id);

            _logger.LogDebug("Retrieving layouts fields from descriptor, {count} entities found", entities.Count);

            DialogResult res;

            do
            {
                //Initialize and show a form that allows to input personalization data
                using var frmIns = _serviceProvider.GetRequiredService<InsertDataForm>();
                res = frmIns.Initialize(entities).ShowDialog();

                if (res is DialogResult.OK or DialogResult.Retry)
                {
                    //Add the record with the personalization data to a listbox
                    listPersoRecordsToSend.Items.Add(frmIns.Record);
                }
            } while (res == DialogResult.Retry);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listPersoRecordsToSend.SelectedItem != null)
            {
                //Remove the selected record with the personalization data from the listbox
                listPersoRecordsToSend.Items.Remove(listPersoRecordsToSend.SelectedItem);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //Converts the list of personalization records in a plain array
            var recordCopy = new object[listPersoRecordsToSend.Items.Count];
            listPersoRecordsToSend.Items.CopyTo(recordCopy, 0);

            //Writes the list of records to the Exchange Database
            _machineInterface.PushPersonalizationDataToExchangeDatabase(((JobTemplateItem)cmbJobTemplates.SelectedItem).Id,
                recordCopy.Select(_ => (PersonalizationRecord)_).ToList());

            listPersoRecordsToSend.Items.Clear();
        }
        private async void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            cmbJobTemplates.Enabled = false;
            AppState.SelectedJobTemplate = (JobTemplateItem)cmbJobTemplates.SelectedItem;
            pnlDataControls.Enabled = true;
            UpdateUi(_machineInterface.WorkflowSchedulerState?.Status);
        }

        private async void btnStop_Click(object sender, EventArgs e) { await _machineInterface.StopPersonalizationCycleAsync().ConfigureAwait(false); }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            var selectedWorkflow    = (WorkflowItem)cmbBoxWorkflows.SelectedItem;
            var selectedJobTemplate = (JobTemplateItem)cmbJobTemplates.SelectedItem;
            var batchId             = txtBatchId.Text.Trim();
            var dryRun              = checkBoxDryRun.Checked;

            if (selectedJobTemplate is null)
            {
                MessageBox.Show("Please select a job template from the drop down menu");
                return;
            }

            await Task.Run(async () =>
            {
                try
                {
                    var state = await _machineInterface.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                    if (state.Status == WorkflowSchedulerStatus.Running && state.CurrentJobTemplateName != selectedJobTemplate.Name)
                        await _machineInterface.StopPersonalizationCycleAsync().ConfigureAwait(false);
                    //Starts the workflow scheduler for the given JobTemplate, the system will now start personalizing supports
                    await _machineInterface.StartWorkflowSchedulerAsync(
                        jobTemplateName: selectedJobTemplate.Name,
                        batchId: batchId,
                        workflowTypeName: "",
                        dryRun: dryRun).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Failed to start workflow scheduler");
                }
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Populates UI elements with data extracted from appsettings.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// appsettings.json is located in the bin folder fo the application
        /// </remarks>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var dbUser     = _configuration.GetSection("MachineInterface:DbUser").Get<string>();
            var dbPassword = _configuration.GetSection("MachineInterface:DbPassword").Get<string>();
            var dbPort     = _configuration.GetSection("MachineInterface:DbPort").Get<int>();
            var ipAddress  = _configuration.GetSection("MachineInterface:IpAddress").Get<string>();
            var baseUrl    = $"http://{ipAddress}:5000";

            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = ipAddress,
                Port = dbPort,
                Database = "ixla_iws",
                Password = dbPassword,
                Username = dbUser
            };

            TxtConnectionString.Text = builder.ToString();
            TxtIpAddress.Text = baseUrl;
        }

        /// <summary>
        /// Event handler for connection state changed event triggerd
        /// by MachineInterface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns>
        /// </returns>

        private Task MachineInterface_ConnectionStateChanged(object sender, MachineInterfaceConnectionStateChangedArgs args)
        {
            switch (args.Current)
            {
                case MachineInterfaceConnectionState.Connecting:
                    UpdateUi(null);
                    break;
                case MachineInterfaceConnectionState.Connected:
                    EnableJobTemplateSelection(true);
                    SetWindowTitle($"Connected (Scheduler: {_machineInterface.WorkflowSchedulerState?.Status})");
                    break;
                case MachineInterfaceConnectionState.Disconnected:
                    EnableJobTemplateSelection(false);
                    SetWindowTitle("Disconnected");
                    break;
            }

            return Task.CompletedTask;
        }

        private void SetWindowTitle(string text) => UiThreadExec(() => Text = text);

        private Task WorkflowScheduler_StateChanged(object sender, WorkflowSchedulerStateChangedEventArgs args)
        {
            UpdateUi(args.Current.Status, args.Current.CurrentJobTemplateId);
            return Task.CompletedTask;
        }

        private void UpdateUi(WorkflowSchedulerStatus? status, int? currentJobId = null)
        {
            UiThreadExec(() =>
            {
                var errorCode = _machineInterface.WorkflowSchedulerState?.Errors?.Any() ?? false
                    ? _machineInterface.WorkflowSchedulerState?.Errors?.First().ToString() ?? "Ok"
                    : "Ok";

                SetWindowTitle(status != null
                    ? $"{_machineInterface.ConnectionState} (Scheduler: {status}, {errorCode}))"
                    : $"{_machineInterface.ConnectionState}");

                if (currentJobId is not null) UpdateSelectedJob(currentJobId.Value);
                EnableJobTemplateSelection(status is WorkflowSchedulerStatus.Stopped or null);
                EnableDataControls(true);

                var isConnected = _machineInterface.ConnectionState is MachineInterfaceConnectionState.Connected;

                pnlJobTemplate.Enabled = isConnected;
                pnlSchedulerControls.Enabled = isConnected;
                btnStart.Enabled = isConnected && status is WorkflowSchedulerStatus.Stopped or WorkflowSchedulerStatus.FeederEmpty or null;
                btnStop.Enabled = isConnected && status == WorkflowSchedulerStatus.Running;

                if (status is WorkflowSchedulerStatus.FeederEmpty)
                    MessageBox.Show("Feeder Empty!");

                pnlSchedulerControls.Refresh();
                btnStart.Refresh();
                btnStop.Refresh();
            });
        }

        private void UpdateSelectedJob(int jobTemplateId)
        {
            foreach (JobTemplateItem item in cmbJobTemplates.Items)
            {
                if (item.Id != jobTemplateId)
                    continue;
                cmbJobTemplates.SelectedItem = item;
                break;
            }
        }

        private void EnableDataControls(bool enabled)
        {
            UiThreadExec(() =>
            {
                pnlDataControls.Enabled = enabled;
                foreach (Control c in pnlDataControls.Controls) c.Enabled = enabled;
            });
        }

        private void EnableJobTemplateSelection(bool enabled)
        {
            UiThreadExec(() =>
            {
                // pnlJobTemplate.Enabled = enabled;
                foreach (Control c in pnlJobTemplate.Controls)
                    c.Enabled = enabled;
            });
        }

        public T UiThreadExec<T>(Control control, Func<T> fn, params object[] args)
        {
            args ??= Array.Empty<object>();
            if (control.InvokeRequired) return (T)control.Invoke(fn, args);
            return fn();
        }

        private void UiThreadExec(Control control, Action action, params object[] args)
        {
            args ??= Array.Empty<object>();
            if (control.InvokeRequired) control.Invoke(action, args);
            else action();
        }

        public T UiThreadExec<T>(Func<T> fn, params object[] args) => UiThreadExec(this, fn, args);

        private void UiThreadExec(Action action, params object[] args) => UiThreadExec(this, action, args);

        private void TxtConnectionString_TextChanged(object sender, EventArgs e) { }

        private void btnClearJobs_Click(object sender, EventArgs e)
        {
            _ = Task.Run(async () => await _machineInterface.ClearJobsAsync(AppState.SelectedJobTemplate.Id)).ConfigureAwait(false);
        }
        private async void btnInsertRecord_Click(object sender, EventArgs e)
        {
            var item = (JobTemplateItem)cmbJobTemplates.SelectedItem;
            if (item is null)
            {
                MessageBox.Show("Please select a job template from the drop down menu");
                return;
            }

            var templateId = item.Id;
            await _machineInterface.InsertBatch(templateId, txtBatchId.Text, 1).ConfigureAwait(false);
        }

        private void cmbJobTemplates_SelectedIndexChanged(object sender, EventArgs e) { AppState.SelectedJobTemplate = (JobTemplateItem)cmbJobTemplates.SelectedItem; }
        private void btnResume_Click(object sender, EventArgs e) { _ = Task.Run(_machineInterface.ResumeSchedulerAsync).ConfigureAwait(false); }
    }
}