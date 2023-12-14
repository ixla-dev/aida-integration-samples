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
    /// LaserBoardStateChangedEventArgs
    /// </summary>
    [DataContract(Name = "LaserBoardStateChangedEventArgs")]
    public partial class LaserBoardStateChangedEventArgs : IEquatable<LaserBoardStateChangedEventArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaserBoardStateChangedEventArgs" /> class.
        /// </summary>
        /// <param name="currentState">currentState.</param>
        /// <param name="previousState">previousState.</param>
        public LaserBoardStateChangedEventArgs(LaserBoardState currentState = default(LaserBoardState), LaserBoardState previousState = default(LaserBoardState))
        {
            this.CurrentState = currentState;
            this.PreviousState = previousState;
        }

        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name = "currentState", EmitDefaultValue = false)]
        public LaserBoardState CurrentState { get; set; }

        /// <summary>
        /// Gets or Sets PreviousState
        /// </summary>
        [DataMember(Name = "previousState", EmitDefaultValue = false)]
        public LaserBoardState PreviousState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LaserBoardStateChangedEventArgs {\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  PreviousState: ").Append(PreviousState).Append("\n");
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
            return this.Equals(input as LaserBoardStateChangedEventArgs);
        }

        /// <summary>
        /// Returns true if LaserBoardStateChangedEventArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of LaserBoardStateChangedEventArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LaserBoardStateChangedEventArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentState == input.CurrentState ||
                    (this.CurrentState != null &&
                    this.CurrentState.Equals(input.CurrentState))
                ) && 
                (
                    this.PreviousState == input.PreviousState ||
                    (this.PreviousState != null &&
                    this.PreviousState.Equals(input.PreviousState))
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
                if (this.CurrentState != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentState.GetHashCode();
                }
                if (this.PreviousState != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousState.GetHashCode();
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
