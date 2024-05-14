/*
 * aida
 *
 * 1.0.692
 *
 * The version of the OpenAPI document: 1.0.692
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
    ///  Class for testing PCSCGatewayApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PCSCGatewayApiTests : IDisposable
    {
        private PCSCGatewayApi instance;

        public PCSCGatewayApiTests()
        {
            instance = new PCSCGatewayApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PCSCGatewayApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PCSCGatewayApi
            //Assert.IsType<PCSCGatewayApi>(instance);
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
        /// Test ReleaseContext
        /// </summary>
        [Fact]
        public void ReleaseContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ReleaseContext();
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
    }
}
