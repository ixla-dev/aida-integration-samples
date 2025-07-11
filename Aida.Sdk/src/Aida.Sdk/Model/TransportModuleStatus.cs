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
    /// Defines TransportModuleStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransportModuleStatus
    {
        /// <summary>
        /// Enum Initializing for value: Initializing
        /// </summary>
        [EnumMember(Value = "Initializing")]
        Initializing = 1,

        /// <summary>
        /// Enum Ready for value: Ready
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready = 2,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3,

        /// <summary>
        /// Enum WaitingCard for value: WaitingCard
        /// </summary>
        [EnumMember(Value = "WaitingCard")]
        WaitingCard = 4,

        /// <summary>
        /// Enum Busy for value: Busy
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy = 5,

        /// <summary>
        /// Enum CardJam for value: CardJam
        /// </summary>
        [EnumMember(Value = "CardJam")]
        CardJam = 6,

        /// <summary>
        /// Enum InputTimeout for value: InputTimeout
        /// </summary>
        [EnumMember(Value = "InputTimeout")]
        InputTimeout = 7

    }

}
