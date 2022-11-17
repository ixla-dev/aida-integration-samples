using System;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI.Model
{
    public class WorkflowMessage
    {
        public JobStatus JobStatus { get; set; }
        public DateTime ReceiveTimestamp { get; set; }
        public string MessageId { get; set; }
        public string WorkflowInstanceId { get; set; }
        public MessageType MessageType { get; set; }
        public string CorrelationId { get; set; }
        public string JobId { get; set; }
    }
}