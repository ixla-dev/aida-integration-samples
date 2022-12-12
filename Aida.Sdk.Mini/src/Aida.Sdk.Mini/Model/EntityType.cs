/*
 * aida-mini
 *
 * 1.0.308
 *
 * The version of the OpenAPI document: 1.0.308
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
    /// Defines EntityType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityType
    {
        /// <summary>
        /// Enum Bitmap for value: Bitmap
        /// </summary>
        [EnumMember(Value = "Bitmap")]
        Bitmap = 1,

        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 2,

        /// <summary>
        /// Enum Barcode for value: Barcode
        /// </summary>
        [EnumMember(Value = "Barcode")]
        Barcode = 3,

        /// <summary>
        /// Enum LineArray for value: LineArray
        /// </summary>
        [EnumMember(Value = "LineArray")]
        LineArray = 4,

        /// <summary>
        /// Enum LineArrays for value: LineArrays
        /// </summary>
        [EnumMember(Value = "LineArrays")]
        LineArrays = 5,

        /// <summary>
        /// Enum PolyLine for value: PolyLine
        /// </summary>
        [EnumMember(Value = "PolyLine")]
        PolyLine = 6,

        /// <summary>
        /// Enum PolyLines for value: PolyLines
        /// </summary>
        [EnumMember(Value = "PolyLines")]
        PolyLines = 7,

        /// <summary>
        /// Enum Rectangle for value: Rectangle
        /// </summary>
        [EnumMember(Value = "Rectangle")]
        Rectangle = 8,

        /// <summary>
        /// Enum Layer for value: Layer
        /// </summary>
        [EnumMember(Value = "Layer")]
        Layer = 9,

        /// <summary>
        /// Enum SerialNumber for value: SerialNumber
        /// </summary>
        [EnumMember(Value = "SerialNumber")]
        SerialNumber = 10,

        /// <summary>
        /// Enum Group for value: Group
        /// </summary>
        [EnumMember(Value = "Group")]
        Group = 11

    }

}
