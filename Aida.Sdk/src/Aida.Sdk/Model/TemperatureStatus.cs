/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines TemperatureStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemperatureStatus
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Warming for value: Warming
        /// </summary>
        [EnumMember(Value = "Warming")]
        Warming = 2,

        /// <summary>
        /// Enum Ready for value: Ready
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready = 3,

        /// <summary>
        /// Enum OverTemperature for value: OverTemperature
        /// </summary>
        [EnumMember(Value = "OverTemperature")]
        OverTemperature = 4,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 5

    }

}