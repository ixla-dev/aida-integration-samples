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
    /// Job
    /// </summary>
    [DataContract(Name = "Job")]
    public partial class Job : IEquatable<Job>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public JobStatus? JobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="completedAt">completedAt.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="workflowStatus">workflowStatus.</param>
        /// <param name="currentActivityId">currentActivityId.</param>
        /// <param name="currentActivityDisplayName">currentActivityDisplayName.</param>
        public Job(int id = default(int), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? completedAt = default(DateTime?), string correlationId = default(string), string workflowId = default(string), JobStatus? jobStatus = default(JobStatus?), string workflowStatus = default(string), string currentActivityId = default(string), string currentActivityDisplayName = default(string))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.CorrelationId = correlationId;
            this.WorkflowId = workflowId;
            this.JobStatus = jobStatus;
            this.WorkflowStatus = workflowStatus;
            this.CurrentActivityId = currentActivityId;
            this.CurrentActivityDisplayName = currentActivityDisplayName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name = "completedAt", EmitDefaultValue = true)]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name = "workflowId", EmitDefaultValue = true)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowStatus
        /// </summary>
        [DataMember(Name = "workflowStatus", EmitDefaultValue = true)]
        public string WorkflowStatus { get; set; }

        /// <summary>
        /// Gets or Sets CurrentActivityId
        /// </summary>
        [DataMember(Name = "currentActivityId", EmitDefaultValue = true)]
        public string CurrentActivityId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentActivityDisplayName
        /// </summary>
        [DataMember(Name = "currentActivityDisplayName", EmitDefaultValue = true)]
        public string CurrentActivityDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  WorkflowStatus: ").Append(WorkflowStatus).Append("\n");
            sb.Append("  CurrentActivityId: ").Append(CurrentActivityId).Append("\n");
            sb.Append("  CurrentActivityDisplayName: ").Append(CurrentActivityDisplayName).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    this.JobStatus.Equals(input.JobStatus)
                ) && 
                (
                    this.WorkflowStatus == input.WorkflowStatus ||
                    (this.WorkflowStatus != null &&
                    this.WorkflowStatus.Equals(input.WorkflowStatus))
                ) && 
                (
                    this.CurrentActivityId == input.CurrentActivityId ||
                    (this.CurrentActivityId != null &&
                    this.CurrentActivityId.Equals(input.CurrentActivityId))
                ) && 
                (
                    this.CurrentActivityDisplayName == input.CurrentActivityDisplayName ||
                    (this.CurrentActivityDisplayName != null &&
                    this.CurrentActivityDisplayName.Equals(input.CurrentActivityDisplayName))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.WorkflowId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobStatus.GetHashCode();
                if (this.WorkflowStatus != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowStatus.GetHashCode();
                }
                if (this.CurrentActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentActivityId.GetHashCode();
                }
                if (this.CurrentActivityDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentActivityDisplayName.GetHashCode();
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
            yield break;
        }
    }

}
