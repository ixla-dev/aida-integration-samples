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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// TemperatureReadingsDto
    /// </summary>
    [DataContract(Name = "TemperatureReadingsDto")]
    public partial class TemperatureReadingsDto : IEquatable<TemperatureReadingsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureReadingsDto" /> class.
        /// </summary>
        /// <param name="printHeadTemperatureCelsius">printHeadTemperatureCelsius.</param>
        /// <param name="heaterTemperatureCelsius">heaterTemperatureCelsius.</param>
        /// <param name="internalTemperatureCelsius">internalTemperatureCelsius.</param>
        /// <param name="board1TemperatureCelsius">board1TemperatureCelsius.</param>
        /// <param name="board2TemperatureCelsius">board2TemperatureCelsius.</param>
        public TemperatureReadingsDto(float printHeadTemperatureCelsius = default(float), float heaterTemperatureCelsius = default(float), float internalTemperatureCelsius = default(float), float board1TemperatureCelsius = default(float), float board2TemperatureCelsius = default(float))
        {
            this.PrintHeadTemperatureCelsius = printHeadTemperatureCelsius;
            this.HeaterTemperatureCelsius = heaterTemperatureCelsius;
            this.InternalTemperatureCelsius = internalTemperatureCelsius;
            this.Board1TemperatureCelsius = board1TemperatureCelsius;
            this.Board2TemperatureCelsius = board2TemperatureCelsius;
        }

        /// <summary>
        /// Gets or Sets PrintHeadTemperatureCelsius
        /// </summary>
        [DataMember(Name = "printHeadTemperatureCelsius", EmitDefaultValue = false)]
        public float PrintHeadTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets HeaterTemperatureCelsius
        /// </summary>
        [DataMember(Name = "heaterTemperatureCelsius", EmitDefaultValue = false)]
        public float HeaterTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets InternalTemperatureCelsius
        /// </summary>
        [DataMember(Name = "internalTemperatureCelsius", EmitDefaultValue = false)]
        public float InternalTemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets Board1TemperatureCelsius
        /// </summary>
        [DataMember(Name = "board1TemperatureCelsius", EmitDefaultValue = false)]
        public float Board1TemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or Sets Board2TemperatureCelsius
        /// </summary>
        [DataMember(Name = "board2TemperatureCelsius", EmitDefaultValue = false)]
        public float Board2TemperatureCelsius { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemperatureReadingsDto {\n");
            sb.Append("  PrintHeadTemperatureCelsius: ").Append(PrintHeadTemperatureCelsius).Append("\n");
            sb.Append("  HeaterTemperatureCelsius: ").Append(HeaterTemperatureCelsius).Append("\n");
            sb.Append("  InternalTemperatureCelsius: ").Append(InternalTemperatureCelsius).Append("\n");
            sb.Append("  Board1TemperatureCelsius: ").Append(Board1TemperatureCelsius).Append("\n");
            sb.Append("  Board2TemperatureCelsius: ").Append(Board2TemperatureCelsius).Append("\n");
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
            return this.Equals(input as TemperatureReadingsDto);
        }

        /// <summary>
        /// Returns true if TemperatureReadingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TemperatureReadingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemperatureReadingsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrintHeadTemperatureCelsius == input.PrintHeadTemperatureCelsius ||
                    this.PrintHeadTemperatureCelsius.Equals(input.PrintHeadTemperatureCelsius)
                ) && 
                (
                    this.HeaterTemperatureCelsius == input.HeaterTemperatureCelsius ||
                    this.HeaterTemperatureCelsius.Equals(input.HeaterTemperatureCelsius)
                ) && 
                (
                    this.InternalTemperatureCelsius == input.InternalTemperatureCelsius ||
                    this.InternalTemperatureCelsius.Equals(input.InternalTemperatureCelsius)
                ) && 
                (
                    this.Board1TemperatureCelsius == input.Board1TemperatureCelsius ||
                    this.Board1TemperatureCelsius.Equals(input.Board1TemperatureCelsius)
                ) && 
                (
                    this.Board2TemperatureCelsius == input.Board2TemperatureCelsius ||
                    this.Board2TemperatureCelsius.Equals(input.Board2TemperatureCelsius)
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
                hashCode = (hashCode * 59) + this.PrintHeadTemperatureCelsius.GetHashCode();
                hashCode = (hashCode * 59) + this.HeaterTemperatureCelsius.GetHashCode();
                hashCode = (hashCode * 59) + this.InternalTemperatureCelsius.GetHashCode();
                hashCode = (hashCode * 59) + this.Board1TemperatureCelsius.GetHashCode();
                hashCode = (hashCode * 59) + this.Board2TemperatureCelsius.GetHashCode();
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
