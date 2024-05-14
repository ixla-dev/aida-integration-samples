/*
 * aida
 *
 * 1.0.692
 *
 * The version of the OpenAPI document: 1.0.692
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
    /// JobTemplateDto
    /// </summary>
    [DataContract(Name = "JobTemplateDto")]
    public partial class JobTemplateDto : IEquatable<JobTemplateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="expectedMarkDuration">expectedMarkDuration.</param>
        /// <param name="workingArea">workingArea.</param>
        /// <param name="readBackConfiguration">readBackConfiguration.</param>
        /// <param name="chipEncodingConfiguration">chipEncodingConfiguration.</param>
        /// <param name="magStripeConfiguration">magStripeConfiguration.</param>
        /// <param name="webhooksTarget">webhooksTarget.</param>
        /// <param name="file">file.</param>
        /// <param name="dataSourceConfiguration">dataSourceConfiguration.</param>
        /// <param name="layouts">layouts.</param>
        /// <param name="inkjetLayouts">inkjetLayouts.</param>
        /// <param name="markGroups">markGroups.</param>
        /// <param name="ocrSettings">ocrSettings.</param>
        /// <param name="autoPosEnabled">autoPosEnabled.</param>
        public JobTemplateDto(int? id = default(int?), string name = default(string), string description = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), string expectedMarkDuration = default(string), DRectangleDto workingArea = default(DRectangleDto), ReadBackConfigurationDto readBackConfiguration = default(ReadBackConfigurationDto), ChipEncodingConfigurationDto chipEncodingConfiguration = default(ChipEncodingConfigurationDto), MagneticStripeConfigurationDto magStripeConfiguration = default(MagneticStripeConfigurationDto), WebhooksTargetDto webhooksTarget = default(WebhooksTargetDto), FileDto file = default(FileDto), DataSourceConfigurationDto dataSourceConfiguration = default(DataSourceConfigurationDto), List<JobTemplateLayoutDto> layouts = default(List<JobTemplateLayoutDto>), List<JobTemplateInkjetLayoutDto> inkjetLayouts = default(List<JobTemplateInkjetLayoutDto>), List<ScannerMarkGroupDto> markGroups = default(List<ScannerMarkGroupDto>), List<JobTemplateOcrSettingsDto> ocrSettings = default(List<JobTemplateOcrSettingsDto>), bool autoPosEnabled = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExpectedMarkDuration = expectedMarkDuration;
            this.WorkingArea = workingArea;
            this.ReadBackConfiguration = readBackConfiguration;
            this.ChipEncodingConfiguration = chipEncodingConfiguration;
            this.MagStripeConfiguration = magStripeConfiguration;
            this.WebhooksTarget = webhooksTarget;
            this.File = file;
            this.DataSourceConfiguration = dataSourceConfiguration;
            this.Layouts = layouts;
            this.InkjetLayouts = inkjetLayouts;
            this.MarkGroups = markGroups;
            this.OcrSettings = ocrSettings;
            this.AutoPosEnabled = autoPosEnabled;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

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
        /// Gets or Sets ExpectedMarkDuration
        /// </summary>
        [DataMember(Name = "expectedMarkDuration", EmitDefaultValue = false)]
        public string ExpectedMarkDuration { get; set; }

        /// <summary>
        /// Gets or Sets WorkingArea
        /// </summary>
        [DataMember(Name = "workingArea", EmitDefaultValue = false)]
        public DRectangleDto WorkingArea { get; set; }

        /// <summary>
        /// Gets or Sets ReadBackConfiguration
        /// </summary>
        [DataMember(Name = "readBackConfiguration", EmitDefaultValue = false)]
        public ReadBackConfigurationDto ReadBackConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets ChipEncodingConfiguration
        /// </summary>
        [DataMember(Name = "chipEncodingConfiguration", EmitDefaultValue = false)]
        public ChipEncodingConfigurationDto ChipEncodingConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets MagStripeConfiguration
        /// </summary>
        [DataMember(Name = "magStripeConfiguration", EmitDefaultValue = false)]
        public MagneticStripeConfigurationDto MagStripeConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets WebhooksTarget
        /// </summary>
        [DataMember(Name = "webhooksTarget", EmitDefaultValue = false)]
        public WebhooksTargetDto WebhooksTarget { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileDto File { get; set; }

        /// <summary>
        /// Gets or Sets DataSourceConfiguration
        /// </summary>
        [DataMember(Name = "dataSourceConfiguration", EmitDefaultValue = false)]
        public DataSourceConfigurationDto DataSourceConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets Layouts
        /// </summary>
        [DataMember(Name = "layouts", EmitDefaultValue = true)]
        public List<JobTemplateLayoutDto> Layouts { get; set; }

        /// <summary>
        /// Gets or Sets InkjetLayouts
        /// </summary>
        [DataMember(Name = "inkjetLayouts", EmitDefaultValue = true)]
        public List<JobTemplateInkjetLayoutDto> InkjetLayouts { get; set; }

        /// <summary>
        /// Gets or Sets MarkGroups
        /// </summary>
        [DataMember(Name = "markGroups", EmitDefaultValue = true)]
        public List<ScannerMarkGroupDto> MarkGroups { get; set; }

        /// <summary>
        /// Gets or Sets OcrSettings
        /// </summary>
        [DataMember(Name = "ocrSettings", EmitDefaultValue = true)]
        public List<JobTemplateOcrSettingsDto> OcrSettings { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosEnabled
        /// </summary>
        [DataMember(Name = "autoPosEnabled", EmitDefaultValue = true)]
        public bool AutoPosEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ExpectedMarkDuration: ").Append(ExpectedMarkDuration).Append("\n");
            sb.Append("  WorkingArea: ").Append(WorkingArea).Append("\n");
            sb.Append("  ReadBackConfiguration: ").Append(ReadBackConfiguration).Append("\n");
            sb.Append("  ChipEncodingConfiguration: ").Append(ChipEncodingConfiguration).Append("\n");
            sb.Append("  MagStripeConfiguration: ").Append(MagStripeConfiguration).Append("\n");
            sb.Append("  WebhooksTarget: ").Append(WebhooksTarget).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  DataSourceConfiguration: ").Append(DataSourceConfiguration).Append("\n");
            sb.Append("  Layouts: ").Append(Layouts).Append("\n");
            sb.Append("  InkjetLayouts: ").Append(InkjetLayouts).Append("\n");
            sb.Append("  MarkGroups: ").Append(MarkGroups).Append("\n");
            sb.Append("  OcrSettings: ").Append(OcrSettings).Append("\n");
            sb.Append("  AutoPosEnabled: ").Append(AutoPosEnabled).Append("\n");
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
            return this.Equals(input as JobTemplateDto);
        }

        /// <summary>
        /// Returns true if JobTemplateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTemplateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTemplateDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.ExpectedMarkDuration == input.ExpectedMarkDuration ||
                    (this.ExpectedMarkDuration != null &&
                    this.ExpectedMarkDuration.Equals(input.ExpectedMarkDuration))
                ) && 
                (
                    this.WorkingArea == input.WorkingArea ||
                    (this.WorkingArea != null &&
                    this.WorkingArea.Equals(input.WorkingArea))
                ) && 
                (
                    this.ReadBackConfiguration == input.ReadBackConfiguration ||
                    (this.ReadBackConfiguration != null &&
                    this.ReadBackConfiguration.Equals(input.ReadBackConfiguration))
                ) && 
                (
                    this.ChipEncodingConfiguration == input.ChipEncodingConfiguration ||
                    (this.ChipEncodingConfiguration != null &&
                    this.ChipEncodingConfiguration.Equals(input.ChipEncodingConfiguration))
                ) && 
                (
                    this.MagStripeConfiguration == input.MagStripeConfiguration ||
                    (this.MagStripeConfiguration != null &&
                    this.MagStripeConfiguration.Equals(input.MagStripeConfiguration))
                ) && 
                (
                    this.WebhooksTarget == input.WebhooksTarget ||
                    (this.WebhooksTarget != null &&
                    this.WebhooksTarget.Equals(input.WebhooksTarget))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.DataSourceConfiguration == input.DataSourceConfiguration ||
                    (this.DataSourceConfiguration != null &&
                    this.DataSourceConfiguration.Equals(input.DataSourceConfiguration))
                ) && 
                (
                    this.Layouts == input.Layouts ||
                    this.Layouts != null &&
                    input.Layouts != null &&
                    this.Layouts.SequenceEqual(input.Layouts)
                ) && 
                (
                    this.InkjetLayouts == input.InkjetLayouts ||
                    this.InkjetLayouts != null &&
                    input.InkjetLayouts != null &&
                    this.InkjetLayouts.SequenceEqual(input.InkjetLayouts)
                ) && 
                (
                    this.MarkGroups == input.MarkGroups ||
                    this.MarkGroups != null &&
                    input.MarkGroups != null &&
                    this.MarkGroups.SequenceEqual(input.MarkGroups)
                ) && 
                (
                    this.OcrSettings == input.OcrSettings ||
                    this.OcrSettings != null &&
                    input.OcrSettings != null &&
                    this.OcrSettings.SequenceEqual(input.OcrSettings)
                ) && 
                (
                    this.AutoPosEnabled == input.AutoPosEnabled ||
                    this.AutoPosEnabled.Equals(input.AutoPosEnabled)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.ExpectedMarkDuration != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedMarkDuration.GetHashCode();
                }
                if (this.WorkingArea != null)
                {
                    hashCode = (hashCode * 59) + this.WorkingArea.GetHashCode();
                }
                if (this.ReadBackConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.ReadBackConfiguration.GetHashCode();
                }
                if (this.ChipEncodingConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.ChipEncodingConfiguration.GetHashCode();
                }
                if (this.MagStripeConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.MagStripeConfiguration.GetHashCode();
                }
                if (this.WebhooksTarget != null)
                {
                    hashCode = (hashCode * 59) + this.WebhooksTarget.GetHashCode();
                }
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                if (this.DataSourceConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.DataSourceConfiguration.GetHashCode();
                }
                if (this.Layouts != null)
                {
                    hashCode = (hashCode * 59) + this.Layouts.GetHashCode();
                }
                if (this.InkjetLayouts != null)
                {
                    hashCode = (hashCode * 59) + this.InkjetLayouts.GetHashCode();
                }
                if (this.MarkGroups != null)
                {
                    hashCode = (hashCode * 59) + this.MarkGroups.GetHashCode();
                }
                if (this.OcrSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OcrSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoPosEnabled.GetHashCode();
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
