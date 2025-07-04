/*
 * aida-mini
 *
 * 1.3.5+5a9fb622482f18d24fc4f1b5ae8fe290f7c62728
 *
 * The version of the OpenAPI document: 1.3.5+5a9fb622482f18d24fc4f1b5ae8fe290f7c62728
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
    /// WorkflowInstanceStateChangedEventArgs
    /// </summary>
    [DataContract(Name = "WorkflowInstanceStateChangedEventArgs")]
    public partial class WorkflowInstanceStateChangedEventArgs : IEquatable<WorkflowInstanceStateChangedEventArgs>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public WorkflowStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInstanceStateChangedEventArgs" /> class.
        /// </summary>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="executingActivityId">executingActivityId.</param>
        /// <param name="executingActivityName">executingActivityName.</param>
        /// <param name="lastExecutedActivityId">lastExecutedActivityId.</param>
        /// <param name="lastExecutedActivityName">lastExecutedActivityName.</param>
        /// <param name="supportId">supportId.</param>
        /// <param name="currentPositionId">currentPositionId.</param>
        /// <param name="status">status.</param>
        public WorkflowInstanceStateChangedEventArgs(string workflowInstanceId = default(string), string executingActivityId = default(string), string executingActivityName = default(string), string lastExecutedActivityId = default(string), string lastExecutedActivityName = default(string), string supportId = default(string), string currentPositionId = default(string), WorkflowStatus? status = default(WorkflowStatus?))
        {
            this.WorkflowInstanceId = workflowInstanceId;
            this.ExecutingActivityId = executingActivityId;
            this.ExecutingActivityName = executingActivityName;
            this.LastExecutedActivityId = lastExecutedActivityId;
            this.LastExecutedActivityName = lastExecutedActivityName;
            this.SupportId = supportId;
            this.CurrentPositionId = currentPositionId;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutingActivityId
        /// </summary>
        [DataMember(Name = "executingActivityId", EmitDefaultValue = true)]
        public string ExecutingActivityId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutingActivityName
        /// </summary>
        [DataMember(Name = "executingActivityName", EmitDefaultValue = true)]
        public string ExecutingActivityName { get; set; }

        /// <summary>
        /// Gets or Sets LastExecutedActivityId
        /// </summary>
        [DataMember(Name = "lastExecutedActivityId", EmitDefaultValue = true)]
        public string LastExecutedActivityId { get; set; }

        /// <summary>
        /// Gets or Sets LastExecutedActivityName
        /// </summary>
        [DataMember(Name = "lastExecutedActivityName", EmitDefaultValue = true)]
        public string LastExecutedActivityName { get; set; }

        /// <summary>
        /// Gets or Sets SupportId
        /// </summary>
        [DataMember(Name = "supportId", EmitDefaultValue = true)]
        public string SupportId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPositionId
        /// </summary>
        [DataMember(Name = "currentPositionId", EmitDefaultValue = true)]
        public string CurrentPositionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowInstanceStateChangedEventArgs {\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  ExecutingActivityId: ").Append(ExecutingActivityId).Append("\n");
            sb.Append("  ExecutingActivityName: ").Append(ExecutingActivityName).Append("\n");
            sb.Append("  LastExecutedActivityId: ").Append(LastExecutedActivityId).Append("\n");
            sb.Append("  LastExecutedActivityName: ").Append(LastExecutedActivityName).Append("\n");
            sb.Append("  SupportId: ").Append(SupportId).Append("\n");
            sb.Append("  CurrentPositionId: ").Append(CurrentPositionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as WorkflowInstanceStateChangedEventArgs);
        }

        /// <summary>
        /// Returns true if WorkflowInstanceStateChangedEventArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowInstanceStateChangedEventArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowInstanceStateChangedEventArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkflowInstanceId == input.WorkflowInstanceId ||
                    (this.WorkflowInstanceId != null &&
                    this.WorkflowInstanceId.Equals(input.WorkflowInstanceId))
                ) && 
                (
                    this.ExecutingActivityId == input.ExecutingActivityId ||
                    (this.ExecutingActivityId != null &&
                    this.ExecutingActivityId.Equals(input.ExecutingActivityId))
                ) && 
                (
                    this.ExecutingActivityName == input.ExecutingActivityName ||
                    (this.ExecutingActivityName != null &&
                    this.ExecutingActivityName.Equals(input.ExecutingActivityName))
                ) && 
                (
                    this.LastExecutedActivityId == input.LastExecutedActivityId ||
                    (this.LastExecutedActivityId != null &&
                    this.LastExecutedActivityId.Equals(input.LastExecutedActivityId))
                ) && 
                (
                    this.LastExecutedActivityName == input.LastExecutedActivityName ||
                    (this.LastExecutedActivityName != null &&
                    this.LastExecutedActivityName.Equals(input.LastExecutedActivityName))
                ) && 
                (
                    this.SupportId == input.SupportId ||
                    (this.SupportId != null &&
                    this.SupportId.Equals(input.SupportId))
                ) && 
                (
                    this.CurrentPositionId == input.CurrentPositionId ||
                    (this.CurrentPositionId != null &&
                    this.CurrentPositionId.Equals(input.CurrentPositionId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.WorkflowInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceId.GetHashCode();
                }
                if (this.ExecutingActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutingActivityId.GetHashCode();
                }
                if (this.ExecutingActivityName != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutingActivityName.GetHashCode();
                }
                if (this.LastExecutedActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.LastExecutedActivityId.GetHashCode();
                }
                if (this.LastExecutedActivityName != null)
                {
                    hashCode = (hashCode * 59) + this.LastExecutedActivityName.GetHashCode();
                }
                if (this.SupportId != null)
                {
                    hashCode = (hashCode * 59) + this.SupportId.GetHashCode();
                }
                if (this.CurrentPositionId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentPositionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
