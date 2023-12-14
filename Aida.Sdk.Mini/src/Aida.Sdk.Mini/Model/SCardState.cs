/*
 * aida-mini
 *
 * 1.0.524
 *
 * The version of the OpenAPI document: 1.0.524
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
    /// Defines SCardState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SCardState
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Absent for value: Absent
        /// </summary>
        [EnumMember(Value = "Absent")]
        Absent = 2,

        /// <summary>
        /// Enum Present for value: Present
        /// </summary>
        [EnumMember(Value = "Present")]
        Present = 3,

        /// <summary>
        /// Enum Swallowed for value: Swallowed
        /// </summary>
        [EnumMember(Value = "Swallowed")]
        Swallowed = 4,

        /// <summary>
        /// Enum Powered for value: Powered
        /// </summary>
        [EnumMember(Value = "Powered")]
        Powered = 5,

        /// <summary>
        /// Enum Negotiable for value: Negotiable
        /// </summary>
        [EnumMember(Value = "Negotiable")]
        Negotiable = 6,

        /// <summary>
        /// Enum Specific for value: Specific
        /// </summary>
        [EnumMember(Value = "Specific")]
        Specific = 7

    }

}
