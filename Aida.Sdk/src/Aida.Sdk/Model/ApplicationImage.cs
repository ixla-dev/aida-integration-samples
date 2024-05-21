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
    /// ApplicationImage
    /// </summary>
    [DataContract(Name = "ApplicationImage")]
    public partial class ApplicationImage : IEquatable<ApplicationImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationImage" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="file">file.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        /// <param name="horizontalResolution">horizontalResolution.</param>
        /// <param name="verticalResolution">verticalResolution.</param>
        /// <param name="imageFormat">imageFormat.</param>
        /// <param name="templateMatchingConfigurationId">templateMatchingConfigurationId.</param>
        public ApplicationImage(int id = default(int), ApplicationFile file = default(ApplicationFile), int fileId = default(int), int height = default(int), int width = default(int), float horizontalResolution = default(float), float verticalResolution = default(float), string imageFormat = default(string), int? templateMatchingConfigurationId = default(int?))
        {
            this.Id = id;
            this.File = file;
            this.FileId = fileId;
            this.Height = height;
            this.Width = width;
            this.HorizontalResolution = horizontalResolution;
            this.VerticalResolution = verticalResolution;
            this.ImageFormat = imageFormat;
            this.TemplateMatchingConfigurationId = templateMatchingConfigurationId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public ApplicationFile File { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets HorizontalResolution
        /// </summary>
        [DataMember(Name = "horizontalResolution", EmitDefaultValue = false)]
        public float HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or Sets VerticalResolution
        /// </summary>
        [DataMember(Name = "verticalResolution", EmitDefaultValue = false)]
        public float VerticalResolution { get; set; }

        /// <summary>
        /// Gets or Sets ImageFormat
        /// </summary>
        [DataMember(Name = "imageFormat", EmitDefaultValue = true)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMatchingConfigurationId
        /// </summary>
        [DataMember(Name = "templateMatchingConfigurationId", EmitDefaultValue = true)]
        public int? TemplateMatchingConfigurationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationImage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(HorizontalResolution).Append("\n");
            sb.Append("  VerticalResolution: ").Append(VerticalResolution).Append("\n");
            sb.Append("  ImageFormat: ").Append(ImageFormat).Append("\n");
            sb.Append("  TemplateMatchingConfigurationId: ").Append(TemplateMatchingConfigurationId).Append("\n");
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
            return this.Equals(input as ApplicationImage);
        }

        /// <summary>
        /// Returns true if ApplicationImage instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationImage input)
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
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.FileId == input.FileId ||
                    this.FileId.Equals(input.FileId)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.HorizontalResolution == input.HorizontalResolution ||
                    this.HorizontalResolution.Equals(input.HorizontalResolution)
                ) && 
                (
                    this.VerticalResolution == input.VerticalResolution ||
                    this.VerticalResolution.Equals(input.VerticalResolution)
                ) && 
                (
                    this.ImageFormat == input.ImageFormat ||
                    (this.ImageFormat != null &&
                    this.ImageFormat.Equals(input.ImageFormat))
                ) && 
                (
                    this.TemplateMatchingConfigurationId == input.TemplateMatchingConfigurationId ||
                    (this.TemplateMatchingConfigurationId != null &&
                    this.TemplateMatchingConfigurationId.Equals(input.TemplateMatchingConfigurationId))
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
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.HorizontalResolution.GetHashCode();
                hashCode = (hashCode * 59) + this.VerticalResolution.GetHashCode();
                if (this.ImageFormat != null)
                {
                    hashCode = (hashCode * 59) + this.ImageFormat.GetHashCode();
                }
                if (this.TemplateMatchingConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateMatchingConfigurationId.GetHashCode();
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
