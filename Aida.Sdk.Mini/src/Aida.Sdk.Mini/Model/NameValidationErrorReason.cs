/*
 * aida-mini
 *
 * 1.0.361
 *
 * The version of the OpenAPI document: 1.0.361
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
    /// Defines NameValidationErrorReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameValidationErrorReason
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum EmptyName for value: EmptyName
        /// </summary>
        [EnumMember(Value = "EmptyName")]
        EmptyName = 2,

        /// <summary>
        /// Enum NameAlreadyTaken for value: NameAlreadyTaken
        /// </summary>
        [EnumMember(Value = "NameAlreadyTaken")]
        NameAlreadyTaken = 3,

        /// <summary>
        /// Enum NameContainsInvalidCharacters for value: NameContainsInvalidCharacters
        /// </summary>
        [EnumMember(Value = "NameContainsInvalidCharacters")]
        NameContainsInvalidCharacters = 4

    }

}
