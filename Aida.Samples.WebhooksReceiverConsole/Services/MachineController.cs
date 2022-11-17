using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;

namespace Aida.Samples.WebhooksReceiverConsole.Services
{
    public class MachineController
    {
        private readonly IntegrationApi _api;
        private readonly IConfiguration _configuration;

        public MachineController(
            // IConfiguration is injected by AspNetCore, it provides an interface 
            // to access values from the appsettings.json file 
            IConfiguration configuration,
            IntegrationApi api)
        {
            _configuration = configuration;
            _api = api;
        }

        public async Task<WorkflowSchedulerStateDto> StartWorkflowSchedulerAsync(
            int jobTemplateId,
            bool dryRun = true
        )
        {
            var state = await _api.GetWorkflowSchedulerStateAsync();
            if (state.Status is WorkflowSchedulerStatus.Running or WorkflowSchedulerStatus.Starting)
                // no-op if the scheduler is already running
                return state;

            var workflowTypeName = _configuration.GetValue<string>("WorkflowTypeName");
            state = await _api.StartWorkflowSchedulerAsync(new WorkflowSchedulerStartupParamsDto
            {
                // The ID of the job template we want to use
                JobTemplateId = jobTemplateId,
                // Tell AIDA to reset the transport when the scheduler is started
                NoReset = false,
                // Tell AIDA it needs to fetch personalization data and update entities values 
                SkipEntityUpdates = false,
                // this can be static, Is the type name of the workflow definition we are using 
                WorkflowTypeName = workflowTypeName,
                // Tell AIDA if we want to disable the laser or not 
                DryRun = dryRun,
                // Number of cards to process before stopping the scheduler automatically. 
                // -1 = infinity
                StopAfter = -1,
                // Disable the redpointer during issuance
                DisableRedPointer = true,
                // This one can be static, it is being used only in modular systems
                TaskAllocationStrategy = "batch"
            });

            return state;
        }
    }
}