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
    /// SCardConnectParamsDto
    /// </summary>
    [DataContract(Name = "SCardConnectParamsDto")]
    public partial class SCardConnectParamsDto : IEquatable<SCardConnectParamsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SCardShare? Share { get; set; }

        /// <summary>
        /// Gets or Sets PreferredProtocol
        /// </summary>
        [DataMember(Name = "preferredProtocol", EmitDefaultValue = false)]
        public SCardProtocol? PreferredProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardConnectParamsDto" /> class.
        /// </summary>
        /// <param name="share">share.</param>
        /// <param name="preferredProtocol">preferredProtocol.</param>
        public SCardConnectParamsDto(SCardShare? share = default(SCardShare?), SCardProtocol? preferredProtocol = default(SCardProtocol?))
        {
            this.Share = share;
            this.PreferredProtocol = preferredProtocol;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardConnectParamsDto {\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  PreferredProtocol: ").Append(PreferredProtocol).Append("\n");
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
            return this.Equals(input as SCardConnectParamsDto);
        }

        /// <summary>
        /// Returns true if SCardConnectParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SCardConnectParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCardConnectParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Share == input.Share ||
                    this.Share.Equals(input.Share)
                ) && 
                (
                    this.PreferredProtocol == input.PreferredProtocol ||
                    this.PreferredProtocol.Equals(input.PreferredProtocol)
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
                hashCode = (hashCode * 59) + this.Share.GetHashCode();
                hashCode = (hashCode * 59) + this.PreferredProtocol.GetHashCode();
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
