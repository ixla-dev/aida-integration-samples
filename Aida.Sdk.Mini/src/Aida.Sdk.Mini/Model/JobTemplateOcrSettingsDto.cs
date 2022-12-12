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
    /// JobTemplateOcrSettingsDto
    /// </summary>
    [DataContract(Name = "JobTemplateOcrSettingsDto")]
    public partial class JobTemplateOcrSettingsDto : IEquatable<JobTemplateOcrSettingsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", IsRequired = true, EmitDefaultValue = false)]
        public SupportSide SupportSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateOcrSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobTemplateOcrSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateOcrSettingsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="jobTemplateId">jobTemplateId (required).</param>
        /// <param name="ocrSettingsId">ocrSettingsId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="runBeforeMark">runBeforeMark.</param>
        /// <param name="resultFieldName">resultFieldName.</param>
        /// <param name="sendWebhookNotification">sendWebhookNotification (required).</param>
        /// <param name="supportSide">supportSide (required).</param>
        /// <param name="ocrSettings">ocrSettings.</param>
        public JobTemplateOcrSettingsDto(int id = default(int), int jobTemplateId = default(int), int ocrSettingsId = default(int), string name = default(string), bool? runBeforeMark = default(bool?), string resultFieldName = default(string), bool sendWebhookNotification = default(bool), SupportSide supportSide = default(SupportSide), OcrSettingsDto ocrSettings = default(OcrSettingsDto))
        {
            this.JobTemplateId = jobTemplateId;
            this.OcrSettingsId = ocrSettingsId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for JobTemplateOcrSettingsDto and cannot be null");
            }
            this.Name = name;
            this.SendWebhookNotification = sendWebhookNotification;
            this.SupportSide = supportSide;
            this.Id = id;
            this.RunBeforeMark = runBeforeMark;
            this.ResultFieldName = resultFieldName;
            this.OcrSettings = ocrSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", IsRequired = true, EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets OcrSettingsId
        /// </summary>
        [DataMember(Name = "ocrSettingsId", IsRequired = true, EmitDefaultValue = false)]
        public int OcrSettingsId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RunBeforeMark
        /// </summary>
        [DataMember(Name = "runBeforeMark", EmitDefaultValue = true)]
        public bool? RunBeforeMark { get; set; }

        /// <summary>
        /// Gets or Sets ResultFieldName
        /// </summary>
        [DataMember(Name = "resultFieldName", EmitDefaultValue = true)]
        public string ResultFieldName { get; set; }

        /// <summary>
        /// Gets or Sets SendWebhookNotification
        /// </summary>
        [DataMember(Name = "sendWebhookNotification", IsRequired = true, EmitDefaultValue = true)]
        public bool SendWebhookNotification { get; set; }

        /// <summary>
        /// Gets or Sets OcrSettings
        /// </summary>
        [DataMember(Name = "ocrSettings", EmitDefaultValue = false)]
        public OcrSettingsDto OcrSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateOcrSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  OcrSettingsId: ").Append(OcrSettingsId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RunBeforeMark: ").Append(RunBeforeMark).Append("\n");
            sb.Append("  ResultFieldName: ").Append(ResultFieldName).Append("\n");
            sb.Append("  SendWebhookNotification: ").Append(SendWebhookNotification).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  OcrSettings: ").Append(OcrSettings).Append("\n");
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
            return this.Equals(input as JobTemplateOcrSettingsDto);
        }

        /// <summary>
        /// Returns true if JobTemplateOcrSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTemplateOcrSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTemplateOcrSettingsDto input)
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
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
                ) && 
                (
                    this.OcrSettingsId == input.OcrSettingsId ||
                    this.OcrSettingsId.Equals(input.OcrSettingsId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RunBeforeMark == input.RunBeforeMark ||
                    (this.RunBeforeMark != null &&
                    this.RunBeforeMark.Equals(input.RunBeforeMark))
                ) && 
                (
                    this.ResultFieldName == input.ResultFieldName ||
                    (this.ResultFieldName != null &&
                    this.ResultFieldName.Equals(input.ResultFieldName))
                ) && 
                (
                    this.SendWebhookNotification == input.SendWebhookNotification ||
                    this.SendWebhookNotification.Equals(input.SendWebhookNotification)
                ) && 
                (
                    this.SupportSide == input.SupportSide ||
                    this.SupportSide.Equals(input.SupportSide)
                ) && 
                (
                    this.OcrSettings == input.OcrSettings ||
                    (this.OcrSettings != null &&
                    this.OcrSettings.Equals(input.OcrSettings))
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
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.OcrSettingsId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RunBeforeMark != null)
                {
                    hashCode = (hashCode * 59) + this.RunBeforeMark.GetHashCode();
                }
                if (this.ResultFieldName != null)
                {
                    hashCode = (hashCode * 59) + this.ResultFieldName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendWebhookNotification.GetHashCode();
                hashCode = (hashCode * 59) + this.SupportSide.GetHashCode();
                if (this.OcrSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OcrSettings.GetHashCode();
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
