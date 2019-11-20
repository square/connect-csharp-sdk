/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CatalogModifierOverride :  IEquatable<CatalogModifierOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogModifierOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogModifierOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogModifierOverride" /> class.
        /// </summary>
        /// <param name="ModifierId">The ID of the &#x60;CatalogModifier&#x60; whose default behavior is being overridden. (required).</param>
        /// <param name="OnByDefault">If &#x60;true&#x60;, this &#x60;CatalogModifier&#x60; should be selected by default for this &#x60;CatalogItem&#x60;..</param>
        public CatalogModifierOverride(string ModifierId = default(string), bool? OnByDefault = default(bool?))
        {
            // to ensure "ModifierId" is required (not null)
            if (ModifierId == null)
            {
                throw new InvalidDataException("ModifierId is a required property for CatalogModifierOverride and cannot be null");
            }
            else
            {
                this.ModifierId = ModifierId;
            }
            this.OnByDefault = OnByDefault;
        }
        
        /// <summary>
        /// The ID of the &#x60;CatalogModifier&#x60; whose default behavior is being overridden.
        /// </summary>
        /// <value>The ID of the &#x60;CatalogModifier&#x60; whose default behavior is being overridden.</value>
        [DataMember(Name="modifier_id", EmitDefaultValue=false)]
        public string ModifierId { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, this &#x60;CatalogModifier&#x60; should be selected by default for this &#x60;CatalogItem&#x60;.
        /// </summary>
        /// <value>If &#x60;true&#x60;, this &#x60;CatalogModifier&#x60; should be selected by default for this &#x60;CatalogItem&#x60;.</value>
        [DataMember(Name="on_by_default", EmitDefaultValue=false)]
        public bool? OnByDefault { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogModifierOverride {\n");
            sb.Append("  ModifierId: ").Append(ModifierId).Append("\n");
            sb.Append("  OnByDefault: ").Append(OnByDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CatalogModifierOverride);
        }

        /// <summary>
        /// Returns true if CatalogModifierOverride instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogModifierOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogModifierOverride other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ModifierId == other.ModifierId ||
                    this.ModifierId != null &&
                    this.ModifierId.Equals(other.ModifierId)
                ) && 
                (
                    this.OnByDefault == other.OnByDefault ||
                    this.OnByDefault != null &&
                    this.OnByDefault.Equals(other.OnByDefault)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ModifierId != null)
                    hash = hash * 59 + this.ModifierId.GetHashCode();
                if (this.OnByDefault != null)
                    hash = hash * 59 + this.OnByDefault.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // ModifierId (string) minLength
            if(this.ModifierId != null && this.ModifierId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ModifierId, length must be greater than 1.", new [] { "ModifierId" });
            }

            yield break;
        }
    }

}
