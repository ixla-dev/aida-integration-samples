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
    /// DisplayIssuanceStatusDto
    /// </summary>
    [DataContract(Name = "DisplayIssuanceStatusDto")]
    public partial class DisplayIssuanceStatusDto : IEquatable<DisplayIssuanceStatusDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayIssuanceStatusDto" /> class.
        /// </summary>
        /// <param name="jobsPerHour">jobsPerHour.</param>
        /// <param name="jobAvgDuration">jobAvgDuration.</param>
        /// <param name="jobsRunning">jobsRunning.</param>
        /// <param name="jobsCompleted">jobsCompleted.</param>
        /// <param name="jobsFaulted">jobsFaulted.</param>
        /// <param name="jobsInQueue">jobsInQueue.</param>
        public DisplayIssuanceStatusDto(int jobsPerHour = default(int), int jobAvgDuration = default(int), int jobsRunning = default(int), int jobsCompleted = default(int), int jobsFaulted = default(int), int jobsInQueue = default(int))
        {
            this.JobsPerHour = jobsPerHour;
            this.JobAvgDuration = jobAvgDuration;
            this.JobsRunning = jobsRunning;
            this.JobsCompleted = jobsCompleted;
            this.JobsFaulted = jobsFaulted;
            this.JobsInQueue = jobsInQueue;
        }

        /// <summary>
        /// Gets or Sets JobsPerHour
        /// </summary>
        [DataMember(Name = "jobsPerHour", EmitDefaultValue = false)]
        public int JobsPerHour { get; set; }

        /// <summary>
        /// Gets or Sets JobAvgDuration
        /// </summary>
        [DataMember(Name = "jobAvgDuration", EmitDefaultValue = false)]
        public int JobAvgDuration { get; set; }

        /// <summary>
        /// Gets or Sets JobsRunning
        /// </summary>
        [DataMember(Name = "jobsRunning", EmitDefaultValue = false)]
        public int JobsRunning { get; set; }

        /// <summary>
        /// Gets or Sets JobsCompleted
        /// </summary>
        [DataMember(Name = "jobsCompleted", EmitDefaultValue = false)]
        public int JobsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets JobsFaulted
        /// </summary>
        [DataMember(Name = "jobsFaulted", EmitDefaultValue = false)]
        public int JobsFaulted { get; set; }

        /// <summary>
        /// Gets or Sets JobsInQueue
        /// </summary>
        [DataMember(Name = "jobsInQueue", EmitDefaultValue = false)]
        public int JobsInQueue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayIssuanceStatusDto {\n");
            sb.Append("  JobsPerHour: ").Append(JobsPerHour).Append("\n");
            sb.Append("  JobAvgDuration: ").Append(JobAvgDuration).Append("\n");
            sb.Append("  JobsRunning: ").Append(JobsRunning).Append("\n");
            sb.Append("  JobsCompleted: ").Append(JobsCompleted).Append("\n");
            sb.Append("  JobsFaulted: ").Append(JobsFaulted).Append("\n");
            sb.Append("  JobsInQueue: ").Append(JobsInQueue).Append("\n");
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
            return this.Equals(input as DisplayIssuanceStatusDto);
        }

        /// <summary>
        /// Returns true if DisplayIssuanceStatusDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayIssuanceStatusDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayIssuanceStatusDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobsPerHour == input.JobsPerHour ||
                    this.JobsPerHour.Equals(input.JobsPerHour)
                ) && 
                (
                    this.JobAvgDuration == input.JobAvgDuration ||
                    this.JobAvgDuration.Equals(input.JobAvgDuration)
                ) && 
                (
                    this.JobsRunning == input.JobsRunning ||
                    this.JobsRunning.Equals(input.JobsRunning)
                ) && 
                (
                    this.JobsCompleted == input.JobsCompleted ||
                    this.JobsCompleted.Equals(input.JobsCompleted)
                ) && 
                (
                    this.JobsFaulted == input.JobsFaulted ||
                    this.JobsFaulted.Equals(input.JobsFaulted)
                ) && 
                (
                    this.JobsInQueue == input.JobsInQueue ||
                    this.JobsInQueue.Equals(input.JobsInQueue)
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
                hashCode = (hashCode * 59) + this.JobsPerHour.GetHashCode();
                hashCode = (hashCode * 59) + this.JobAvgDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.JobsRunning.GetHashCode();
                hashCode = (hashCode * 59) + this.JobsCompleted.GetHashCode();
                hashCode = (hashCode * 59) + this.JobsFaulted.GetHashCode();
                hashCode = (hashCode * 59) + this.JobsInQueue.GetHashCode();
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
