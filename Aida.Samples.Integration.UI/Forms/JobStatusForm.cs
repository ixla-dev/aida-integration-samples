#nullable enable
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Model;
using Aida.Samples.Integration.UI.Services;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class JobStatusForm : Form
    {
        private CancellationTokenSource? _pollJobsCancellation;
        public BindingList<AidaJobViewModel> Jobs { get; } = new();
        public readonly MachineInterface _machineInterface;
        private readonly AppState _appState;

        public JobStatusForm(
            AppState appState,
            MachineInterface machineInterface)
        {
            _appState = appState;
            _machineInterface = machineInterface;
            InitializeComponent();

            dataGridJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridJobs.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridJobs.DataSource = Jobs;
            dataGridJobs.MultiSelect = false;
            dataGridJobs.CellFormatting += DataGridJobs_CellFormatting;

            foreach (DataGridViewColumn c in dataGridJobs.Columns)
            {
                if (c.ValueType == typeof(DateTime) || c.ValueType == typeof(DateTime?))
                    c.DefaultCellStyle.Format = "MM/dd HH:mm:ss";
            }

            _machineInterface.ConnectionStateChanged += (_, args) =>
            {
                if (args.Current is MachineInterfaceConnectionState.Disconnected)
                    StopPollingJobs();
                return Task.CompletedTask;
            };

            appState.SelectedJobTemplateChanged += (_, job) => StartPollingJobs(job);
        }

        private void DataGridJobs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as AidaJobViewModel;
            var cell = row.Cells[e.ColumnIndex]; 
            if (item is null) return;
            cell.Style.ForeColor = item.JobStatus switch
            {
                JobStatus.None => Color.DarkGray,
                JobStatus.Waiting => Color.Blue,
                JobStatus.Starting => Color.Blue,
                JobStatus.Resuming => Color.Blue,
                JobStatus.Running => Color.Blue,
                JobStatus.Completed => Color.DarkGreen,
                JobStatus.Cancelled => Color.DarkGray,
                JobStatus.Suspended => Color.Orange,
                JobStatus.Rejected => Color.DarkRed,
                JobStatus.Faulted => Color.DarkRed,
                _ => Color.DarkRed,
            };
            
        }

        private void JobStatusForm_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await _machineInterface.ConnectToExchangeDatabase().ConfigureAwait(false);
                StartPollingJobs(_appState.SelectedJobTemplate);
            });
        }

        private void StopPollingJobs()
        {
            if (_pollJobsCancellation == null) return;
            try
            {
                _pollJobsCancellation.Cancel();
                _pollJobsCancellation.Dispose();
            }
            catch
            {
            }
        }

        private void StartPollingJobs(JobTemplateItem job)
        {
            StopPollingJobs();
            _pollJobsCancellation = new CancellationTokenSource();
            Task.Run(async () =>
            {
                var tableDefinition = await _machineInterface.GetDataExchangeTableDefinition(job.Id).ConfigureAwait(false);
                while (!_pollJobsCancellation.Token.IsCancellationRequested)
                {
                    try
                    {
                        if (_appState.SelectedJobTemplate == null) continue;
                        var result = await _machineInterface.FetchJobsAsync(tableDefinition).ConfigureAwait(false);

                        RunInUIThread(dataGridJobs, () =>
                        {
                            if (result.Count == 0)
                            {
                                Jobs.Clear();
                                return;
                            }

                            for (var i = 1; i <= result.Count; i++)
                            {
                                var index = i - 1;
                                if (i > Jobs.Count) Jobs.Add(result.ElementAt(index));
                                else Jobs[index].Update(result.ElementAt(index));
                            }
                        });
                    }
                    catch
                    {
                        await Task.Delay(500);
                    }
                }
            });
        }

        private void RunInUIThread(Control ctrl, Action action, params object?[] args)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke(action, args);
            else
                action();
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridJobs.SelectedRows.Count <= 0) return;
            var row = dataGridJobs.SelectedRows[0];
            if (row.DataBoundItem is AidaJobViewModel data)
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await _machineInterface.SignalExternalProcessOutcomeAsync(
                            data.WorkflowId,
                            ExternalProcessOutcome.Faulted
                        ).ConfigureAwait(false);
                    }
                    catch
                    {
                    }
                });
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridJobs.SelectedRows.Count <= 0) return;
            var row = dataGridJobs.SelectedRows[0];
            if (row.DataBoundItem is AidaJobViewModel data)
            {
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await _machineInterface.SignalExternalProcessOutcomeAsync(
                            data.WorkflowId,
                            ExternalProcessOutcome.Completed
                        ).ConfigureAwait(false);
                    }
                    catch
                    {
                    }
                });
            }
        }

        private void dataGridJobs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var grid = (DataGridView)sender;
            if (e.RowIndex > grid.Rows.Count - 1)
                return;
            var row = grid.Rows[e.RowIndex];
            var job = row.DataBoundItem as AidaJobViewModel;
            if (job?.WorkflowStatus is not WorkflowStatus.Suspended)
                return;
            grid.ClearSelection();
            row.Selected = true;
            grid.Refresh();
            var cellRect = grid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            dataGridContextMenu.Show(grid, new Point(cellRect.Left + e.X, cellRect.Top + e.Y));
        }

        private void dataGridJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}