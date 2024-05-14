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
    /// SortCriteria
    /// </summary>
    [DataContract(Name = "SortCriteria")]
    public partial class SortCriteria : IEquatable<SortCriteria>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public SortDirection? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortCriteria" /> class.
        /// </summary>
        /// <param name="propertyName">propertyName.</param>
        /// <param name="direction">direction.</param>
        public SortCriteria(string propertyName = default(string), SortDirection? direction = default(SortDirection?))
        {
            this.PropertyName = propertyName;
            this.Direction = direction;
        }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name = "propertyName", EmitDefaultValue = true)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SortCriteria {\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as SortCriteria);
        }

        /// <summary>
        /// Returns true if SortCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of SortCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortCriteria input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.PropertyName != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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
