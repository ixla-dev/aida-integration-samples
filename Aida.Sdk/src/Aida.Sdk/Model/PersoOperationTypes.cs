/*
 * aida
 *
 * 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
 *
 * The version of the OpenAPI document: 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
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
    /// Defines PersoOperationTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersoOperationTypes
    {
        /// <summary>
        /// Enum Feed for value: Feed
        /// </summary>
        [EnumMember(Value = "Feed")]
        Feed = 1,

        /// <summary>
        /// Enum Mark for value: Mark
        /// </summary>
        [EnumMember(Value = "Mark")]
        Mark = 2,

        /// <summary>
        /// Enum Ocr for value: Ocr
        /// </summary>
        [EnumMember(Value = "Ocr")]
        Ocr = 3,

        /// <summary>
        /// Enum MagneticEncoding for value: MagneticEncoding
        /// </summary>
        [EnumMember(Value = "MagneticEncoding")]
        MagneticEncoding = 4,

        /// <summary>
        /// Enum ChipEncoding for value: ChipEncoding
        /// </summary>
        [EnumMember(Value = "ChipEncoding")]
        ChipEncoding = 5,

        /// <summary>
        /// Enum Eject for value: Eject
        /// </summary>
        [EnumMember(Value = "Eject")]
        Eject = 6,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 7,

        /// <summary>
        /// Enum AllowNextWorkflowStart for value: AllowNextWorkflowStart
        /// </summary>
        [EnumMember(Value = "AllowNextWorkflowStart")]
        AllowNextWorkflowStart = 8,

        /// <summary>
        /// Enum AutoPos for value: AutoPos
        /// </summary>
        [EnumMember(Value = "AutoPos")]
        AutoPos = 9,

        /// <summary>
        /// Enum FetchPersoData for value: FetchPersoData
        /// </summary>
        [EnumMember(Value = "FetchPersoData")]
        FetchPersoData = 10,

        /// <summary>
        /// Enum ReadBack for value: ReadBack
        /// </summary>
        [EnumMember(Value = "ReadBack")]
        ReadBack = 11,

        /// <summary>
        /// Enum InkjetPrint for value: InkjetPrint
        /// </summary>
        [EnumMember(Value = "InkjetPrint")]
        InkjetPrint = 12,

        /// <summary>
        /// Enum CardOrientationCheck for value: CardOrientationCheck
        /// </summary>
        [EnumMember(Value = "CardOrientationCheck")]
        CardOrientationCheck = 13,

        /// <summary>
        /// Enum SaveSnapshot for value: SaveSnapshot
        /// </summary>
        [EnumMember(Value = "SaveSnapshot")]
        SaveSnapshot = 14,

        /// <summary>
        /// Enum MatchTemplate for value: MatchTemplate
        /// </summary>
        [EnumMember(Value = "MatchTemplate")]
        MatchTemplate = 15

    }

}
