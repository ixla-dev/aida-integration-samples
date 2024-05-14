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
    /// BarcodeReadResultDto
    /// </summary>
    [DataContract(Name = "BarcodeReadResultDto")]
    public partial class BarcodeReadResultDto : IEquatable<BarcodeReadResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeReadResultDto" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="barcodeFormat">barcodeFormat.</param>
        /// <param name="durationMs">durationMs.</param>
        /// <param name="rawBytesBase64">rawBytesBase64.</param>
        public BarcodeReadResultDto(string text = default(string), string barcodeFormat = default(string), long durationMs = default(long), string rawBytesBase64 = default(string))
        {
            this.Text = text;
            this.BarcodeFormat = barcodeFormat;
            this.DurationMs = durationMs;
            this.RawBytesBase64 = rawBytesBase64;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets BarcodeFormat
        /// </summary>
        [DataMember(Name = "barcodeFormat", EmitDefaultValue = true)]
        public string BarcodeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name = "durationMs", EmitDefaultValue = false)]
        public long DurationMs { get; set; }

        /// <summary>
        /// Gets or Sets RawBytesBase64
        /// </summary>
        [DataMember(Name = "rawBytesBase64", EmitDefaultValue = true)]
        public string RawBytesBase64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BarcodeReadResultDto {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  BarcodeFormat: ").Append(BarcodeFormat).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  RawBytesBase64: ").Append(RawBytesBase64).Append("\n");
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
            return this.Equals(input as BarcodeReadResultDto);
        }

        /// <summary>
        /// Returns true if BarcodeReadResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeReadResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeReadResultDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.BarcodeFormat == input.BarcodeFormat ||
                    (this.BarcodeFormat != null &&
                    this.BarcodeFormat.Equals(input.BarcodeFormat))
                ) && 
                (
                    this.DurationMs == input.DurationMs ||
                    this.DurationMs.Equals(input.DurationMs)
                ) && 
                (
                    this.RawBytesBase64 == input.RawBytesBase64 ||
                    (this.RawBytesBase64 != null &&
                    this.RawBytesBase64.Equals(input.RawBytesBase64))
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.BarcodeFormat != null)
                {
                    hashCode = (hashCode * 59) + this.BarcodeFormat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DurationMs.GetHashCode();
                if (this.RawBytesBase64 != null)
                {
                    hashCode = (hashCode * 59) + this.RawBytesBase64.GetHashCode();
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
