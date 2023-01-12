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

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class JobStatusForm : Form
    {
        private CancellationTokenSource? _pollJobsCancellation;
        public BindingList<AidaJob> Jobs { get; } = new();
        public readonly MachineInterface _machineInterface;

        private readonly AppState _appState;


        public JobStatusForm(
            AppState appState,
            MachineInterface machineInterface)
        {
            _appState = appState;
            _machineInterface = machineInterface;
            InitializeComponent();

            dataGridJobs.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridJobs.DataSource = Jobs;
            dataGridJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridJobs.MultiSelect = false;

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
        }

        private void JobStatusForm_Load(object sender, EventArgs e)
        {
            StartPollingJobs();
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

        private void StartPollingJobs()
        {
            StopPollingJobs();
            _pollJobsCancellation = new CancellationTokenSource();
            Task.Run(async () =>
            {
                while (!_pollJobsCancellation.Token.IsCancellationRequested)
                {
                    try
                    {
                        if (_appState.SelectedJobTemplate == null) continue;
                        var result = (await _machineInterface.FetchJobsAsync(_appState.SelectedJobTemplate.Id).ConfigureAwait(false)).ToList();

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
            if (row.DataBoundItem is AidaJob data)
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await _machineInterface.SignalExternalProcessOutcomeAsync(
                            data.WorkflowId,
                            Sdk.Mini.Model.ExternalProcessOutcome.Faulted
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
            if (row.DataBoundItem is AidaJob data)
            {
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await _machineInterface.SignalExternalProcessOutcomeAsync(
                            data.WorkflowId,
                            Sdk.Mini.Model.ExternalProcessOutcome.Completed
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
            var job = row.DataBoundItem as AidaJob;
            if (job?.WorkflowStatus is not Sdk.Mini.Model.WorkflowStatus.Suspended)
                return;
            grid.ClearSelection();
            row.Selected = true;
            grid.Refresh();
            var cellRect = grid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            dataGridContextMenu.Show(grid, new Point(cellRect.Left + e.X, cellRect.Top + e.Y));
        }
    }
}