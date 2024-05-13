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
    ///  Class for testing PersonalizationSessionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PersonalizationSessionApiTests : IDisposable
    {
        private PersonalizationSessionApi instance;

        public PersonalizationSessionApiTests()
        {
            instance = new PersonalizationSessionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PersonalizationSessionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PersonalizationSessionApi
            //Assert.IsType<PersonalizationSessionApi>(instance);
        }

        /// <summary>
        /// Test DeletePersonalizationSession
        /// </summary>
        [Fact]
        public void DeletePersonalizationSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sessionId = null;
            //instance.DeletePersonalizationSession(sessionId);
        }

        /// <summary>
        /// Test GetPersonalizationSession
        /// </summary>
        [Fact]
        public void GetPersonalizationSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sessionId = null;
            //bool? realTimeUpdate = null;
            //var response = instance.GetPersonalizationSession(sessionId, realTimeUpdate);
            //Assert.IsType<PersonalizationSessionDto>(response);
        }

        /// <summary>
        /// Test GetPersonalizationSessionEvents
        /// </summary>
        [Fact]
        public void GetPersonalizationSessionEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sessionId = null;
            //DateTime? startingFrom = null;
            //var response = instance.GetPersonalizationSessionEvents(sessionId, startingFrom);
            //Assert.IsType<List<PersonalizationSessionEventDto>>(response);
        }

        /// <summary>
        /// Test GetPersonalizationSessions
        /// </summary>
        [Fact]
        public void GetPersonalizationSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPersonalizationSessions();
            //Assert.IsType<List<PersonalizationSessionDto>>(response);
        }

        /// <summary>
        /// Test Last30Days
        /// </summary>
        [Fact]
        public void Last30DaysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Last30Days();
            //Assert.IsType<List<PersoSessionAggregateDto>>(response);
        }
    }
}
