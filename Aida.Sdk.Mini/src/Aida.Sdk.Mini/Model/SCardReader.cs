/*
 * aida-mini
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
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
    /// SCardReader
    /// </summary>
    [DataContract(Name = "SCardReader")]
    public partial class SCardReader : IEquatable<SCardReader>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReaderInterfaceType
        /// </summary>
        [DataMember(Name = "readerInterfaceType", EmitDefaultValue = false)]
        public ReaderInterfaceType? ReaderInterfaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardReader" /> class.
        /// </summary>
        /// <param name="readerState">readerState.</param>
        /// <param name="readerName">readerName.</param>
        /// <param name="id">id.</param>
        /// <param name="index">index.</param>
        /// <param name="readerInterfaceType">readerInterfaceType.</param>
        public SCardReader(SmartCardReaderState readerState = default(SmartCardReaderState), string readerName = default(string), string id = default(string), int index = default(int), ReaderInterfaceType? readerInterfaceType = default(ReaderInterfaceType?))
        {
            this.ReaderState = readerState;
            this.ReaderName = readerName;
            this.Id = id;
            this.Index = index;
            this.ReaderInterfaceType = readerInterfaceType;
        }

        /// <summary>
        /// Gets or Sets Connected
        /// </summary>
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; private set; }

        /// <summary>
        /// Returns false as Connected should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnected()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ReaderState
        /// </summary>
        [DataMember(Name = "readerState", EmitDefaultValue = false)]
        public SmartCardReaderState ReaderState { get; set; }

        /// <summary>
        /// Gets or Sets ReaderName
        /// </summary>
        [DataMember(Name = "readerName", EmitDefaultValue = true)]
        public string ReaderName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardReader {\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  ReaderState: ").Append(ReaderState).Append("\n");
            sb.Append("  ReaderName: ").Append(ReaderName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  ReaderInterfaceType: ").Append(ReaderInterfaceType).Append("\n");
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
            return this.Equals(input as SCardReader);
        }

        /// <summary>
        /// Returns true if SCardReader instances are equal
        /// </summary>
        /// <param name="input">Instance of SCardReader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCardReader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Connected == input.Connected ||
                    this.Connected.Equals(input.Connected)
                ) && 
                (
                    this.ReaderState == input.ReaderState ||
                    (this.ReaderState != null &&
                    this.ReaderState.Equals(input.ReaderState))
                ) && 
                (
                    this.ReaderName == input.ReaderName ||
                    (this.ReaderName != null &&
                    this.ReaderName.Equals(input.ReaderName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.ReaderInterfaceType == input.ReaderInterfaceType ||
                    this.ReaderInterfaceType.Equals(input.ReaderInterfaceType)
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
                hashCode = (hashCode * 59) + this.Connected.GetHashCode();
                if (this.ReaderState != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderState.GetHashCode();
                }
                if (this.ReaderName != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.ReaderInterfaceType.GetHashCode();
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
