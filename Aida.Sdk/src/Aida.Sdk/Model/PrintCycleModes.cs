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
    /// Defines PrintCycleModes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrintCycleModes
    {
        /// <summary>
        /// Enum PrintAndLaser for value: PrintAndLaser
        /// </summary>
        [EnumMember(Value = "PrintAndLaser")]
        PrintAndLaser = 1,

        /// <summary>
        /// Enum PrintAndEject for value: PrintAndEject
        /// </summary>
        [EnumMember(Value = "PrintAndEject")]
        PrintAndEject = 2,

        /// <summary>
        /// Enum PrintAndMli for value: PrintAndMli
        /// </summary>
        [EnumMember(Value = "PrintAndMli")]
        PrintAndMli = 3

    }

}
