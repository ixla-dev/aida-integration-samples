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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// PersoOperation
    /// </summary>
    [DataContract(Name = "PersoOperation")]
    public partial class PersoOperation : IEquatable<PersoOperation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name = "operationType", EmitDefaultValue = false)]
        public PersoOperationTypes? OperationType { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public PersoOperationOutcome? Outcome { get; set; }

        /// <summary>
        /// Gets or Sets RequiredSide
        /// </summary>
        [DataMember(Name = "requiredSide", EmitDefaultValue = false)]
        public SupportSide? RequiredSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersoOperation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="operationType">operationType.</param>
        /// <param name="requiredPositionId">requiredPositionId.</param>
        /// <param name="maxRetries">maxRetries.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="unlocksWorkflowStart">unlocksWorkflowStart.</param>
        /// <param name="requiredSide">requiredSide.</param>
        public PersoOperation(int id = default(int), string name = default(string), string workflowInstanceId = default(string), PersoOperationTypes? operationType = default(PersoOperationTypes?), string requiredPositionId = default(string), int maxRetries = default(int), PersoOperationOutcome? outcome = default(PersoOperationOutcome?), bool unlocksWorkflowStart = default(bool), SupportSide? requiredSide = default(SupportSide?))
        {
            this.Id = id;
            this.Name = name;
            this.WorkflowInstanceId = workflowInstanceId;
            this.OperationType = operationType;
            this.RequiredPositionId = requiredPositionId;
            this.MaxRetries = maxRetries;
            this.Outcome = outcome;
            this.UnlocksWorkflowStart = unlocksWorkflowStart;
            this.RequiredSide = requiredSide;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets RequiredPositionId
        /// </summary>
        [DataMember(Name = "requiredPositionId", EmitDefaultValue = true)]
        public string RequiredPositionId { get; set; }

        /// <summary>
        /// Gets or Sets MaxRetries
        /// </summary>
        [DataMember(Name = "maxRetries", EmitDefaultValue = false)]
        public int MaxRetries { get; set; }

        /// <summary>
        /// Gets or Sets IsDestructiveOperation
        /// </summary>
        [DataMember(Name = "isDestructiveOperation", EmitDefaultValue = true)]
        public bool IsDestructiveOperation { get; private set; }

        /// <summary>
        /// Returns false as IsDestructiveOperation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDestructiveOperation()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CanBeRetried
        /// </summary>
        [DataMember(Name = "canBeRetried", EmitDefaultValue = true)]
        public bool CanBeRetried { get; private set; }

        /// <summary>
        /// Returns false as CanBeRetried should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanBeRetried()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UnlocksWorkflowStart
        /// </summary>
        [DataMember(Name = "unlocksWorkflowStart", EmitDefaultValue = true)]
        public bool UnlocksWorkflowStart { get; set; }

        /// <summary>
        /// Gets or Sets Executed
        /// </summary>
        [DataMember(Name = "executed", EmitDefaultValue = true)]
        public bool Executed { get; private set; }

        /// <summary>
        /// Returns false as Executed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExecuted()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersoOperation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  RequiredPositionId: ").Append(RequiredPositionId).Append("\n");
            sb.Append("  MaxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  IsDestructiveOperation: ").Append(IsDestructiveOperation).Append("\n");
            sb.Append("  CanBeRetried: ").Append(CanBeRetried).Append("\n");
            sb.Append("  UnlocksWorkflowStart: ").Append(UnlocksWorkflowStart).Append("\n");
            sb.Append("  RequiredSide: ").Append(RequiredSide).Append("\n");
            sb.Append("  Executed: ").Append(Executed).Append("\n");
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
            return this.Equals(input as PersoOperation);
        }

        /// <summary>
        /// Returns true if PersoOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of PersoOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersoOperation input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.WorkflowInstanceId == input.WorkflowInstanceId ||
                    (this.WorkflowInstanceId != null &&
                    this.WorkflowInstanceId.Equals(input.WorkflowInstanceId))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    this.OperationType.Equals(input.OperationType)
                ) && 
                (
                    this.RequiredPositionId == input.RequiredPositionId ||
                    (this.RequiredPositionId != null &&
                    this.RequiredPositionId.Equals(input.RequiredPositionId))
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    this.MaxRetries.Equals(input.MaxRetries)
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    this.Outcome.Equals(input.Outcome)
                ) && 
                (
                    this.IsDestructiveOperation == input.IsDestructiveOperation ||
                    this.IsDestructiveOperation.Equals(input.IsDestructiveOperation)
                ) && 
                (
                    this.CanBeRetried == input.CanBeRetried ||
                    this.CanBeRetried.Equals(input.CanBeRetried)
                ) && 
                (
                    this.UnlocksWorkflowStart == input.UnlocksWorkflowStart ||
                    this.UnlocksWorkflowStart.Equals(input.UnlocksWorkflowStart)
                ) && 
                (
                    this.RequiredSide == input.RequiredSide ||
                    this.RequiredSide.Equals(input.RequiredSide)
                ) && 
                (
                    this.Executed == input.Executed ||
                    this.Executed.Equals(input.Executed)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.WorkflowInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OperationType.GetHashCode();
                if (this.RequiredPositionId != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredPositionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxRetries.GetHashCode();
                hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDestructiveOperation.GetHashCode();
                hashCode = (hashCode * 59) + this.CanBeRetried.GetHashCode();
                hashCode = (hashCode * 59) + this.UnlocksWorkflowStart.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiredSide.GetHashCode();
                hashCode = (hashCode * 59) + this.Executed.GetHashCode();
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