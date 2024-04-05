/*
 * aida-mini
 *
 * 1.0.543
 *
 * The version of the OpenAPI document: 1.0.543
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
    /// LaserBoardStateChangedEventNotification
    /// </summary>
    [DataContract(Name = "LaserBoardStateChangedEventNotification")]
    public partial class LaserBoardStateChangedEventNotification : IEquatable<LaserBoardStateChangedEventNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaserBoardStateChangedEventNotification" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="moduleId">moduleId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="eventData">eventData.</param>
        public LaserBoardStateChangedEventNotification(string nodeId = default(string), string moduleId = default(string), string deviceId = default(string), LaserBoardStateChangedEventArgs eventData = default(LaserBoardStateChangedEventArgs))
        {
            this.NodeId = nodeId;
            this.ModuleId = moduleId;
            this.DeviceId = deviceId;
            this.EventData = eventData;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "nodeId", EmitDefaultValue = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name = "moduleId", EmitDefaultValue = true)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets EventData
        /// </summary>
        [DataMember(Name = "eventData", EmitDefaultValue = false)]
        public LaserBoardStateChangedEventArgs EventData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LaserBoardStateChangedEventNotification {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  EventData: ").Append(EventData).Append("\n");
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
            return this.Equals(input as LaserBoardStateChangedEventNotification);
        }

        /// <summary>
        /// Returns true if LaserBoardStateChangedEventNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of LaserBoardStateChangedEventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LaserBoardStateChangedEventNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.EventData == input.EventData ||
                    (this.EventData != null &&
                    this.EventData.Equals(input.EventData))
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
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.EventData != null)
                {
                    hashCode = (hashCode * 59) + this.EventData.GetHashCode();
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
