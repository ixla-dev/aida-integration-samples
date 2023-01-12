/*
 * aida-mini
 *
 * 1.0.321
 *
 * The version of the OpenAPI document: 1.0.321
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
    /// Defines WorkflowAction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowAction
    {
        /// <summary>
        /// Enum Resume for value: Resume
        /// </summary>
        [EnumMember(Value = "Resume")]
        Resume = 1,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 2

    }

}
