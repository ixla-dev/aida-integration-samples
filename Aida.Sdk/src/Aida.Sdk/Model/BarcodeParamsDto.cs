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
    /// BarcodeParamsDto
    /// </summary>
    [DataContract(Name = "BarcodeParamsDto")]
    public partial class BarcodeParamsDto : IEquatable<BarcodeParamsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeParamsDto" /> class.
        /// </summary>
        /// <param name="rotation">rotation.</param>
        /// <param name="roi">roi.</param>
        public BarcodeParamsDto(double? rotation = default(double?), RectangleDto roi = default(RectangleDto))
        {
            this.Rotation = rotation;
            this.Roi = roi;
        }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = true)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Gets or Sets Roi
        /// </summary>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public RectangleDto Roi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BarcodeParamsDto {\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
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
            return this.Equals(input as BarcodeParamsDto);
        }

        /// <summary>
        /// Returns true if BarcodeParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.Roi == input.Roi ||
                    (this.Roi != null &&
                    this.Roi.Equals(input.Roi))
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
                if (this.Rotation != null)
                {
                    hashCode = (hashCode * 59) + this.Rotation.GetHashCode();
                }
                if (this.Roi != null)
                {
                    hashCode = (hashCode * 59) + this.Roi.GetHashCode();
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
