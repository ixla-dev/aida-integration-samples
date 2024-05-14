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
    /// DisplaySystemStatusDto
    /// </summary>
    [DataContract(Name = "DisplaySystemStatusDto")]
    public partial class DisplaySystemStatusDto : IEquatable<DisplaySystemStatusDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplaySystemStatusDto" /> class.
        /// </summary>
        /// <param name="serverStatus">serverStatus.</param>
        /// <param name="upTime">upTime.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="softwareVersion">softwareVersion.</param>
        public DisplaySystemStatusDto(string serverStatus = default(string), string upTime = default(string), string ipAddress = default(string), string softwareVersion = default(string))
        {
            this.ServerStatus = serverStatus;
            this.UpTime = upTime;
            this.IpAddress = ipAddress;
            this.SoftwareVersion = softwareVersion;
        }

        /// <summary>
        /// Gets or Sets ServerStatus
        /// </summary>
        [DataMember(Name = "serverStatus", EmitDefaultValue = true)]
        public string ServerStatus { get; set; }

        /// <summary>
        /// Gets or Sets UpTime
        /// </summary>
        [DataMember(Name = "upTime", EmitDefaultValue = false)]
        public string UpTime { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets SoftwareVersion
        /// </summary>
        [DataMember(Name = "softwareVersion", EmitDefaultValue = true)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplaySystemStatusDto {\n");
            sb.Append("  ServerStatus: ").Append(ServerStatus).Append("\n");
            sb.Append("  UpTime: ").Append(UpTime).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
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
            return this.Equals(input as DisplaySystemStatusDto);
        }

        /// <summary>
        /// Returns true if DisplaySystemStatusDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplaySystemStatusDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplaySystemStatusDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServerStatus == input.ServerStatus ||
                    (this.ServerStatus != null &&
                    this.ServerStatus.Equals(input.ServerStatus))
                ) && 
                (
                    this.UpTime == input.UpTime ||
                    (this.UpTime != null &&
                    this.UpTime.Equals(input.UpTime))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
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
                if (this.ServerStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ServerStatus.GetHashCode();
                }
                if (this.UpTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpTime.GetHashCode();
                }
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.SoftwareVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SoftwareVersion.GetHashCode();
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
