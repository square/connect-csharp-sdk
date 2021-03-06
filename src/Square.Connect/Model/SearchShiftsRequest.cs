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
    /// A request for a filtered and sorted set of &#x60;Shift&#x60; objects.
    /// </summary>
    [DataContract]
    public partial class SearchShiftsRequest :  IEquatable<SearchShiftsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchShiftsRequest" /> class.
        /// </summary>
        /// <param name="Query">Query filters..</param>
        /// <param name="Limit">number of resources in a page (200 by default)..</param>
        /// <param name="Cursor">opaque cursor for fetching the next page..</param>
        public SearchShiftsRequest(ShiftQuery Query = default(ShiftQuery), int? Limit = default(int?), string Cursor = default(string))
        {
            this.Query = Query;
            this.Limit = Limit;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// Query filters.
        /// </summary>
        /// <value>Query filters.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public ShiftQuery Query { get; set; }
        /// <summary>
        /// number of resources in a page (200 by default).
        /// </summary>
        /// <value>number of resources in a page (200 by default).</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// opaque cursor for fetching the next page.
        /// </summary>
        /// <value>opaque cursor for fetching the next page.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchShiftsRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
            return this.Equals(obj as SearchShiftsRequest);
        }

        /// <summary>
        /// Returns true if SearchShiftsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchShiftsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchShiftsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Limit (int?) maximum
            if(this.Limit > (int?)200)
            {
                yield return new ValidationResult("Invalid value for Limit, must be a value less than or equal to 200.", new [] { "Limit" });
            }

            // Limit (int?) minimum
            if(this.Limit < (int?)1)
            {
                yield return new ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
