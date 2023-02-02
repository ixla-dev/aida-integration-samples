using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI.Model
{
    public class AidaJobViewModel : INotifyPropertyChanged
    {

        private string _batchId;

        public string BatchId
        {
            get => _batchId;
            set
            {
                if (value == _batchId) return;
                _batchId = value;
                OnPropertyChanged();
            }

        }

        private int _jobId;

        public int JobId
        {
            get => _jobId;
            set
            {
                if (value == _jobId) return;
                _jobId = value;
                OnPropertyChanged();
            }
        }

        private string _workflowId;

        public string WorkflowId
        {
            get => _workflowId;
            set
            {
                if (value == _workflowId) return;
                _workflowId = value;
                OnPropertyChanged();
            }
        }


        private string _correlationId;

        public string CorrelationId
        {
            get => _correlationId;
            set
            {
                if (value == _correlationId) return;
                _correlationId = value;
                OnPropertyChanged();
            }
        }


        private string _executingActivity;

        public string ExecutingActivity
        {
            get => _executingActivity;
            set
            {
                if (value == _executingActivity) return;
                _executingActivity = value;
                OnPropertyChanged();
            }
        }

        private string _lastExecutedActivity;

        public string LastExecutedActivity
        {
            get => _lastExecutedActivity;
            set
            {
                if (value == _lastExecutedActivity) return;
                _lastExecutedActivity = value;
                OnPropertyChanged();
            }
        }

        private WorkflowStatus? _workflowStatus;

        public WorkflowStatus? WorkflowStatus
        {
            get => _workflowStatus;
            set
            {
                if (value == _workflowStatus) return;
                _workflowStatus = value;
                OnPropertyChanged();
            }
        }

        private JobStatus _jobStatus;

        public JobStatus JobStatus
        {
            get => _jobStatus;
            set
            {
                if (value == _jobStatus) return;
                _jobStatus = value;
                OnPropertyChanged();
            }
        }

        private DateTime _createTimestamp;

        public DateTime CreateTimestamp
        {
            get => _createTimestamp;
            set
            {
                if (value == _createTimestamp) return;
                _createTimestamp = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _startTimestamp;

        public DateTime? StartTimestamp
        {
            get => _startTimestamp;
            set
            {
                if (value == _startTimestamp) return;
                _startTimestamp = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _updateTimestamp;

        public DateTime? UpdateTimestamp
        {
            get => _updateTimestamp;
            set
            {
                if (value == _updateTimestamp) return;
                _updateTimestamp = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _completeTimestamp;

        public DateTime? CompleteTimestamp
        {
            get => _completeTimestamp;
            set
            {
                if (value == _completeTimestamp) return;
                _completeTimestamp = value;
                OnPropertyChanged();
            }
        }

        private string _jobErrorCode { get; set; }

        public string JobErrorCode
        {
            get => _jobErrorCode;
            set
            {
                if (value == _jobErrorCode) return;
                _jobErrorCode = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Update(AidaJobViewModel jobViewModel)
        {
            foreach (var p in GetType().GetProperties(
                         System.Reflection.BindingFlags.Public |
                         System.Reflection.BindingFlags.Instance))
            {
                p.SetValue(this, p.GetValue(jobViewModel));
            }
        }
    }
}