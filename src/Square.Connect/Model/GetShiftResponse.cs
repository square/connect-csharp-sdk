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
    /// A response to request to get a &#x60;Shift&#x60;. Contains the requested &#x60;Shift&#x60; object. May contain a set of &#x60;Error&#x60; objects if the request resulted in errors.
    /// </summary>
    [DataContract]
    public partial class GetShiftResponse :  IEquatable<GetShiftResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShiftResponse" /> class.
        /// </summary>
        /// <param name="Shift">The requested &#x60;Shift&#x60;..</param>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        public GetShiftResponse(Shift Shift = default(Shift), List<Error> Errors = default(List<Error>))
        {
            this.Shift = Shift;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// The requested &#x60;Shift&#x60;.
        /// </summary>
        /// <value>The requested &#x60;Shift&#x60;.</value>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public Shift Shift { get; set; }
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetShiftResponse {\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as GetShiftResponse);
        }

        /// <summary>
        /// Returns true if GetShiftResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetShiftResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetShiftResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Shift == other.Shift ||
                    this.Shift != null &&
                    this.Shift.Equals(other.Shift)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
