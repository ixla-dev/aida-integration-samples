/*
 * aida-mini
 *
 * 1.0.321
 *
 * The version of the OpenAPI document: 1.0.321
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
    /// JobTemplateLayoutDto
    /// </summary>
    [DataContract(Name = "JobTemplateLayoutDto")]
    public partial class JobTemplateLayoutDto : IEquatable<JobTemplateLayoutDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateLayoutDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="layout">layout.</param>
        /// <param name="index">index.</param>
        /// <param name="layoutId">layoutId.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="autoPosSettings">autoPosSettings.</param>
        public JobTemplateLayoutDto(int id = default(int), LayoutDto layout = default(LayoutDto), int index = default(int), int layoutId = default(int), int jobTemplateId = default(int), string supportSide = default(string), List<JobTemplateLayoutAutoPosSettingsDto> autoPosSettings = default(List<JobTemplateLayoutAutoPosSettingsDto>))
        {
            this.Id = id;
            this.Layout = layout;
            this.Index = index;
            this.LayoutId = layoutId;
            this.JobTemplateId = jobTemplateId;
            this.SupportSide = supportSide;
            this.AutoPosSettings = autoPosSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false)]
        public LayoutDto Layout { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets LayoutId
        /// </summary>
        [DataMember(Name = "layoutId", EmitDefaultValue = false)]
        public int LayoutId { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosSettings
        /// </summary>
        [DataMember(Name = "autoPosSettings", EmitDefaultValue = true)]
        public List<JobTemplateLayoutAutoPosSettingsDto> AutoPosSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateLayoutDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  AutoPosSettings: ").Append(AutoPosSettings).Append("\n");
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
            return this.Equals(input as JobTemplateLayoutDto);
        }

        /// <summary>
        /// Returns true if JobTemplateLayoutDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTemplateLayoutDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTemplateLayoutDto input)
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
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.LayoutId == input.LayoutId ||
                    this.LayoutId.Equals(input.LayoutId)
                ) && 
                (
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
                ) && 
                (
                    this.SupportSide == input.SupportSide ||
                    (this.SupportSide != null &&
                    this.SupportSide.Equals(input.SupportSide))
                ) && 
                (
                    this.AutoPosSettings == input.AutoPosSettings ||
                    this.AutoPosSettings != null &&
                    input.AutoPosSettings != null &&
                    this.AutoPosSettings.SequenceEqual(input.AutoPosSettings)
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
                if (this.Layout != null)
                {
                    hashCode = (hashCode * 59) + this.Layout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.LayoutId.GetHashCode();
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
                if (this.SupportSide != null)
                {
                    hashCode = (hashCode * 59) + this.SupportSide.GetHashCode();
                }
                if (this.AutoPosSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AutoPosSettings.GetHashCode();
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
