/*
 * aida
 *
 * 1.0.691
 *
 * The version of the OpenAPI document: 1.0.691
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
    /// Defines ReadBackType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReadBackType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Chip for value: Chip
        /// </summary>
        [EnumMember(Value = "Chip")]
        Chip = 2,

        /// <summary>
        /// Enum Ocr for value: Ocr
        /// </summary>
        [EnumMember(Value = "Ocr")]
        Ocr = 3,

        /// <summary>
        /// Enum Barcode for value: Barcode
        /// </summary>
        [EnumMember(Value = "Barcode")]
        Barcode = 4,

        /// <summary>
        /// Enum Magnetic for value: Magnetic
        /// </summary>
        [EnumMember(Value = "Magnetic")]
        Magnetic = 5

    }

}
