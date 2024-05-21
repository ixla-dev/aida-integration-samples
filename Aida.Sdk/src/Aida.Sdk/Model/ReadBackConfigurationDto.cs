/*
 * aida
 *
 * 1.0.696
 *
 * The version of the OpenAPI document: 1.0.696
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// ReadBackConfigurationDto
    /// </summary>
    [DataContract(Name = "ReadBackConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackConfigurationDto), "ChipReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackConfigurationDto), "IXLA.Box.Automapper.ChipReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(MagneticReadBackConfigurationDto), "IXLA.Box.Automapper.MagneticReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackConfigurationDto), "IXLA.Box.Automapper.OcrReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(MagneticReadBackConfigurationDto), "MagneticReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackConfigurationDto), "OcrReadBackConfigurationDto")]
    public partial class ReadBackConfigurationDto : IEquatable<ReadBackConfigurationDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReadBackType
        /// </summary>
        [DataMember(Name = "readBackType", EmitDefaultValue = false)]
        public ReadBackType? ReadBackType { get; set; }

        /// <summary>
        /// Gets or Sets RequiredSide
        /// </summary>
        [DataMember(Name = "requiredSide", EmitDefaultValue = false)]
        public SupportSide? RequiredSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadBackConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReadBackConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadBackConfigurationDto" /> class.
        /// </summary>
        /// <param name="discriminator">discriminator (required).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="readBackType">readBackType.</param>
        /// <param name="requiredSide">requiredSide.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        public ReadBackConfigurationDto(string discriminator = default(string), int id = default(int), string name = default(string), ReadBackType? readBackType = default(ReadBackType?), SupportSide? requiredSide = default(SupportSide?), int jobTemplateId = default(int))
        {
            // to ensure "discriminator" is required (not null)
            if (discriminator == null)
            {
                throw new ArgumentNullException("discriminator is a required property for ReadBackConfigurationDto and cannot be null");
            }
            this.Discriminator = discriminator;
            this.Id = id;
            this.Name = name;
            this.ReadBackType = readBackType;
            this.RequiredSide = requiredSide;
            this.JobTemplateId = jobTemplateId;
        }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", IsRequired = true, EmitDefaultValue = true)]
        public string Discriminator { get; set; }

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
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadBackConfigurationDto {\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadBackType: ").Append(ReadBackType).Append("\n");
            sb.Append("  RequiredSide: ").Append(RequiredSide).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
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
            return this.Equals(input as ReadBackConfigurationDto);
        }

        /// <summary>
        /// Returns true if ReadBackConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadBackConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadBackConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
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
                    this.ReadBackType == input.ReadBackType ||
                    this.ReadBackType.Equals(input.ReadBackType)
                ) && 
                (
                    this.RequiredSide == input.RequiredSide ||
                    this.RequiredSide.Equals(input.RequiredSide)
                ) && 
                (
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
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
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReadBackType.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiredSide.GetHashCode();
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
