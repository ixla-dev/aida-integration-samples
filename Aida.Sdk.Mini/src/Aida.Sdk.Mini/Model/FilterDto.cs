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
    /// FilterDto
    /// </summary>
    [DataContract(Name = "FilterDto")]
    public partial class FilterDto : IEquatable<FilterDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDto" /> class.
        /// </summary>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="value">value.</param>
        public FilterDto(string fieldName = default(string), List<string> value = default(List<string>))
        {
            this.FieldName = fieldName;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<string> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterDto {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FilterDto);
        }

        /// <summary>
        /// Returns true if FilterDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
