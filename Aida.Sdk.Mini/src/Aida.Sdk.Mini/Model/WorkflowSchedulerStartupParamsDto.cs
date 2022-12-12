/*
 * aida-mini
 *
 * 1.0.308
 *
 * The version of the OpenAPI document: 1.0.308
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
    /// WorkflowSchedulerStartupParamsDto
    /// </summary>
    [DataContract(Name = "WorkflowSchedulerStartupParamsDto")]
    public partial class WorkflowSchedulerStartupParamsDto : IEquatable<WorkflowSchedulerStartupParamsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSchedulerStartupParamsDto" /> class.
        /// </summary>
        /// <param name="workflowTypeName">workflowTypeName.</param>
        /// <param name="jobTemplateName">jobTemplateName.</param>
        /// <param name="stopAfter">stopAfter.</param>
        /// <param name="dryRun">dryRun.</param>
        /// <param name="taskAllocationStrategy">taskAllocationStrategy.</param>
        /// <param name="noReset">noReset.</param>
        /// <param name="disableRedPointer">disableRedPointer.</param>
        /// <param name="skipEntityUpdates">skipEntityUpdates.</param>
        /// <param name="metadataFields">metadataFields.</param>
        /// <param name="filterJobsBy">filterJobsBy.</param>
        public WorkflowSchedulerStartupParamsDto(string workflowTypeName = default(string), string jobTemplateName = default(string), int? stopAfter = default(int?), bool? dryRun = default(bool?), string taskAllocationStrategy = default(string), bool? noReset = default(bool?), bool? disableRedPointer = default(bool?), bool? skipEntityUpdates = default(bool?), Dictionary<string, Object> metadataFields = default(Dictionary<string, Object>), List<FilterDto> filterJobsBy = default(List<FilterDto>))
        {
            this.WorkflowTypeName = workflowTypeName;
            this.JobTemplateName = jobTemplateName;
            this.StopAfter = stopAfter;
            this.DryRun = dryRun;
            this.TaskAllocationStrategy = taskAllocationStrategy;
            this.NoReset = noReset;
            this.DisableRedPointer = disableRedPointer;
            this.SkipEntityUpdates = skipEntityUpdates;
            this.MetadataFields = metadataFields;
            this.FilterJobsBy = filterJobsBy;
        }

        /// <summary>
        /// Gets or Sets WorkflowTypeName
        /// </summary>
        [DataMember(Name = "workflowTypeName", EmitDefaultValue = true)]
        public string WorkflowTypeName { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateName
        /// </summary>
        [DataMember(Name = "jobTemplateName", EmitDefaultValue = true)]
        public string JobTemplateName { get; set; }

        /// <summary>
        /// Gets or Sets StopAfter
        /// </summary>
        [DataMember(Name = "stopAfter", EmitDefaultValue = true)]
        public int? StopAfter { get; set; }

        /// <summary>
        /// Gets or Sets DryRun
        /// </summary>
        [DataMember(Name = "dryRun", EmitDefaultValue = true)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Gets or Sets TaskAllocationStrategy
        /// </summary>
        [DataMember(Name = "taskAllocationStrategy", EmitDefaultValue = true)]
        public string TaskAllocationStrategy { get; set; }

        /// <summary>
        /// Gets or Sets NoReset
        /// </summary>
        [DataMember(Name = "noReset", EmitDefaultValue = true)]
        public bool? NoReset { get; set; }

        /// <summary>
        /// Gets or Sets DisableRedPointer
        /// </summary>
        [DataMember(Name = "disableRedPointer", EmitDefaultValue = true)]
        public bool? DisableRedPointer { get; set; }

        /// <summary>
        /// Gets or Sets SkipEntityUpdates
        /// </summary>
        [DataMember(Name = "skipEntityUpdates", EmitDefaultValue = true)]
        public bool? SkipEntityUpdates { get; set; }

        /// <summary>
        /// Gets or Sets MetadataFields
        /// </summary>
        [DataMember(Name = "metadataFields", EmitDefaultValue = true)]
        public Dictionary<string, Object> MetadataFields { get; set; }

        /// <summary>
        /// Gets or Sets FilterJobsBy
        /// </summary>
        [DataMember(Name = "filterJobsBy", EmitDefaultValue = true)]
        public List<FilterDto> FilterJobsBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowSchedulerStartupParamsDto {\n");
            sb.Append("  WorkflowTypeName: ").Append(WorkflowTypeName).Append("\n");
            sb.Append("  JobTemplateName: ").Append(JobTemplateName).Append("\n");
            sb.Append("  StopAfter: ").Append(StopAfter).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  TaskAllocationStrategy: ").Append(TaskAllocationStrategy).Append("\n");
            sb.Append("  NoReset: ").Append(NoReset).Append("\n");
            sb.Append("  DisableRedPointer: ").Append(DisableRedPointer).Append("\n");
            sb.Append("  SkipEntityUpdates: ").Append(SkipEntityUpdates).Append("\n");
            sb.Append("  MetadataFields: ").Append(MetadataFields).Append("\n");
            sb.Append("  FilterJobsBy: ").Append(FilterJobsBy).Append("\n");
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
            return this.Equals(input as WorkflowSchedulerStartupParamsDto);
        }

        /// <summary>
        /// Returns true if WorkflowSchedulerStartupParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowSchedulerStartupParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowSchedulerStartupParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkflowTypeName == input.WorkflowTypeName ||
                    (this.WorkflowTypeName != null &&
                    this.WorkflowTypeName.Equals(input.WorkflowTypeName))
                ) && 
                (
                    this.JobTemplateName == input.JobTemplateName ||
                    (this.JobTemplateName != null &&
                    this.JobTemplateName.Equals(input.JobTemplateName))
                ) && 
                (
                    this.StopAfter == input.StopAfter ||
                    (this.StopAfter != null &&
                    this.StopAfter.Equals(input.StopAfter))
                ) && 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
                ) && 
                (
                    this.TaskAllocationStrategy == input.TaskAllocationStrategy ||
                    (this.TaskAllocationStrategy != null &&
                    this.TaskAllocationStrategy.Equals(input.TaskAllocationStrategy))
                ) && 
                (
                    this.NoReset == input.NoReset ||
                    (this.NoReset != null &&
                    this.NoReset.Equals(input.NoReset))
                ) && 
                (
                    this.DisableRedPointer == input.DisableRedPointer ||
                    (this.DisableRedPointer != null &&
                    this.DisableRedPointer.Equals(input.DisableRedPointer))
                ) && 
                (
                    this.SkipEntityUpdates == input.SkipEntityUpdates ||
                    (this.SkipEntityUpdates != null &&
                    this.SkipEntityUpdates.Equals(input.SkipEntityUpdates))
                ) && 
                (
                    this.MetadataFields == input.MetadataFields ||
                    this.MetadataFields != null &&
                    input.MetadataFields != null &&
                    this.MetadataFields.SequenceEqual(input.MetadataFields)
                ) && 
                (
                    this.FilterJobsBy == input.FilterJobsBy ||
                    this.FilterJobsBy != null &&
                    input.FilterJobsBy != null &&
                    this.FilterJobsBy.SequenceEqual(input.FilterJobsBy)
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
                if (this.WorkflowTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowTypeName.GetHashCode();
                }
                if (this.JobTemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.JobTemplateName.GetHashCode();
                }
                if (this.StopAfter != null)
                {
                    hashCode = (hashCode * 59) + this.StopAfter.GetHashCode();
                }
                if (this.DryRun != null)
                {
                    hashCode = (hashCode * 59) + this.DryRun.GetHashCode();
                }
                if (this.TaskAllocationStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.TaskAllocationStrategy.GetHashCode();
                }
                if (this.NoReset != null)
                {
                    hashCode = (hashCode * 59) + this.NoReset.GetHashCode();
                }
                if (this.DisableRedPointer != null)
                {
                    hashCode = (hashCode * 59) + this.DisableRedPointer.GetHashCode();
                }
                if (this.SkipEntityUpdates != null)
                {
                    hashCode = (hashCode * 59) + this.SkipEntityUpdates.GetHashCode();
                }
                if (this.MetadataFields != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataFields.GetHashCode();
                }
                if (this.FilterJobsBy != null)
                {
                    hashCode = (hashCode * 59) + this.FilterJobsBy.GetHashCode();
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
