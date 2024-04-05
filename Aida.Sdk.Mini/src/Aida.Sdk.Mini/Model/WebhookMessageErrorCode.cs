/*
 * aida-mini
 *
 * 1.0.543
 *
 * The version of the OpenAPI document: 1.0.543
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
    /// Defines WebhookMessageErrorCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookMessageErrorCode
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum TimeoutError for value: TimeoutError
        /// </summary>
        [EnumMember(Value = "TimeoutError")]
        TimeoutError = 2,

        /// <summary>
        /// Enum ConnectionError for value: ConnectionError
        /// </summary>
        [EnumMember(Value = "ConnectionError")]
        ConnectionError = 3,

        /// <summary>
        /// Enum ResponseError for value: ResponseError
        /// </summary>
        [EnumMember(Value = "ResponseError")]
        ResponseError = 4,

        /// <summary>
        /// Enum GenericError for value: GenericError
        /// </summary>
        [EnumMember(Value = "GenericError")]
        GenericError = 5

    }

}
