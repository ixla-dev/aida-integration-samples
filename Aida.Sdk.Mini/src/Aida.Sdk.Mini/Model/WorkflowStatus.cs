/*
 * aida-mini
 *
 * 1.0.696
 *
 * The version of the OpenAPI document: 1.0.696
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
    /// Defines WorkflowStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowStatus
    {
        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 1,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 2,

        /// <summary>
        /// Enum Finished for value: Finished
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished = 3,

        /// <summary>
        /// Enum Suspended for value: Suspended
        /// </summary>
        [EnumMember(Value = "Suspended")]
        Suspended = 4,

        /// <summary>
        /// Enum Faulted for value: Faulted
        /// </summary>
        [EnumMember(Value = "Faulted")]
        Faulted = 5,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 6

    }

}
