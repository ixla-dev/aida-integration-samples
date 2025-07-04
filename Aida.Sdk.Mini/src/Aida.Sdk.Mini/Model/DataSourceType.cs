/*
 * aida-mini
 *
 * 1.3.5+5a9fb622482f18d24fc4f1b5ae8fe290f7c62728
 *
 * The version of the OpenAPI document: 1.3.5+5a9fb622482f18d24fc4f1b5ae8fe290f7c62728
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// Defines DataSourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataSourceType
    {
        /// <summary>
        /// Enum RelationalDatabaseMySql for value: RelationalDatabaseMySql
        /// </summary>
        [EnumMember(Value = "RelationalDatabaseMySql")]
        RelationalDatabaseMySql = 1,

        /// <summary>
        /// Enum RelationalDatabasePostgres for value: RelationalDatabasePostgres
        /// </summary>
        [EnumMember(Value = "RelationalDatabasePostgres")]
        RelationalDatabasePostgres = 2

    }

}
