using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Aida.Samples.Integration.UI.Extensions;
using Aida.Samples.Integration.UI.Model;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Aida.Samples.Integration.UI.Services
{
    public enum MachineInterfaceConnectionState
    {
        Disconnected,
        Connecting,
        Connected
    }

    public class MachineInterfaceConnectionStateChangedArgs
    {
        public string IpAddress;
        public string DbConnectionString;
        public MachineInterfaceConnectionState Previous { get; set; }
        public MachineInterfaceConnectionState Current { get; set; }
    }

    public class WorkflowSchedulerStateChangedEventArgs
    {
        public WorkflowSchedulerStateDto Previous { get; set; }
        public WorkflowSchedulerStateDto Current { get; set; }
    }

    /// <summary>
    /// Class that wraps interactions with the system, both via APIs and Exchange Database
    /// </summary>
    public class MachineInterface
    {
        private string _apiAddress;
        private string _dbConnectionString;
        private CancellationTokenSource _pollCancellation;

        public WorkflowSchedulerStateDto WorkflowSchedulerState;
        private NpgsqlConnection _dbConnection;
        public MachineInterfaceConnectionState _connectionState = MachineInterfaceConnectionState.Disconnected;

        public MachineInterfaceConnectionState ConnectionState
        {
            get => _connectionState;
            set
            {
                if (value == _connectionState) return;

                var previous = _connectionState;
                _connectionState = value;

                ConnectionStateChanged?.Invoke(this, new MachineInterfaceConnectionStateChangedArgs
                {
                    IpAddress = _apiAddress,
                    DbConnectionString = _dbConnectionString,
                    Previous = previous,
                    Current = value
                });
                UpdateState(new WorkflowSchedulerStateDto
                {
                    Status = null
                });
            }
        }

        private readonly IConfiguration _configuration;
        public delegate Task MachineInterfaceConnectionStateChanged(object sender, MachineInterfaceConnectionStateChangedArgs args);
        public delegate Task WorkflowSchedulerStateChangedHandler(object sender, WorkflowSchedulerStateChangedEventArgs args);
        public event WorkflowSchedulerStateChangedHandler WorkflowSchedulerStateChanged;
        public event MachineInterfaceConnectionStateChanged ConnectionStateChanged;

        /// <summary>
        /// </summary>
        /// <param name="apiAddress">Address of the system (ex. http://127.0.0.1:5000)</param>
        /// <param name="dbConnectionString">Connection string for the Exchange Database (this demo only supports embedded PostgreSQL instance)</param>
        public MachineInterface(string apiAddress, string dbConnectionString, IConfiguration configuration)
        {
            _apiAddress = apiAddress;
            _dbConnectionString = dbConnectionString;
            _configuration = configuration;
        }

        /// <summary>
        /// Tries to query the AIDA's API and connect to the shared 
        /// database
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task ConnectAsync(TimeSpan? timeout)
        {
            try
            {
                ConnectionState = MachineInterfaceConnectionState.Connecting;
                await ConnectToMachineApi(timeout).ConfigureAwait(false);
                await ConnectToExchangeDatabase().ConfigureAwait(false);
                ConnectionState = WorkflowSchedulerState != null && _dbConnection.State == System.Data.ConnectionState.Open
                    ? MachineInterfaceConnectionState.Connected
                    : MachineInterfaceConnectionState.Disconnected;
            }
            catch
            {
                ConnectionState = MachineInterfaceConnectionState.Disconnected;
                throw;
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task ConnectToMachineApi(TimeSpan? timeout)
        {
            try
            {
                // just send a request so we know we are able to reach the machine
                await GetWorkflowSchedulerStateAsync(timeout).ConfigureAwait(false);
            }
            catch (ApiException)
            {
                ConnectionState = MachineInterfaceConnectionState.Disconnected;
            }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task ConnectToExchangeDatabase()
        {
            if (_dbConnection != null)
            {
                await _dbConnection.DisposeAsync();
                _dbConnection = null;
            }

            _dbConnection = new NpgsqlConnection(_dbConnectionString);
            _dbConnection.StateChange += (_, args) =>
            {
                if (args.CurrentState != System.Data.ConnectionState.Broken) return;
                {
                    _dbConnection.Close();
                    StopPollingState();
                }
            };
            await _dbConnection.OpenAsync();
        }

        /// <summary>
        /// Get all the JobTemplates configured on the system
        /// </summary>
        /// <returns>List of JobTemplates</returns>
        public async Task<List<JobTemplateDto>> GetAvailableJobTemplatesAsync(TimeSpan? timeout = null)
        {
            using var api = GetClient(timeout);
            return (await api.FindJobTemplatesAsync().ConfigureAwait(false)).Items;
        }

        /// <summary>
        /// Retrieves the list of entities for a given job template. 
        /// </summary>
        /// <param name="jobTemplateId">ID of the JobTemplate</param>
        /// <returns>List of Entities</returns>
        public List<EntityDescriptor> GetEntitiesPerJobTemplate(int jobTemplateId)
        {
            using var api = GetClient();
            return api.GetEntityDescriptorsByJobTemplateId(jobTemplateId);
        }

        /// <summary>
        /// Builds and executes the insert statement for the provided list of records, which will be inserted 
        /// in the shared "Data Exchange Table" 
        /// </summary>
        /// <param name="jobTemplateId">ID of the JobTemplate</param>
        /// <param name="records">List of PersonalizationRecords</param>
        public void PushPersonalizationDataToExchangeDatabase(int jobTemplateId, List<PersonalizationRecord> records)
        {
            using var etl = GetClient();

            var etlDefinition = etl.GetDataExchangeTableDefinition(jobTemplateId);
            foreach (var r in records)
            {
                var ins = DatabaseUtils.BuildInsertStatement(etlDefinition.TableName, _dbConnection, r.Fields);
                ins.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Helper method that inserts a record in the shared database table. This is used 
        /// to avoid having to populate records manually while testing.
        /// </summary>
        /// <param name="jobTemplateId">
        /// The target job template Id. This is used to retrieve the DataSourceConfiguration for the
        /// given job template, which contains the connection information for the shared database
        /// </param>
        /// <returns></returns>
        public async Task InsertMockRecord(int jobTemplateId, string batchId)
        {
            using var api = GetClient();

            var record = new PersonalizationRecord();
            var fields = await api.GetEntityDescriptorsByJobTemplateIdAsync(jobTemplateId).ConfigureAwait(false);
            var job = await api.GetJobTemplateByIdAsync(jobTemplateId).ConfigureAwait(false);

            foreach (var f in fields)
            {
                if (f.ValueType is EntityFieldValueType.String)
                {
                    record.Fields.Add(f.EntityName.StartsWith("FE_")
                        ? new PersonalizationField(f.EntityName, "123123")
                        : new PersonalizationField(f.EntityName, f.EntityName));
                }
            }

            // the magnetic stripe operations are enabled, the system uses these values 
            // to write them 

            if ((job.MagStripeConfiguration?.Operations ?? MagneticStripeOperations.None) != MagneticStripeOperations.None)
            {
                record.Fields.Add(new PersonalizationField("magnetic_track_1_w", "TRACK 1"));
                record.Fields.Add(new PersonalizationField("magnetic_track_2_w", "123456789"));
                record.Fields.Add(new PersonalizationField("magnetic_track_3_w", "1234"));
            }

            record.Fields.Add(new PersonalizationField("batch_id", batchId));

            var etlDefinition = await api.GetDataExchangeTableDefinitionAsync(jobTemplateId).ConfigureAwait(false);
            var statement = DatabaseUtils.BuildInsertStatement(etlDefinition.TableName, _dbConnection, record.Fields);
            await statement.ExecuteNonQueryAsync().ConfigureAwait(false);
        }

        public async Task<WorkflowSchedulerStateDto> ResumeSchedulerAsync()
        {
            using var api = GetClient();
            await api.ResumeWorkflowSchedulerAsync().ConfigureAwait(false);
            return await api.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Starts the workflow scheduler for the given JobTemplate
        /// </summary>
        /// <param name="jobTemplateName"></param>
        public async Task StartWorkflowSchedulerAsync(string jobTemplateName, string batchId)
        {
            using var api = GetClient();
            var startupParams = new WorkflowSchedulerStartupParamsDto
            {
                JobTemplateName = jobTemplateName,
                DisableRedPointer = false,
                DryRun = true,
                NoReset = false,
                SkipEntityUpdates = false,
                StopAfter = -1,
                TaskAllocationStrategy = null,
                WorkflowTypeName = _configuration.GetValue<string>("WorkflowTypeName"),
                MetadataFields = new Dictionary<string, object>
                {
                    ["Field"] = "Some data you might need in your process that we are not storing",
                    ["Another"] = "This fields will be sent back to you in webhooks"
                },
                FilterJobsBy = new List<FilterDto> { new("batch_id", new List<string> { batchId }) }
            };
            var state = await GetWorkflowSchedulerStateAsync();
            if (state.Status == WorkflowSchedulerStatus.Running) return;
            try
            {
                state = await api.StartWorkflowSchedulerAsync(startupParams).ConfigureAwait(false);
                UpdateState(state);
            }
            catch
            {
                state = await api.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                UpdateState(state);
            }
        }
        /// <summary>
        /// Stops all currently running workflows
        /// </summary>
        public async Task StopPersonalizationCycleAsync()
        {
            using var scheduler = GetClient();
            var state = await scheduler.StopWorkflowSchedulerAsync(true);
            UpdateState(state);
        }

        /// <summary>
        /// Gets status information from the WorkflowScheduler service. 
        /// </summary>
        /// <returns></returns>
        public async Task<WorkflowSchedulerStateDto> GetWorkflowSchedulerStateAsync(TimeSpan? timeout = null)
        {
            using var scheduler = GetClient();
            var state = await scheduler
                .GetWorkflowSchedulerStateAsync()
                .ConfigureAwait(false);
            UpdateState(state);
            return state;
        }

        /// <summary>
        /// Updates the scheduler state (in memory) that is used to notify the UI 
        /// and enable/disable buttons accordingly 
        /// </summary>
        /// <param name="state"></param>
        private void UpdateState(WorkflowSchedulerStateDto state)
        {
            if (state.Status == WorkflowSchedulerState?.Status) return;
            var previous = WorkflowSchedulerState;
            WorkflowSchedulerState = state;
            WorkflowSchedulerStateChanged?.Invoke(this, new WorkflowSchedulerStateChangedEventArgs
            {
                Current = state,
                Previous = previous
            });
        }

        /// <summary>
        /// </summary>
        /// <param name="workflowInstanceId"></param>
        /// <param name="outcome"></param>
        /// <param name="errorReason"></param>
        /// <param name="requiredAction"></param>
        /// <returns></returns>
        public async Task SignalExternalProcessOutcomeAsync(
            string workflowInstanceId,
            ExternalProcessOutcome outcome,
            string errorReason = null,
            WorkflowAction? requiredAction = null)
        {
            var api = GetClient();
            await api.SignalExternalProcessCompletedAsync(
                // tells the server to dispatch the signal asynchronously 
                waitForCompletion: false,
                new ExternalProcessCompletedMessage
                {
                    Outcome = outcome,
                    WorkflowInstanceId = workflowInstanceId,
                    RequiredAction = requiredAction,
                    ErrorReason = errorReason
                }
            );
        }

        /// <summary>
        /// Get current jobs status from shared database
        /// </summary>
        /// <param name="jobTemplateId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<IEnumerable<AidaJob>> FetchJobsAsync(int jobTemplateId, int offset = 0, int limit = 50)
        {
            try
            {
                var etl = GetClient();
                var definition = await etl.GetDataExchangeTableDefinitionAsync(jobTemplateId).ConfigureAwait(false);

                await using var cmd = _dbConnection.CreateCommand();

                cmd.CommandText = $@"select * from ""{definition.TableName}"" order by job_id desc offset @offset limit @limit";
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limit", limit);

                await using var reader = cmd.ExecuteReader();

                var list = new List<AidaJob>();
                while (reader.Read())
                {
                    var job = new AidaJob
                    {
                        JobId = reader.ReadInt32("job_id"),
                        BatchId = reader.ReadNullableString("batch_id"),
                        JobErrorCode = reader.ReadNullableString("job_error_code"),
                        LastExecutedActivity = reader.ReadNullableString("last_executed_activity_name"),
                        ExecutingActivity = reader.ReadNullableString("current_activity_name"),
                        CorrelationId = reader.ReadNullableString("correlation_id"),
                        CreateTimestamp = reader.ReadDateTime("create_timestamp"),
                        StartTimestamp = reader.ReadNullableDateTime("start_timestamp"),
                        UpdateTimestamp = reader.ReadNullableDateTime("update_timestamp"),
                        CompleteTimestamp = reader.ReadNullableDateTime("complete_timestamp"),
                        WorkflowId = reader.ReadNullableString("workflow_id"),
                        WorkflowStatus =
                            Enum.TryParse<WorkflowStatus>(reader.ReadNullableString("workflow_status") ?? "", out var workflowStatus)
                                ? workflowStatus
                                : null,
                        JobStatus = Enum.Parse<JobStatus>(reader.ReadString("job_status"))
                    };
                    list.Add(job);
                }

                return list;
            }
            catch (Exception)
            {
                return Array.Empty<AidaJob>();
            }
        }

        private IntegrationApi GetClient(TimeSpan? timeout = null)
        {
            timeout ??= TimeSpan.FromSeconds(1);
            return new IntegrationApi(new Configuration
            {
                BasePath = _apiAddress,
                Timeout = (int)timeout.Value.TotalMilliseconds
            });
        }

        public void StopPollingState()
        {
            try
            {
                _pollCancellation?.Cancel();
                _pollCancellation?.Dispose();
            }
            catch
            {
            }
        }

        public void StartPollingState()
        {
            if (_pollCancellation != null)
            {
                _pollCancellation.Cancel();
                _pollCancellation.Dispose();
            }

            _pollCancellation = new CancellationTokenSource();
            Task.Run(async () =>
            {
                while (!_pollCancellation.IsCancellationRequested)
                {
                    try
                    {
                        await GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                        ConnectionState = MachineInterfaceConnectionState.Connected;
                        await Task.Delay(1000).ConfigureAwait(false);
                    }
                    catch
                    {
                        ConnectionState = MachineInterfaceConnectionState.Connecting;
                        await Task.Delay(1000).ConfigureAwait(false);
                    }
                }
            });
        }
    }
}