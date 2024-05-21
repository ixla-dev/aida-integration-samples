/*
 * aida-mini
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// WorkflowMessage
    /// </summary>
    [DataContract(Name = "WorkflowMessage")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackMessage), "ChipReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(EncoderLoadedMessage), "EncoderLoadedMessage")]
    [JsonSubtypes.KnownSubType(typeof(FeederEmptyMessage), "FeederEmptyMessage")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.ChipReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(EncoderLoadedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.EncoderLoadedMessage")]
    [JsonSubtypes.KnownSubType(typeof(FeederEmptyMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.FeederEmptyMessage")]
    [JsonSubtypes.KnownSubType(typeof(MagneticStripeReadBackMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.MagneticStripeReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrExecutedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.OcrExecutedMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.OcrReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(WebhookReceiverHealthCheckMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WebhookReceiverHealthCheckMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCancelledMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowCancelledMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCompletedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowCompletedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowFaultedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowFaultedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerProcessSuspendedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowSchedulerProcessSuspendedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStartedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowSchedulerStartedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStoppedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowSchedulerStoppedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowStartedMessage), "IXLA.Box.Services.Workflow.Messaging.Signals.WorkflowStartedMessage")]
    [JsonSubtypes.KnownSubType(typeof(MagneticStripeReadBackMessage), "MagneticStripeReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrExecutedMessage), "OcrExecutedMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackMessage), "OcrReadBackMessage")]
    [JsonSubtypes.KnownSubType(typeof(WebhookReceiverHealthCheckMessage), "WebhookReceiverHealthCheckMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCancelledMessage), "WorkflowCancelledMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCompletedMessage), "WorkflowCompletedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowFaultedMessage), "WorkflowFaultedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerProcessSuspendedMessage), "WorkflowSchedulerProcessSuspendedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStartedMessage), "WorkflowSchedulerStartedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStoppedMessage), "WorkflowSchedulerStoppedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowStartedMessage), "WorkflowStartedMessage")]
    public partial class WorkflowMessage : IEquatable<WorkflowMessage>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "messageType", EmitDefaultValue = false)]
        public MessageType? MessageType { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public JobStatus? JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public JobErrorCodes? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkflowMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMessage" /> class.
        /// </summary>
        /// <param name="discriminator">discriminator (required).</param>
        /// <param name="sourceJobInstanceId">sourceJobInstanceId.</param>
        /// <param name="machineName">machineName.</param>
        /// <param name="machineSerial">machineSerial.</param>
        /// <param name="hostName">hostName.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="workflowInstanceName">workflowInstanceName.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="additionalMetadata">additionalMetadata.</param>
        /// <param name="documentProduced">documentProduced.</param>
        /// <param name="destructiveOperationExecuted">destructiveOperationExecuted.</param>
        public WorkflowMessage(string discriminator = default(string), string sourceJobInstanceId = default(string), string machineName = default(string), string machineSerial = default(string), string hostName = default(string), string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), string workflowInstanceName = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), bool documentProduced = default(bool), bool destructiveOperationExecuted = default(bool))
        {
            // to ensure "discriminator" is required (not null)
            if (discriminator == null)
            {
                throw new ArgumentNullException("discriminator is a required property for WorkflowMessage and cannot be null");
            }
            this.Discriminator = discriminator;
            this.SourceJobInstanceId = sourceJobInstanceId;
            this.MachineName = machineName;
            this.MachineSerial = machineSerial;
            this.HostName = hostName;
            this.JobId = jobId;
            this.BatchId = batchId;
            this.CorrelationId = correlationId;
            this.MessageId = messageId;
            this.WorkflowInstanceId = workflowInstanceId;
            this.WorkflowInstanceName = workflowInstanceName;
            this.MessageType = messageType;
            this.JobStatus = jobStatus;
            this.ErrorCode = errorCode;
            this.AdditionalMetadata = additionalMetadata;
            this.DocumentProduced = documentProduced;
            this.DestructiveOperationExecuted = destructiveOperationExecuted;
        }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", IsRequired = true, EmitDefaultValue = true)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets SourceJobInstanceId
        /// </summary>
        [DataMember(Name = "sourceJobInstanceId", EmitDefaultValue = true)]
        public string SourceJobInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets MachineName
        /// </summary>
        [DataMember(Name = "machineName", EmitDefaultValue = true)]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or Sets MachineSerial
        /// </summary>
        [DataMember(Name = "machineSerial", EmitDefaultValue = true)]
        public string MachineSerial { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name = "hostName", EmitDefaultValue = true)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batchId", EmitDefaultValue = true)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceName
        /// </summary>
        [DataMember(Name = "workflowInstanceName", EmitDefaultValue = true)]
        public string WorkflowInstanceName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalMetadata
        /// </summary>
        [DataMember(Name = "additionalMetadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> AdditionalMetadata { get; set; }

        /// <summary>
        /// Gets or Sets DocumentProduced
        /// </summary>
        [DataMember(Name = "documentProduced", EmitDefaultValue = true)]
        public bool DocumentProduced { get; set; }

        /// <summary>
        /// Gets or Sets DestructiveOperationExecuted
        /// </summary>
        [DataMember(Name = "destructiveOperationExecuted", EmitDefaultValue = true)]
        public bool DestructiveOperationExecuted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowMessage {\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  SourceJobInstanceId: ").Append(SourceJobInstanceId).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  MachineSerial: ").Append(MachineSerial).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  WorkflowInstanceName: ").Append(WorkflowInstanceName).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  AdditionalMetadata: ").Append(AdditionalMetadata).Append("\n");
            sb.Append("  DocumentProduced: ").Append(DocumentProduced).Append("\n");
            sb.Append("  DestructiveOperationExecuted: ").Append(DestructiveOperationExecuted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowMessage);
        }

        /// <summary>
        /// Returns true if WorkflowMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.SourceJobInstanceId == input.SourceJobInstanceId ||
                    (this.SourceJobInstanceId != null &&
                    this.SourceJobInstanceId.Equals(input.SourceJobInstanceId))
                ) && 
                (
                    this.MachineName == input.MachineName ||
                    (this.MachineName != null &&
                    this.MachineName.Equals(input.MachineName))
                ) && 
                (
                    this.MachineSerial == input.MachineSerial ||
                    (this.MachineSerial != null &&
                    this.MachineSerial.Equals(input.MachineSerial))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.WorkflowInstanceId == input.WorkflowInstanceId ||
                    (this.WorkflowInstanceId != null &&
                    this.WorkflowInstanceId.Equals(input.WorkflowInstanceId))
                ) && 
                (
                    this.WorkflowInstanceName == input.WorkflowInstanceName ||
                    (this.WorkflowInstanceName != null &&
                    this.WorkflowInstanceName.Equals(input.WorkflowInstanceName))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    this.MessageType.Equals(input.MessageType)
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    this.JobStatus.Equals(input.JobStatus)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.AdditionalMetadata == input.AdditionalMetadata ||
                    this.AdditionalMetadata != null &&
                    input.AdditionalMetadata != null &&
                    this.AdditionalMetadata.SequenceEqual(input.AdditionalMetadata)
                ) && 
                (
                    this.DocumentProduced == input.DocumentProduced ||
                    this.DocumentProduced.Equals(input.DocumentProduced)
                ) && 
                (
                    this.DestructiveOperationExecuted == input.DestructiveOperationExecuted ||
                    this.DestructiveOperationExecuted.Equals(input.DestructiveOperationExecuted)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                if (this.SourceJobInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceJobInstanceId.GetHashCode();
                }
                if (this.MachineName != null)
                {
                    hashCode = (hashCode * 59) + this.MachineName.GetHashCode();
                }
                if (this.MachineSerial != null)
                {
                    hashCode = (hashCode * 59) + this.MachineSerial.GetHashCode();
                }
                if (this.HostName != null)
                {
                    hashCode = (hashCode * 59) + this.HostName.GetHashCode();
                }
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.BatchId != null)
                {
                    hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
                }
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.WorkflowInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceId.GetHashCode();
                }
                if (this.WorkflowInstanceName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                hashCode = (hashCode * 59) + this.JobStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                if (this.AdditionalMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalMetadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DocumentProduced.GetHashCode();
                hashCode = (hashCode * 59) + this.DestructiveOperationExecuted.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
