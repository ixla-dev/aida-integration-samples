/*
 * aida
 *
 * 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
 *
 * The version of the OpenAPI document: 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
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
    /// Defines XPrintSystemTemperatureStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum XPrintSystemTemperatureStatus
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum SystemUnderTemperature for value: SystemUnderTemperature
        /// </summary>
        [EnumMember(Value = "SystemUnderTemperature")]
        SystemUnderTemperature = 2,

        /// <summary>
        /// Enum SystemOverTemperature for value: SystemOverTemperature
        /// </summary>
        [EnumMember(Value = "SystemOverTemperature")]
        SystemOverTemperature = 3,

        /// <summary>
        /// Enum SystemTemperatureNotAvailable for value: SystemTemperatureNotAvailable
        /// </summary>
        [EnumMember(Value = "SystemTemperatureNotAvailable")]
        SystemTemperatureNotAvailable = 4

    }

}
