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
    /// UpdateMirroringSettingsRequest
    /// </summary>
    [DataContract(Name = "UpdateMirroringSettingsRequest")]
    public partial class UpdateMirroringSettingsRequest : IEquatable<UpdateMirroringSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMirroringSettingsRequest" /> class.
        /// </summary>
        /// <param name="jobTemplateLayoutId">jobTemplateLayoutId.</param>
        /// <param name="mirrorX">mirrorX.</param>
        /// <param name="mirrorY">mirrorY.</param>
        public UpdateMirroringSettingsRequest(int jobTemplateLayoutId = default(int), bool? mirrorX = default(bool?), bool? mirrorY = default(bool?))
        {
            this.JobTemplateLayoutId = jobTemplateLayoutId;
            this.MirrorX = mirrorX;
            this.MirrorY = mirrorY;
        }

        /// <summary>
        /// Gets or Sets JobTemplateLayoutId
        /// </summary>
        [DataMember(Name = "jobTemplateLayoutId", EmitDefaultValue = false)]
        public int JobTemplateLayoutId { get; set; }

        /// <summary>
        /// Gets or Sets MirrorX
        /// </summary>
        [DataMember(Name = "mirrorX", EmitDefaultValue = true)]
        public bool? MirrorX { get; set; }

        /// <summary>
        /// Gets or Sets MirrorY
        /// </summary>
        [DataMember(Name = "mirrorY", EmitDefaultValue = true)]
        public bool? MirrorY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateMirroringSettingsRequest {\n");
            sb.Append("  JobTemplateLayoutId: ").Append(JobTemplateLayoutId).Append("\n");
            sb.Append("  MirrorX: ").Append(MirrorX).Append("\n");
            sb.Append("  MirrorY: ").Append(MirrorY).Append("\n");
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
            return this.Equals(input as UpdateMirroringSettingsRequest);
        }

        /// <summary>
        /// Returns true if UpdateMirroringSettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMirroringSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMirroringSettingsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobTemplateLayoutId == input.JobTemplateLayoutId ||
                    this.JobTemplateLayoutId.Equals(input.JobTemplateLayoutId)
                ) && 
                (
                    this.MirrorX == input.MirrorX ||
                    (this.MirrorX != null &&
                    this.MirrorX.Equals(input.MirrorX))
                ) && 
                (
                    this.MirrorY == input.MirrorY ||
                    (this.MirrorY != null &&
                    this.MirrorY.Equals(input.MirrorY))
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
                hashCode = (hashCode * 59) + this.JobTemplateLayoutId.GetHashCode();
                if (this.MirrorX != null)
                {
                    hashCode = (hashCode * 59) + this.MirrorX.GetHashCode();
                }
                if (this.MirrorY != null)
                {
                    hashCode = (hashCode * 59) + this.MirrorY.GetHashCode();
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