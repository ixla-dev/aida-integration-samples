using System.Collections.Concurrent;
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
        public void Enqueue(MachineMessage message) => _incomingMessages.Enqueue(message);
        public MachineMessage TakeMessage() => _incomingMessages.TryDequeue(out var message) ? message : null;
    }
}