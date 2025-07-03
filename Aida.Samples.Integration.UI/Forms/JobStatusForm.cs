#nullable enable
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Model;
using Aida.Samples.Integration.UI.Services;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class JobStatusForm : Form
    {
        private CancellationTokenSource? _pollJobsCancellation;
        public BindingList<AidaJobViewModel> Jobs { get; } = new();
        public readonly  MachineInterface _machineInterface;
        private readonly AppState         _appState;

        public JobStatusForm(
            AppState appState,
            MachineInterface machineInterface
            )
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
            var row  = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as AidaJobViewModel;
            var cell = row.Cells[e.ColumnIndex];
            if (item is null) return;

            cell.Style.ForeColor = item.JobStatus switch
            {
                JobStatus.None      => Color.DarkGray,
                JobStatus.Waiting   => Color.Blue,
                JobStatus.Starting  => Color.Blue,
                JobStatus.Resuming  => Color.Goldenrod,
                JobStatus.Running   => Color.Green,
                JobStatus.Completed => Color.DarkGreen,
                JobStatus.Cancelled => Color.DarkGray,
                JobStatus.Suspended => Color.Orange,
                JobStatus.Rejected  => Color.DarkRed,
                JobStatus.Faulted   => Color.DarkRed,
                _                   => Color.DarkRed
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
                const int lastCompletedJob = 0;
                var       tableDefinition  = await _machineInterface.GetDataExchangeTableDefinition(job.Id).ConfigureAwait(false);
                while (!_pollJobsCancellation.Token.IsCancellationRequested)
                {
                    try
                    {
                        if (_appState.SelectedJobTemplate == null) continue;
                        var result = await _machineInterface.FetchJobsAsync(tableDefinition, last_completed_job: lastCompletedJob, limit: 50).ConfigureAwait(false);
                        RunInUIThread(dataGridJobs, () =>
                        {
                            if (result.Count == 0)
                            {
                                Jobs.Clear();
                                return;
                            }

                            result = result.OrderBy(m => m.JobId).ToList();
                            var resultMap   = result.ToDictionary(model => model.JobId, model => model);
                            var existingMap = Jobs.ToDictionary(model => model.JobId, model => model);

                            foreach (var kv in resultMap)
                            {
                                if (existingMap.TryGetValue(kv.Key, out var value))
                                    value.Update(kv.Value);
                                else
                                    Jobs.Insert(0, kv.Value);
                            }

                            var lastJobs = Jobs.TakeLast(50);
                            var toRemove = Jobs.Except(lastJobs);
                            foreach (var j in toRemove)
                                Jobs.Remove(j);
                        });
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        await Task.Delay(250).ConfigureAwait(false);
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
                        await _machineInterface.SignalExternalProcessOutcomeAsync(data.WorkflowId, ExternalProcessOutcome.Faulted).ConfigureAwait(false);
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
                        await _machineInterface.SignalExternalProcessOutcomeAsync(data.WorkflowId, ExternalProcessOutcome.Completed).ConfigureAwait(false);
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

        private void dataGridJobs_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}