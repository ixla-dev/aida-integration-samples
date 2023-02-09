/*
 * aida-mini
 *
 * 1.0.324
 *
 * The version of the OpenAPI document: 1.0.324
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
    /// Defines MachineStateNotifierEvents
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MachineStateNotifierEvents
    {
        /// <summary>
        /// Enum ModuleStateChanged for value: ModuleStateChanged
        /// </summary>
        [EnumMember(Value = "ModuleStateChanged")]
        ModuleStateChanged = 1,

        /// <summary>
        /// Enum LaserBoardStateChanged for value: LaserBoardStateChanged
        /// </summary>
        [EnumMember(Value = "LaserBoardStateChanged")]
        LaserBoardStateChanged = 2,

        /// <summary>
        /// Enum SerialDataSent for value: SerialDataSent
        /// </summary>
        [EnumMember(Value = "SerialDataSent")]
        SerialDataSent = 3,

        /// <summary>
        /// Enum SerialDataReceived for value: SerialDataReceived
        /// </summary>
        [EnumMember(Value = "SerialDataReceived")]
        SerialDataReceived = 4,

        /// <summary>
        /// Enum SystemStatusChanged for value: SystemStatusChanged
        /// </summary>
        [EnumMember(Value = "SystemStatusChanged")]
        SystemStatusChanged = 5,

        /// <summary>
        /// Enum WorkflowSchedulerStateChanged for value: WorkflowSchedulerStateChanged
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerStateChanged")]
        WorkflowSchedulerStateChanged = 6,

        /// <summary>
        /// Enum WorkflowInstanceStateChanged for value: WorkflowInstanceStateChanged
        /// </summary>
        [EnumMember(Value = "WorkflowInstanceStateChanged")]
        WorkflowInstanceStateChanged = 7

    }

}
