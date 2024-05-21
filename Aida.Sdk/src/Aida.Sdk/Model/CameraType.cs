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
    /// Defines CameraType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CameraType
    {
        /// <summary>
        /// Enum MockCamera for value: MockCamera
        /// </summary>
        [EnumMember(Value = "MockCamera")]
        MockCamera = 1,

        /// <summary>
        /// Enum MvBlueFox for value: MvBlueFox
        /// </summary>
        [EnumMember(Value = "MvBlueFox")]
        MvBlueFox = 2,

        /// <summary>
        /// Enum VideoCapture for value: VideoCapture
        /// </summary>
        [EnumMember(Value = "VideoCapture")]
        VideoCapture = 3

    }

}
