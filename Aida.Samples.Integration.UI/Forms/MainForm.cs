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
            var form = new SuspendedWorkflowsForm(handler);
            form.Show();
        }

        private void OpenJobsStatusForm()
        {
            var form = new JobStatusForm(AppState, _machineInterface);
            form.Show();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var defaultTimeout = TimeSpan.FromSeconds(1);
                //Create an instance of MachineInterface class, used to interact with the system
                AppState.ApiBaseUrl = TxtIpAddress.Text;
                AppState.DbConnectionString = TxtConnectionString.Text;

                _machineInterface = new MachineInterface(TxtIpAddress.Text, TxtConnectionString.Text, _configuration);
                _machineInterface.WorkflowSchedulerStateChanged += WorkflowScheduler_StateChanged;
                _machineInterface.ConnectionStateChanged += MachineInterface_ConnectionStateChanged;
                await _machineInterface.ConnectAsync(timeout: defaultTimeout).ConfigureAwait(false);
                _machineInterface.StartPollingState();

                //retrieve the list of JobTemplates to allow the user to choose the JobTemplate he'll working with
                var jobTemplates = await _machineInterface.GetAvailableJobTemplatesAsync().ConfigureAwait(false);

                var items = jobTemplates.Select(_ => new JobTemplateItem
                {
                    Name = _.Name,
                    Id = _.Id!.Value,
                    Description = _.Description
                }).ToArray();


                UiThreadExec(() =>
                {
                    cmbJobTemplates.Items.AddRange(items);

                    if (_machineInterface.WorkflowSchedulerState.Status == WorkflowSchedulerStatus.Running)
                    {
                        var selectedItem = items.First(item => item.Id == _machineInterface.WorkflowSchedulerState.CurrentJobTemplate.Id);
                        cmbJobTemplates.SelectedItem = selectedItem;
                        UpdateUi(_machineInterface.WorkflowSchedulerState.Status);
                    }
                    else
                    {
                        if (cmbJobTemplates.Items.Count == 1)
                            cmbJobTemplates.SelectedItem = cmbJobTemplates.Items[0];
                    }

                    grpBoxConnections.Enabled = false;
                    pnlJobTemplate.Enabled = true;
                    OpenSuspendedWorkflowsForm();
                    OpenJobsStatusForm();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void Disconnect()
        {
            _machineInterface.StopPollingState();
        }


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
            object[] recordCopy = new object[listPersoRecordsToSend.Items.Count];
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
            UpdateUi(_machineInterface.WorkflowSchedulerState.Status);
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await _machineInterface.StopPersonalizationCycleAsync().ConfigureAwait(false);
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            var item = (JobTemplateItem)cmbJobTemplates.SelectedItem;
            if (item is null)
            {
                MessageBox.Show("Please select a job template from the drop down menu");
                return;
            }

            await Task.Run(async () =>
            {
                try
                {
                    var state = await _machineInterface.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                    if (state.Status == WorkflowSchedulerStatus.Running && state.CurrentJobTemplate.Name != item.Name)
                        await _machineInterface.StopPersonalizationCycleAsync().ConfigureAwait(false);
                    //Starts the workflow scheduler for the given JobTemplate, the system will now start personalizing supports
                    await _machineInterface.StartWorkflowSchedulerAsync(item.Name, txtBatchId.Text).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Failed to start workflow scheduler");
                }
            }).ConfigureAwait(false);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var dbUser     = _configuration.GetSection("MachineInterface:DbUser").Get<string>();
            var dbPassword = _configuration.GetSection("MachineInterface:DbPassword").Get<string>();
            var dbPort     = _configuration.GetSection("MachineInterface:DbPort").Get<int>();
            var ipAddress  = _configuration.GetSection("MachineInterface:IpAddress").Get<string>();
            var baseUrl    = $"http://{ipAddress}:5000";

            var builder = new NpgsqlConnectionStringBuilder();
            builder.Host = ipAddress;
            builder.Port = dbPort;
            builder.Database = "ixla_iws";
            builder.Password = dbPassword;
            builder.Username = dbUser;

            TxtConnectionString.Text = builder.ToString();
            TxtIpAddress.Text = baseUrl;
        }

        private Task MachineInterface_ConnectionStateChanged(object sender, MachineInterfaceConnectionStateChangedArgs args)
        {
            switch (args.Current)
            {
                case MachineInterfaceConnectionState.Connecting:
                    UpdateUi(null, null);
                    break;
                case MachineInterfaceConnectionState.Connected:
                    EnableJobTemplateSelection(true);
                    SetWindowTitle($"Connected (Scheduler: {_machineInterface.WorkflowSchedulerState.Status})");
                    break;
                case MachineInterfaceConnectionState.Disconnected:
                    EnableJobTemplateSelection(false);
                    SetWindowTitle("Disconnected");
                    break;
            }

            return Task.CompletedTask;
        }

        private void SetWindowTitle(string text) => UiThreadExec(() => Text = text);

        private async Task WorkflowScheduler_StateChanged(object sender, WorkflowSchedulerStateChangedEventArgs args)
        {
            UpdateUi(args.Current.Status, args.Current.CurrentJobTemplate);
        }

        private void UpdateUi(WorkflowSchedulerStatus? status, JobTemplateDto? currentJob = null)
        {
            UiThreadExec(() =>
            {
                var errorCode = _machineInterface.WorkflowSchedulerState?.Errors?.Any() ?? false
                              ? _machineInterface.WorkflowSchedulerState?.Errors?.First().ToString() ?? "Ok"
                              : "Ok";
                if (status != null)
                    SetWindowTitle($"{_machineInterface.ConnectionState} (Scheduler: {_machineInterface.WorkflowSchedulerState.Status}, {errorCode}))");
                else
                    SetWindowTitle($"{_machineInterface.ConnectionState}");

                if (currentJob != null) UpdateSelectedJob(currentJob);
                EnableJobTemplateSelection(status == WorkflowSchedulerStatus.Stopped || status is null);
                EnableDataControls(status == WorkflowSchedulerStatus.Running);

                var isConnected = _machineInterface.ConnectionState is MachineInterfaceConnectionState.Connected;

                pnlJobTemplate.Enabled = isConnected;
                pnlSchedulerControls.Enabled = isConnected;
                btnStart.Enabled = isConnected && (status is WorkflowSchedulerStatus.Stopped or WorkflowSchedulerStatus.FeederEmpty || status == null);
                btnStop.Enabled = isConnected && (status == WorkflowSchedulerStatus.Running);

                if (status is WorkflowSchedulerStatus.FeederEmpty)
                    MessageBox.Show("Feeder Empty!");

                pnlSchedulerControls.Refresh();
                btnStart.Refresh();
                btnStop.Refresh();
            });
        }

        private void UpdateSelectedJob(JobTemplateDto jobTemplate)
        {
            foreach (JobTemplateItem item in cmbJobTemplates.Items)
            {
                if (item.Id == jobTemplate.Id)
                {
                    cmbJobTemplates.SelectedItem = item;
                    break;
                }
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
                pnlJobTemplate.Enabled = enabled;
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

        public T UiThreadExec<T>(Func<T> fn, params object[] args)
        {
            return UiThreadExec<T>(this, fn, args);
        }

        private void UiThreadExec(Action action, params object[] args)
        {
            UiThreadExec(this, action, args);
        }

        private void TxtConnectionString_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertRecord_Click(object sender, EventArgs e)
        {
            var item = (JobTemplateItem)cmbJobTemplates.SelectedItem;
            if (item is null)
            {
                MessageBox.Show("Please select a job template from the drop down menu");
                return;
            }

            var id = item.Id;
            Task.Run(async () => { await _machineInterface.InsertMockRecord(id, txtBatchId.Text); });
        }

        private void cmbJobTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.SelectedJobTemplate = (JobTemplateItem)cmbJobTemplates.SelectedItem;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await _machineInterface.ResumeSchedulerAsync());
        }

        private void txtBatchId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}