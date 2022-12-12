/*
 * aida-mini
 *
 * 1.0.308
 *
 * The version of the OpenAPI document: 1.0.308
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
    /// OcrSettingsDto
    /// </summary>
    [DataContract(Name = "OcrSettingsDto")]
    public partial class OcrSettingsDto : IEquatable<OcrSettingsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PageSegmentationMode
        /// </summary>
        [DataMember(Name = "pageSegmentationMode", EmitDefaultValue = false)]
        public PageSegmentationMode? PageSegmentationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrSettingsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="roi">roi.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="pageSegmentationMode">pageSegmentationMode.</param>
        /// <param name="whiteList">whiteList.</param>
        /// <param name="blackList">blackList.</param>
        /// <param name="languages">languages.</param>
        /// <param name="multiply">multiply.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="rotation">rotation.</param>
        /// <param name="matchPattern">matchPattern.</param>
        /// <param name="meanConfidenceThreshold">meanConfidenceThreshold.</param>
        /// <param name="imageAcquisitionPreset">imageAcquisitionPreset.</param>
        public OcrSettingsDto(int id = default(int), string name = default(string), RectangleDto roi = default(RectangleDto), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), PageSegmentationMode? pageSegmentationMode = default(PageSegmentationMode?), string whiteList = default(string), string blackList = default(string), string languages = default(string), int? multiply = default(int?), int? threshold = default(int?), double? rotation = default(double?), string matchPattern = default(string), double? meanConfidenceThreshold = default(double?), string imageAcquisitionPreset = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Roi = roi;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PageSegmentationMode = pageSegmentationMode;
            this.WhiteList = whiteList;
            this.BlackList = blackList;
            this.Languages = languages;
            this.Multiply = multiply;
            this.Threshold = threshold;
            this.Rotation = rotation;
            this.MatchPattern = matchPattern;
            this.MeanConfidenceThreshold = meanConfidenceThreshold;
            this.ImageAcquisitionPreset = imageAcquisitionPreset;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Roi
        /// </summary>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public RectangleDto Roi { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets WhiteList
        /// </summary>
        [DataMember(Name = "whiteList", EmitDefaultValue = true)]
        public string WhiteList { get; set; }

        /// <summary>
        /// Gets or Sets BlackList
        /// </summary>
        [DataMember(Name = "blackList", EmitDefaultValue = true)]
        public string BlackList { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = true)]
        public string Languages { get; set; }

        /// <summary>
        /// Gets or Sets Multiply
        /// </summary>
        [DataMember(Name = "multiply", EmitDefaultValue = true)]
        public int? Multiply { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = true)]
        public int? Threshold { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = true)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Gets or Sets MatchPattern
        /// </summary>
        [DataMember(Name = "matchPattern", EmitDefaultValue = true)]
        public string MatchPattern { get; set; }

        /// <summary>
        /// Gets or Sets MeanConfidenceThreshold
        /// </summary>
        [DataMember(Name = "meanConfidenceThreshold", EmitDefaultValue = true)]
        public double? MeanConfidenceThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ImageAcquisitionPreset
        /// </summary>
        [DataMember(Name = "imageAcquisitionPreset", EmitDefaultValue = true)]
        public string ImageAcquisitionPreset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  PageSegmentationMode: ").Append(PageSegmentationMode).Append("\n");
            sb.Append("  WhiteList: ").Append(WhiteList).Append("\n");
            sb.Append("  BlackList: ").Append(BlackList).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Multiply: ").Append(Multiply).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  MatchPattern: ").Append(MatchPattern).Append("\n");
            sb.Append("  MeanConfidenceThreshold: ").Append(MeanConfidenceThreshold).Append("\n");
            sb.Append("  ImageAcquisitionPreset: ").Append(ImageAcquisitionPreset).Append("\n");
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
            return this.Equals(input as OcrSettingsDto);
        }

        /// <summary>
        /// Returns true if OcrSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrSettingsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Roi == input.Roi ||
                    (this.Roi != null &&
                    this.Roi.Equals(input.Roi))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.PageSegmentationMode == input.PageSegmentationMode ||
                    this.PageSegmentationMode.Equals(input.PageSegmentationMode)
                ) && 
                (
                    this.WhiteList == input.WhiteList ||
                    (this.WhiteList != null &&
                    this.WhiteList.Equals(input.WhiteList))
                ) && 
                (
                    this.BlackList == input.BlackList ||
                    (this.BlackList != null &&
                    this.BlackList.Equals(input.BlackList))
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
                ) && 
                (
                    this.Multiply == input.Multiply ||
                    (this.Multiply != null &&
                    this.Multiply.Equals(input.Multiply))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.MatchPattern == input.MatchPattern ||
                    (this.MatchPattern != null &&
                    this.MatchPattern.Equals(input.MatchPattern))
                ) && 
                (
                    this.MeanConfidenceThreshold == input.MeanConfidenceThreshold ||
                    (this.MeanConfidenceThreshold != null &&
                    this.MeanConfidenceThreshold.Equals(input.MeanConfidenceThreshold))
                ) && 
                (
                    this.ImageAcquisitionPreset == input.ImageAcquisitionPreset ||
                    (this.ImageAcquisitionPreset != null &&
                    this.ImageAcquisitionPreset.Equals(input.ImageAcquisitionPreset))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Roi != null)
                {
                    hashCode = (hashCode * 59) + this.Roi.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageSegmentationMode.GetHashCode();
                if (this.WhiteList != null)
                {
                    hashCode = (hashCode * 59) + this.WhiteList.GetHashCode();
                }
                if (this.BlackList != null)
                {
                    hashCode = (hashCode * 59) + this.BlackList.GetHashCode();
                }
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.Multiply != null)
                {
                    hashCode = (hashCode * 59) + this.Multiply.GetHashCode();
                }
                if (this.Threshold != null)
                {
                    hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
                }
                if (this.Rotation != null)
                {
                    hashCode = (hashCode * 59) + this.Rotation.GetHashCode();
                }
                if (this.MatchPattern != null)
                {
                    hashCode = (hashCode * 59) + this.MatchPattern.GetHashCode();
                }
                if (this.MeanConfidenceThreshold != null)
                {
                    hashCode = (hashCode * 59) + this.MeanConfidenceThreshold.GetHashCode();
                }
                if (this.ImageAcquisitionPreset != null)
                {
                    hashCode = (hashCode * 59) + this.ImageAcquisitionPreset.GetHashCode();
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
