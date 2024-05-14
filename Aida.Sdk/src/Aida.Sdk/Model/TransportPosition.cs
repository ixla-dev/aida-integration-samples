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
    /// TransportPosition
    /// </summary>
    [DataContract(Name = "TransportPosition")]
    public partial class TransportPosition : IEquatable<TransportPosition>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransportPositionType
        /// </summary>
        [DataMember(Name = "transportPositionType", EmitDefaultValue = false)]
        public TransportPositionType? TransportPositionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportPosition" /> class.
        /// </summary>
        /// <param name="positionName">positionName.</param>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="isAlias">isAlias.</param>
        /// <param name="realPosition">realPosition.</param>
        /// <param name="isMachineInput">isMachineInput.</param>
        /// <param name="isMachineExit">isMachineExit.</param>
        /// <param name="isFeeder">isFeeder.</param>
        /// <param name="isMultiChipExit">isMultiChipExit.</param>
        /// <param name="currentSupport">currentSupport.</param>
        /// <param name="aliases">aliases.</param>
        /// <param name="transportPositionType">transportPositionType.</param>
        /// <param name="connections">connections.</param>
        public TransportPosition(string positionName = default(string), int moduleId = default(int), bool isAlias = default(bool), string realPosition = default(string), bool isMachineInput = default(bool), bool isMachineExit = default(bool), bool isFeeder = default(bool), bool isMultiChipExit = default(bool), Support currentSupport = default(Support), List<TransportPosition> aliases = default(List<TransportPosition>), TransportPositionType? transportPositionType = default(TransportPositionType?), List<TransportPosition> connections = default(List<TransportPosition>))
        {
            this.PositionName = positionName;
            this.ModuleId = moduleId;
            this.IsAlias = isAlias;
            this.RealPosition = realPosition;
            this.IsMachineInput = isMachineInput;
            this.IsMachineExit = isMachineExit;
            this.IsFeeder = isFeeder;
            this.IsMultiChipExit = isMultiChipExit;
            this.CurrentSupport = currentSupport;
            this.Aliases = aliases;
            this.TransportPositionType = transportPositionType;
            this.Connections = connections;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PositionName
        /// </summary>
        [DataMember(Name = "positionName", EmitDefaultValue = true)]
        public string PositionName { get; set; }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = false)]
        public int ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets IsAlias
        /// </summary>
        [DataMember(Name = "isAlias", EmitDefaultValue = true)]
        public bool IsAlias { get; set; }

        /// <summary>
        /// Gets or Sets RealPosition
        /// </summary>
        [DataMember(Name = "realPosition", EmitDefaultValue = true)]
        public string RealPosition { get; set; }

        /// <summary>
        /// Gets or Sets IsMachineInput
        /// </summary>
        [DataMember(Name = "isMachineInput", EmitDefaultValue = true)]
        public bool IsMachineInput { get; set; }

        /// <summary>
        /// Gets or Sets IsMachineExit
        /// </summary>
        [DataMember(Name = "isMachineExit", EmitDefaultValue = true)]
        public bool IsMachineExit { get; set; }

        /// <summary>
        /// Gets or Sets IsFeeder
        /// </summary>
        [DataMember(Name = "isFeeder", EmitDefaultValue = true)]
        public bool IsFeeder { get; set; }

        /// <summary>
        /// Gets or Sets IsMultiChipExit
        /// </summary>
        [DataMember(Name = "isMultiChipExit", EmitDefaultValue = true)]
        public bool IsMultiChipExit { get; set; }

        /// <summary>
        /// Gets or Sets IsTransient
        /// </summary>
        [DataMember(Name = "isTransient", EmitDefaultValue = true)]
        public bool IsTransient { get; private set; }

        /// <summary>
        /// Returns false as IsTransient should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsTransient()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsReject
        /// </summary>
        [DataMember(Name = "isReject", EmitDefaultValue = true)]
        public bool IsReject { get; private set; }

        /// <summary>
        /// Returns false as IsReject should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsReject()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Occupied
        /// </summary>
        [DataMember(Name = "occupied", EmitDefaultValue = true)]
        public bool Occupied { get; private set; }

        /// <summary>
        /// Returns false as Occupied should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOccupied()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentSupport
        /// </summary>
        [DataMember(Name = "currentSupport", EmitDefaultValue = false)]
        public Support CurrentSupport { get; set; }

        /// <summary>
        /// Gets or Sets Aliases
        /// </summary>
        [DataMember(Name = "aliases", EmitDefaultValue = true)]
        public List<TransportPosition> Aliases { get; set; }

        /// <summary>
        /// Gets or Sets IsFlip
        /// </summary>
        [DataMember(Name = "isFlip", EmitDefaultValue = true)]
        public bool IsFlip { get; private set; }

        /// <summary>
        /// Returns false as IsFlip should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsFlip()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name = "connections", EmitDefaultValue = true)]
        public List<TransportPosition> Connections { get; set; }

        /// <summary>
        /// Gets or Sets IsIntersection
        /// </summary>
        [DataMember(Name = "isIntersection", EmitDefaultValue = true)]
        public bool IsIntersection { get; private set; }

        /// <summary>
        /// Returns false as IsIntersection should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsIntersection()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportPosition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PositionName: ").Append(PositionName).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  IsAlias: ").Append(IsAlias).Append("\n");
            sb.Append("  RealPosition: ").Append(RealPosition).Append("\n");
            sb.Append("  IsMachineInput: ").Append(IsMachineInput).Append("\n");
            sb.Append("  IsMachineExit: ").Append(IsMachineExit).Append("\n");
            sb.Append("  IsFeeder: ").Append(IsFeeder).Append("\n");
            sb.Append("  IsMultiChipExit: ").Append(IsMultiChipExit).Append("\n");
            sb.Append("  IsTransient: ").Append(IsTransient).Append("\n");
            sb.Append("  IsReject: ").Append(IsReject).Append("\n");
            sb.Append("  Occupied: ").Append(Occupied).Append("\n");
            sb.Append("  CurrentSupport: ").Append(CurrentSupport).Append("\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  TransportPositionType: ").Append(TransportPositionType).Append("\n");
            sb.Append("  IsFlip: ").Append(IsFlip).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  IsIntersection: ").Append(IsIntersection).Append("\n");
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
            return this.Equals(input as TransportPosition);
        }

        /// <summary>
        /// Returns true if TransportPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportPosition input)
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
                    this.PositionName == input.PositionName ||
                    (this.PositionName != null &&
                    this.PositionName.Equals(input.PositionName))
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    this.ModuleId.Equals(input.ModuleId)
                ) && 
                (
                    this.IsAlias == input.IsAlias ||
                    this.IsAlias.Equals(input.IsAlias)
                ) && 
                (
                    this.RealPosition == input.RealPosition ||
                    (this.RealPosition != null &&
                    this.RealPosition.Equals(input.RealPosition))
                ) && 
                (
                    this.IsMachineInput == input.IsMachineInput ||
                    this.IsMachineInput.Equals(input.IsMachineInput)
                ) && 
                (
                    this.IsMachineExit == input.IsMachineExit ||
                    this.IsMachineExit.Equals(input.IsMachineExit)
                ) && 
                (
                    this.IsFeeder == input.IsFeeder ||
                    this.IsFeeder.Equals(input.IsFeeder)
                ) && 
                (
                    this.IsMultiChipExit == input.IsMultiChipExit ||
                    this.IsMultiChipExit.Equals(input.IsMultiChipExit)
                ) && 
                (
                    this.IsTransient == input.IsTransient ||
                    this.IsTransient.Equals(input.IsTransient)
                ) && 
                (
                    this.IsReject == input.IsReject ||
                    this.IsReject.Equals(input.IsReject)
                ) && 
                (
                    this.Occupied == input.Occupied ||
                    this.Occupied.Equals(input.Occupied)
                ) && 
                (
                    this.CurrentSupport == input.CurrentSupport ||
                    (this.CurrentSupport != null &&
                    this.CurrentSupport.Equals(input.CurrentSupport))
                ) && 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    input.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.TransportPositionType == input.TransportPositionType ||
                    this.TransportPositionType.Equals(input.TransportPositionType)
                ) && 
                (
                    this.IsFlip == input.IsFlip ||
                    this.IsFlip.Equals(input.IsFlip)
                ) && 
                (
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.IsIntersection == input.IsIntersection ||
                    this.IsIntersection.Equals(input.IsIntersection)
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
                if (this.PositionName != null)
                {
                    hashCode = (hashCode * 59) + this.PositionName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAlias.GetHashCode();
                if (this.RealPosition != null)
                {
                    hashCode = (hashCode * 59) + this.RealPosition.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMachineInput.GetHashCode();
                hashCode = (hashCode * 59) + this.IsMachineExit.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFeeder.GetHashCode();
                hashCode = (hashCode * 59) + this.IsMultiChipExit.GetHashCode();
                hashCode = (hashCode * 59) + this.IsTransient.GetHashCode();
                hashCode = (hashCode * 59) + this.IsReject.GetHashCode();
                hashCode = (hashCode * 59) + this.Occupied.GetHashCode();
                if (this.CurrentSupport != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentSupport.GetHashCode();
                }
                if (this.Aliases != null)
                {
                    hashCode = (hashCode * 59) + this.Aliases.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransportPositionType.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFlip.GetHashCode();
                if (this.Connections != null)
                {
                    hashCode = (hashCode * 59) + this.Connections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsIntersection.GetHashCode();
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
