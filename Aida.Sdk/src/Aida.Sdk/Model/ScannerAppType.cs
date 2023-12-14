/*
 * aida
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines ScannerAppType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScannerAppType
    {
        /// <summary>
        /// Enum ScapsSmaLight for value: ScapsSmaLight
        /// </summary>
        [EnumMember(Value = "ScapsSmaLight")]
        ScapsSmaLight = 1,

        /// <summary>
        /// Enum VirtualScannerApp for value: VirtualScannerApp
        /// </summary>
        [EnumMember(Value = "VirtualScannerApp")]
        VirtualScannerApp = 2

    }

}