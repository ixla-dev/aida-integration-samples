/*
 * aida-mini
 *
 * 1.0.524
 *
 * The version of the OpenAPI document: 1.0.524
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
    /// PcScConnectResult
    /// </summary>
    [DataContract(Name = "PcScConnectResult")]
    public partial class PcScConnectResult : IEquatable<PcScConnectResult>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public PcScErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ActiveSCardProtocol
        /// </summary>
        [DataMember(Name = "activeSCardProtocol", EmitDefaultValue = false)]
        public SCardProtocol? ActiveSCardProtocol { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SCardShare? Share { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PcScConnectResult" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="success">success.</param>
        /// <param name="readerName">readerName.</param>
        /// <param name="activeSCardProtocol">activeSCardProtocol.</param>
        /// <param name="share">share.</param>
        public PcScConnectResult(PcScErrorCode? errorCode = default(PcScErrorCode?), bool success = default(bool), string readerName = default(string), SCardProtocol? activeSCardProtocol = default(SCardProtocol?), SCardShare? share = default(SCardShare?))
        {
            this.ErrorCode = errorCode;
            this.Success = success;
            this.ReaderName = readerName;
            this.ActiveSCardProtocol = activeSCardProtocol;
            this.Share = share;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets ReaderName
        /// </summary>
        [DataMember(Name = "readerName", EmitDefaultValue = true)]
        public string ReaderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PcScConnectResult {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ReaderName: ").Append(ReaderName).Append("\n");
            sb.Append("  ActiveSCardProtocol: ").Append(ActiveSCardProtocol).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
            return this.Equals(input as PcScConnectResult);
        }

        /// <summary>
        /// Returns true if PcScConnectResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PcScConnectResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PcScConnectResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.ReaderName == input.ReaderName ||
                    (this.ReaderName != null &&
                    this.ReaderName.Equals(input.ReaderName))
                ) && 
                (
                    this.ActiveSCardProtocol == input.ActiveSCardProtocol ||
                    this.ActiveSCardProtocol.Equals(input.ActiveSCardProtocol)
                ) && 
                (
                    this.Share == input.Share ||
                    this.Share.Equals(input.Share)
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
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.ReaderName != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActiveSCardProtocol.GetHashCode();
                hashCode = (hashCode * 59) + this.Share.GetHashCode();
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
