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
    /// The information needed to define a custom unit, provided by the seller.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class MeasurementUnitCustom :  IEquatable<MeasurementUnitCustom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementUnitCustom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MeasurementUnitCustom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementUnitCustom" /> class.
        /// </summary>
        /// <param name="Name">The name of the custom unit, for example \&quot;bushel\&quot;. (required).</param>
        /// <param name="Abbreviation">The abbreviation of the custom unit, such as \&quot;bsh\&quot; (bushel). This appears in the cart for the Point of Sale app, and in reports. (required).</param>
        public MeasurementUnitCustom(string Name = default(string), string Abbreviation = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for MeasurementUnitCustom and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Abbreviation" is required (not null)
            if (Abbreviation == null)
            {
                throw new InvalidDataException("Abbreviation is a required property for MeasurementUnitCustom and cannot be null");
            }
            else
            {
                this.Abbreviation = Abbreviation;
            }
        }
        
        /// <summary>
        /// The name of the custom unit, for example \&quot;bushel\&quot;.
        /// </summary>
        /// <value>The name of the custom unit, for example \&quot;bushel\&quot;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The abbreviation of the custom unit, such as \&quot;bsh\&quot; (bushel). This appears in the cart for the Point of Sale app, and in reports.
        /// </summary>
        /// <value>The abbreviation of the custom unit, such as \&quot;bsh\&quot; (bushel). This appears in the cart for the Point of Sale app, and in reports.</value>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementUnitCustom {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
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
            return this.Equals(obj as MeasurementUnitCustom);
        }

        /// <summary>
        /// Returns true if MeasurementUnitCustom instances are equal
        /// </summary>
        /// <param name="other">Instance of MeasurementUnitCustom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementUnitCustom other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Abbreviation == other.Abbreviation ||
                    this.Abbreviation != null &&
                    this.Abbreviation.Equals(other.Abbreviation)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Abbreviation != null)
                    hash = hash * 59 + this.Abbreviation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}