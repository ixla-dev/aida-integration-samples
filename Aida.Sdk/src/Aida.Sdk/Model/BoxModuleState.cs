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
    /// BoxModuleState
    /// </summary>
    [DataContract(Name = "BoxModuleState")]
    public partial class BoxModuleState : IEquatable<BoxModuleState>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public BoxModuleConfiguration? _Configuration { get; set; }

        /// <summary>
        /// Gets or Sets DipSwitchHardwareSetting
        /// </summary>
        [DataMember(Name = "dipSwitchHardwareSetting", EmitDefaultValue = false)]
        public DipSwitchSetting? DipSwitchHardwareSetting { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = false)]
        public ModulePositionsFlags? Positions { get; set; }

        /// <summary>
        /// Gets or Sets BoxModuleDoors
        /// </summary>
        [DataMember(Name = "boxModuleDoors", EmitDefaultValue = false)]
        public BoxModuleDoorStatus? BoxModuleDoors { get; set; }

        /// <summary>
        /// Gets or Sets TransportStatus
        /// </summary>
        [DataMember(Name = "transportStatus", EmitDefaultValue = false)]
        public BoxModuleTransportStatus? TransportStatus { get; set; }

        /// <summary>
        /// Gets or Sets ClosedPhotoSensors
        /// </summary>
        [DataMember(Name = "closedPhotoSensors", EmitDefaultValue = false)]
        public PhotoSensorsFlags? ClosedPhotoSensors { get; set; }

        /// <summary>
        /// Gets or Sets StatusFlags
        /// </summary>
        [DataMember(Name = "statusFlags", EmitDefaultValue = false)]
        public TransportStatusFlags? StatusFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxModuleState" /> class.
        /// </summary>
        /// <param name="statusChangeId">statusChangeId.</param>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="hardwareRevision">hardwareRevision.</param>
        /// <param name="firmwareRevision">firmwareRevision.</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="dipSwitchHardwareSetting">dipSwitchHardwareSetting.</param>
        /// <param name="positions">positions.</param>
        /// <param name="boxModuleDoors">boxModuleDoors.</param>
        /// <param name="transportStatus">transportStatus.</param>
        /// <param name="closedPhotoSensors">closedPhotoSensors.</param>
        /// <param name="statusFlags">statusFlags.</param>
        /// <param name="transportBoardSerialNumber">transportBoardSerialNumber.</param>
        public BoxModuleState(int statusChangeId = default(int), int moduleId = default(int), string hardwareRevision = default(string), string firmwareRevision = default(string), BoxModuleConfiguration? configuration = default(BoxModuleConfiguration?), DipSwitchSetting? dipSwitchHardwareSetting = default(DipSwitchSetting?), ModulePositionsFlags? positions = default(ModulePositionsFlags?), BoxModuleDoorStatus? boxModuleDoors = default(BoxModuleDoorStatus?), BoxModuleTransportStatus? transportStatus = default(BoxModuleTransportStatus?), PhotoSensorsFlags? closedPhotoSensors = default(PhotoSensorsFlags?), TransportStatusFlags? statusFlags = default(TransportStatusFlags?), string transportBoardSerialNumber = default(string))
        {
            this.StatusChangeId = statusChangeId;
            this.ModuleId = moduleId;
            this.HardwareRevision = hardwareRevision;
            this.FirmwareRevision = firmwareRevision;
            this._Configuration = configuration;
            this.DipSwitchHardwareSetting = dipSwitchHardwareSetting;
            this.Positions = positions;
            this.BoxModuleDoors = boxModuleDoors;
            this.TransportStatus = transportStatus;
            this.ClosedPhotoSensors = closedPhotoSensors;
            this.StatusFlags = statusFlags;
            this.TransportBoardSerialNumber = transportBoardSerialNumber;
        }

        /// <summary>
        /// Gets or Sets StatusChangeId
        /// </summary>
        [DataMember(Name = "statusChangeId", EmitDefaultValue = false)]
        public int StatusChangeId { get; set; }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = false)]
        public int ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets HardwareRevision
        /// </summary>
        [DataMember(Name = "hardwareRevision", EmitDefaultValue = true)]
        public string HardwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareRevision
        /// </summary>
        [DataMember(Name = "firmwareRevision", EmitDefaultValue = true)]
        public string FirmwareRevision { get; set; }

        /// <summary>
        /// Gets or Sets TransportBoardSerialNumber
        /// </summary>
        [DataMember(Name = "transportBoardSerialNumber", EmitDefaultValue = true)]
        public string TransportBoardSerialNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoxModuleState {\n");
            sb.Append("  StatusChangeId: ").Append(StatusChangeId).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  HardwareRevision: ").Append(HardwareRevision).Append("\n");
            sb.Append("  FirmwareRevision: ").Append(FirmwareRevision).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("  DipSwitchHardwareSetting: ").Append(DipSwitchHardwareSetting).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  BoxModuleDoors: ").Append(BoxModuleDoors).Append("\n");
            sb.Append("  TransportStatus: ").Append(TransportStatus).Append("\n");
            sb.Append("  ClosedPhotoSensors: ").Append(ClosedPhotoSensors).Append("\n");
            sb.Append("  StatusFlags: ").Append(StatusFlags).Append("\n");
            sb.Append("  TransportBoardSerialNumber: ").Append(TransportBoardSerialNumber).Append("\n");
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
            return this.Equals(input as BoxModuleState);
        }

        /// <summary>
        /// Returns true if BoxModuleState instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxModuleState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxModuleState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusChangeId == input.StatusChangeId ||
                    this.StatusChangeId.Equals(input.StatusChangeId)
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    this.ModuleId.Equals(input.ModuleId)
                ) && 
                (
                    this.HardwareRevision == input.HardwareRevision ||
                    (this.HardwareRevision != null &&
                    this.HardwareRevision.Equals(input.HardwareRevision))
                ) && 
                (
                    this.FirmwareRevision == input.FirmwareRevision ||
                    (this.FirmwareRevision != null &&
                    this.FirmwareRevision.Equals(input.FirmwareRevision))
                ) && 
                (
                    this._Configuration == input._Configuration ||
                    this._Configuration.Equals(input._Configuration)
                ) && 
                (
                    this.DipSwitchHardwareSetting == input.DipSwitchHardwareSetting ||
                    this.DipSwitchHardwareSetting.Equals(input.DipSwitchHardwareSetting)
                ) && 
                (
                    this.Positions == input.Positions ||
                    this.Positions.Equals(input.Positions)
                ) && 
                (
                    this.BoxModuleDoors == input.BoxModuleDoors ||
                    this.BoxModuleDoors.Equals(input.BoxModuleDoors)
                ) && 
                (
                    this.TransportStatus == input.TransportStatus ||
                    this.TransportStatus.Equals(input.TransportStatus)
                ) && 
                (
                    this.ClosedPhotoSensors == input.ClosedPhotoSensors ||
                    this.ClosedPhotoSensors.Equals(input.ClosedPhotoSensors)
                ) && 
                (
                    this.StatusFlags == input.StatusFlags ||
                    this.StatusFlags.Equals(input.StatusFlags)
                ) && 
                (
                    this.TransportBoardSerialNumber == input.TransportBoardSerialNumber ||
                    (this.TransportBoardSerialNumber != null &&
                    this.TransportBoardSerialNumber.Equals(input.TransportBoardSerialNumber))
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
                hashCode = (hashCode * 59) + this.StatusChangeId.GetHashCode();
                hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                if (this.HardwareRevision != null)
                {
                    hashCode = (hashCode * 59) + this.HardwareRevision.GetHashCode();
                }
                if (this.FirmwareRevision != null)
                {
                    hashCode = (hashCode * 59) + this.FirmwareRevision.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                hashCode = (hashCode * 59) + this.DipSwitchHardwareSetting.GetHashCode();
                hashCode = (hashCode * 59) + this.Positions.GetHashCode();
                hashCode = (hashCode * 59) + this.BoxModuleDoors.GetHashCode();
                hashCode = (hashCode * 59) + this.TransportStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.ClosedPhotoSensors.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusFlags.GetHashCode();
                if (this.TransportBoardSerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TransportBoardSerialNumber.GetHashCode();
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
