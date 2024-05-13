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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// MagneticReadBackConfigurationDto
    /// </summary>
    [DataContract(Name = "MagneticReadBackConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(ChipReadBackConfigurationDto), "IXLA.Box.Automapper.ChipReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(MagneticReadBackConfigurationDto), "IXLA.Box.Automapper.MagneticReadBackConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(OcrReadBackConfigurationDto), "IXLA.Box.Automapper.OcrReadBackConfigurationDto")]
    public partial class MagneticReadBackConfigurationDto : ReadBackConfigurationDto, IEquatable<MagneticReadBackConfigurationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticReadBackConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MagneticReadBackConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticReadBackConfigurationDto" /> class.
        /// </summary>
        /// <param name="highCoercivity">highCoercivity.</param>
        /// <param name="readFromTrack1">readFromTrack1.</param>
        /// <param name="readFromTrack2">readFromTrack2.</param>
        /// <param name="readFromTrack3">readFromTrack3.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;MagneticReadBackConfigurationDto&quot;).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="readBackType">readBackType.</param>
        /// <param name="requiredSide">requiredSide.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        public MagneticReadBackConfigurationDto(bool highCoercivity = default(bool), bool readFromTrack1 = default(bool), bool readFromTrack2 = default(bool), bool readFromTrack3 = default(bool), string discriminator = "MagneticReadBackConfigurationDto", int id = default(int), string name = default(string), ReadBackType? readBackType = default(ReadBackType?), SupportSide? requiredSide = default(SupportSide?), int jobTemplateId = default(int)) : base(discriminator, id, name, readBackType, requiredSide, jobTemplateId)
        {
            this.HighCoercivity = highCoercivity;
            this.ReadFromTrack1 = readFromTrack1;
            this.ReadFromTrack2 = readFromTrack2;
            this.ReadFromTrack3 = readFromTrack3;
        }

        /// <summary>
        /// Gets or Sets HighCoercivity
        /// </summary>
        [DataMember(Name = "highCoercivity", EmitDefaultValue = true)]
        public bool HighCoercivity { get; set; }

        /// <summary>
        /// Gets or Sets ReadFromTrack1
        /// </summary>
        [DataMember(Name = "readFromTrack1", EmitDefaultValue = true)]
        public bool ReadFromTrack1 { get; set; }

        /// <summary>
        /// Gets or Sets ReadFromTrack2
        /// </summary>
        [DataMember(Name = "readFromTrack2", EmitDefaultValue = true)]
        public bool ReadFromTrack2 { get; set; }

        /// <summary>
        /// Gets or Sets ReadFromTrack3
        /// </summary>
        [DataMember(Name = "readFromTrack3", EmitDefaultValue = true)]
        public bool ReadFromTrack3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MagneticReadBackConfigurationDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  HighCoercivity: ").Append(HighCoercivity).Append("\n");
            sb.Append("  ReadFromTrack1: ").Append(ReadFromTrack1).Append("\n");
            sb.Append("  ReadFromTrack2: ").Append(ReadFromTrack2).Append("\n");
            sb.Append("  ReadFromTrack3: ").Append(ReadFromTrack3).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as MagneticReadBackConfigurationDto);
        }

        /// <summary>
        /// Returns true if MagneticReadBackConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MagneticReadBackConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagneticReadBackConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.HighCoercivity == input.HighCoercivity ||
                    this.HighCoercivity.Equals(input.HighCoercivity)
                ) && base.Equals(input) && 
                (
                    this.ReadFromTrack1 == input.ReadFromTrack1 ||
                    this.ReadFromTrack1.Equals(input.ReadFromTrack1)
                ) && base.Equals(input) && 
                (
                    this.ReadFromTrack2 == input.ReadFromTrack2 ||
                    this.ReadFromTrack2.Equals(input.ReadFromTrack2)
                ) && base.Equals(input) && 
                (
                    this.ReadFromTrack3 == input.ReadFromTrack3 ||
                    this.ReadFromTrack3.Equals(input.ReadFromTrack3)
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
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 59) + this.HighCoercivity.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadFromTrack1.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadFromTrack2.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadFromTrack3.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
