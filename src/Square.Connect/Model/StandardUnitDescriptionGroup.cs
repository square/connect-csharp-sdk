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
    /// Group of standard measurement units.
    /// </summary>
    [DataContract]
    public partial class StandardUnitDescriptionGroup :  IEquatable<StandardUnitDescriptionGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardUnitDescriptionGroup" /> class.
        /// </summary>
        /// <param name="StandardUnitDescriptions">List of standard (non-custom) measurement units in this description group..</param>
        /// <param name="LanguageCode">IETF language tag..</param>
        public StandardUnitDescriptionGroup(List<StandardUnitDescription> StandardUnitDescriptions = default(List<StandardUnitDescription>), string LanguageCode = default(string))
        {
            this.StandardUnitDescriptions = StandardUnitDescriptions;
            this.LanguageCode = LanguageCode;
        }
        
        /// <summary>
        /// List of standard (non-custom) measurement units in this description group.
        /// </summary>
        /// <value>List of standard (non-custom) measurement units in this description group.</value>
        [DataMember(Name="standard_unit_descriptions", EmitDefaultValue=false)]
        public List<StandardUnitDescription> StandardUnitDescriptions { get; set; }
        /// <summary>
        /// IETF language tag.
        /// </summary>
        /// <value>IETF language tag.</value>
        [DataMember(Name="language_code", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardUnitDescriptionGroup {\n");
            sb.Append("  StandardUnitDescriptions: ").Append(StandardUnitDescriptions).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(obj as StandardUnitDescriptionGroup);
        }

        /// <summary>
        /// Returns true if StandardUnitDescriptionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of StandardUnitDescriptionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardUnitDescriptionGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StandardUnitDescriptions == other.StandardUnitDescriptions ||
                    this.StandardUnitDescriptions != null &&
                    this.StandardUnitDescriptions.SequenceEqual(other.StandardUnitDescriptions)
                ) && 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
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
                if (this.StandardUnitDescriptions != null)
                    hash = hash * 59 + this.StandardUnitDescriptions.GetHashCode();
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
