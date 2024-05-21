/*
 * aida
 *
 * 1.0.696
 *
 * The version of the OpenAPI document: 1.0.696
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
    /// PersonalizationSessionDto
    /// </summary>
    [DataContract(Name = "PersonalizationSessionDto")]
    public partial class PersonalizationSessionDto : IEquatable<PersonalizationSessionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizationSessionDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="jobTemplateName">jobTemplateName.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="jobsCompleted">jobsCompleted.</param>
        /// <param name="jobsFaulted">jobsFaulted.</param>
        /// <param name="cardsProcessed">cardsProcessed.</param>
        /// <param name="cardsPerHour">cardsPerHour.</param>
        /// <param name="averagePersonalizationTime">averagePersonalizationTime.</param>
        /// <param name="averageEngravingTime">averageEngravingTime.</param>
        public PersonalizationSessionDto(string id = default(string), int jobTemplateId = default(int), string jobTemplateName = default(string), DateTime startTime = default(DateTime), DateTime? endTime = default(DateTime?), int jobsCompleted = default(int), int jobsFaulted = default(int), int cardsProcessed = default(int), float cardsPerHour = default(float), float averagePersonalizationTime = default(float), float averageEngravingTime = default(float))
        {
            this.Id = id;
            this.JobTemplateId = jobTemplateId;
            this.JobTemplateName = jobTemplateName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.JobsCompleted = jobsCompleted;
            this.JobsFaulted = jobsFaulted;
            this.CardsProcessed = cardsProcessed;
            this.CardsPerHour = cardsPerHour;
            this.AveragePersonalizationTime = averagePersonalizationTime;
            this.AverageEngravingTime = averageEngravingTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateName
        /// </summary>
        [DataMember(Name = "jobTemplateName", EmitDefaultValue = true)]
        public string JobTemplateName { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

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
        /// Gets or Sets CardsProcessed
        /// </summary>
        [DataMember(Name = "cardsProcessed", EmitDefaultValue = false)]
        public int CardsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets CardsPerHour
        /// </summary>
        [DataMember(Name = "cardsPerHour", EmitDefaultValue = false)]
        public float CardsPerHour { get; set; }

        /// <summary>
        /// Gets or Sets AveragePersonalizationTime
        /// </summary>
        [DataMember(Name = "averagePersonalizationTime", EmitDefaultValue = false)]
        public float AveragePersonalizationTime { get; set; }

        /// <summary>
        /// Gets or Sets AverageEngravingTime
        /// </summary>
        [DataMember(Name = "averageEngravingTime", EmitDefaultValue = false)]
        public float AverageEngravingTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonalizationSessionDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  JobTemplateName: ").Append(JobTemplateName).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  JobsCompleted: ").Append(JobsCompleted).Append("\n");
            sb.Append("  JobsFaulted: ").Append(JobsFaulted).Append("\n");
            sb.Append("  CardsProcessed: ").Append(CardsProcessed).Append("\n");
            sb.Append("  CardsPerHour: ").Append(CardsPerHour).Append("\n");
            sb.Append("  AveragePersonalizationTime: ").Append(AveragePersonalizationTime).Append("\n");
            sb.Append("  AverageEngravingTime: ").Append(AverageEngravingTime).Append("\n");
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
            return this.Equals(input as PersonalizationSessionDto);
        }

        /// <summary>
        /// Returns true if PersonalizationSessionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalizationSessionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalizationSessionDto input)
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
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
                ) && 
                (
                    this.JobTemplateName == input.JobTemplateName ||
                    (this.JobTemplateName != null &&
                    this.JobTemplateName.Equals(input.JobTemplateName))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                    this.CardsProcessed == input.CardsProcessed ||
                    this.CardsProcessed.Equals(input.CardsProcessed)
                ) && 
                (
                    this.CardsPerHour == input.CardsPerHour ||
                    this.CardsPerHour.Equals(input.CardsPerHour)
                ) && 
                (
                    this.AveragePersonalizationTime == input.AveragePersonalizationTime ||
                    this.AveragePersonalizationTime.Equals(input.AveragePersonalizationTime)
                ) && 
                (
                    this.AverageEngravingTime == input.AverageEngravingTime ||
                    this.AverageEngravingTime.Equals(input.AverageEngravingTime)
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
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
                if (this.JobTemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.JobTemplateName.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobsCompleted.GetHashCode();
                hashCode = (hashCode * 59) + this.JobsFaulted.GetHashCode();
                hashCode = (hashCode * 59) + this.CardsProcessed.GetHashCode();
                hashCode = (hashCode * 59) + this.CardsPerHour.GetHashCode();
                hashCode = (hashCode * 59) + this.AveragePersonalizationTime.GetHashCode();
                hashCode = (hashCode * 59) + this.AverageEngravingTime.GetHashCode();
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
