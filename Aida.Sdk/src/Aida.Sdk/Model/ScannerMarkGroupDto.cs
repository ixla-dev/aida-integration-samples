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
    /// ScannerMarkGroupDto
    /// </summary>
    [DataContract(Name = "ScannerMarkGroupDto")]
    public partial class ScannerMarkGroupDto : IEquatable<ScannerMarkGroupDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerMarkGroupDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="description">description.</param>
        /// <param name="scannerId">The scanner module that will mark entities.</param>
        /// <param name="positionId">The target position the support should be in  when marking entities.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="index">index.</param>
        /// <param name="jobTemplateId">jobTemplateId.</param>
        /// <param name="entities">entities.</param>
        /// <param name="expectedMarkDuration">expectedMarkDuration.</param>
        public ScannerMarkGroupDto(int? id = default(int?), string name = default(string), string displayName = default(string), string description = default(string), string scannerId = default(string), string positionId = default(string), string supportSide = default(string), string deviceId = default(string), int index = default(int), int jobTemplateId = default(int), List<MarkGroupScannerEntityDto> entities = default(List<MarkGroupScannerEntityDto>), string expectedMarkDuration = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.ScannerId = scannerId;
            this.PositionId = positionId;
            this.SupportSide = supportSide;
            this.DeviceId = deviceId;
            this.Index = index;
            this.JobTemplateId = jobTemplateId;
            this.Entities = entities;
            this.ExpectedMarkDuration = expectedMarkDuration;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The scanner module that will mark entities
        /// </summary>
        /// <value>The scanner module that will mark entities</value>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// The target position the support should be in  when marking entities
        /// </summary>
        /// <value>The target position the support should be in  when marking entities</value>
        [DataMember(Name = "positionId", EmitDefaultValue = true)]
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets JobTemplateId
        /// </summary>
        [DataMember(Name = "jobTemplateId", EmitDefaultValue = false)]
        public int JobTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = true)]
        public List<MarkGroupScannerEntityDto> Entities { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedMarkDuration
        /// </summary>
        [DataMember(Name = "expectedMarkDuration", EmitDefaultValue = false)]
        public string ExpectedMarkDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerMarkGroupDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  JobTemplateId: ").Append(JobTemplateId).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  ExpectedMarkDuration: ").Append(ExpectedMarkDuration).Append("\n");
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
            return this.Equals(input as ScannerMarkGroupDto);
        }

        /// <summary>
        /// Returns true if ScannerMarkGroupDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerMarkGroupDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerMarkGroupDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ScannerId == input.ScannerId ||
                    (this.ScannerId != null &&
                    this.ScannerId.Equals(input.ScannerId))
                ) && 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.SupportSide == input.SupportSide ||
                    (this.SupportSide != null &&
                    this.SupportSide.Equals(input.SupportSide))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.JobTemplateId == input.JobTemplateId ||
                    this.JobTemplateId.Equals(input.JobTemplateId)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.ExpectedMarkDuration == input.ExpectedMarkDuration ||
                    (this.ExpectedMarkDuration != null &&
                    this.ExpectedMarkDuration.Equals(input.ExpectedMarkDuration))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ScannerId != null)
                {
                    hashCode = (hashCode * 59) + this.ScannerId.GetHashCode();
                }
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.SupportSide != null)
                {
                    hashCode = (hashCode * 59) + this.SupportSide.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.JobTemplateId.GetHashCode();
                if (this.Entities != null)
                {
                    hashCode = (hashCode * 59) + this.Entities.GetHashCode();
                }
                if (this.ExpectedMarkDuration != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedMarkDuration.GetHashCode();
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
