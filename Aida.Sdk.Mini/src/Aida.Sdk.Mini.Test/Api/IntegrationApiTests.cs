/*
 * aida-mini
 *
 * 1.0.524
 *
 * The version of the OpenAPI document: 1.0.524
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Api;
// uncomment below to import models
//using Aida.Sdk.Mini.Model;

namespace Aida.Sdk.Mini.Test.Api
{
    /// <summary>
    ///  Class for testing IntegrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IntegrationApiTests : IDisposable
    {
        private IntegrationApi instance;

        public IntegrationApiTests()
        {
            instance = new IntegrationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IntegrationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IntegrationApi
            //Assert.IsType<IntegrationApi>(instance);
        }

        /// <summary>
        /// Test CreateJobTemplate
        /// </summary>
        [Fact]
        public void CreateJobTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //CreateJobTemplateDto createJobTemplateDto = null;
            //var response = instance.CreateJobTemplate(scannerId, createJobTemplateDto);
            //Assert.IsType<JobTemplateDto>(response);
        }

        /// <summary>
        /// Test CreateWebhooksTarget
        /// </summary>
        [Fact]
        public void CreateWebhooksTargetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhooksTargetDto webhooksTargetDto = null;
            //var response = instance.CreateWebhooksTarget(webhooksTargetDto);
            //Assert.IsType<WebhooksTargetDto>(response);
        }

        /// <summary>
        /// Test DeleteInkjetLayout
        /// </summary>
        [Fact]
        public void DeleteInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteInkjetLayout(id);
        }

        /// <summary>
        /// Test DeleteJobTemplate
        /// </summary>
        [Fact]
        public void DeleteJobTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string scannerId = null;
            //instance.DeleteJobTemplate(id, scannerId);
        }

        /// <summary>
        /// Test DeleteLayout
        /// </summary>
        [Fact]
        public void DeleteLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string scannerId = null;
            //instance.DeleteLayout(id, scannerId);
        }

        /// <summary>
        /// Test DeleteWebhooksTarget
        /// </summary>
        [Fact]
        public void DeleteWebhooksTargetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteWebhooksTarget(id);
            //Assert.IsType<WebhooksTargetDto>(response);
        }

        /// <summary>
        /// Test EstablishContext
        /// </summary>
        [Fact]
        public void EstablishContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCardEstablishContextParamsDto sCardEstablishContextParamsDto = null;
            //instance.EstablishContext(sCardEstablishContextParamsDto);
        }

        /// <summary>
        /// Test FindInkjetLayouts
        /// </summary>
        [Fact]
        public void FindInkjetLayoutsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? includeFile = null;
            //bool? includeEntities = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.FindInkjetLayouts(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<SearchInkjetLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test FindJobTemplates
        /// </summary>
        [Fact]
        public void FindJobTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //bool? includeLayouts = null;
            //bool? includeFile = null;
            //bool? includeEntities = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.FindJobTemplates(scannerId, includeLayouts, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<SearchJobTemplatesResultDto>(response);
        }

        /// <summary>
        /// Test FindLayouts
        /// </summary>
        [Fact]
        public void FindLayoutsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //bool? includeFile = null;
            //bool? includeEntities = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.FindLayouts(scannerId, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<SearchLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test FindWebhooksTargets
        /// </summary>
        [Fact]
        public void FindWebhooksTargetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.FindWebhooksTargets(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<SearchWebhooksTargetsResultDto>(response);
        }

        /// <summary>
        /// Test GetAssignableInkjetLayoutsByJobTemplateId
        /// </summary>
        [Fact]
        public void GetAssignableInkjetLayoutsByJobTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //int? pageSize = null;
            //string supportSide = null;
            //var response = instance.GetAssignableInkjetLayoutsByJobTemplateId(id, page, pageSize, supportSide);
            //Assert.IsType<SearchInkjetLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test GetAssignableLayoutsByJobTemplateId
        /// </summary>
        [Fact]
        public void GetAssignableLayoutsByJobTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //int? pageSize = null;
            //string supportSide = null;
            //var response = instance.GetAssignableLayoutsByJobTemplateId(id, page, pageSize, supportSide);
            //Assert.IsType<SearchLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test GetAssignedLayoutsByJobTemplateId
        /// </summary>
        [Fact]
        public void GetAssignedLayoutsByJobTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.GetAssignedLayoutsByJobTemplateId(id, page, pageSize);
            //Assert.IsType<SearchJobLayoutsResultDto>(response);
        }

        /// <summary>
        /// Test GetDataExchangeTableDefinition
        /// </summary>
        [Fact]
        public void GetDataExchangeTableDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobId = null;
            //var response = instance.GetDataExchangeTableDefinition(jobId);
            //Assert.IsType<DataExchangeTableDefinition>(response);
        }

        /// <summary>
        /// Test GetEntityDescriptorsByJobTemplateId
        /// </summary>
        [Fact]
        public void GetEntityDescriptorsByJobTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobId = null;
            //var response = instance.GetEntityDescriptorsByJobTemplateId(jobId);
            //Assert.IsType<List<EntityDescriptor>>(response);
        }

        /// <summary>
        /// Test GetJobTemplateById
        /// </summary>
        [Fact]
        public void GetJobTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string scannerId = null;
            //var response = instance.GetJobTemplateById(id, scannerId);
            //Assert.IsType<JobTemplateDto>(response);
        }

        /// <summary>
        /// Test GetLayoutById
        /// </summary>
        [Fact]
        public void GetLayoutByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string scannerId = null;
            //var response = instance.GetLayoutById(id, scannerId);
            //Assert.IsType<LayoutDto>(response);
        }

        /// <summary>
        /// Test GetMetrics
        /// </summary>
        [Fact]
        public void GetMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMetrics();
            //Assert.IsType<RuntimeMetrics>(response);
        }

        /// <summary>
        /// Test GetQueuedJobs
        /// </summary>
        [Fact]
        public void GetQueuedJobsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetQueuedJobs();
            //Assert.IsType<List<int>>(response);
        }

        /// <summary>
        /// Test GetReader
        /// </summary>
        [Fact]
        public void GetReaderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //var response = instance.GetReader(readerIndex);
            //Assert.IsType<SCardReader>(response);
        }

        /// <summary>
        /// Test GetReaders
        /// </summary>
        [Fact]
        public void GetReadersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetReaders();
            //Assert.IsType<List<SCardReader>>(response);
        }

        /// <summary>
        /// Test GetRunningWorkflows
        /// </summary>
        [Fact]
        public void GetRunningWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRunningWorkflows();
            //Assert.IsType<List<WorkflowInstanceSummaryModel>>(response);
        }

        /// <summary>
        /// Test GetSmartCardAtr
        /// </summary>
        [Fact]
        public void GetSmartCardAtrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //var response = instance.GetSmartCardAtr(readerIndex);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test GetSmartCardStatus
        /// </summary>
        [Fact]
        public void GetSmartCardStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //var response = instance.GetSmartCardStatus(readerIndex);
            //Assert.IsType<SCardState>(response);
        }

        /// <summary>
        /// Test GetWebhooksTargetById
        /// </summary>
        [Fact]
        public void GetWebhooksTargetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetWebhooksTargetById(id);
            //Assert.IsType<WebhooksTargetDto>(response);
        }

        /// <summary>
        /// Test GetWorkflowRegistry
        /// </summary>
        [Fact]
        public void GetWorkflowRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWorkflowRegistry();
            //Assert.IsType<WorkflowBlueprintSummaryModelPagedList>(response);
        }

        /// <summary>
        /// Test GetWorkflowSchedulerState
        /// </summary>
        [Fact]
        public void GetWorkflowSchedulerStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWorkflowSchedulerState();
            //Assert.IsType<WorkflowSchedulerStateDto>(response);
        }

        /// <summary>
        /// Test ImportLayoutFile
        /// </summary>
        [Fact]
        public void ImportLayoutFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //string layoutName = null;
            //string filename = null;
            //var response = instance.ImportLayoutFile(scannerId, layoutName, filename);
            //Assert.IsType<LayoutDto>(response);
        }

        /// <summary>
        /// Test ImportLayoutFileValidation
        /// </summary>
        [Fact]
        public void ImportLayoutFileValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string layoutName = null;
            //string filename = null;
            //instance.ImportLayoutFileValidation(layoutName, filename);
        }

        /// <summary>
        /// Test ReleaseContext
        /// </summary>
        [Fact]
        public void ReleaseContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ReleaseContext();
        }

        /// <summary>
        /// Test RenameInkjetLayout
        /// </summary>
        [Fact]
        public void RenameInkjetLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string name = null;
            //var response = instance.RenameInkjetLayout(id, name);
            //Assert.IsType<InkjetLayoutDto>(response);
        }

        /// <summary>
        /// Test RenameLayout
        /// </summary>
        [Fact]
        public void RenameLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string name = null;
            //var response = instance.RenameLayout(id, name);
            //Assert.IsType<LayoutDto>(response);
        }

        /// <summary>
        /// Test ResumeWorkflowScheduler
        /// </summary>
        [Fact]
        public void ResumeWorkflowSchedulerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResumeWorkflowScheduler();
            //Assert.IsType<List<JobInstance>>(response);
        }

        /// <summary>
        /// Test SignalExternalProcessCompleted
        /// </summary>
        [Fact]
        public void SignalExternalProcessCompletedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? waitForCompletion = null;
            //ExternalProcessCompletedMessage externalProcessCompletedMessage = null;
            //var response = instance.SignalExternalProcessCompleted(waitForCompletion, externalProcessCompletedMessage);
            //Assert.IsType<List<JobInstance>>(response);
        }

        /// <summary>
        /// Test SmartCardConnect
        /// </summary>
        [Fact]
        public void SmartCardConnectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //SCardConnectParamsDto sCardConnectParamsDto = null;
            //var response = instance.SmartCardConnect(readerIndex, sCardConnectParamsDto);
            //Assert.IsType<PcScConnectResult>(response);
        }

        /// <summary>
        /// Test SmartCardDisconnect
        /// </summary>
        [Fact]
        public void SmartCardDisconnectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //SCardDisconnectParamsDto sCardDisconnectParamsDto = null;
            //var response = instance.SmartCardDisconnect(readerIndex, sCardDisconnectParamsDto);
            //Assert.IsType<PCSCActionResultDto>(response);
        }

        /// <summary>
        /// Test SmartCardReconnect
        /// </summary>
        [Fact]
        public void SmartCardReconnectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //SCardReconnectParamsDto sCardReconnectParamsDto = null;
            //instance.SmartCardReconnect(readerIndex, sCardReconnectParamsDto);
        }

        /// <summary>
        /// Test StartWorkflowScheduler
        /// </summary>
        [Fact]
        public void StartWorkflowSchedulerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WorkflowSchedulerStartupParamsDto workflowSchedulerStartupParamsDto = null;
            //var response = instance.StartWorkflowScheduler(workflowSchedulerStartupParamsDto);
            //Assert.IsType<WorkflowSchedulerStateDto>(response);
        }

        /// <summary>
        /// Test StopWorkflowScheduler
        /// </summary>
        [Fact]
        public void StopWorkflowSchedulerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? stopAllRunningWorkflows = null;
            //JobErrorCodes? errorCode = null;
            //var response = instance.StopWorkflowScheduler(stopAllRunningWorkflows, errorCode);
            //Assert.IsType<WorkflowSchedulerStateDto>(response);
        }

        /// <summary>
        /// Test TestWebhookTarget
        /// </summary>
        [Fact]
        public void TestWebhookTargetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.TestWebhookTarget(id);
            //Assert.IsType<WebhookTargetTestResultDto>(response);
        }

        /// <summary>
        /// Test Transmit
        /// </summary>
        [Fact]
        public void TransmitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int readerIndex = null;
            //byte[] body = null;
            //var response = instance.Transmit(readerIndex, body);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test UpdateWebhooksTarget
        /// </summary>
        [Fact]
        public void UpdateWebhooksTargetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhooksTargetDto webhooksTargetDto = null;
            //var response = instance.UpdateWebhooksTarget(webhooksTargetDto);
            //Assert.IsType<WebhooksTargetDto>(response);
        }

        /// <summary>
        /// Test UploadLayoutFile
        /// </summary>
        [Fact]
        public void UploadLayoutFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string layoutName = null;
            //string supportSide = null;
            //string scannerId = null;
            //List<FileParameter> files = null;
            //var response = instance.UploadLayoutFile(layoutName, supportSide, scannerId, files);
            //Assert.IsType<LayoutDto>(response);
        }

        /// <summary>
        /// Test ValidateInkjetLayoutName
        /// </summary>
        [Fact]
        public void ValidateInkjetLayoutNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //string body = null;
            //var response = instance.ValidateInkjetLayoutName(scannerId, body);
            //Assert.IsType<NameValidationResultDto>(response);
        }

        /// <summary>
        /// Test ValidateJobTemplateName
        /// </summary>
        [Fact]
        public void ValidateJobTemplateNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //string body = null;
            //var response = instance.ValidateJobTemplateName(scannerId, body);
            //Assert.IsType<NameValidationResultDto>(response);
        }

        /// <summary>
        /// Test ValidateLayoutName
        /// </summary>
        [Fact]
        public void ValidateLayoutNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //string body = null;
            //var response = instance.ValidateLayoutName(scannerId, body);
            //Assert.IsType<NameValidationResultDto>(response);
        }
    }
}
