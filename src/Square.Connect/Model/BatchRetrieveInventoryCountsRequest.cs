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
    public partial class BatchRetrieveInventoryCountsRequest :  IEquatable<BatchRetrieveInventoryCountsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveInventoryCountsRequest" /> class.
        /// </summary>
        /// <param name="CatalogObjectIds">Filters results by &#x60;CatalogObject&#x60; ID. Only applied when set. Default: unset..</param>
        /// <param name="LocationIds">Filters results by &#x60;Location&#x60; ID. Only applied when set. Default: unset..</param>
        /// <param name="UpdatedAfter">Provided as an RFC 3339 timestamp. Returns results whose &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;)..</param>
        /// <param name="Cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information..</param>
        public BatchRetrieveInventoryCountsRequest(List<string> CatalogObjectIds = default(List<string>), List<string> LocationIds = default(List<string>), string UpdatedAfter = default(string), string Cursor = default(string))
        {
            this.CatalogObjectIds = CatalogObjectIds;
            this.LocationIds = LocationIds;
            this.UpdatedAfter = UpdatedAfter;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// Filters results by &#x60;CatalogObject&#x60; ID. Only applied when set. Default: unset.
        /// </summary>
        /// <value>Filters results by &#x60;CatalogObject&#x60; ID. Only applied when set. Default: unset.</value>
        [DataMember(Name="catalog_object_ids", EmitDefaultValue=false)]
        public List<string> CatalogObjectIds { get; set; }
        /// <summary>
        /// Filters results by &#x60;Location&#x60; ID. Only applied when set. Default: unset.
        /// </summary>
        /// <value>Filters results by &#x60;Location&#x60; ID. Only applied when set. Default: unset.</value>
        [DataMember(Name="location_ids", EmitDefaultValue=false)]
        public List<string> LocationIds { get; set; }
        /// <summary>
        /// Provided as an RFC 3339 timestamp. Returns results whose &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).
        /// </summary>
        /// <value>Provided as an RFC 3339 timestamp. Returns results whose &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).</value>
        [DataMember(Name="updated_after", EmitDefaultValue=false)]
        public string UpdatedAfter { get; set; }
        /// <summary>
        /// A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information.
        /// </summary>
        /// <value>A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRetrieveInventoryCountsRequest {\n");
            sb.Append("  CatalogObjectIds: ").Append(CatalogObjectIds).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  UpdatedAfter: ").Append(UpdatedAfter).Append("\n");
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
            return this.Equals(obj as BatchRetrieveInventoryCountsRequest);
        }

        /// <summary>
        /// Returns true if BatchRetrieveInventoryCountsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchRetrieveInventoryCountsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchRetrieveInventoryCountsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogObjectIds == other.CatalogObjectIds ||
                    this.CatalogObjectIds != null &&
                    this.CatalogObjectIds.SequenceEqual(other.CatalogObjectIds)
                ) && 
                (
                    this.LocationIds == other.LocationIds ||
                    this.LocationIds != null &&
                    this.LocationIds.SequenceEqual(other.LocationIds)
                ) && 
                (
                    this.UpdatedAfter == other.UpdatedAfter ||
                    this.UpdatedAfter != null &&
                    this.UpdatedAfter.Equals(other.UpdatedAfter)
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
                if (this.CatalogObjectIds != null)
                    hash = hash * 59 + this.CatalogObjectIds.GetHashCode();
                if (this.LocationIds != null)
                    hash = hash * 59 + this.LocationIds.GetHashCode();
                if (this.UpdatedAfter != null)
                    hash = hash * 59 + this.UpdatedAfter.GetHashCode();
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
