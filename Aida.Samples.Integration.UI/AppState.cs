using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI
{
    public class AppState
    {
        public bool Connected { get; set; }
        public string ApiBaseUrl { get; set; }
        public string DbConnectionString { get; set; }
        public JobTemplateItem SelectedJobTemplate { get; set; }
        public WorkflowSchedulerStatus WorkflowSchedulerStatus { get; set; }
    }
}