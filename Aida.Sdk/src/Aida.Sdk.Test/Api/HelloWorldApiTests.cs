/*
 * aida
 *
 * 1.0.691
 *
 * The version of the OpenAPI document: 1.0.691
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
    ///  Class for testing HelloWorldApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HelloWorldApiTests : IDisposable
    {
        private HelloWorldApi instance;

        public HelloWorldApiTests()
        {
            instance = new HelloWorldApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HelloWorldApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HelloWorldApi
            //Assert.IsType<HelloWorldApi>(instance);
        }

        /// <summary>
        /// Test Home
        /// </summary>
        [Fact]
        public void HomeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Home();
            //Assert.IsType<HelloWorldDto>(response);
        }

        /// <summary>
        /// Test TransportReset
        /// </summary>
        [Fact]
        public void TransportResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.TransportReset();
        }
    }
}
