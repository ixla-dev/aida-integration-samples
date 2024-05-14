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
    /// DisplayTransportStatusDto
    /// </summary>
    [DataContract(Name = "DisplayTransportStatusDto")]
    public partial class DisplayTransportStatusDto : IEquatable<DisplayTransportStatusDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayTransportStatusDto" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="closedPhotoSensors">closedPhotoSensors.</param>
        /// <param name="doors">doors.</param>
        /// <param name="firmwareRevision">firmwareRevision.</param>
        /// <param name="hardwareRevision">hardwareRevision.</param>
        /// <param name="positions">positions.</param>
        public DisplayTransportStatusDto(string status = default(string), string closedPhotoSensors = default(string), string doors = default(string), string firmwareRevision = default(string), string hardwareRevision = default(string), string positions = default(string))
        {
            this.Status = status;
            this.ClosedPhotoSensors = closedPhotoSensors;
            this.Doors = doors;
            this.FirmwareRevision = firmwareRevision;
            this.HardwareRevision = hardwareRevision;
            this.Positions = positions;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ClosedPhotoSensors
        /// </summary>
        [DataMember(Name = "closedPhotoSensors", EmitDefaultValue = true)]
        public string ClosedPhotoSensors { get; set; }

        /// <summary>
        /// Gets or Sets Doors
        /// </summary>
        [DataMember(Name = "doors", EmitDefaultValue = true)]
        public string Doors { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareRevision
        /// </summary>
        [DataMember(Name = "firmwareRevision", EmitDefaultValue = true)]
        public string FirmwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets HardwareRevision
        /// </summary>
        [DataMember(Name = "hardwareRevision", EmitDefaultValue = true)]
        public string HardwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = true)]
        public string Positions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayTransportStatusDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ClosedPhotoSensors: ").Append(ClosedPhotoSensors).Append("\n");
            sb.Append("  Doors: ").Append(Doors).Append("\n");
            sb.Append("  FirmwareRevision: ").Append(FirmwareRevision).Append("\n");
            sb.Append("  HardwareRevision: ").Append(HardwareRevision).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
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
            return this.Equals(input as DisplayTransportStatusDto);
        }

        /// <summary>
        /// Returns true if DisplayTransportStatusDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayTransportStatusDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayTransportStatusDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ClosedPhotoSensors == input.ClosedPhotoSensors ||
                    (this.ClosedPhotoSensors != null &&
                    this.ClosedPhotoSensors.Equals(input.ClosedPhotoSensors))
                ) && 
                (
                    this.Doors == input.Doors ||
                    (this.Doors != null &&
                    this.Doors.Equals(input.Doors))
                ) && 
                (
                    this.FirmwareRevision == input.FirmwareRevision ||
                    (this.FirmwareRevision != null &&
                    this.FirmwareRevision.Equals(input.FirmwareRevision))
                ) && 
                (
                    this.HardwareRevision == input.HardwareRevision ||
                    (this.HardwareRevision != null &&
                    this.HardwareRevision.Equals(input.HardwareRevision))
                ) && 
                (
                    this.Positions == input.Positions ||
                    (this.Positions != null &&
                    this.Positions.Equals(input.Positions))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.ClosedPhotoSensors != null)
                {
                    hashCode = (hashCode * 59) + this.ClosedPhotoSensors.GetHashCode();
                }
                if (this.Doors != null)
                {
                    hashCode = (hashCode * 59) + this.Doors.GetHashCode();
                }
                if (this.FirmwareRevision != null)
                {
                    hashCode = (hashCode * 59) + this.FirmwareRevision.GetHashCode();
                }
                if (this.HardwareRevision != null)
                {
                    hashCode = (hashCode * 59) + this.HardwareRevision.GetHashCode();
                }
                if (this.Positions != null)
                {
                    hashCode = (hashCode * 59) + this.Positions.GetHashCode();
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
