/*
 * aida
 *
 * 1.0.691
 *
 * The version of the OpenAPI document: 1.0.691
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
    /// Defines TransportPositionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransportPositionType
    {
        /// <summary>
        /// Enum Feeder for value: Feeder
        /// </summary>
        [EnumMember(Value = "Feeder")]
        Feeder = 1,

        /// <summary>
        /// Enum Input for value: Input
        /// </summary>
        [EnumMember(Value = "Input")]
        Input = 2,

        /// <summary>
        /// Enum Exit for value: Exit
        /// </summary>
        [EnumMember(Value = "Exit")]
        Exit = 3,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 4,

        /// <summary>
        /// Enum Work for value: Work
        /// </summary>
        [EnumMember(Value = "Work")]
        Work = 5,

        /// <summary>
        /// Enum Park for value: Park
        /// </summary>
        [EnumMember(Value = "Park")]
        Park = 6,

        /// <summary>
        /// Enum Transient for value: Transient
        /// </summary>
        [EnumMember(Value = "Transient")]
        Transient = 7,

        /// <summary>
        /// Enum Flip for value: Flip
        /// </summary>
        [EnumMember(Value = "Flip")]
        Flip = 8

    }

}
