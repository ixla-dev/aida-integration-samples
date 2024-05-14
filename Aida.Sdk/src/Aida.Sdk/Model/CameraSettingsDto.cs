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
    /// CameraSettingsDto
    /// </summary>
    [DataContract(Name = "CameraSettingsDto")]
    public partial class CameraSettingsDto : IEquatable<CameraSettingsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BinningMode
        /// </summary>
        [DataMember(Name = "binningMode", EmitDefaultValue = false)]
        public BinningMode? BinningMode { get; set; }

        /// <summary>
        /// Gets or Sets MirroringMode
        /// </summary>
        [DataMember(Name = "mirroringMode", EmitDefaultValue = false)]
        public MirroringMode? MirroringMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraSettingsDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="gainDb">gainDb.</param>
        /// <param name="exposureMicroseconds">exposureMicroseconds.</param>
        /// <param name="binningMode">binningMode.</param>
        /// <param name="mirroringMode">mirroringMode.</param>
        /// <param name="roi">roi.</param>
        /// <param name="rotationEnabled">rotationEnabled.</param>
        /// <param name="rotationAngle">rotationAngle.</param>
        public CameraSettingsDto(string name = default(string), double? gainDb = default(double?), int? exposureMicroseconds = default(int?), BinningMode? binningMode = default(BinningMode?), MirroringMode? mirroringMode = default(MirroringMode?), RectangleDto roi = default(RectangleDto), bool? rotationEnabled = default(bool?), int? rotationAngle = default(int?))
        {
            this.Name = name;
            this.GainDb = gainDb;
            this.ExposureMicroseconds = exposureMicroseconds;
            this.BinningMode = binningMode;
            this.MirroringMode = mirroringMode;
            this.Roi = roi;
            this.RotationEnabled = rotationEnabled;
            this.RotationAngle = rotationAngle;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GainDb
        /// </summary>
        [DataMember(Name = "gainDb", EmitDefaultValue = true)]
        public double? GainDb { get; set; }

        /// <summary>
        /// Gets or Sets ExposureMicroseconds
        /// </summary>
        [DataMember(Name = "exposureMicroseconds", EmitDefaultValue = true)]
        public int? ExposureMicroseconds { get; set; }

        /// <summary>
        /// Gets or Sets Roi
        /// </summary>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public RectangleDto Roi { get; set; }

        /// <summary>
        /// Gets or Sets RotationEnabled
        /// </summary>
        [DataMember(Name = "rotationEnabled", EmitDefaultValue = true)]
        public bool? RotationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets RotationAngle
        /// </summary>
        [DataMember(Name = "rotationAngle", EmitDefaultValue = true)]
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CameraSettingsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GainDb: ").Append(GainDb).Append("\n");
            sb.Append("  ExposureMicroseconds: ").Append(ExposureMicroseconds).Append("\n");
            sb.Append("  BinningMode: ").Append(BinningMode).Append("\n");
            sb.Append("  MirroringMode: ").Append(MirroringMode).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  RotationEnabled: ").Append(RotationEnabled).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
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
            return this.Equals(input as CameraSettingsDto);
        }

        /// <summary>
        /// Returns true if CameraSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CameraSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CameraSettingsDto input)
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
                    this.GainDb == input.GainDb ||
                    (this.GainDb != null &&
                    this.GainDb.Equals(input.GainDb))
                ) && 
                (
                    this.ExposureMicroseconds == input.ExposureMicroseconds ||
                    (this.ExposureMicroseconds != null &&
                    this.ExposureMicroseconds.Equals(input.ExposureMicroseconds))
                ) && 
                (
                    this.BinningMode == input.BinningMode ||
                    this.BinningMode.Equals(input.BinningMode)
                ) && 
                (
                    this.MirroringMode == input.MirroringMode ||
                    this.MirroringMode.Equals(input.MirroringMode)
                ) && 
                (
                    this.Roi == input.Roi ||
                    (this.Roi != null &&
                    this.Roi.Equals(input.Roi))
                ) && 
                (
                    this.RotationEnabled == input.RotationEnabled ||
                    (this.RotationEnabled != null &&
                    this.RotationEnabled.Equals(input.RotationEnabled))
                ) && 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
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
                if (this.GainDb != null)
                {
                    hashCode = (hashCode * 59) + this.GainDb.GetHashCode();
                }
                if (this.ExposureMicroseconds != null)
                {
                    hashCode = (hashCode * 59) + this.ExposureMicroseconds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BinningMode.GetHashCode();
                hashCode = (hashCode * 59) + this.MirroringMode.GetHashCode();
                if (this.Roi != null)
                {
                    hashCode = (hashCode * 59) + this.Roi.GetHashCode();
                }
                if (this.RotationEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.RotationEnabled.GetHashCode();
                }
                if (this.RotationAngle != null)
                {
                    hashCode = (hashCode * 59) + this.RotationAngle.GetHashCode();
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
