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
    /// Contains the measurement unit for a quantity and a precision which specifies the number of digits after the decimal point for decimal quantities.
    /// </summary>
    [DataContract]
    public partial class OrderQuantityUnit :  IEquatable<OrderQuantityUnit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderQuantityUnit" /> class.
        /// </summary>
        /// <param name="MeasurementUnit">A &#x60;MeasurementUnit&#x60; that represents the unit of measure for the quantity..</param>
        /// <param name="Precision">For non-integer quantities, represents the number of digits after the decimal point that are recorded for this quantity.  For example, a precision of 1 allows quantities like &#x60;\&quot;1.0\&quot;&#x60; and &#x60;\&quot;1.1\&quot;&#x60;, but not &#x60;\&quot;1.01\&quot;&#x60;.  Min: 0. Max: 5..</param>
        public OrderQuantityUnit(MeasurementUnit MeasurementUnit = default(MeasurementUnit), int? Precision = default(int?))
        {
            this.MeasurementUnit = MeasurementUnit;
            this.Precision = Precision;
        }
        
        /// <summary>
        /// A &#x60;MeasurementUnit&#x60; that represents the unit of measure for the quantity.
        /// </summary>
        /// <value>A &#x60;MeasurementUnit&#x60; that represents the unit of measure for the quantity.</value>
        [DataMember(Name="measurement_unit", EmitDefaultValue=false)]
        public MeasurementUnit MeasurementUnit { get; set; }
        /// <summary>
        /// For non-integer quantities, represents the number of digits after the decimal point that are recorded for this quantity.  For example, a precision of 1 allows quantities like &#x60;\&quot;1.0\&quot;&#x60; and &#x60;\&quot;1.1\&quot;&#x60;, but not &#x60;\&quot;1.01\&quot;&#x60;.  Min: 0. Max: 5.
        /// </summary>
        /// <value>For non-integer quantities, represents the number of digits after the decimal point that are recorded for this quantity.  For example, a precision of 1 allows quantities like &#x60;\&quot;1.0\&quot;&#x60; and &#x60;\&quot;1.1\&quot;&#x60;, but not &#x60;\&quot;1.01\&quot;&#x60;.  Min: 0. Max: 5.</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public int? Precision { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderQuantityUnit {\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
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
            return this.Equals(obj as OrderQuantityUnit);
        }

        /// <summary>
        /// Returns true if OrderQuantityUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderQuantityUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderQuantityUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MeasurementUnit == other.MeasurementUnit ||
                    this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(other.MeasurementUnit)
                ) && 
                (
                    this.Precision == other.Precision ||
                    this.Precision != null &&
                    this.Precision.Equals(other.Precision)
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
                if (this.MeasurementUnit != null)
                    hash = hash * 59 + this.MeasurementUnit.GetHashCode();
                if (this.Precision != null)
                    hash = hash * 59 + this.Precision.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}