/*
 * aida-mini
 *
 * 1.0.361
 *
 * The version of the OpenAPI document: 1.0.361
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// DataSourceConfigurationDto
    /// </summary>
    [DataContract(Name = "DataSourceConfigurationDto")]
    [JsonConverter(typeof(JsonSubtypes), "Discriminator")]
    [JsonSubtypes.KnownSubType(typeof(MySqlDataSourceConfigurationDto), "IXLA.Box.Automapper.MySqlDataSourceConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(NpgSqlDataSourceConfigurationDto), "IXLA.Box.Automapper.NpgSqlDataSourceConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(MySqlDataSourceConfigurationDto), "MySqlDataSourceConfigurationDto")]
    [JsonSubtypes.KnownSubType(typeof(NpgSqlDataSourceConfigurationDto), "NpgSqlDataSourceConfigurationDto")]
    public partial class DataSourceConfigurationDto : IEquatable<DataSourceConfigurationDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataSourceType
        /// </summary>
        [DataMember(Name = "dataSourceType", EmitDefaultValue = false)]
        public DataSourceType? DataSourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSourceConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConfigurationDto" /> class.
        /// </summary>
        /// <param name="discriminator">discriminator (required).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="dataSourceType">dataSourceType.</param>
        /// <param name="canBeDeleted">canBeDeleted.</param>
        public DataSourceConfigurationDto(string discriminator = default(string), int? id = default(int?), string name = default(string), DataSourceType? dataSourceType = default(DataSourceType?), bool canBeDeleted = default(bool))
        {
            // to ensure "discriminator" is required (not null)
            if (discriminator == null)
            {
                throw new ArgumentNullException("discriminator is a required property for DataSourceConfigurationDto and cannot be null");
            }
            this.Discriminator = discriminator;
            this.Id = id;
            this.Name = name;
            this.DataSourceType = dataSourceType;
            this.CanBeDeleted = canBeDeleted;
        }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", IsRequired = true, EmitDefaultValue = true)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CanBeDeleted
        /// </summary>
        [DataMember(Name = "canBeDeleted", EmitDefaultValue = true)]
        public bool CanBeDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSourceConfigurationDto {\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataSourceType: ").Append(DataSourceType).Append("\n");
            sb.Append("  CanBeDeleted: ").Append(CanBeDeleted).Append("\n");
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
            return this.Equals(input as DataSourceConfigurationDto);
        }

        /// <summary>
        /// Returns true if DataSourceConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSourceConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceConfigurationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataSourceType == input.DataSourceType ||
                    this.DataSourceType.Equals(input.DataSourceType)
                ) && 
                (
                    this.CanBeDeleted == input.CanBeDeleted ||
                    this.CanBeDeleted.Equals(input.CanBeDeleted)
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
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataSourceType.GetHashCode();
                hashCode = (hashCode * 59) + this.CanBeDeleted.GetHashCode();
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
            yield break;
        }
    }

}
