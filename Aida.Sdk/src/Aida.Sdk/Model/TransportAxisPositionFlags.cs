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
    /// Defines TransportAxisPositionFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransportAxisPositionFlags
    {
        /// <summary>
        /// Enum Feed for value: Feed
        /// </summary>
        [EnumMember(Value = "Feed")]
        Feed = 1,

        /// <summary>
        /// Enum Load for value: Load
        /// </summary>
        [EnumMember(Value = "Load")]
        Load = 2,

        /// <summary>
        /// Enum Laser for value: Laser
        /// </summary>
        [EnumMember(Value = "Laser")]
        Laser = 3,

        /// <summary>
        /// Enum Print for value: Print
        /// </summary>
        [EnumMember(Value = "Print")]
        Print = 4,

        /// <summary>
        /// Enum Curing for value: Curing
        /// </summary>
        [EnumMember(Value = "Curing")]
        Curing = 5,

        /// <summary>
        /// Enum Calib for value: Calib
        /// </summary>
        [EnumMember(Value = "Calib")]
        Calib = 6,

        /// <summary>
        /// Enum Exit for value: Exit
        /// </summary>
        [EnumMember(Value = "Exit")]
        Exit = 7

    }

}
