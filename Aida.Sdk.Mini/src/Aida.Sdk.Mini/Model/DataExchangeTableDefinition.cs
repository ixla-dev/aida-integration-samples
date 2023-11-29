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
    /// DataExchangeTableDefinition
    /// </summary>
    [DataContract(Name = "DataExchangeTableDefinition")]
    public partial class DataExchangeTableDefinition : IEquatable<DataExchangeTableDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExchangeTableDefinition" /> class.
        /// </summary>
        /// <param name="sql">sql.</param>
        /// <param name="tableName">tableName.</param>
        public DataExchangeTableDefinition(string sql = default(string), string tableName = default(string))
        {
            this.Sql = sql;
            this.TableName = tableName;
        }

        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name = "sql", EmitDefaultValue = true)]
        public string Sql { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name = "tableName", EmitDefaultValue = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataExchangeTableDefinition {\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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
            return this.Equals(input as DataExchangeTableDefinition);
        }

        /// <summary>
        /// Returns true if DataExchangeTableDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DataExchangeTableDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataExchangeTableDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sql == input.Sql ||
                    (this.Sql != null &&
                    this.Sql.Equals(input.Sql))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Sql != null)
                {
                    hashCode = (hashCode * 59) + this.Sql.GetHashCode();
                }
                if (this.TableName != null)
                {
                    hashCode = (hashCode * 59) + this.TableName.GetHashCode();
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
