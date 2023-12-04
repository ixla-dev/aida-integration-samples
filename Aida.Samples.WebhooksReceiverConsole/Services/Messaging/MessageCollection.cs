using System.Collections.Concurrent;
using System.Threading;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.WebhooksReceiverConsole.Services.Messaging
{
    public class MachineMessage
    {
        public string IpAddress { get; set; }
        public WorkflowMessage Message { get; set; }
        public MachineMessage(string ipAddress, WorkflowMessage message)
        {
            IpAddress = ipAddress;
            Message = message;
        }
    }

    public class MessageCollection
    {
        private readonly ConcurrentQueue<MachineMessage> _incomingMessages = new();
        public void AddMessage(MachineMessage message) => _incomingMessages.Enqueue(message);
        public MachineMessage TakeMessage(CancellationToken cancellationToken) => _incomingMessages.TryDequeue(out var message) ? message : null;
    }
}