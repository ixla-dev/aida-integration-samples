/*
 * aida-mini
 *
 * 1.0.692
 *
 * The version of the OpenAPI document: 1.0.692
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
    /// Defines JobStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobStatus
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Waiting for value: Waiting
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting = 2,

        /// <summary>
        /// Enum Starting for value: Starting
        /// </summary>
        [EnumMember(Value = "Starting")]
        Starting = 3,

        /// <summary>
        /// Enum Resuming for value: Resuming
        /// </summary>
        [EnumMember(Value = "Resuming")]
        Resuming = 4,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 5,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 6,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 7,

        /// <summary>
        /// Enum Suspended for value: Suspended
        /// </summary>
        [EnumMember(Value = "Suspended")]
        Suspended = 8,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected = 9,

        /// <summary>
        /// Enum Faulted for value: Faulted
        /// </summary>
        [EnumMember(Value = "Faulted")]
        Faulted = 10

    }

}
