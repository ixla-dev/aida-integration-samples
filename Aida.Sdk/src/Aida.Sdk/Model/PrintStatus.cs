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
    /// Defines PrintStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrintStatus
    {
        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 1,

        /// <summary>
        /// Enum Printing for value: Printing
        /// </summary>
        [EnumMember(Value = "Printing")]
        Printing = 2,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3

    }

}
