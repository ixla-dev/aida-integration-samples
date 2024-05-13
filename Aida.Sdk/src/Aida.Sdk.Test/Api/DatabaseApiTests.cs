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

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing DatabaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatabaseApiTests : IDisposable
    {
        private DatabaseApi instance;

        public DatabaseApiTests()
        {
            instance = new DatabaseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatabaseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatabaseApi
            //Assert.IsType<DatabaseApi>(instance);
        }

        /// <summary>
        /// Test DeleteApplicationFilesAndData
        /// </summary>
        [Fact]
        public void DeleteApplicationFilesAndDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteApplicationFilesAndData();
        }

        /// <summary>
        /// Test MigrateDatabase
        /// </summary>
        [Fact]
        public void MigrateDatabaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MigrateDatabase();
        }
    }
}
