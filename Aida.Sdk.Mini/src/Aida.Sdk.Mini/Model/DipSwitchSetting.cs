/*
 * aida-mini
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
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
    /// Defines DipSwitchSetting
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DipSwitchSetting
    {
        /// <summary>
        /// Enum SingleFeeder for value: SingleFeeder
        /// </summary>
        [EnumMember(Value = "SingleFeeder")]
        SingleFeeder = 1,

        /// <summary>
        /// Enum DualFeeder for value: DualFeeder
        /// </summary>
        [EnumMember(Value = "DualFeeder")]
        DualFeeder = 2,

        /// <summary>
        /// Enum Stacker for value: Stacker
        /// </summary>
        [EnumMember(Value = "Stacker")]
        Stacker = 3,

        /// <summary>
        /// Enum MagStripeReader for value: MagStripeReader
        /// </summary>
        [EnumMember(Value = "MagStripeReader")]
        MagStripeReader = 4,

        /// <summary>
        /// Enum MultiChip for value: MultiChip
        /// </summary>
        [EnumMember(Value = "MultiChip")]
        MultiChip = 5,

        /// <summary>
        /// Enum InkJet for value: InkJet
        /// </summary>
        [EnumMember(Value = "InkJet")]
        InkJet = 6,

        /// <summary>
        /// Enum Unused1 for value: Unused_1
        /// </summary>
        [EnumMember(Value = "Unused_1")]
        Unused1 = 7,

        /// <summary>
        /// Enum Unused2 for value: Unused_2
        /// </summary>
        [EnumMember(Value = "Unused_2")]
        Unused2 = 8

    }

}
