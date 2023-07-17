/*
 * aida
 *
 * 1.0.358
 *
 * The version of the OpenAPI document: 1.0.358
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
    ///  Class for testing ApplicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationApiTests : IDisposable
    {
        private ApplicationApi instance;

        public ApplicationApiTests()
        {
            instance = new ApplicationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApplicationApi
            //Assert.IsType<ApplicationApi>(instance);
        }

        /// <summary>
        /// Test GetApplicationSettings
        /// </summary>
        [Fact]
        public void GetApplicationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetApplicationSettings();
            //Assert.IsType<AppConfig>(response);
        }

        /// <summary>
        /// Test GetConfigValue
        /// </summary>
        [Fact]
        public void GetConfigValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //instance.GetConfigValue(path);
        }
    }
}
