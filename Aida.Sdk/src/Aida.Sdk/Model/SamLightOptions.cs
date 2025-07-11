/*
 * aida
 *
 * 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
 *
 * The version of the OpenAPI document: 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
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
    /// SamLightOptions
    /// </summary>
    [DataContract(Name = "SamLightOptions")]
    public partial class SamLightOptions : IEquatable<SamLightOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamLightOptions" /> class.
        /// </summary>
        /// <param name="prefixEntities">prefixEntities.</param>
        /// <param name="optic">optic.</param>
        public SamLightOptions(bool prefixEntities = default(bool), SamlightOpticSettings optic = default(SamlightOpticSettings))
        {
            this.PrefixEntities = prefixEntities;
            this.Optic = optic;
        }

        /// <summary>
        /// Gets or Sets PrefixEntities
        /// </summary>
        [DataMember(Name = "prefixEntities", EmitDefaultValue = true)]
        public bool PrefixEntities { get; set; }

        /// <summary>
        /// Gets or Sets Optic
        /// </summary>
        [DataMember(Name = "optic", EmitDefaultValue = false)]
        public SamlightOpticSettings Optic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamLightOptions {\n");
            sb.Append("  PrefixEntities: ").Append(PrefixEntities).Append("\n");
            sb.Append("  Optic: ").Append(Optic).Append("\n");
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
            return this.Equals(input as SamLightOptions);
        }

        /// <summary>
        /// Returns true if SamLightOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SamLightOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SamLightOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrefixEntities == input.PrefixEntities ||
                    this.PrefixEntities.Equals(input.PrefixEntities)
                ) && 
                (
                    this.Optic == input.Optic ||
                    (this.Optic != null &&
                    this.Optic.Equals(input.Optic))
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
                hashCode = (hashCode * 59) + this.PrefixEntities.GetHashCode();
                if (this.Optic != null)
                {
                    hashCode = (hashCode * 59) + this.Optic.GetHashCode();
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
