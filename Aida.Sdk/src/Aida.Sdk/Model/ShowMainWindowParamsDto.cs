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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// ShowMainWindowParamsDto
    /// </summary>
    [DataContract(Name = "ShowMainWindowParamsDto")]
    public partial class ShowMainWindowParamsDto : IEquatable<ShowMainWindowParamsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowMainWindowParamsDto" /> class.
        /// </summary>
        /// <param name="line1">line1.</param>
        /// <param name="line2">line2.</param>
        public ShowMainWindowParamsDto(string line1 = default(string), string line2 = default(string))
        {
            this.Line1 = line1;
            this.Line2 = line2;
        }

        /// <summary>
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name = "line1", EmitDefaultValue = true)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name = "line2", EmitDefaultValue = true)]
        public string Line2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowMainWindowParamsDto {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
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
            return this.Equals(input as ShowMainWindowParamsDto);
        }

        /// <summary>
        /// Returns true if ShowMainWindowParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowMainWindowParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowMainWindowParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
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
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
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
