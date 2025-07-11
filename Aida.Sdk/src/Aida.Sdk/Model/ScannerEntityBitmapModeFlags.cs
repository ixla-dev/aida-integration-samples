/*
 * aida
 *
 * 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
 *
 * The version of the OpenAPI document: 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
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
    /// ScannerEntityBitmapModeFlags
    /// </summary>
    [DataContract(Name = "ScannerEntityBitmapModeFlags")]
    public partial class ScannerEntityBitmapModeFlags : IEquatable<ScannerEntityBitmapModeFlags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerEntityBitmapModeFlags" /> class.
        /// </summary>
        /// <param name="invert">invert.</param>
        /// <param name="grayscale">grayscale.</param>
        /// <param name="drillMode">drillMode.</param>
        /// <param name="drillGrayscale">drillGrayscale.</param>
        /// <param name="bidirectional">bidirectional.</param>
        /// <param name="startLastLine">startLastLine.</param>
        /// <param name="noLineIncrement">noLineIncrement.</param>
        /// <param name="showBitmap">showBitmap.</param>
        /// <param name="showScanner">showScanner.</param>
        /// <param name="scanXDir">scanXDir.</param>
        /// <param name="penFrequency">penFrequency.</param>
        /// <param name="jumpOverBlankPixel">jumpOverBlankPixel.</param>
        public ScannerEntityBitmapModeFlags(bool? invert = default(bool?), bool? grayscale = default(bool?), bool? drillMode = default(bool?), bool? drillGrayscale = default(bool?), bool? bidirectional = default(bool?), bool? startLastLine = default(bool?), bool? noLineIncrement = default(bool?), bool? showBitmap = default(bool?), bool? showScanner = default(bool?), bool? scanXDir = default(bool?), bool? penFrequency = default(bool?), bool? jumpOverBlankPixel = default(bool?))
        {
            this.Invert = invert;
            this.Grayscale = grayscale;
            this.DrillMode = drillMode;
            this.DrillGrayscale = drillGrayscale;
            this.Bidirectional = bidirectional;
            this.StartLastLine = startLastLine;
            this.NoLineIncrement = noLineIncrement;
            this.ShowBitmap = showBitmap;
            this.ShowScanner = showScanner;
            this.ScanXDir = scanXDir;
            this.PenFrequency = penFrequency;
            this.JumpOverBlankPixel = jumpOverBlankPixel;
        }

        /// <summary>
        /// Gets or Sets Invert
        /// </summary>
        [DataMember(Name = "invert", EmitDefaultValue = true)]
        public bool? Invert { get; set; }

        /// <summary>
        /// Gets or Sets Grayscale
        /// </summary>
        [DataMember(Name = "grayscale", EmitDefaultValue = true)]
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Gets or Sets DrillMode
        /// </summary>
        [DataMember(Name = "drillMode", EmitDefaultValue = true)]
        public bool? DrillMode { get; set; }

        /// <summary>
        /// Gets or Sets DrillGrayscale
        /// </summary>
        [DataMember(Name = "drillGrayscale", EmitDefaultValue = true)]
        public bool? DrillGrayscale { get; set; }

        /// <summary>
        /// Gets or Sets Bidirectional
        /// </summary>
        [DataMember(Name = "bidirectional", EmitDefaultValue = true)]
        public bool? Bidirectional { get; set; }

        /// <summary>
        /// Gets or Sets StartLastLine
        /// </summary>
        [DataMember(Name = "startLastLine", EmitDefaultValue = true)]
        public bool? StartLastLine { get; set; }

        /// <summary>
        /// Gets or Sets NoLineIncrement
        /// </summary>
        [DataMember(Name = "noLineIncrement", EmitDefaultValue = true)]
        public bool? NoLineIncrement { get; set; }

        /// <summary>
        /// Gets or Sets ShowBitmap
        /// </summary>
        [DataMember(Name = "showBitmap", EmitDefaultValue = true)]
        public bool? ShowBitmap { get; set; }

        /// <summary>
        /// Gets or Sets ShowScanner
        /// </summary>
        [DataMember(Name = "showScanner", EmitDefaultValue = true)]
        public bool? ShowScanner { get; set; }

        /// <summary>
        /// Gets or Sets ScanXDir
        /// </summary>
        [DataMember(Name = "scanXDir", EmitDefaultValue = true)]
        public bool? ScanXDir { get; set; }

        /// <summary>
        /// Gets or Sets PenFrequency
        /// </summary>
        [DataMember(Name = "penFrequency", EmitDefaultValue = true)]
        public bool? PenFrequency { get; set; }

        /// <summary>
        /// Gets or Sets JumpOverBlankPixel
        /// </summary>
        [DataMember(Name = "jumpOverBlankPixel", EmitDefaultValue = true)]
        public bool? JumpOverBlankPixel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerEntityBitmapModeFlags {\n");
            sb.Append("  Invert: ").Append(Invert).Append("\n");
            sb.Append("  Grayscale: ").Append(Grayscale).Append("\n");
            sb.Append("  DrillMode: ").Append(DrillMode).Append("\n");
            sb.Append("  DrillGrayscale: ").Append(DrillGrayscale).Append("\n");
            sb.Append("  Bidirectional: ").Append(Bidirectional).Append("\n");
            sb.Append("  StartLastLine: ").Append(StartLastLine).Append("\n");
            sb.Append("  NoLineIncrement: ").Append(NoLineIncrement).Append("\n");
            sb.Append("  ShowBitmap: ").Append(ShowBitmap).Append("\n");
            sb.Append("  ShowScanner: ").Append(ShowScanner).Append("\n");
            sb.Append("  ScanXDir: ").Append(ScanXDir).Append("\n");
            sb.Append("  PenFrequency: ").Append(PenFrequency).Append("\n");
            sb.Append("  JumpOverBlankPixel: ").Append(JumpOverBlankPixel).Append("\n");
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
            return this.Equals(input as ScannerEntityBitmapModeFlags);
        }

        /// <summary>
        /// Returns true if ScannerEntityBitmapModeFlags instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerEntityBitmapModeFlags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerEntityBitmapModeFlags input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Invert == input.Invert ||
                    (this.Invert != null &&
                    this.Invert.Equals(input.Invert))
                ) && 
                (
                    this.Grayscale == input.Grayscale ||
                    (this.Grayscale != null &&
                    this.Grayscale.Equals(input.Grayscale))
                ) && 
                (
                    this.DrillMode == input.DrillMode ||
                    (this.DrillMode != null &&
                    this.DrillMode.Equals(input.DrillMode))
                ) && 
                (
                    this.DrillGrayscale == input.DrillGrayscale ||
                    (this.DrillGrayscale != null &&
                    this.DrillGrayscale.Equals(input.DrillGrayscale))
                ) && 
                (
                    this.Bidirectional == input.Bidirectional ||
                    (this.Bidirectional != null &&
                    this.Bidirectional.Equals(input.Bidirectional))
                ) && 
                (
                    this.StartLastLine == input.StartLastLine ||
                    (this.StartLastLine != null &&
                    this.StartLastLine.Equals(input.StartLastLine))
                ) && 
                (
                    this.NoLineIncrement == input.NoLineIncrement ||
                    (this.NoLineIncrement != null &&
                    this.NoLineIncrement.Equals(input.NoLineIncrement))
                ) && 
                (
                    this.ShowBitmap == input.ShowBitmap ||
                    (this.ShowBitmap != null &&
                    this.ShowBitmap.Equals(input.ShowBitmap))
                ) && 
                (
                    this.ShowScanner == input.ShowScanner ||
                    (this.ShowScanner != null &&
                    this.ShowScanner.Equals(input.ShowScanner))
                ) && 
                (
                    this.ScanXDir == input.ScanXDir ||
                    (this.ScanXDir != null &&
                    this.ScanXDir.Equals(input.ScanXDir))
                ) && 
                (
                    this.PenFrequency == input.PenFrequency ||
                    (this.PenFrequency != null &&
                    this.PenFrequency.Equals(input.PenFrequency))
                ) && 
                (
                    this.JumpOverBlankPixel == input.JumpOverBlankPixel ||
                    (this.JumpOverBlankPixel != null &&
                    this.JumpOverBlankPixel.Equals(input.JumpOverBlankPixel))
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
                if (this.Invert != null)
                {
                    hashCode = (hashCode * 59) + this.Invert.GetHashCode();
                }
                if (this.Grayscale != null)
                {
                    hashCode = (hashCode * 59) + this.Grayscale.GetHashCode();
                }
                if (this.DrillMode != null)
                {
                    hashCode = (hashCode * 59) + this.DrillMode.GetHashCode();
                }
                if (this.DrillGrayscale != null)
                {
                    hashCode = (hashCode * 59) + this.DrillGrayscale.GetHashCode();
                }
                if (this.Bidirectional != null)
                {
                    hashCode = (hashCode * 59) + this.Bidirectional.GetHashCode();
                }
                if (this.StartLastLine != null)
                {
                    hashCode = (hashCode * 59) + this.StartLastLine.GetHashCode();
                }
                if (this.NoLineIncrement != null)
                {
                    hashCode = (hashCode * 59) + this.NoLineIncrement.GetHashCode();
                }
                if (this.ShowBitmap != null)
                {
                    hashCode = (hashCode * 59) + this.ShowBitmap.GetHashCode();
                }
                if (this.ShowScanner != null)
                {
                    hashCode = (hashCode * 59) + this.ShowScanner.GetHashCode();
                }
                if (this.ScanXDir != null)
                {
                    hashCode = (hashCode * 59) + this.ScanXDir.GetHashCode();
                }
                if (this.PenFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.PenFrequency.GetHashCode();
                }
                if (this.JumpOverBlankPixel != null)
                {
                    hashCode = (hashCode * 59) + this.JumpOverBlankPixel.GetHashCode();
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
