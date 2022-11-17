﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;

namespace Aida.Samples.Integration.UI.Services
{
    public class WebhooksHandler
    {
        public string ApiBaseUrl { get; set; }

        public delegate void MessageReceivedHandler(WebhooksHandler handler, Model.WorkflowMessage message);
        public delegate void MessageHandledHandler(WebhooksHandler sender, Model.WorkflowMessage message);

        public event MessageReceivedHandler MessageReceived;
        public event MessageHandledHandler MessageHandled;
        public List<Model.WorkflowMessage> MessagesToProcess { get; set; } = new();
        public bool ContainsMessage(Model.WorkflowMessage message)
            => MessagesToProcess.Any(m => string.Equals(m.WorkflowInstanceId, message.WorkflowInstanceId));

        public Model.WorkflowMessage GetMessageByIndex(int index) => MessagesToProcess[index];
        public Model.WorkflowMessage GetMessageByWorkflowInstanceId(string workflowInstanceId)
            => MessagesToProcess.FirstOrDefault(m => string.Equals(m.WorkflowInstanceId, workflowInstanceId));
        public IConfiguration _configuration;
        public WebhooksHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Add(Model.WorkflowMessage message, bool force = false)
        {
            if (!ContainsMessage(message))
                MessagesToProcess.Add(message);
            MessageReceived?.Invoke(this, message);
        }

        public void Remove(Model.WorkflowMessage message)
        {
            if (ContainsMessage(message))
                MessagesToProcess.Remove(message);
            MessageHandled?.Invoke(this, message);
        }


        public void OnWorkflowFaulted(Model.WorkflowFaultedMessage message)
        {
            var m = GetMessageByWorkflowInstanceId(message.WorkflowInstanceId);
            if (m != null)
                Remove(m);
        }

        public void OnFeederEmpty(Model.FeederEmptyMessage feederEmpty)
        {
            Add(feederEmpty);
        }

        public void OnWorkflowCompleted(Model.WorkflowCompletedMessage message)
        {
            var m = GetMessageByWorkflowInstanceId(message.WorkflowInstanceId);
            if (m != null)
                Remove(m);
        }

        public async Task MarkRejected(Model.WorkflowMessage message)
        {
            // For the sake of simplicity i didn't add timeout/retry logic here 
            // but it might be a good idea, since transient failures are always possible 
            // in distributed applications
            using var api = new IntegrationApi(ApiBaseUrl);

            // Signal AIDA that the external process (encoding/ocr validation) has completed
            await api.SignalExternalProcessCompletedAsync(
                // if set to true, the server will return the response when the workflow 
                // finishes 
                waitForCompletion: false,
                new ExternalProcessCompletedMessage
                {
                    // Tells AIDA what action should it take when it receives the notification
                    RequiredAction = WorkflowAction.Reject,
                    // we tell AIDA the operation failed
                    Outcome = ExternalProcessOutcome.Faulted,
                    ErrorReason = "Manually rejected",
                    WorkflowInstanceId = message.WorkflowInstanceId
                }).ConfigureAwait(false);
        }

        public async Task MarkCompleted(Model.WorkflowMessage message)
        {
            using var api = new IntegrationApi(ApiBaseUrl);
            await api.SignalExternalProcessCompletedAsync(
                // if set to true, the server will return the response when the workflow 
                // finishes 
                waitForCompletion: false,
                new ExternalProcessCompletedMessage
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    RequiredAction = WorkflowAction.Resume,
                    WorkflowInstanceId = message.WorkflowInstanceId
                }).ConfigureAwait(false);
        }

        public async Task FetchSuspendedWorkflows()
        {
        }
    }
}