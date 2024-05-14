/*
 * aida-mini
 *
 * 1.0.692
 *
 * The version of the OpenAPI document: 1.0.692
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
    ///  Class for testing DataSourceConfigurationDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DataSourceConfigurationDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DataSourceConfigurationDto
        //private DataSourceConfigurationDto instance;

        public DataSourceConfigurationDtoTests()
        {
            // TODO uncomment below to create an instance of DataSourceConfigurationDto
            //instance = new DataSourceConfigurationDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataSourceConfigurationDto
        /// </summary>
        [Fact]
        public void DataSourceConfigurationDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" DataSourceConfigurationDto
            //Assert.IsType<DataSourceConfigurationDto>(instance);
        }

        /// <summary>
        /// Test deserialize a MySqlDataSourceConfigurationDto from type DataSourceConfigurationDto
        /// </summary>
        [Fact]
        public void MySqlDataSourceConfigurationDtoDeserializeFromDataSourceConfigurationDtoTest()
        {
            // TODO uncomment below to test deserialize a MySqlDataSourceConfigurationDto from type DataSourceConfigurationDto
            //Assert.IsType<DataSourceConfigurationDto>(JsonConvert.DeserializeObject<DataSourceConfigurationDto>(new MySqlDataSourceConfigurationDto().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NpgSqlDataSourceConfigurationDto from type DataSourceConfigurationDto
        /// </summary>
        [Fact]
        public void NpgSqlDataSourceConfigurationDtoDeserializeFromDataSourceConfigurationDtoTest()
        {
            // TODO uncomment below to test deserialize a NpgSqlDataSourceConfigurationDto from type DataSourceConfigurationDto
            //Assert.IsType<DataSourceConfigurationDto>(JsonConvert.DeserializeObject<DataSourceConfigurationDto>(new NpgSqlDataSourceConfigurationDto().ToJson()));
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
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'DataSourceType'
        /// </summary>
        [Fact]
        public void DataSourceTypeTest()
        {
            // TODO unit test for the property 'DataSourceType'
        }
        /// <summary>
        /// Test the property 'CanBeDeleted'
        /// </summary>
        [Fact]
        public void CanBeDeletedTest()
        {
            // TODO unit test for the property 'CanBeDeleted'
        }

    }

}
