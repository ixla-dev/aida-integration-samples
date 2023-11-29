/*
 * aida-mini
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
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
    /// Defines JobErrorCodes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobErrorCodes
    {
        /// <summary>
        /// Enum NoErrors for value: NoErrors
        /// </summary>
        [EnumMember(Value = "NoErrors")]
        NoErrors = 1,

        /// <summary>
        /// Enum ManualStop for value: ManualStop
        /// </summary>
        [EnumMember(Value = "ManualStop")]
        ManualStop = 2,

        /// <summary>
        /// Enum GenericError for value: GenericError
        /// </summary>
        [EnumMember(Value = "GenericError")]
        GenericError = 3,

        /// <summary>
        /// Enum CardJam for value: CardJam
        /// </summary>
        [EnumMember(Value = "CardJam")]
        CardJam = 4,

        /// <summary>
        /// Enum MarkLayoutFailed for value: MarkLayoutFailed
        /// </summary>
        [EnumMember(Value = "MarkLayoutFailed")]
        MarkLayoutFailed = 5,

        /// <summary>
        /// Enum OpenInterlock for value: OpenInterlock
        /// </summary>
        [EnumMember(Value = "OpenInterlock")]
        OpenInterlock = 6,

        /// <summary>
        /// Enum MarkErrorLayoutOutOfBounds for value: MarkErrorLayoutOutOfBounds
        /// </summary>
        [EnumMember(Value = "MarkErrorLayoutOutOfBounds")]
        MarkErrorLayoutOutOfBounds = 7,

        /// <summary>
        /// Enum MarkErrorEntitySelectionEmpty for value: MarkErrorEntitySelectionEmpty
        /// </summary>
        [EnumMember(Value = "MarkErrorEntitySelectionEmpty")]
        MarkErrorEntitySelectionEmpty = 8,

        /// <summary>
        /// Enum MarkErrorMarkAlreadyExecuting for value: MarkErrorMarkAlreadyExecuting
        /// </summary>
        [EnumMember(Value = "MarkErrorMarkAlreadyExecuting")]
        MarkErrorMarkAlreadyExecuting = 9,

        /// <summary>
        /// Enum ChipPersonalizationFailed for value: ChipPersonalizationFailed
        /// </summary>
        [EnumMember(Value = "ChipPersonalizationFailed")]
        ChipPersonalizationFailed = 10,

        /// <summary>
        /// Enum MagStripeReadFailed for value: MagStripeReadFailed
        /// </summary>
        [EnumMember(Value = "MagStripeReadFailed")]
        MagStripeReadFailed = 11,

        /// <summary>
        /// Enum MagStripeWriteFailed for value: MagStripeWriteFailed
        /// </summary>
        [EnumMember(Value = "MagStripeWriteFailed")]
        MagStripeWriteFailed = 12,

        /// <summary>
        /// Enum OcrUnexpectedResult for value: OcrUnexpectedResult
        /// </summary>
        [EnumMember(Value = "OcrUnexpectedResult")]
        OcrUnexpectedResult = 13,

        /// <summary>
        /// Enum OcrFailedToAcquireImage for value: OcrFailedToAcquireImage
        /// </summary>
        [EnumMember(Value = "OcrFailedToAcquireImage")]
        OcrFailedToAcquireImage = 14,

        /// <summary>
        /// Enum OcrFailedToExecuteAlgorithm for value: OcrFailedToExecuteAlgorithm
        /// </summary>
        [EnumMember(Value = "OcrFailedToExecuteAlgorithm")]
        OcrFailedToExecuteAlgorithm = 15,

        /// <summary>
        /// Enum AutoPosFailedToMatchPattern for value: AutoPosFailedToMatchPattern
        /// </summary>
        [EnumMember(Value = "AutoPosFailedToMatchPattern")]
        AutoPosFailedToMatchPattern = 16,

        /// <summary>
        /// Enum WebhookAckTimeout for value: WebhookAckTimeout
        /// </summary>
        [EnumMember(Value = "WebhookAckTimeout")]
        WebhookAckTimeout = 17,

        /// <summary>
        /// Enum WebhooksServerUnreachable for value: WebhooksServerUnreachable
        /// </summary>
        [EnumMember(Value = "WebhooksServerUnreachable")]
        WebhooksServerUnreachable = 18,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty = 19,

        /// <summary>
        /// Enum CancelledOnStartup for value: CancelledOnStartup
        /// </summary>
        [EnumMember(Value = "CancelledOnStartup")]
        CancelledOnStartup = 20,

        /// <summary>
        /// Enum OcrExternalValidationKo for value: OcrExternalValidationKo
        /// </summary>
        [EnumMember(Value = "OcrExternalValidationKo")]
        OcrExternalValidationKo = 21

    }

}
