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
    /// ChipEncodingConfigurationDto
    /// </summary>
    [DataContract(Name = "ChipEncodingConfigurationDto")]
    public partial class ChipEncodingConfigurationDto : IEquatable<ChipEncodingConfigurationDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReaderAccessType
        /// </summary>
        [DataMember(Name = "readerAccessType", EmitDefaultValue = false)]
        public ReaderAccessType? ReaderAccessType { get; set; }

        /// <summary>
        /// Gets or Sets ReaderInterfaceType
        /// </summary>
        [DataMember(Name = "readerInterfaceType", EmitDefaultValue = false)]
        public ReaderInterfaceType? ReaderInterfaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChipEncodingConfigurationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="readerAccessType">readerAccessType.</param>
        /// <param name="readerInterfaceType">readerInterfaceType.</param>
        public ChipEncodingConfigurationDto(int? id = default(int?), ReaderAccessType? readerAccessType = default(ReaderAccessType?), ReaderInterfaceType? readerInterfaceType = default(ReaderInterfaceType?))
        {
            this.Id = id;
            this.ReaderAccessType = readerAccessType;
            this.ReaderInterfaceType = readerInterfaceType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChipEncodingConfigurationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReaderAccessType: ").Append(ReaderAccessType).Append("\n");
            sb.Append("  ReaderInterfaceType: ").Append(ReaderInterfaceType).Append("\n");
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
            return this.Equals(input as ChipEncodingConfigurationDto);
        }

        /// <summary>
        /// Returns true if ChipEncodingConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ChipEncodingConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChipEncodingConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ReaderAccessType == input.ReaderAccessType ||
                    this.ReaderAccessType.Equals(input.ReaderAccessType)
                ) && 
                (
                    this.ReaderInterfaceType == input.ReaderInterfaceType ||
                    this.ReaderInterfaceType.Equals(input.ReaderInterfaceType)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReaderAccessType.GetHashCode();
                hashCode = (hashCode * 59) + this.ReaderInterfaceType.GetHashCode();
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
