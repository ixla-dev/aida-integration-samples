﻿using System;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Model;
using Aida.Samples.Integration.UI.Services;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class SuspendedWorkflowsForm : Form
    {
        private readonly WebhooksHandler _webhooksHandler;

        public SuspendedWorkflowsForm(
            WebhooksHandler webhooksHandler)
        {
            InitializeComponent();
            _webhooksHandler = webhooksHandler;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = _webhooksHandler.MessagesToProcess;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            _webhooksHandler.MessageReceived += (_, _) => { ThreadSafeUpdateGrid(); };
            _webhooksHandler.MessageHandled += (_, _) => { ThreadSafeUpdateGrid(); };
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
            void Func() => (BindingContext[dataGridView1.DataSource] as CurrencyManager)?.Refresh();
            if (dataGridView1.InvokeRequired)
                dataGridView1.Invoke((Action)Func, Array.Empty<object>());
            else
            {
                Func();
            }
        }

        private void UIThreadExec(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
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

        private async void SuspendedWorkflowsForm_Load(object sender, EventArgs e) { await WebhooksHandler.FetchSuspendedWorkflows(); }
    }
}