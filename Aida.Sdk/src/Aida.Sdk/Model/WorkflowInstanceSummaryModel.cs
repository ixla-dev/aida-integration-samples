/*
 * aida
 *
 * 1.0.691
 *
 * The version of the OpenAPI document: 1.0.691
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
    /// WorkflowInstanceSummaryModel
    /// </summary>
    [DataContract(Name = "WorkflowInstanceSummaryModel")]
    public partial class WorkflowInstanceSummaryModel : IEquatable<WorkflowInstanceSummaryModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets WorkflowStatus
        /// </summary>
        [DataMember(Name = "workflowStatus", EmitDefaultValue = false)]
        public WorkflowStatus? WorkflowStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInstanceSummaryModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="definitionId">definitionId.</param>
        /// <param name="definitionVersionId">definitionVersionId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="version">version.</param>
        /// <param name="workflowStatus">workflowStatus.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="contextType">contextType.</param>
        /// <param name="contextId">contextId.</param>
        /// <param name="name">name.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="lastExecutedAt">lastExecutedAt.</param>
        /// <param name="finishedAt">finishedAt.</param>
        /// <param name="cancelledAt">cancelledAt.</param>
        /// <param name="faultedAt">faultedAt.</param>
        /// <param name="metadata">metadata.</param>
        public WorkflowInstanceSummaryModel(string id = default(string), string definitionId = default(string), string definitionVersionId = default(string), string tenantId = default(string), int version = default(int), WorkflowStatus? workflowStatus = default(WorkflowStatus?), string correlationId = default(string), string contextType = default(string), string contextId = default(string), string name = default(string), DateTime? createdAt = default(DateTime?), DateTime? lastExecutedAt = default(DateTime?), DateTime? finishedAt = default(DateTime?), DateTime? cancelledAt = default(DateTime?), DateTime? faultedAt = default(DateTime?), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.DefinitionId = definitionId;
            this.DefinitionVersionId = definitionVersionId;
            this.TenantId = tenantId;
            this._Version = version;
            this.WorkflowStatus = workflowStatus;
            this.CorrelationId = correlationId;
            this.ContextType = contextType;
            this.ContextId = contextId;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.LastExecutedAt = lastExecutedAt;
            this.FinishedAt = finishedAt;
            this.CancelledAt = cancelledAt;
            this.FaultedAt = faultedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DefinitionId
        /// </summary>
        [DataMember(Name = "definitionId", EmitDefaultValue = true)]
        public string DefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets DefinitionVersionId
        /// </summary>
        [DataMember(Name = "definitionVersionId", EmitDefaultValue = true)]
        public string DefinitionVersionId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets ContextType
        /// </summary>
        [DataMember(Name = "contextType", EmitDefaultValue = true)]
        public string ContextType { get; set; }

        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name = "contextId", EmitDefaultValue = true)]
        public string ContextId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastExecutedAt
        /// </summary>
        [DataMember(Name = "lastExecutedAt", EmitDefaultValue = true)]
        public DateTime? LastExecutedAt { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        [DataMember(Name = "finishedAt", EmitDefaultValue = true)]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Gets or Sets CancelledAt
        /// </summary>
        [DataMember(Name = "cancelledAt", EmitDefaultValue = true)]
        public DateTime? CancelledAt { get; set; }

        /// <summary>
        /// Gets or Sets FaultedAt
        /// </summary>
        [DataMember(Name = "faultedAt", EmitDefaultValue = true)]
        public DateTime? FaultedAt { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowInstanceSummaryModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DefinitionId: ").Append(DefinitionId).Append("\n");
            sb.Append("  DefinitionVersionId: ").Append(DefinitionVersionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  WorkflowStatus: ").Append(WorkflowStatus).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ContextType: ").Append(ContextType).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastExecutedAt: ").Append(LastExecutedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  CancelledAt: ").Append(CancelledAt).Append("\n");
            sb.Append("  FaultedAt: ").Append(FaultedAt).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as WorkflowInstanceSummaryModel);
        }

        /// <summary>
        /// Returns true if WorkflowInstanceSummaryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowInstanceSummaryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowInstanceSummaryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DefinitionId == input.DefinitionId ||
                    (this.DefinitionId != null &&
                    this.DefinitionId.Equals(input.DefinitionId))
                ) && 
                (
                    this.DefinitionVersionId == input.DefinitionVersionId ||
                    (this.DefinitionVersionId != null &&
                    this.DefinitionVersionId.Equals(input.DefinitionVersionId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.WorkflowStatus == input.WorkflowStatus ||
                    this.WorkflowStatus.Equals(input.WorkflowStatus)
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.ContextType == input.ContextType ||
                    (this.ContextType != null &&
                    this.ContextType.Equals(input.ContextType))
                ) && 
                (
                    this.ContextId == input.ContextId ||
                    (this.ContextId != null &&
                    this.ContextId.Equals(input.ContextId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.LastExecutedAt == input.LastExecutedAt ||
                    (this.LastExecutedAt != null &&
                    this.LastExecutedAt.Equals(input.LastExecutedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.CancelledAt == input.CancelledAt ||
                    (this.CancelledAt != null &&
                    this.CancelledAt.Equals(input.CancelledAt))
                ) && 
                (
                    this.FaultedAt == input.FaultedAt ||
                    (this.FaultedAt != null &&
                    this.FaultedAt.Equals(input.FaultedAt))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.DefinitionId.GetHashCode();
                }
                if (this.DefinitionVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.DefinitionVersionId.GetHashCode();
                }
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkflowStatus.GetHashCode();
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.ContextType != null)
                {
                    hashCode = (hashCode * 59) + this.ContextType.GetHashCode();
                }
                if (this.ContextId != null)
                {
                    hashCode = (hashCode * 59) + this.ContextId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.LastExecutedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastExecutedAt.GetHashCode();
                }
                if (this.FinishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedAt.GetHashCode();
                }
                if (this.CancelledAt != null)
                {
                    hashCode = (hashCode * 59) + this.CancelledAt.GetHashCode();
                }
                if (this.FaultedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FaultedAt.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
