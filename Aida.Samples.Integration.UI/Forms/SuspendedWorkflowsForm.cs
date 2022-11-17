using System;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Model;
using Aida.Samples.Integration.UI.Services;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class SuspendedWorkflowsForm : Form
    {
        private WebhooksHandler _webhooksHandler;

        public SuspendedWorkflowsForm(
            WebhooksHandler webhooksHandler)
        {
            InitializeComponent();
            _webhooksHandler = webhooksHandler;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = _webhooksHandler.MessagesToProcess;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            _webhooksHandler.MessageReceived += (sender, e) => {
                ThreadSafeUpdateGrid();
            };
            _webhooksHandler.MessageHandled += (sender, e) => {
                ThreadSafeUpdateGrid();
            };
        }

        private async void BtnResume_Click(object sender, System.EventArgs e)
        {
            var item = GetSelectedItem();
            if (item is not null) await _webhooksHandler.MarkCompleted(item);
        }

        private async void BtnReject_Click(object sender, System.EventArgs e)
        {
            var item = GetSelectedItem();
            if (item is not null) await _webhooksHandler.MarkRejected(item);
        }

        public void ThreadSafeUpdateGrid()
        {
            Action func = () => (BindingContext[dataGridView1.DataSource] as CurrencyManager).Refresh();
            if (dataGridView1.InvokeRequired)
                dataGridView1.Invoke(func, Array.Empty<object>());
            else {
                func();
            }
        }

        private void UIThreadExec(Action action) { 
            if (InvokeRequired)
            {
                Invoke(action);
            } else
            {
                action();
            }
        }

        private WorkflowMessage GetSelectedItem()
        {
            var count = dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                return _webhooksHandler.GetMessageByIndex(index);
            }
            else
            {
                return null;
            }
        }

        private async void SuspendedWorkflowsForm_Load(object sender, EventArgs e)
        {
            await _webhooksHandler.FetchSuspendedWorkflows();
        }
    }
}