/*
 * aida
 *
 * 1.0.696
 *
 * The version of the OpenAPI document: 1.0.696
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
    ///  Class for testing ModbusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModbusApiTests : IDisposable
    {
        private ModbusApi instance;

        public ModbusApiTests()
        {
            instance = new ModbusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModbusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModbusApi
            //Assert.IsType<ModbusApi>(instance);
        }

        /// <summary>
        /// Test GetModbusClients
        /// </summary>
        [Fact]
        public void GetModbusClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetModbusClients();
        }

        /// <summary>
        /// Test ReadHoldingRegisters
        /// </summary>
        [Fact]
        public void ReadHoldingRegistersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //string body = null;
            //instance.ReadHoldingRegisters(port, body);
        }

        /// <summary>
        /// Test WriteSingleRegister
        /// </summary>
        [Fact]
        public void WriteSingleRegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string port = null;
            //string body = null;
            //instance.WriteSingleRegister(port, body);
        }
    }
}
