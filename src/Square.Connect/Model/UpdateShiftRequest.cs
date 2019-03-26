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
    /// A request to update a &#x60;Shift&#x60; object.
    /// </summary>
    [DataContract]
    public partial class UpdateShiftRequest :  IEquatable<UpdateShiftRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateShiftRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftRequest" /> class.
        /// </summary>
        /// <param name="Shift">The updated &#x60;Shift&#x60; object. (required).</param>
        public UpdateShiftRequest(Shift Shift = default(Shift))
        {
            // to ensure "Shift" is required (not null)
            if (Shift == null)
            {
                throw new InvalidDataException("Shift is a required property for UpdateShiftRequest and cannot be null");
            }
            else
            {
                this.Shift = Shift;
            }
        }
        
        /// <summary>
        /// The updated &#x60;Shift&#x60; object.
        /// </summary>
        /// <value>The updated &#x60;Shift&#x60; object.</value>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public Shift Shift { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShiftRequest {\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
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
            return this.Equals(obj as UpdateShiftRequest);
        }

        /// <summary>
        /// Returns true if UpdateShiftRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateShiftRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShiftRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Shift == other.Shift ||
                    this.Shift != null &&
                    this.Shift.Equals(other.Shift)
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
                if (this.Shift != null)
                    hash = hash * 59 + this.Shift.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}