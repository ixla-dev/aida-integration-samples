/*
 * aida-mini
 *
 * 1.0.308
 *
 * The version of the OpenAPI document: 1.0.308
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Aida.Sdk.Mini.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Aida.Sdk.Mini.Test.Model
{
    /// <summary>
    ///  Class for testing WorkflowMessage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WorkflowMessageTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WorkflowMessage
        //private WorkflowMessage instance;

        public WorkflowMessageTests()
        {
            // TODO uncomment below to create an instance of WorkflowMessage
            //instance = new WorkflowMessage();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowMessageInstanceTest()
        {
            // TODO uncomment below to test "IsType" WorkflowMessage
            //Assert.IsType<WorkflowMessage>(instance);
        }

        /// <summary>
        /// Test deserialize a EncoderLoadedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void EncoderLoadedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a EncoderLoadedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new EncoderLoadedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a FeederEmptyMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void FeederEmptyMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a FeederEmptyMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new FeederEmptyMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a OcrExecutedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void OcrExecutedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a OcrExecutedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new OcrExecutedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowCancelledMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowCancelledMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowCancelledMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowCancelledMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowCompletedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowCompletedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowCompletedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowCompletedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowFaultedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowFaultedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowFaultedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowFaultedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowSchedulerProcessSuspendedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowSchedulerProcessSuspendedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowSchedulerProcessSuspendedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowSchedulerProcessSuspendedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowSchedulerStartedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowSchedulerStartedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowSchedulerStartedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowSchedulerStartedMessage().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WorkflowSchedulerStoppedMessage from type WorkflowMessage
        /// </summary>
        [Fact]
        public void WorkflowSchedulerStoppedMessageDeserializeFromWorkflowMessageTest()
        {
            // TODO uncomment below to test deserialize a WorkflowSchedulerStoppedMessage from type WorkflowMessage
            //Assert.IsType<WorkflowMessage>(JsonConvert.DeserializeObject<WorkflowMessage>(new WorkflowSchedulerStoppedMessage().ToJson()));
        }

        /// <summary>
        /// Test the property 'Discriminator'
        /// </summary>
        [Fact]
        public void DiscriminatorTest()
        {
            // TODO unit test for the property 'Discriminator'
        }
        /// <summary>
        /// Test the property 'JobId'
        /// </summary>
        [Fact]
        public void JobIdTest()
        {
            // TODO unit test for the property 'JobId'
        }
        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Fact]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
        }
        /// <summary>
        /// Test the property 'CorrelationId'
        /// </summary>
        [Fact]
        public void CorrelationIdTest()
        {
            // TODO unit test for the property 'CorrelationId'
        }
        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            // TODO unit test for the property 'MessageId'
        }
        /// <summary>
        /// Test the property 'WorkflowInstanceId'
        /// </summary>
        [Fact]
        public void WorkflowInstanceIdTest()
        {
            // TODO unit test for the property 'WorkflowInstanceId'
        }
        /// <summary>
        /// Test the property 'MessageType'
        /// </summary>
        [Fact]
        public void MessageTypeTest()
        {
            // TODO unit test for the property 'MessageType'
        }
        /// <summary>
        /// Test the property 'JobStatus'
        /// </summary>
        [Fact]
        public void JobStatusTest()
        {
            // TODO unit test for the property 'JobStatus'
        }
        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Fact]
        public void ErrorCodeTest()
        {
            // TODO unit test for the property 'ErrorCode'
        }
        /// <summary>
        /// Test the property 'AdditionalMetadata'
        /// </summary>
        [Fact]
        public void AdditionalMetadataTest()
        {
            // TODO unit test for the property 'AdditionalMetadata'
        }
        /// <summary>
        /// Test the property 'PersonalizationTasks'
        /// </summary>
        [Fact]
        public void PersonalizationTasksTest()
        {
            // TODO unit test for the property 'PersonalizationTasks'
        }
        /// <summary>
        /// Test the property 'DocumentProduced'
        /// </summary>
        [Fact]
        public void DocumentProducedTest()
        {
            // TODO unit test for the property 'DocumentProduced'
        }

    }

}
