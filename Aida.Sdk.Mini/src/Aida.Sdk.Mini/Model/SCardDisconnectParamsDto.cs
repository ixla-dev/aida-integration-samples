/*
 * aida-mini
 *
 * 1.0.324
 *
 * The version of the OpenAPI document: 1.0.324
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
    /// SCardDisconnectParamsDto
    /// </summary>
    [DataContract(Name = "SCardDisconnectParamsDto")]
    public partial class SCardDisconnectParamsDto : IEquatable<SCardDisconnectParamsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Disposition
        /// </summary>
        [DataMember(Name = "disposition", EmitDefaultValue = false)]
        public SCardDisposition? Disposition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardDisconnectParamsDto" /> class.
        /// </summary>
        /// <param name="disposition">disposition.</param>
        public SCardDisconnectParamsDto(SCardDisposition? disposition = default(SCardDisposition?))
        {
            this.Disposition = disposition;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardDisconnectParamsDto {\n");
            sb.Append("  Disposition: ").Append(Disposition).Append("\n");
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
            return this.Equals(input as SCardDisconnectParamsDto);
        }

        /// <summary>
        /// Returns true if SCardDisconnectParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SCardDisconnectParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCardDisconnectParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Disposition == input.Disposition ||
                    this.Disposition.Equals(input.Disposition)
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
                hashCode = (hashCode * 59) + this.Disposition.GetHashCode();
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
