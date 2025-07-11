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
    /// PrintTask
    /// </summary>
    [DataContract(Name = "PrintTask")]
    public partial class PrintTask : IEquatable<PrintTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintTask" /> class.
        /// </summary>
        /// <param name="documentId">documentId.</param>
        /// <param name="printHeadOffset">printHeadOffset.</param>
        /// <param name="next">next.</param>
        /// <param name="previous">previous.</param>
        public PrintTask(int documentId = default(int), int printHeadOffset = default(int), PrintTask next = default(PrintTask), PrintTask previous = default(PrintTask))
        {
            this.DocumentId = documentId;
            this.PrintHeadOffset = printHeadOffset;
            this.Next = next;
            this.Previous = previous;
        }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public int DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets PrintHeadOffset
        /// </summary>
        [DataMember(Name = "printHeadOffset", EmitDefaultValue = false)]
        public int PrintHeadOffset { get; set; }

        /// <summary>
        /// Gets or Sets IsFirst
        /// </summary>
        [DataMember(Name = "isFirst", EmitDefaultValue = true)]
        public bool IsFirst { get; private set; }

        /// <summary>
        /// Returns false as IsFirst should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsFirst()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsLast
        /// </summary>
        [DataMember(Name = "isLast", EmitDefaultValue = true)]
        public bool IsLast { get; private set; }

        /// <summary>
        /// Returns false as IsLast should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsLast()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public PrintTask Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", EmitDefaultValue = false)]
        public PrintTask Previous { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintTask {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  PrintHeadOffset: ").Append(PrintHeadOffset).Append("\n");
            sb.Append("  IsFirst: ").Append(IsFirst).Append("\n");
            sb.Append("  IsLast: ").Append(IsLast).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
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
            return this.Equals(input as PrintTask);
        }

        /// <summary>
        /// Returns true if PrintTask instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintTask input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentId == input.DocumentId ||
                    this.DocumentId.Equals(input.DocumentId)
                ) && 
                (
                    this.PrintHeadOffset == input.PrintHeadOffset ||
                    this.PrintHeadOffset.Equals(input.PrintHeadOffset)
                ) && 
                (
                    this.IsFirst == input.IsFirst ||
                    this.IsFirst.Equals(input.IsFirst)
                ) && 
                (
                    this.IsLast == input.IsLast ||
                    this.IsLast.Equals(input.IsLast)
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Previous == input.Previous ||
                    (this.Previous != null &&
                    this.Previous.Equals(input.Previous))
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
                hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                hashCode = (hashCode * 59) + this.PrintHeadOffset.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFirst.GetHashCode();
                hashCode = (hashCode * 59) + this.IsLast.GetHashCode();
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
                }
                if (this.Previous != null)
                {
                    hashCode = (hashCode * 59) + this.Previous.GetHashCode();
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
