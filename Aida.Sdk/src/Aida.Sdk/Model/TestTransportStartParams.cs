/*
 * aida
 *
 * 1.0.691
 *
 * The version of the OpenAPI document: 1.0.691
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
    /// TestTransportStartParams
    /// </summary>
    [DataContract(Name = "TestTransportStartParams")]
    public partial class TestTransportStartParams : IEquatable<TestTransportStartParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestTransportStartParams" /> class.
        /// </summary>
        /// <param name="positionList">positionList.</param>
        /// <param name="repetitions">repetitions.</param>
        public TestTransportStartParams(List<string> positionList = default(List<string>), int repetitions = default(int))
        {
            this.PositionList = positionList;
            this.Repetitions = repetitions;
        }

        /// <summary>
        /// Gets or Sets PositionList
        /// </summary>
        [DataMember(Name = "positionList", EmitDefaultValue = true)]
        public List<string> PositionList { get; set; }

        /// <summary>
        /// Gets or Sets Repetitions
        /// </summary>
        [DataMember(Name = "repetitions", EmitDefaultValue = false)]
        public int Repetitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestTransportStartParams {\n");
            sb.Append("  PositionList: ").Append(PositionList).Append("\n");
            sb.Append("  Repetitions: ").Append(Repetitions).Append("\n");
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
            return this.Equals(input as TestTransportStartParams);
        }

        /// <summary>
        /// Returns true if TestTransportStartParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TestTransportStartParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestTransportStartParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PositionList == input.PositionList ||
                    this.PositionList != null &&
                    input.PositionList != null &&
                    this.PositionList.SequenceEqual(input.PositionList)
                ) && 
                (
                    this.Repetitions == input.Repetitions ||
                    this.Repetitions.Equals(input.Repetitions)
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
                if (this.PositionList != null)
                {
                    hashCode = (hashCode * 59) + this.PositionList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Repetitions.GetHashCode();
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
