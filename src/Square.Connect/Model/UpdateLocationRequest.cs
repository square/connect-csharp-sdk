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
    /// Request object for the [UpdateLocation](#endpoint-updatelocation) endpoint.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class UpdateLocationRequest :  IEquatable<UpdateLocationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLocationRequest" /> class.
        /// </summary>
        /// <param name="Location">The &#x60;Location&#x60; object with only the fields to update..</param>
        public UpdateLocationRequest(Location Location = default(Location))
        {
            this.Location = Location;
        }
        
        /// <summary>
        /// The &#x60;Location&#x60; object with only the fields to update.
        /// </summary>
        /// <value>The &#x60;Location&#x60; object with only the fields to update.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLocationRequest {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as UpdateLocationRequest);
        }

        /// <summary>
        /// Returns true if UpdateLocationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateLocationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLocationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
