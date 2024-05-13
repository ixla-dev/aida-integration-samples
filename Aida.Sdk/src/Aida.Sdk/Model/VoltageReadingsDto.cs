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
    /// VoltageReadingsDto
    /// </summary>
    [DataContract(Name = "VoltageReadingsDto")]
    public partial class VoltageReadingsDto : IEquatable<VoltageReadingsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoltageReadingsDto" /> class.
        /// </summary>
        /// <param name="feedbackVoltage12">feedbackVoltage12.</param>
        /// <param name="feedbackVoltage24">feedbackVoltage24.</param>
        /// <param name="feedbackVoltage48">feedbackVoltage48.</param>
        public VoltageReadingsDto(float feedbackVoltage12 = default(float), float feedbackVoltage24 = default(float), float feedbackVoltage48 = default(float))
        {
            this.FeedbackVoltage12 = feedbackVoltage12;
            this.FeedbackVoltage24 = feedbackVoltage24;
            this.FeedbackVoltage48 = feedbackVoltage48;
        }

        /// <summary>
        /// Gets or Sets FeedbackVoltage12
        /// </summary>
        [DataMember(Name = "feedbackVoltage12", EmitDefaultValue = false)]
        public float FeedbackVoltage12 { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackVoltage24
        /// </summary>
        [DataMember(Name = "feedbackVoltage24", EmitDefaultValue = false)]
        public float FeedbackVoltage24 { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackVoltage48
        /// </summary>
        [DataMember(Name = "feedbackVoltage48", EmitDefaultValue = false)]
        public float FeedbackVoltage48 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoltageReadingsDto {\n");
            sb.Append("  FeedbackVoltage12: ").Append(FeedbackVoltage12).Append("\n");
            sb.Append("  FeedbackVoltage24: ").Append(FeedbackVoltage24).Append("\n");
            sb.Append("  FeedbackVoltage48: ").Append(FeedbackVoltage48).Append("\n");
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
            return this.Equals(input as VoltageReadingsDto);
        }

        /// <summary>
        /// Returns true if VoltageReadingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VoltageReadingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoltageReadingsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FeedbackVoltage12 == input.FeedbackVoltage12 ||
                    this.FeedbackVoltage12.Equals(input.FeedbackVoltage12)
                ) && 
                (
                    this.FeedbackVoltage24 == input.FeedbackVoltage24 ||
                    this.FeedbackVoltage24.Equals(input.FeedbackVoltage24)
                ) && 
                (
                    this.FeedbackVoltage48 == input.FeedbackVoltage48 ||
                    this.FeedbackVoltage48.Equals(input.FeedbackVoltage48)
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
                hashCode = (hashCode * 59) + this.FeedbackVoltage12.GetHashCode();
                hashCode = (hashCode * 59) + this.FeedbackVoltage24.GetHashCode();
                hashCode = (hashCode * 59) + this.FeedbackVoltage48.GetHashCode();
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
