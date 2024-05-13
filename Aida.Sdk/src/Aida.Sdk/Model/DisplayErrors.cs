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
    /// Defines DisplayErrors
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayErrors
    {
        /// <summary>
        /// Enum DISPLAYNOTAVAILABLE for value: E_DISPLAY_NOT_AVAILABLE
        /// </summary>
        [EnumMember(Value = "E_DISPLAY_NOT_AVAILABLE")]
        DISPLAYNOTAVAILABLE = 1,

        /// <summary>
        /// Enum INVALIDPARAMS for value: E_INVALID_PARAMS
        /// </summary>
        [EnumMember(Value = "E_INVALID_PARAMS")]
        INVALIDPARAMS = 2

    }

}
