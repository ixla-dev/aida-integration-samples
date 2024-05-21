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
    /// Defines TransportFeatureTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransportFeatureTypes
    {
        /// <summary>
        /// Enum SingleFeeder for value: SingleFeeder
        /// </summary>
        [EnumMember(Value = "SingleFeeder")]
        SingleFeeder = 1,

        /// <summary>
        /// Enum DoubleFeeder for value: DoubleFeeder
        /// </summary>
        [EnumMember(Value = "DoubleFeeder")]
        DoubleFeeder = 2,

        /// <summary>
        /// Enum DoubleFeederOnBoard for value: DoubleFeederOnBoard
        /// </summary>
        [EnumMember(Value = "DoubleFeederOnBoard")]
        DoubleFeederOnBoard = 3,

        /// <summary>
        /// Enum SingleFeederOnBoard for value: SingleFeederOnBoard
        /// </summary>
        [EnumMember(Value = "SingleFeederOnBoard")]
        SingleFeederOnBoard = 4,

        /// <summary>
        /// Enum MagneticEncoder for value: MagneticEncoder
        /// </summary>
        [EnumMember(Value = "MagneticEncoder")]
        MagneticEncoder = 5,

        /// <summary>
        /// Enum SingleChipEncoder for value: SingleChipEncoder
        /// </summary>
        [EnumMember(Value = "SingleChipEncoder")]
        SingleChipEncoder = 6,

        /// <summary>
        /// Enum SingleRfiIdEncoder for value: SingleRfiIdEncoder
        /// </summary>
        [EnumMember(Value = "SingleRfiIdEncoder")]
        SingleRfiIdEncoder = 7,

        /// <summary>
        /// Enum SingleChipAndRfIdEncoder for value: SingleChipAndRfIdEncoder
        /// </summary>
        [EnumMember(Value = "SingleChipAndRfIdEncoder")]
        SingleChipAndRfIdEncoder = 8,

        /// <summary>
        /// Enum MultiChipOnBoard for value: MultiChipOnBoard
        /// </summary>
        [EnumMember(Value = "MultiChipOnBoard")]
        MultiChipOnBoard = 9,

        /// <summary>
        /// Enum MultiChipControlBoardLower for value: MultiChipControlBoardLower
        /// </summary>
        [EnumMember(Value = "MultiChipControlBoardLower")]
        MultiChipControlBoardLower = 10,

        /// <summary>
        /// Enum MultiChipControlBoardHigher for value: MultiChipControlBoardHigher
        /// </summary>
        [EnumMember(Value = "MultiChipControlBoardHigher")]
        MultiChipControlBoardHigher = 11,

        /// <summary>
        /// Enum CliTilt for value: CliTilt
        /// </summary>
        [EnumMember(Value = "CliTilt")]
        CliTilt = 12,

        /// <summary>
        /// Enum MliTilt for value: MliTilt
        /// </summary>
        [EnumMember(Value = "MliTilt")]
        MliTilt = 13,

        /// <summary>
        /// Enum SingleStacker for value: SingleStacker
        /// </summary>
        [EnumMember(Value = "SingleStacker")]
        SingleStacker = 14,

        /// <summary>
        /// Enum DoubleStacker for value: DoubleStacker
        /// </summary>
        [EnumMember(Value = "DoubleStacker")]
        DoubleStacker = 15,

        /// <summary>
        /// Enum StackerOnBoard for value: StackerOnBoard
        /// </summary>
        [EnumMember(Value = "StackerOnBoard")]
        StackerOnBoard = 16,

        /// <summary>
        /// Enum InkjetPrinter for value: InkjetPrinter
        /// </summary>
        [EnumMember(Value = "InkjetPrinter")]
        InkjetPrinter = 17,

        /// <summary>
        /// Enum QualityControl for value: QualityControl
        /// </summary>
        [EnumMember(Value = "QualityControl")]
        QualityControl = 18

    }

}
