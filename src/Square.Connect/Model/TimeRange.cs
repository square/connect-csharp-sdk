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
    /// Represents a generic time range. The start and end values are represented in RFC-3339 format. Time ranges are customized to be inclusive or exclusive based on the needs of a particular endpoint. Refer to the relevent endpoint-specific documentation to determine how time ranges are handled.
    /// </summary>
    [DataContract]
    public partial class TimeRange :  IEquatable<TimeRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        /// <param name="StartAt">A datetime value in RFC-3339 format indicating when the time range starts..</param>
        /// <param name="EndAt">A datetime value in RFC-3339 format indicating when the time range ends..</param>
        public TimeRange(string StartAt = default(string), string EndAt = default(string))
        {
            this.StartAt = StartAt;
            this.EndAt = EndAt;
        }
        
        /// <summary>
        /// A datetime value in RFC-3339 format indicating when the time range starts.
        /// </summary>
        /// <value>A datetime value in RFC-3339 format indicating when the time range starts.</value>
        [DataMember(Name="start_at", EmitDefaultValue=false)]
        public string StartAt { get; set; }
        /// <summary>
        /// A datetime value in RFC-3339 format indicating when the time range ends.
        /// </summary>
        /// <value>A datetime value in RFC-3339 format indicating when the time range ends.</value>
        [DataMember(Name="end_at", EmitDefaultValue=false)]
        public string EndAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRange {\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
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
            return this.Equals(obj as TimeRange);
        }

        /// <summary>
        /// Returns true if TimeRange instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartAt == other.StartAt ||
                    this.StartAt != null &&
                    this.StartAt.Equals(other.StartAt)
                ) && 
                (
                    this.EndAt == other.EndAt ||
                    this.EndAt != null &&
                    this.EndAt.Equals(other.EndAt)
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
                if (this.StartAt != null)
                    hash = hash * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null)
                    hash = hash * 59 + this.EndAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
