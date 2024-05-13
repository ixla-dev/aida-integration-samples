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
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthApiTests : IDisposable
    {
        private AuthApi instance;

        public AuthApiTests()
        {
            instance = new AuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthApi
            //Assert.IsType<AuthApi>(instance);
        }

        /// <summary>
        /// Test AddUserRole
        /// </summary>
        [Fact]
        public void AddUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string roleName = null;
            //var response = instance.AddUserRole(username, roleName);
            //Assert.IsType<IdentityResult>(response);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //string roleName = null;
            //var response = instance.CreateUser(username, password, roleName);
            //Assert.IsType<IdentityResult>(response);
        }

        /// <summary>
        /// Test FindApiKeys
        /// </summary>
        [Fact]
        public void FindApiKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchParameters searchParameters = null;
            //var response = instance.FindApiKeys(searchParameters);
            //Assert.IsType<ApiKeyDtoSearchResultDto>(response);
        }

        /// <summary>
        /// Test FindUsers
        /// </summary>
        [Fact]
        public void FindUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FindUsers();
            //Assert.IsType<List<AidaUserDto>>(response);
        }

        /// <summary>
        /// Test GetToken
        /// </summary>
        [Fact]
        public void GetTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userName = null;
            //string password = null;
            //string clientId = null;
            //string clientSecret = null;
            //string grantType = null;
            //var response = instance.GetToken(userName, password, clientId, clientSecret, grantType);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetUser
        /// </summary>
        [Fact]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetUser();
        }

        /// <summary>
        /// Test LogOut
        /// </summary>
        [Fact]
        public void LogOutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.LogOut();
        }

        /// <summary>
        /// Test Login
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userName = null;
            //string password = null;
            //string clientId = null;
            //string clientSecret = null;
            //string redirectUrl = null;
            //instance.Login(userName, password, clientId, clientSecret, redirectUrl);
        }
    }
}
