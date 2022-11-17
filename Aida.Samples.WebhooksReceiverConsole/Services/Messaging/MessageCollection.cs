using System.Collections.Concurrent;
using System.Threading;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.WebhooksReceiverConsole.Services.Messaging
{
    public class MessageCollection
    {
        private readonly BlockingCollection<WorkflowMessage> _incomingMessages = new();
        public void AddMessage(WorkflowMessage message) => _incomingMessages.Add(message);
        public WorkflowMessage TakeMessage(CancellationToken cancellationToken)
        {
            return _incomingMessages.Take(cancellationToken);
        }
    }
}