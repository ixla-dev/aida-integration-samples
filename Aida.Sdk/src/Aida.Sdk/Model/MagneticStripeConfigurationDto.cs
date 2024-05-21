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
    /// MagneticStripeConfigurationDto
    /// </summary>
    [DataContract(Name = "MagneticStripeConfigurationDto")]
    public partial class MagneticStripeConfigurationDto : IEquatable<MagneticStripeConfigurationDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name = "operations", EmitDefaultValue = false)]
        public MagneticStripeOperations? Operations { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticStripeConfigurationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="operations">operations.</param>
        /// <param name="highCoercivity">highCoercivity.</param>
        /// <param name="track1Enabled">track1Enabled.</param>
        /// <param name="track2Enabled">track2Enabled.</param>
        /// <param name="track3Enabled">track3Enabled.</param>
        public MagneticStripeConfigurationDto(int id = default(int), MagneticStripeOperations? operations = default(MagneticStripeOperations?), bool? highCoercivity = default(bool?), bool? track1Enabled = default(bool?), bool? track2Enabled = default(bool?), bool? track3Enabled = default(bool?))
        {
            this.Id = id;
            this.Operations = operations;
            this.HighCoercivity = highCoercivity;
            this.Track1Enabled = track1Enabled;
            this.Track2Enabled = track2Enabled;
            this.Track3Enabled = track3Enabled;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets HighCoercivity
        /// </summary>
        [DataMember(Name = "highCoercivity", EmitDefaultValue = true)]
        public bool? HighCoercivity { get; set; }

        /// <summary>
        /// Gets or Sets Track1Enabled
        /// </summary>
        [DataMember(Name = "track1Enabled", EmitDefaultValue = true)]
        public bool? Track1Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Track2Enabled
        /// </summary>
        [DataMember(Name = "track2Enabled", EmitDefaultValue = true)]
        public bool? Track2Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Track3Enabled
        /// </summary>
        [DataMember(Name = "track3Enabled", EmitDefaultValue = true)]
        public bool? Track3Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MagneticStripeConfigurationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  HighCoercivity: ").Append(HighCoercivity).Append("\n");
            sb.Append("  Track1Enabled: ").Append(Track1Enabled).Append("\n");
            sb.Append("  Track2Enabled: ").Append(Track2Enabled).Append("\n");
            sb.Append("  Track3Enabled: ").Append(Track3Enabled).Append("\n");
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
            return this.Equals(input as MagneticStripeConfigurationDto);
        }

        /// <summary>
        /// Returns true if MagneticStripeConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MagneticStripeConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagneticStripeConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations.Equals(input.Operations)
                ) && 
                (
                    this.HighCoercivity == input.HighCoercivity ||
                    (this.HighCoercivity != null &&
                    this.HighCoercivity.Equals(input.HighCoercivity))
                ) && 
                (
                    this.Track1Enabled == input.Track1Enabled ||
                    (this.Track1Enabled != null &&
                    this.Track1Enabled.Equals(input.Track1Enabled))
                ) && 
                (
                    this.Track2Enabled == input.Track2Enabled ||
                    (this.Track2Enabled != null &&
                    this.Track2Enabled.Equals(input.Track2Enabled))
                ) && 
                (
                    this.Track3Enabled == input.Track3Enabled ||
                    (this.Track3Enabled != null &&
                    this.Track3Enabled.Equals(input.Track3Enabled))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Operations.GetHashCode();
                if (this.HighCoercivity != null)
                {
                    hashCode = (hashCode * 59) + this.HighCoercivity.GetHashCode();
                }
                if (this.Track1Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Track1Enabled.GetHashCode();
                }
                if (this.Track2Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Track2Enabled.GetHashCode();
                }
                if (this.Track3Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Track3Enabled.GetHashCode();
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
