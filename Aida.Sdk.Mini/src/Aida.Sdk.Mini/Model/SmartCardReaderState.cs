/*
 * aida-mini
 *
 * 1.0.323
 *
 * The version of the OpenAPI document: 1.0.323
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
    /// SmartCardReaderState
    /// </summary>
    [DataContract(Name = "SmartCardReaderState")]
    public partial class SmartCardReaderState : IEquatable<SmartCardReaderState>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name = "currentState", EmitDefaultValue = false)]
        public SCardReaderState? CurrentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartCardReaderState" /> class.
        /// </summary>
        /// <param name="currentState">currentState.</param>
        /// <param name="readerName">readerName.</param>
        /// <param name="updateCount">updateCount.</param>
        public SmartCardReaderState(SCardReaderState? currentState = default(SCardReaderState?), string readerName = default(string), int updateCount = default(int))
        {
            this.CurrentState = currentState;
            this.ReaderName = readerName;
            this.UpdateCount = updateCount;
        }

        /// <summary>
        /// Gets or Sets ReaderName
        /// </summary>
        [DataMember(Name = "readerName", EmitDefaultValue = true)]
        public string ReaderName { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCount
        /// </summary>
        [DataMember(Name = "updateCount", EmitDefaultValue = false)]
        public int UpdateCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmartCardReaderState {\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  ReaderName: ").Append(ReaderName).Append("\n");
            sb.Append("  UpdateCount: ").Append(UpdateCount).Append("\n");
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
            return this.Equals(input as SmartCardReaderState);
        }

        /// <summary>
        /// Returns true if SmartCardReaderState instances are equal
        /// </summary>
        /// <param name="input">Instance of SmartCardReaderState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartCardReaderState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentState == input.CurrentState ||
                    this.CurrentState.Equals(input.CurrentState)
                ) && 
                (
                    this.ReaderName == input.ReaderName ||
                    (this.ReaderName != null &&
                    this.ReaderName.Equals(input.ReaderName))
                ) && 
                (
                    this.UpdateCount == input.UpdateCount ||
                    this.UpdateCount.Equals(input.UpdateCount)
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
                hashCode = (hashCode * 59) + this.CurrentState.GetHashCode();
                if (this.ReaderName != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdateCount.GetHashCode();
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
