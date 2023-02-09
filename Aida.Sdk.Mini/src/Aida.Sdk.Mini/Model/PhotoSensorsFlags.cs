/*
 * aida-mini
 *
 * 1.0.324
 *
 * The version of the OpenAPI document: 1.0.324
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
    /// Defines PhotoSensorsFlags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhotoSensorsFlags
    {
        /// <summary>
        /// Enum Feeder1Home for value: Feeder1Home
        /// </summary>
        [EnumMember(Value = "Feeder1Home")]
        Feeder1Home = 1,

        /// <summary>
        /// Enum Feeder1CardPresent for value: Feeder1CardPresent
        /// </summary>
        [EnumMember(Value = "Feeder1CardPresent")]
        Feeder1CardPresent = 2,

        /// <summary>
        /// Enum Input for value: Input
        /// </summary>
        [EnumMember(Value = "Input")]
        Input = 3,

        /// <summary>
        /// Enum FlipHome for value: FlipHome
        /// </summary>
        [EnumMember(Value = "FlipHome")]
        FlipHome = 4,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 5,

        /// <summary>
        /// Enum LaserInput for value: LaserInput
        /// </summary>
        [EnumMember(Value = "LaserInput")]
        LaserInput = 6,

        /// <summary>
        /// Enum Output for value: Output
        /// </summary>
        [EnumMember(Value = "Output")]
        Output = 7,

        /// <summary>
        /// Enum StackerHome for value: StackerHome
        /// </summary>
        [EnumMember(Value = "StackerHome")]
        StackerHome = 8,

        /// <summary>
        /// Enum Feeder1ToPinchroll for value: Feeder1ToPinchroll
        /// </summary>
        [EnumMember(Value = "Feeder1ToPinchroll")]
        Feeder1ToPinchroll = 9,

        /// <summary>
        /// Enum Feeder1CardBatch for value: Feeder1CardBatch
        /// </summary>
        [EnumMember(Value = "Feeder1CardBatch")]
        Feeder1CardBatch = 10,

        /// <summary>
        /// Enum EncoderInOut1 for value: EncoderInOut1
        /// </summary>
        [EnumMember(Value = "EncoderInOut1")]
        EncoderInOut1 = 11,

        /// <summary>
        /// Enum EncoderInOut2 for value: EncoderInOut2
        /// </summary>
        [EnumMember(Value = "EncoderInOut2")]
        EncoderInOut2 = 12,

        /// <summary>
        /// Enum EncoderInOut3 for value: EncoderInOut3
        /// </summary>
        [EnumMember(Value = "EncoderInOut3")]
        EncoderInOut3 = 13,

        /// <summary>
        /// Enum EncoderInOut4 for value: EncoderInOut4
        /// </summary>
        [EnumMember(Value = "EncoderInOut4")]
        EncoderInOut4 = 14,

        /// <summary>
        /// Enum FeederTubePresent for value: FeederTubePresent
        /// </summary>
        [EnumMember(Value = "FeederTubePresent")]
        FeederTubePresent = 15,

        /// <summary>
        /// Enum StackerTubePresent for value: StackerTubePresent
        /// </summary>
        [EnumMember(Value = "StackerTubePresent")]
        StackerTubePresent = 16,

        /// <summary>
        /// Enum Feeder2Home for value: Feeder2Home
        /// </summary>
        [EnumMember(Value = "Feeder2Home")]
        Feeder2Home = 17,

        /// <summary>
        /// Enum Feeder2CardPresent for value: Feeder2CardPresent
        /// </summary>
        [EnumMember(Value = "Feeder2CardPresent")]
        Feeder2CardPresent = 18,

        /// <summary>
        /// Enum Feeder2ToPinchroll for value: Feeder2ToPinchroll
        /// </summary>
        [EnumMember(Value = "Feeder2ToPinchroll")]
        Feeder2ToPinchroll = 19,

        /// <summary>
        /// Enum ModuleOutput for value: ModuleOutput
        /// </summary>
        [EnumMember(Value = "ModuleOutput")]
        ModuleOutput = 20,

        /// <summary>
        /// Enum InkJetIn for value: InkJetIn
        /// </summary>
        [EnumMember(Value = "InkJetIn")]
        InkJetIn = 21,

        /// <summary>
        /// Enum InkJetOut for value: InkJetOut
        /// </summary>
        [EnumMember(Value = "InkJetOut")]
        InkJetOut = 22,

        /// <summary>
        /// Enum InkJetBeltHome for value: InkJetBeltHome
        /// </summary>
        [EnumMember(Value = "InkJetBeltHome")]
        InkJetBeltHome = 23,

        /// <summary>
        /// Enum Feeder2CardBatch for value: Feeder2CardBatch
        /// </summary>
        [EnumMember(Value = "Feeder2CardBatch")]
        Feeder2CardBatch = 24,

        /// <summary>
        /// Enum PinchRollOut for value: PinchRollOut
        /// </summary>
        [EnumMember(Value = "PinchRollOut")]
        PinchRollOut = 25

    }

}
