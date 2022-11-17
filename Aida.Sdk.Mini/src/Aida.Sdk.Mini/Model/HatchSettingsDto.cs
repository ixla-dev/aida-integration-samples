/*
 * aida-mini
 *
 * 1.0.307
 *
 * The version of the OpenAPI document: 1.0.307
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
    /// HatchSettingsDto
    /// </summary>
    [DataContract(Name = "HatchSettingsDto")]
    public partial class HatchSettingsDto : IEquatable<HatchSettingsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public HatchFlags? Flags { get; set; }

        /// <summary>
        /// Gets or Sets HatchStyle
        /// </summary>
        [DataMember(Name = "hatchStyle", EmitDefaultValue = false)]
        public HatchStyle? HatchStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HatchSettingsDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="flags">flags.</param>
        /// <param name="hatchDistance">hatchDistance.</param>
        /// <param name="hatchAngle">hatchAngle.</param>
        /// <param name="hatchStyle">hatchStyle.</param>
        /// <param name="beamCompensation">beamCompensation.</param>
        /// <param name="enabled">enabled.</param>
        public HatchSettingsDto(string name = default(string), HatchFlags? flags = default(HatchFlags?), double? hatchDistance = default(double?), double? hatchAngle = default(double?), HatchStyle? hatchStyle = default(HatchStyle?), double? beamCompensation = default(double?), bool? enabled = default(bool?))
        {
            this.Name = name;
            this.Flags = flags;
            this.HatchDistance = hatchDistance;
            this.HatchAngle = hatchAngle;
            this.HatchStyle = hatchStyle;
            this.BeamCompensation = beamCompensation;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HatchDistance
        /// </summary>
        [DataMember(Name = "hatchDistance", EmitDefaultValue = true)]
        public double? HatchDistance { get; set; }

        /// <summary>
        /// Gets or Sets HatchAngle
        /// </summary>
        [DataMember(Name = "hatchAngle", EmitDefaultValue = true)]
        public double? HatchAngle { get; set; }

        /// <summary>
        /// Gets or Sets BeamCompensation
        /// </summary>
        [DataMember(Name = "beamCompensation", EmitDefaultValue = true)]
        public double? BeamCompensation { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HatchSettingsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  HatchDistance: ").Append(HatchDistance).Append("\n");
            sb.Append("  HatchAngle: ").Append(HatchAngle).Append("\n");
            sb.Append("  HatchStyle: ").Append(HatchStyle).Append("\n");
            sb.Append("  BeamCompensation: ").Append(BeamCompensation).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as HatchSettingsDto);
        }

        /// <summary>
        /// Returns true if HatchSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HatchSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HatchSettingsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags.Equals(input.Flags)
                ) && 
                (
                    this.HatchDistance == input.HatchDistance ||
                    (this.HatchDistance != null &&
                    this.HatchDistance.Equals(input.HatchDistance))
                ) && 
                (
                    this.HatchAngle == input.HatchAngle ||
                    (this.HatchAngle != null &&
                    this.HatchAngle.Equals(input.HatchAngle))
                ) && 
                (
                    this.HatchStyle == input.HatchStyle ||
                    this.HatchStyle.Equals(input.HatchStyle)
                ) && 
                (
                    this.BeamCompensation == input.BeamCompensation ||
                    (this.BeamCompensation != null &&
                    this.BeamCompensation.Equals(input.BeamCompensation))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Flags.GetHashCode();
                if (this.HatchDistance != null)
                {
                    hashCode = (hashCode * 59) + this.HatchDistance.GetHashCode();
                }
                if (this.HatchAngle != null)
                {
                    hashCode = (hashCode * 59) + this.HatchAngle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HatchStyle.GetHashCode();
                if (this.BeamCompensation != null)
                {
                    hashCode = (hashCode * 59) + this.BeamCompensation.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
