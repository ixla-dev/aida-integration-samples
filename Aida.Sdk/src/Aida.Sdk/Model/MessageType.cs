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
    /// Defines MessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum EncoderLoaded for value: EncoderLoaded
        /// </summary>
        [EnumMember(Value = "EncoderLoaded")]
        EncoderLoaded = 2,

        /// <summary>
        /// Enum OcrExecuted for value: OcrExecuted
        /// </summary>
        [EnumMember(Value = "OcrExecuted")]
        OcrExecuted = 3,

        /// <summary>
        /// Enum WorkflowStarted for value: WorkflowStarted
        /// </summary>
        [EnumMember(Value = "WorkflowStarted")]
        WorkflowStarted = 4,

        /// <summary>
        /// Enum WorkflowCompleted for value: WorkflowCompleted
        /// </summary>
        [EnumMember(Value = "WorkflowCompleted")]
        WorkflowCompleted = 5,

        /// <summary>
        /// Enum WorkflowFaulted for value: WorkflowFaulted
        /// </summary>
        [EnumMember(Value = "WorkflowFaulted")]
        WorkflowFaulted = 6,

        /// <summary>
        /// Enum WorkflowCancelled for value: WorkflowCancelled
        /// </summary>
        [EnumMember(Value = "WorkflowCancelled")]
        WorkflowCancelled = 7,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty = 8,

        /// <summary>
        /// Enum WorkflowSchedulerStarted for value: WorkflowSchedulerStarted
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerStarted")]
        WorkflowSchedulerStarted = 9,

        /// <summary>
        /// Enum WorkflowSchedulerStopped for value: WorkflowSchedulerStopped
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerStopped")]
        WorkflowSchedulerStopped = 10,

        /// <summary>
        /// Enum WorkflowSchedulerSuspended for value: WorkflowSchedulerSuspended
        /// </summary>
        [EnumMember(Value = "WorkflowSchedulerSuspended")]
        WorkflowSchedulerSuspended = 11,

        /// <summary>
        /// Enum HealthCheck for value: HealthCheck
        /// </summary>
        [EnumMember(Value = "HealthCheck")]
        HealthCheck = 12,

        /// <summary>
        /// Enum MagneticStripeReadBack for value: MagneticStripeReadBack
        /// </summary>
        [EnumMember(Value = "MagneticStripeReadBack")]
        MagneticStripeReadBack = 13,

        /// <summary>
        /// Enum OcrReadBack for value: OcrReadBack
        /// </summary>
        [EnumMember(Value = "OcrReadBack")]
        OcrReadBack = 14,

        /// <summary>
        /// Enum ChipReadBack for value: ChipReadBack
        /// </summary>
        [EnumMember(Value = "ChipReadBack")]
        ChipReadBack = 15,

        /// <summary>
        /// Enum BarcodeReadBack for value: BarcodeReadBack
        /// </summary>
        [EnumMember(Value = "BarcodeReadBack")]
        BarcodeReadBack = 16

    }

}
