/*
 * aida-mini
 *
 * 1.0.323
 *
 * The version of the OpenAPI document: 1.0.323
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
    /// OcrExecutedMessage
    /// </summary>
    [DataContract(Name = "OcrExecutedMessage")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(FeederEmptyMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.FeederEmptyMessage")]
    [JsonSubtypes.KnownSubType(typeof(OcrExecutedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.OcrExecutedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCancelledMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowCancelledMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowCompletedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowCompletedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowFaultedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowFaultedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerProcessSuspendedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerProcessSuspendedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStartedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerStartedMessage")]
    [JsonSubtypes.KnownSubType(typeof(WorkflowSchedulerStoppedMessage), "IXLA.Box.Services.Workflow.ElsaWorkflows.SharedActivities.WorkflowSchedulerStoppedMessage")]
    public partial class OcrExecutedMessage : WorkflowMessage, IEquatable<OcrExecutedMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrExecutedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OcrExecutedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrExecutedMessage" /> class.
        /// </summary>
        /// <param name="hostname">hostname.</param>
        /// <param name="results">results.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;OcrExecutedMessage&quot;).</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="additionalMetadata">additionalMetadata.</param>
        /// <param name="personalizationTasks">personalizationTasks.</param>
        /// <param name="documentProduced">documentProduced.</param>
        public OcrExecutedMessage(string hostname = default(string), List<RuntimeOcrInspectionResult> results = default(List<RuntimeOcrInspectionResult>), string discriminator = "OcrExecutedMessage", string jobId = default(string), string batchId = default(string), string correlationId = default(string), string messageId = default(string), string workflowInstanceId = default(string), MessageType? messageType = default(MessageType?), JobStatus? jobStatus = default(JobStatus?), JobErrorCodes? errorCode = default(JobErrorCodes?), Dictionary<string, Object> additionalMetadata = default(Dictionary<string, Object>), List<PersonalizationTask> personalizationTasks = default(List<PersonalizationTask>), bool documentProduced = default(bool)) : base(discriminator, jobId, batchId, correlationId, messageId, workflowInstanceId, messageType, jobStatus, errorCode, additionalMetadata, personalizationTasks, documentProduced)
        {
            this.Hostname = hostname;
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "hostname", EmitDefaultValue = true)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = true)]
        public List<RuntimeOcrInspectionResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrExecutedMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as OcrExecutedMessage);
        }

        /// <summary>
        /// Returns true if OcrExecutedMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrExecutedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrExecutedMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && base.Equals(input) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                int hashCode = base.GetHashCode();
                if (this.Hostname != null)
                {
                    hashCode = (hashCode * 59) + this.Hostname.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
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
