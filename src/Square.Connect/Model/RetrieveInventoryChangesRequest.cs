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
    public partial class RetrieveInventoryChangesRequest :  IEquatable<RetrieveInventoryChangesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveInventoryChangesRequest" /> class.
        /// </summary>
        /// <param name="LocationIds">The [Location](#type-location) IDs to look up as a comma-separated list. An empty list queries all locations..</param>
        /// <param name="Cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information..</param>
        public RetrieveInventoryChangesRequest(string LocationIds = default(string), string Cursor = default(string))
        {
            this.LocationIds = LocationIds;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// The [Location](#type-location) IDs to look up as a comma-separated list. An empty list queries all locations.
        /// </summary>
        /// <value>The [Location](#type-location) IDs to look up as a comma-separated list. An empty list queries all locations.</value>
        [DataMember(Name="location_ids", EmitDefaultValue=false)]
        public string LocationIds { get; set; }
        /// <summary>
        /// A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information.
        /// </summary>
        /// <value>A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveInventoryChangesRequest {\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
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
            return this.Equals(obj as RetrieveInventoryChangesRequest);
        }

        /// <summary>
        /// Returns true if RetrieveInventoryChangesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveInventoryChangesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveInventoryChangesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocationIds == other.LocationIds ||
                    this.LocationIds != null &&
                    this.LocationIds.Equals(other.LocationIds)
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
                if (this.LocationIds != null)
                    hash = hash * 59 + this.LocationIds.GetHashCode();
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
