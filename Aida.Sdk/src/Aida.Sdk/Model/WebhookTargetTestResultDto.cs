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
    /// WebhookTargetTestResultDto
    /// </summary>
    [DataContract(Name = "WebhookTargetTestResultDto")]
    public partial class WebhookTargetTestResultDto : IEquatable<WebhookTargetTestResultDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public WebhookMessageErrorCode? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetTestResultDto" /> class.
        /// </summary>
        /// <param name="webhookTargetId">webhookTargetId.</param>
        /// <param name="success">success.</param>
        /// <param name="url">url.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public WebhookTargetTestResultDto(int webhookTargetId = default(int), bool success = default(bool), string url = default(string), WebhookMessageErrorCode? errorCode = default(WebhookMessageErrorCode?), int httpStatusCode = default(int))
        {
            this.WebhookTargetId = webhookTargetId;
            this.Success = success;
            this.Url = url;
            this.ErrorCode = errorCode;
            this.HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Gets or Sets WebhookTargetId
        /// </summary>
        [DataMember(Name = "webhookTargetId", EmitDefaultValue = false)]
        public int WebhookTargetId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookTargetTestResultDto {\n");
            sb.Append("  WebhookTargetId: ").Append(WebhookTargetId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return this.Equals(input as WebhookTargetTestResultDto);
        }

        /// <summary>
        /// Returns true if WebhookTargetTestResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookTargetTestResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookTargetTestResultDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebhookTargetId == input.WebhookTargetId ||
                    this.WebhookTargetId.Equals(input.WebhookTargetId)
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    this.HttpStatusCode.Equals(input.HttpStatusCode)
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
                hashCode = (hashCode * 59) + this.WebhookTargetId.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpStatusCode.GetHashCode();
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
