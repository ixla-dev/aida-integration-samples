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
    /// Defines HatchStyle
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HatchStyle
    {
        /// <summary>
        /// Enum Disable for value: Disable
        /// </summary>
        [EnumMember(Value = "Disable")]
        Disable = 1,

        /// <summary>
        /// Enum WavyLineWithJumps for value: WavyLineWithJumps
        /// </summary>
        [EnumMember(Value = "WavyLineWithJumps")]
        WavyLineWithJumps = 2,

        /// <summary>
        /// Enum LeftToRightWithoutJumps for value: LeftToRightWithoutJumps
        /// </summary>
        [EnumMember(Value = "LeftToRightWithoutJumps")]
        LeftToRightWithoutJumps = 3,

        /// <summary>
        /// Enum RightToLeftWithoutJumps for value: RightToLeftWithoutJumps
        /// </summary>
        [EnumMember(Value = "RightToLeftWithoutJumps")]
        RightToLeftWithoutJumps = 4,

        /// <summary>
        /// Enum WavyLineIncludingJumps for value: WavyLineIncludingJumps
        /// </summary>
        [EnumMember(Value = "WavyLineIncludingJumps")]
        WavyLineIncludingJumps = 5,

        /// <summary>
        /// Enum ZigZag for value: ZigZag
        /// </summary>
        [EnumMember(Value = "ZigZag")]
        ZigZag = 6

    }

}
