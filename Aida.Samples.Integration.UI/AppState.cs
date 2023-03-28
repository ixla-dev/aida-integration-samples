using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI
{
    public delegate void SelectedJobTemplateChanged(object sender, JobTemplateItem job);
    public delegate void SchedulerStatusChanged(object sender, WorkflowSchedulerStatus status);

    public class AppState
    {
        public event SelectedJobTemplateChanged SelectedJobTemplateChanged;
        public event SchedulerStatusChanged SchedulerStatusChanged;

        public bool Connected { get; set; }
        public string ApiBaseUrl { get; set; }
        public string DbConnectionString { get; set; }
        private JobTemplateItem _selectedJobTemplate;

        public JobTemplateItem SelectedJobTemplate
        {
            get => _selectedJobTemplate;
            set
            {
                if (value == _selectedJobTemplate) return;
                _selectedJobTemplate = value;
                SelectedJobTemplateChanged?.Invoke(this, _selectedJobTemplate);
            }
        }

        private WorkflowSchedulerStatus _workflowSchedulerStatus;

        public WorkflowSchedulerStatus WorkflowSchedulerStatus
        {
            get => _workflowSchedulerStatus;
            set
            {
                if (value == _workflowSchedulerStatus) return;
                _workflowSchedulerStatus = value;
                SchedulerStatusChanged?.Invoke(this, _workflowSchedulerStatus);
            }
        }
    }
}