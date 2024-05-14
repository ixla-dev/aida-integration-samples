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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// NpgSqlDataSourceConfigurationDto
    /// </summary>
    [DataContract(Name = "NpgSqlDataSourceConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(MySqlDataSourceConfigurationDto), "IXLA.Box.Automapper.MySqlDataSourceConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(NpgSqlDataSourceConfigurationDto), "IXLA.Box.Automapper.NpgSqlDataSourceConfigurationDto")]
    public partial class NpgSqlDataSourceConfigurationDto : DataSourceConfigurationDto, IEquatable<NpgSqlDataSourceConfigurationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpgSqlDataSourceConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NpgSqlDataSourceConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NpgSqlDataSourceConfigurationDto" /> class.
        /// </summary>
        /// <param name="tableName">tableName.</param>
        /// <param name="queryTemplate">queryTemplate.</param>
        /// <param name="connectionString">connectionString.</param>
        /// <param name="provider">provider.</param>
        /// <param name="discriminator">discriminator (required) (default to &quot;NpgSqlDataSourceConfigurationDto&quot;).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="dataSourceType">dataSourceType.</param>
        /// <param name="canBeDeleted">canBeDeleted.</param>
        public NpgSqlDataSourceConfigurationDto(string tableName = default(string), string queryTemplate = default(string), string connectionString = default(string), string provider = default(string), string discriminator = "NpgSqlDataSourceConfigurationDto", int? id = default(int?), string name = default(string), DataSourceType? dataSourceType = default(DataSourceType?), bool canBeDeleted = default(bool)) : base(discriminator, id, name, dataSourceType, canBeDeleted)
        {
            this.TableName = tableName;
            this.QueryTemplate = queryTemplate;
            this.ConnectionString = connectionString;
            this.Provider = provider;
        }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name = "tableName", EmitDefaultValue = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets QueryTemplate
        /// </summary>
        [DataMember(Name = "queryTemplate", EmitDefaultValue = true)]
        public string QueryTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionString
        /// </summary>
        [DataMember(Name = "connectionString", EmitDefaultValue = true)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NpgSqlDataSourceConfigurationDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  QueryTemplate: ").Append(QueryTemplate).Append("\n");
            sb.Append("  ConnectionString: ").Append(ConnectionString).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as NpgSqlDataSourceConfigurationDto);
        }

        /// <summary>
        /// Returns true if NpgSqlDataSourceConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NpgSqlDataSourceConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpgSqlDataSourceConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && base.Equals(input) && 
                (
                    this.QueryTemplate == input.QueryTemplate ||
                    (this.QueryTemplate != null &&
                    this.QueryTemplate.Equals(input.QueryTemplate))
                ) && base.Equals(input) && 
                (
                    this.ConnectionString == input.ConnectionString ||
                    (this.ConnectionString != null &&
                    this.ConnectionString.Equals(input.ConnectionString))
                ) && base.Equals(input) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
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
                int hashCode = base.GetHashCode();
                if (this.TableName != null)
                {
                    hashCode = (hashCode * 59) + this.TableName.GetHashCode();
                }
                if (this.QueryTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.QueryTemplate.GetHashCode();
                }
                if (this.ConnectionString != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionString.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
