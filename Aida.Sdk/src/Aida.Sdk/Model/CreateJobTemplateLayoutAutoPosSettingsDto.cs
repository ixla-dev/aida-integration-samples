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
    /// CreateJobTemplateLayoutAutoPosSettingsDto
    /// </summary>
    [DataContract(Name = "CreateJobTemplateLayoutAutoPosSettingsDto")]
    public partial class CreateJobTemplateLayoutAutoPosSettingsDto : IEquatable<CreateJobTemplateLayoutAutoPosSettingsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobTemplateLayoutAutoPosSettingsDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="templateMatchingConfigurationId">templateMatchingConfigurationId.</param>
        public CreateJobTemplateLayoutAutoPosSettingsDto(string name = default(string), float threshold = default(float), int templateMatchingConfigurationId = default(int))
        {
            this.Name = name;
            this.Threshold = threshold;
            this.TemplateMatchingConfigurationId = templateMatchingConfigurationId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public float Threshold { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMatchingConfigurationId
        /// </summary>
        [DataMember(Name = "templateMatchingConfigurationId", EmitDefaultValue = false)]
        public int TemplateMatchingConfigurationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateJobTemplateLayoutAutoPosSettingsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  TemplateMatchingConfigurationId: ").Append(TemplateMatchingConfigurationId).Append("\n");
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
            return this.Equals(input as CreateJobTemplateLayoutAutoPosSettingsDto);
        }

        /// <summary>
        /// Returns true if CreateJobTemplateLayoutAutoPosSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateJobTemplateLayoutAutoPosSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateJobTemplateLayoutAutoPosSettingsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    this.Threshold.Equals(input.Threshold)
                ) && 
                (
                    this.TemplateMatchingConfigurationId == input.TemplateMatchingConfigurationId ||
                    this.TemplateMatchingConfigurationId.Equals(input.TemplateMatchingConfigurationId)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
                hashCode = (hashCode * 59) + this.TemplateMatchingConfigurationId.GetHashCode();
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
