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
    /// Defines EntityFieldValueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityFieldValueType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum String for value: String
        /// </summary>
        [EnumMember(Value = "String")]
        String = 2,

        /// <summary>
        /// Enum Image for value: Image
        /// </summary>
        [EnumMember(Value = "Image")]
        Image = 3,

        /// <summary>
        /// Enum InkjetImage for value: InkjetImage
        /// </summary>
        [EnumMember(Value = "InkjetImage")]
        InkjetImage = 4

    }

}
