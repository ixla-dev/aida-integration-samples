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
    /// Defines HatchFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HatchFlags
    {
        /// <summary>
        /// Enum NoSort for value: NoSort
        /// </summary>
        [EnumMember(Value = "NoSort")]
        NoSort = 1,

        /// <summary>
        /// Enum AllLines for value: AllLines
        /// </summary>
        [EnumMember(Value = "AllLines")]
        AllLines = 2,

        /// <summary>
        /// Enum PolyLineBeamCompensate for value: PolyLineBeamCompensate
        /// </summary>
        [EnumMember(Value = "PolyLineBeamCompensate")]
        PolyLineBeamCompensate = 3,

        /// <summary>
        /// Enum DontFillRest for value: DontFillRest
        /// </summary>
        [EnumMember(Value = "DontFillRest")]
        DontFillRest = 4,

        /// <summary>
        /// Enum KeepAngle for value: KeepAngle
        /// </summary>
        [EnumMember(Value = "KeepAngle")]
        KeepAngle = 5,

        /// <summary>
        /// Enum EqualizeDistance for value: EqualizeDistance
        /// </summary>
        [EnumMember(Value = "EqualizeDistance")]
        EqualizeDistance = 6,

        /// <summary>
        /// Enum BeamCompensationLoopReverseOrder for value: BeamCompensationLoopReverseOrder
        /// </summary>
        [EnumMember(Value = "BeamCompensationLoopReverseOrder")]
        BeamCompensationLoopReverseOrder = 7

    }

}
