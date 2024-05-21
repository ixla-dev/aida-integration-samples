/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines CleanAtStartupStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CleanAtStartupStatus
    {
        /// <summary>
        /// Enum Disabled for value: Disabled
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled = 1,

        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 2,

        /// <summary>
        /// Enum WaitingForTemperature for value: WaitingForTemperature
        /// </summary>
        [EnumMember(Value = "WaitingForTemperature")]
        WaitingForTemperature = 3,

        /// <summary>
        /// Enum PerformingCleaning for value: PerformingCleaning
        /// </summary>
        [EnumMember(Value = "PerformingCleaning")]
        PerformingCleaning = 4,

        /// <summary>
        /// Enum Done for value: Done
        /// </summary>
        [EnumMember(Value = "Done")]
        Done = 5,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 6

    }

}
