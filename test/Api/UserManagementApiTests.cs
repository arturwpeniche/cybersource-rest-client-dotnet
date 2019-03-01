/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing UserManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserManagementApiTests
    {
        private UserManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserManagementApi
            //Assert.IsInstanceOfType(typeof(UserManagementApi), instance, "instance is a UserManagementApi");
        }

        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string userName = null;
            //string permissionId = null;
            //string roleId = null;
            //var response = instance.GetUsers(organizationId, userName, permissionId, roleId);
            //Assert.IsInstanceOf<UmsV1UsersGet200Response> (response, "response is UmsV1UsersGet200Response");
        }
        
    }

}
