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
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// EntityDescriptor
    /// </summary>
    [DataContract(Name = "EntityDescriptor")]
    public partial class EntityDescriptor : IEquatable<EntityDescriptor>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        public EntityFieldValueType? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDescriptor" /> class.
        /// </summary>
        /// <param name="entityIndex">entityIndex.</param>
        /// <param name="entityName">entityName.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="valueType">valueType.</param>
        /// <param name="dbValueType">dbValueType.</param>
        /// <param name="pageName">pageName.</param>
        /// <param name="isConstant">isConstant.</param>
        public EntityDescriptor(int entityIndex = default(int), string entityName = default(string), string groupName = default(string), string displayName = default(string), EntityFieldValueType? valueType = default(EntityFieldValueType?), string dbValueType = default(string), string pageName = default(string), bool isConstant = default(bool))
        {
            this.EntityIndex = entityIndex;
            this.EntityName = entityName;
            this.GroupName = groupName;
            this.DisplayName = displayName;
            this.ValueType = valueType;
            this.DbValueType = dbValueType;
            this.PageName = pageName;
            this.IsConstant = isConstant;
        }

        /// <summary>
        /// Gets or Sets EntityIndex
        /// </summary>
        [DataMember(Name = "entityIndex", EmitDefaultValue = false)]
        public int EntityIndex { get; set; }

        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name = "entityName", EmitDefaultValue = true)]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DbValueType
        /// </summary>
        [DataMember(Name = "dbValueType", EmitDefaultValue = true)]
        public string DbValueType { get; set; }

        /// <summary>
        /// Gets or Sets PageName
        /// </summary>
        [DataMember(Name = "pageName", EmitDefaultValue = true)]
        public string PageName { get; set; }

        /// <summary>
        /// Gets or Sets IsConstant
        /// </summary>
        [DataMember(Name = "isConstant", EmitDefaultValue = true)]
        public bool IsConstant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityDescriptor {\n");
            sb.Append("  EntityIndex: ").Append(EntityIndex).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  DbValueType: ").Append(DbValueType).Append("\n");
            sb.Append("  PageName: ").Append(PageName).Append("\n");
            sb.Append("  IsConstant: ").Append(IsConstant).Append("\n");
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
            return this.Equals(input as EntityDescriptor);
        }

        /// <summary>
        /// Returns true if EntityDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityDescriptor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityIndex == input.EntityIndex ||
                    this.EntityIndex.Equals(input.EntityIndex)
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
                ) && 
                (
                    this.DbValueType == input.DbValueType ||
                    (this.DbValueType != null &&
                    this.DbValueType.Equals(input.DbValueType))
                ) && 
                (
                    this.PageName == input.PageName ||
                    (this.PageName != null &&
                    this.PageName.Equals(input.PageName))
                ) && 
                (
                    this.IsConstant == input.IsConstant ||
                    this.IsConstant.Equals(input.IsConstant)
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
                hashCode = (hashCode * 59) + this.EntityIndex.GetHashCode();
                if (this.EntityName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityName.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                if (this.DbValueType != null)
                {
                    hashCode = (hashCode * 59) + this.DbValueType.GetHashCode();
                }
                if (this.PageName != null)
                {
                    hashCode = (hashCode * 59) + this.PageName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsConstant.GetHashCode();
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
