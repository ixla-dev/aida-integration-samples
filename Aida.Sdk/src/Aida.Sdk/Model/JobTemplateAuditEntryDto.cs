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
    /// JobTemplateAuditEntryDto
    /// </summary>
    [DataContract(Name = "JobTemplateAuditEntryDto")]
    public partial class JobTemplateAuditEntryDto : IEquatable<JobTemplateAuditEntryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTemplateAuditEntryDto" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="operation">operation.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="ocrName">ocrName.</param>
        /// <param name="autoposName">autoposName.</param>
        /// <param name="webhookName">webhookName.</param>
        public JobTemplateAuditEntryDto(string description = default(string), int jobTemplateId = default(int), string operation = default(string), string layoutName = default(string), string ocrName = default(string), string autoposName = default(string), string webhookName = default(string))
        {
            this.Description = description;
            this.JobTemplateId = jobTemplateId;
            this.Operation = operation;
            this.LayoutName = layoutName;
            this.OcrName = ocrName;
            this.AutoposName = autoposName;
            this.WebhookName = webhookName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// Returns false as Timestamp should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimestamp()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets OcrName
        /// </summary>
        [DataMember(Name = "ocrName", EmitDefaultValue = true)]
        public string OcrName { get; set; }

        /// <summary>
        /// Gets or Sets AutoposName
        /// </summary>
        [DataMember(Name = "autoposName", EmitDefaultValue = true)]
        public string AutoposName { get; set; }

        /// <summary>
        /// Gets or Sets WebhookName
        /// </summary>
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobTemplateAuditEntryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  OcrName: ").Append(OcrName).Append("\n");
            sb.Append("  AutoposName: ").Append(AutoposName).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
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
            return this.Equals(input as JobTemplateAuditEntryDto);
        }

        /// <summary>
        /// Returns true if JobTemplateAuditEntryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTemplateAuditEntryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTemplateAuditEntryDto input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.LayoutName == input.LayoutName ||
                    (this.LayoutName != null &&
                    this.LayoutName.Equals(input.LayoutName))
                ) && 
                (
                    this.OcrName == input.OcrName ||
                    (this.OcrName != null &&
                    this.OcrName.Equals(input.OcrName))
                ) && 
                (
                    this.AutoposName == input.AutoposName ||
                    (this.AutoposName != null &&
                    this.AutoposName.Equals(input.AutoposName))
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.LayoutName != null)
                {
                    hashCode = (hashCode * 59) + this.LayoutName.GetHashCode();
                }
                if (this.OcrName != null)
                {
                    hashCode = (hashCode * 59) + this.OcrName.GetHashCode();
                }
                if (this.AutoposName != null)
                {
                    hashCode = (hashCode * 59) + this.AutoposName.GetHashCode();
                }
                if (this.WebhookName != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookName.GetHashCode();
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
