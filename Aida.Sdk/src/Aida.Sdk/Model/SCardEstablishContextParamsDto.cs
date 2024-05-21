/*
 * aida
 *
 * 1.0.696
 *
 * The version of the OpenAPI document: 1.0.696
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
    /// SCardEstablishContextParamsDto
    /// </summary>
    [DataContract(Name = "SCardEstablishContextParamsDto")]
    public partial class SCardEstablishContextParamsDto : IEquatable<SCardEstablishContextParamsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public SCardScope? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCardEstablishContextParamsDto" /> class.
        /// </summary>
        /// <param name="scope">scope.</param>
        public SCardEstablishContextParamsDto(SCardScope? scope = default(SCardScope?))
        {
            this.Scope = scope;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCardEstablishContextParamsDto {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as SCardEstablishContextParamsDto);
        }

        /// <summary>
        /// Returns true if SCardEstablishContextParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SCardEstablishContextParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCardEstablishContextParamsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
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
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
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
