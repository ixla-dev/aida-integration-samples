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
    /// FileDto
    /// </summary>
    [DataContract(Name = "FileDto")]
    public partial class FileDto : IEquatable<FileDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDto" /> class.
        /// </summary>
        /// <param name="filename">filename.</param>
        /// <param name="originalFilename">originalFilename.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="size">size.</param>
        /// <param name="location">location.</param>
        /// <param name="checksum">checksum.</param>
        /// <param name="extension">extension.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public FileDto(string filename = default(string), string originalFilename = default(string), string displayName = default(string), long size = default(long), string location = default(string), string checksum = default(string), string extension = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.Filename = filename;
            this.OriginalFilename = originalFilename;
            this.DisplayName = displayName;
            this.Size = size;
            this.Location = location;
            this.Checksum = checksum;
            this.Extension = extension;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = true)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [DataMember(Name = "originalFilename", EmitDefaultValue = true)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name = "checksum", EmitDefaultValue = true)]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileDto {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as FileDto);
        }

        /// <summary>
        /// Returns true if FileDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.OriginalFilename == input.OriginalFilename ||
                    (this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(input.OriginalFilename))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
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
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                if (this.OriginalFilename != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalFilename.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Checksum != null)
                {
                    hashCode = (hashCode * 59) + this.Checksum.GetHashCode();
                }
                if (this.Extension != null)
                {
                    hashCode = (hashCode * 59) + this.Extension.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
