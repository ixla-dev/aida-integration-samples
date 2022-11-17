namespace Aida.Samples.Integration.UI.Model
{
    /// <summary>
    /// This models exists also in IXLA.Iws.Sdk.Mini
    /// </summary>
    public class EncoderLoadedMessage : WorkflowMessage
    {
        public string Hostname { get; set; } = "";
        public string EncoderId { get; set; }
        public string CallbackUrl { get; set; }
    }
    public class WorkflowCompletedMessage : WorkflowMessage { }
    public class WorkflowFaultedMessage : WorkflowMessage { }
    public class FeederEmptyMessage : WorkflowMessage { }
    public class WorkflowCancelledMessage : WorkflowMessage { }
}