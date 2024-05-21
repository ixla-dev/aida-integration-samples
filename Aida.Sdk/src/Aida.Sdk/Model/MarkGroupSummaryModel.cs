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
    /// MarkGroupSummaryModel
    /// </summary>
    [DataContract(Name = "MarkGroupSummaryModel")]
    public partial class MarkGroupSummaryModel : IEquatable<MarkGroupSummaryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkGroupSummaryModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="layoutName">layoutName.</param>
        /// <param name="positionId">positionId.</param>
        /// <param name="scannerId">scannerId.</param>
        /// <param name="supportSide">supportSide.</param>
        /// <param name="offsetX">offsetX.</param>
        /// <param name="offsetY">offsetY.</param>
        /// <param name="mirrorX">mirrorX.</param>
        /// <param name="mirrorY">mirrorY.</param>
        /// <param name="entities">entities.</param>
        /// <param name="autoPosSettings">autoPosSettings.</param>
        public MarkGroupSummaryModel(string name = default(string), string layoutName = default(string), string positionId = default(string), string scannerId = default(string), string supportSide = default(string), double offsetX = default(double), double offsetY = default(double), bool mirrorX = default(bool), bool mirrorY = default(bool), List<string> entities = default(List<string>), List<AutoPosConfigSummaryModel> autoPosSettings = default(List<AutoPosConfigSummaryModel>))
        {
            this.Name = name;
            this.LayoutName = layoutName;
            this.PositionId = positionId;
            this.ScannerId = scannerId;
            this.SupportSide = supportSide;
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.MirrorX = mirrorX;
            this.MirrorY = mirrorY;
            this.Entities = entities;
            this.AutoPosSettings = autoPosSettings;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LayoutName
        /// </summary>
        [DataMember(Name = "layoutName", EmitDefaultValue = true)]
        public string LayoutName { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = true)]
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or Sets ScannerId
        /// </summary>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets OffsetX
        /// </summary>
        [DataMember(Name = "offsetX", EmitDefaultValue = false)]
        public double OffsetX { get; set; }

        /// <summary>
        /// Gets or Sets OffsetY
        /// </summary>
        [DataMember(Name = "offsetY", EmitDefaultValue = false)]
        public double OffsetY { get; set; }

        /// <summary>
        /// Gets or Sets MirrorX
        /// </summary>
        [DataMember(Name = "mirrorX", EmitDefaultValue = true)]
        public bool MirrorX { get; set; }

        /// <summary>
        /// Gets or Sets MirrorY
        /// </summary>
        [DataMember(Name = "mirrorY", EmitDefaultValue = true)]
        public bool MirrorY { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = true)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Gets or Sets AutoPosSettings
        /// </summary>
        [DataMember(Name = "autoPosSettings", EmitDefaultValue = true)]
        public List<AutoPosConfigSummaryModel> AutoPosSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarkGroupSummaryModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LayoutName: ").Append(LayoutName).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  OffsetX: ").Append(OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(OffsetY).Append("\n");
            sb.Append("  MirrorX: ").Append(MirrorX).Append("\n");
            sb.Append("  MirrorY: ").Append(MirrorY).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  AutoPosSettings: ").Append(AutoPosSettings).Append("\n");
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
            return this.Equals(input as MarkGroupSummaryModel);
        }

        /// <summary>
        /// Returns true if MarkGroupSummaryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MarkGroupSummaryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarkGroupSummaryModel input)
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
                    this.LayoutName == input.LayoutName ||
                    (this.LayoutName != null &&
                    this.LayoutName.Equals(input.LayoutName))
                ) && 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.ScannerId == input.ScannerId ||
                    (this.ScannerId != null &&
                    this.ScannerId.Equals(input.ScannerId))
                ) && 
                (
                    this.SupportSide == input.SupportSide ||
                    (this.SupportSide != null &&
                    this.SupportSide.Equals(input.SupportSide))
                ) && 
                (
                    this.OffsetX == input.OffsetX ||
                    this.OffsetX.Equals(input.OffsetX)
                ) && 
                (
                    this.OffsetY == input.OffsetY ||
                    this.OffsetY.Equals(input.OffsetY)
                ) && 
                (
                    this.MirrorX == input.MirrorX ||
                    this.MirrorX.Equals(input.MirrorX)
                ) && 
                (
                    this.MirrorY == input.MirrorY ||
                    this.MirrorY.Equals(input.MirrorY)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.AutoPosSettings == input.AutoPosSettings ||
                    this.AutoPosSettings != null &&
                    input.AutoPosSettings != null &&
                    this.AutoPosSettings.SequenceEqual(input.AutoPosSettings)
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
                if (this.LayoutName != null)
                {
                    hashCode = (hashCode * 59) + this.LayoutName.GetHashCode();
                }
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.ScannerId != null)
                {
                    hashCode = (hashCode * 59) + this.ScannerId.GetHashCode();
                }
                if (this.SupportSide != null)
                {
                    hashCode = (hashCode * 59) + this.SupportSide.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OffsetX.GetHashCode();
                hashCode = (hashCode * 59) + this.OffsetY.GetHashCode();
                hashCode = (hashCode * 59) + this.MirrorX.GetHashCode();
                hashCode = (hashCode * 59) + this.MirrorY.GetHashCode();
                if (this.Entities != null)
                {
                    hashCode = (hashCode * 59) + this.Entities.GetHashCode();
                }
                if (this.AutoPosSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AutoPosSettings.GetHashCode();
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
