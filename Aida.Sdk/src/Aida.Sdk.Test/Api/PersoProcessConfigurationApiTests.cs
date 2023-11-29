/*
 * aida
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Aida.Sdk.Client;
using Aida.Sdk.Api;
// uncomment below to import models
//using Aida.Sdk.Model;

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PersoProcessConfigurationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PersoProcessConfigurationApiTests : IDisposable
    {
        private PersoProcessConfigurationApi instance;

        public PersoProcessConfigurationApiTests()
        {
            instance = new PersoProcessConfigurationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PersoProcessConfigurationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PersoProcessConfigurationApi
            //Assert.IsType<PersoProcessConfigurationApi>(instance);
        }

        /// <summary>
        /// Test GetJobInstance
        /// </summary>
        [Fact]
        public void GetJobInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobInstanceId = null;
            //var response = instance.GetJobInstance(jobInstanceId);
            //Assert.IsType<JobInstance>(response);
        }

        /// <summary>
        /// Test GetJobInstances
        /// </summary>
        [Fact]
        public void GetJobInstancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.GetJobInstances(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<List<JobInstance>>(response);
        }

        /// <summary>
        /// Test GetPersoProcessConfiguration
        /// </summary>
        [Fact]
        public void GetPersoProcessConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.GetPersoProcessConfiguration(jobTemplateId);
            //Assert.IsType<PersoProcessConfigurationDto>(response);
        }

        /// <summary>
        /// Test GetPersoProcessPreview
        /// </summary>
        [Fact]
        public void GetPersoProcessPreviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.GetPersoProcessPreview(jobTemplateId);
            //Assert.IsType<PersoOperation>(response);
        }

        /// <summary>
        /// Test GetPersoSteps
        /// </summary>
        [Fact]
        public void GetPersoStepsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.GetPersoSteps(jobTemplateId);
            //Assert.IsType<List<PersoOperationDto>>(response);
        }

        /// <summary>
        /// Test GetTestPersoProcessStatus
        /// </summary>
        [Fact]
        public void GetTestPersoProcessStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTestPersoProcessStatus();
            //Assert.IsType<List<PersoOperationDto>>(response);
        }

        /// <summary>
        /// Test SetPersoProcessConfiguration
        /// </summary>
        [Fact]
        public void SetPersoProcessConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //PersoProcessConfigurationDto persoProcessConfigurationDto = null;
            //instance.SetPersoProcessConfiguration(jobTemplateId, persoProcessConfigurationDto);
        }

        /// <summary>
        /// Test StartTestPersoProcess
        /// </summary>
        [Fact]
        public void StartTestPersoProcessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobTemplateId = null;
            //bool? disableLaserSource = null;
            //string machineId = null;
            //var response = instance.StartTestPersoProcess(jobTemplateId, disableLaserSource, machineId);
            //Assert.IsType<JobInstance>(response);
        }

        /// <summary>
        /// Test StopTestPersoProcess
        /// </summary>
        [Fact]
        public void StopTestPersoProcessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.StopTestPersoProcess();
            //Assert.IsType<List<PersoOperationDto>>(response);
        }
    }
}
