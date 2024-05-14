/*
 * aida
 *
 * 1.0.692
 *
 * The version of the OpenAPI document: 1.0.692
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
    /// Defines MarkEntitiesErrorCodes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarkEntitiesErrorCodes
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum OpenInterlocks for value: OpenInterlocks
        /// </summary>
        [EnumMember(Value = "OpenInterlocks")]
        OpenInterlocks = 2,

        /// <summary>
        /// Enum MarkEntitiesLayoutOutOfBounds for value: MarkEntitiesLayoutOutOfBounds
        /// </summary>
        [EnumMember(Value = "MarkEntitiesLayoutOutOfBounds")]
        MarkEntitiesLayoutOutOfBounds = 3,

        /// <summary>
        /// Enum MarkingProcessAlreadyExecuting for value: MarkingProcessAlreadyExecuting
        /// </summary>
        [EnumMember(Value = "MarkingProcessAlreadyExecuting")]
        MarkingProcessAlreadyExecuting = 4,

        /// <summary>
        /// Enum MarkingProcessAborted for value: MarkingProcessAborted
        /// </summary>
        [EnumMember(Value = "MarkingProcessAborted")]
        MarkingProcessAborted = 5,

        /// <summary>
        /// Enum MarkEntitiesSelectionEmpty for value: MarkEntitiesSelectionEmpty
        /// </summary>
        [EnumMember(Value = "MarkEntitiesSelectionEmpty")]
        MarkEntitiesSelectionEmpty = 6,

        /// <summary>
        /// Enum MarkEntitiesApiError for value: MarkEntitiesApiError
        /// </summary>
        [EnumMember(Value = "MarkEntitiesApiError")]
        MarkEntitiesApiError = 7,

        /// <summary>
        /// Enum ManualStop for value: ManualStop
        /// </summary>
        [EnumMember(Value = "ManualStop")]
        ManualStop = 8

    }

}
