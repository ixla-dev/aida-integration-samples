/*
 * aida-mini
 *
 * 1.0.524
 *
 * The version of the OpenAPI document: 1.0.524
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
    /// Defines DeviceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceType
    {
        /// <summary>
        /// Enum Camera for value: Camera
        /// </summary>
        [EnumMember(Value = "Camera")]
        Camera = 1,

        /// <summary>
        /// Enum Encoder for value: Encoder
        /// </summary>
        [EnumMember(Value = "Encoder")]
        Encoder = 2,

        /// <summary>
        /// Enum LightSource for value: LightSource
        /// </summary>
        [EnumMember(Value = "LightSource")]
        LightSource = 3,

        /// <summary>
        /// Enum Transport for value: Transport
        /// </summary>
        [EnumMember(Value = "Transport")]
        Transport = 4,

        /// <summary>
        /// Enum LaserBoard for value: LaserBoard
        /// </summary>
        [EnumMember(Value = "LaserBoard")]
        LaserBoard = 5,

        /// <summary>
        /// Enum Laser for value: Laser
        /// </summary>
        [EnumMember(Value = "Laser")]
        Laser = 6,

        /// <summary>
        /// Enum BarcodeReader for value: BarcodeReader
        /// </summary>
        [EnumMember(Value = "BarcodeReader")]
        BarcodeReader = 7,

        /// <summary>
        /// Enum MagneticStripeEncoder for value: MagneticStripeEncoder
        /// </summary>
        [EnumMember(Value = "MagneticStripeEncoder")]
        MagneticStripeEncoder = 8,

        /// <summary>
        /// Enum InkjetBoard for value: InkjetBoard
        /// </summary>
        [EnumMember(Value = "InkjetBoard")]
        InkjetBoard = 9

    }

}
