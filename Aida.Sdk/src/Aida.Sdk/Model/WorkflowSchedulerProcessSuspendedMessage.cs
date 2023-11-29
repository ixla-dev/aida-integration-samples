/*
 * aida
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// WorkflowSchedulerProcessSuspendedMessage
    /// </summary>
    [DataContract(Name = "WorkflowSchedulerProcessSuspendedMessage")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(FeederEmptyMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.FeederEmptyMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrExecutedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.OcrExecutedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCancelledMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowCancelledMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCompletedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowCompletedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowFaultedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowFaultedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerProcessSuspendedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerProcessSuspendedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStartedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerStartedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStoppedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerStoppedMessage")]
    public partial class WorkflowSchedulerProcessSuspendedMessage : WorkflowMessage, IEquatable<WorkflowSchedulerProcessSuspendedMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSchedulerProcessSuspendedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkflowSchedulerProcessSuspendedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSchedulerProcessSuspendedMessage" /> class.
        /// </summary>
        /// <param name="discriminator">discriminator (required) (default to &quot;WorkflowSchedulerProcessSuspendedMessage&quot;).</param>
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
        public WorkflowSchedulerProcessSuspendedMessage(string discriminator = "WorkflowSchedulerProcessSuspendedMessage", string machineName = default(string), string machineSerial = default(string), string hostName = default(string), string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), string workflowInstanceName = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), bool documentProduced = default(bool), bool destructiveOperationExecuted = default(bool)) : base(discriminator, machineName, machineSerial, hostName, jobId, batchId, correlationId, messageId, workflowInstanceId, workflowInstanceName, messageType, jobStatus, errorCode, additionalMetadata, documentProduced, destructiveOperationExecuted)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowSchedulerProcessSuspendedMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as WorkflowSchedulerProcessSuspendedMessage);
        }

        /// <summary>
        /// Returns true if WorkflowSchedulerProcessSuspendedMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowSchedulerProcessSuspendedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowSchedulerProcessSuspendedMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
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
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
