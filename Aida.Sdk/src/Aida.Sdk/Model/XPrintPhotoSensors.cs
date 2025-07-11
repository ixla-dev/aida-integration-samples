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
    /// Defines XPrintPhotoSensors
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum XPrintPhotoSensors
    {
        /// <summary>
        /// Enum CassettePresenceInFeeder for value: CassettePresenceInFeeder
        /// </summary>
        [EnumMember(Value = "CassettePresenceInFeeder")]
        CassettePresenceInFeeder = 1,

        /// <summary>
        /// Enum CassetteInEject for value: CassetteInEject
        /// </summary>
        [EnumMember(Value = "CassetteInEject")]
        CassetteInEject = 2,

        /// <summary>
        /// Enum WiperHome for value: WiperHome
        /// </summary>
        [EnumMember(Value = "WiperHome")]
        WiperHome = 3,

        /// <summary>
        /// Enum CappingHome for value: CappingHome
        /// </summary>
        [EnumMember(Value = "CappingHome")]
        CappingHome = 4,

        /// <summary>
        /// Enum Aux1 for value: Aux1
        /// </summary>
        [EnumMember(Value = "Aux1")]
        Aux1 = 5,

        /// <summary>
        /// Enum ExitSlot for value: ExitSlot
        /// </summary>
        [EnumMember(Value = "ExitSlot")]
        ExitSlot = 6,

        /// <summary>
        /// Enum Aux2 for value: Aux2
        /// </summary>
        [EnumMember(Value = "Aux2")]
        Aux2 = 7,

        /// <summary>
        /// Enum Aux3 for value: Aux3
        /// </summary>
        [EnumMember(Value = "Aux3")]
        Aux3 = 8

    }

}
