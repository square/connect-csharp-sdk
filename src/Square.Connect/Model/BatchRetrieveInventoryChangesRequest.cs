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
    public partial class BatchRetrieveInventoryChangesRequest :  IEquatable<BatchRetrieveInventoryChangesRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesEnum
        {
            
            /// <summary>
            /// Enum PHYSICALCOUNT for "PHYSICAL_COUNT"
            /// </summary>
            [EnumMember(Value = "PHYSICAL_COUNT")]
            PHYSICALCOUNT,
            
            /// <summary>
            /// Enum ADJUSTMENT for "ADJUSTMENT"
            /// </summary>
            [EnumMember(Value = "ADJUSTMENT")]
            ADJUSTMENT,
            
            /// <summary>
            /// Enum TRANSFER for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            TRANSFER
        }


        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatesEnum
        {
            
            /// <summary>
            /// Enum CUSTOM for "CUSTOM"
            /// </summary>
            [EnumMember(Value = "CUSTOM")]
            CUSTOM,
            
            /// <summary>
            /// Enum INSTOCK for "IN_STOCK"
            /// </summary>
            [EnumMember(Value = "IN_STOCK")]
            INSTOCK,
            
            /// <summary>
            /// Enum SOLD for "SOLD"
            /// </summary>
            [EnumMember(Value = "SOLD")]
            SOLD,
            
            /// <summary>
            /// Enum RETURNEDBYCUSTOMER for "RETURNED_BY_CUSTOMER"
            /// </summary>
            [EnumMember(Value = "RETURNED_BY_CUSTOMER")]
            RETURNEDBYCUSTOMER,
            
            /// <summary>
            /// Enum RESERVEDFORSALE for "RESERVED_FOR_SALE"
            /// </summary>
            [EnumMember(Value = "RESERVED_FOR_SALE")]
            RESERVEDFORSALE,
            
            /// <summary>
            /// Enum SOLDONLINE for "SOLD_ONLINE"
            /// </summary>
            [EnumMember(Value = "SOLD_ONLINE")]
            SOLDONLINE,
            
            /// <summary>
            /// Enum ORDEREDFROMVENDOR for "ORDERED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "ORDERED_FROM_VENDOR")]
            ORDEREDFROMVENDOR,
            
            /// <summary>
            /// Enum RECEIVEDFROMVENDOR for "RECEIVED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "RECEIVED_FROM_VENDOR")]
            RECEIVEDFROMVENDOR,
            
            /// <summary>
            /// Enum INTRANSITTO for "IN_TRANSIT_TO"
            /// </summary>
            [EnumMember(Value = "IN_TRANSIT_TO")]
            INTRANSITTO,
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum WASTE for "WASTE"
            /// </summary>
            [EnumMember(Value = "WASTE")]
            WASTE,
            
            /// <summary>
            /// Enum UNLINKEDRETURN for "UNLINKED_RETURN"
            /// </summary>
            [EnumMember(Value = "UNLINKED_RETURN")]
            UNLINKEDRETURN
        }

        /// <summary>
        /// Filters results by [InventoryChangeType](#type-inventorychangetype). Default: [`PHYSICAL_COUNT`, `ADJUSTMENT`]. `TRANSFER` is not supported as a filter.
        /// </summary>
        /// <value>Filters results by [InventoryChangeType](#type-inventorychangetype). Default: [`PHYSICAL_COUNT`, `ADJUSTMENT`]. `TRANSFER` is not supported as a filter.</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<TypesEnum> Types { get; set; }
        /// <summary>
        /// Filters `ADJUSTMENT` query results by [InventoryState](#type-inventorystate). Only applied when set. Default: unset.
        /// </summary>
        /// <value>Filters `ADJUSTMENT` query results by [InventoryState](#type-inventorystate). Only applied when set. Default: unset.</value>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public List<StatesEnum> States { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveInventoryChangesRequest" /> class.
        /// </summary>
        /// <param name="CatalogObjectIds">Filters results by [CatalogObject](#type-catalogobject) ID. Only applied when set. Default: unset..</param>
        /// <param name="LocationIds">Filters results by [Location](#type-location) ID. Only applied when set. Default: unset..</param>
        /// <param name="Types">Filters results by [InventoryChangeType](#type-inventorychangetype). Default: [&#x60;PHYSICAL_COUNT&#x60;, &#x60;ADJUSTMENT&#x60;]. &#x60;TRANSFER&#x60; is not supported as a filter..</param>
        /// <param name="States">Filters &#x60;ADJUSTMENT&#x60; query results by [InventoryState](#type-inventorystate). Only applied when set. Default: unset..</param>
        /// <param name="UpdatedAfter">Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;)..</param>
        /// <param name="UpdatedBefore">Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is strictly before the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;)..</param>
        /// <param name="Cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Paginating results](#paginatingresults) for more information..</param>
        public BatchRetrieveInventoryChangesRequest(List<string> CatalogObjectIds = default(List<string>), List<string> LocationIds = default(List<string>), List<TypesEnum> Types = default(List<TypesEnum>), List<StatesEnum> States = default(List<StatesEnum>), string UpdatedAfter = default(string), string UpdatedBefore = default(string), string Cursor = default(string))
        {
            this.CatalogObjectIds = CatalogObjectIds;
            this.LocationIds = LocationIds;
            this.Types = Types;
            this.States = States;
            this.UpdatedAfter = UpdatedAfter;
            this.UpdatedBefore = UpdatedBefore;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// Filters results by [CatalogObject](#type-catalogobject) ID. Only applied when set. Default: unset.
        /// </summary>
        /// <value>Filters results by [CatalogObject](#type-catalogobject) ID. Only applied when set. Default: unset.</value>
        [DataMember(Name="catalog_object_ids", EmitDefaultValue=false)]
        public List<string> CatalogObjectIds { get; set; }
        /// <summary>
        /// Filters results by [Location](#type-location) ID. Only applied when set. Default: unset.
        /// </summary>
        /// <value>Filters results by [Location](#type-location) ID. Only applied when set. Default: unset.</value>
        [DataMember(Name="location_ids", EmitDefaultValue=false)]
        public List<string> LocationIds { get; set; }
        /// <summary>
        /// Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).
        /// </summary>
        /// <value>Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).</value>
        [DataMember(Name="updated_after", EmitDefaultValue=false)]
        public string UpdatedAfter { get; set; }
        /// <summary>
        /// Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is strictly before the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).
        /// </summary>
        /// <value>Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is strictly before the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;).</value>
        [DataMember(Name="updated_before", EmitDefaultValue=false)]
        public string UpdatedBefore { get; set; }
        /// <summary>
        /// A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Paginating results](#paginatingresults) for more information.
        /// </summary>
        /// <value>A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Paginating results](#paginatingresults) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRetrieveInventoryChangesRequest {\n");
            sb.Append("  CatalogObjectIds: ").Append(CatalogObjectIds).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  UpdatedAfter: ").Append(UpdatedAfter).Append("\n");
            sb.Append("  UpdatedBefore: ").Append(UpdatedBefore).Append("\n");
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
            return this.Equals(obj as BatchRetrieveInventoryChangesRequest);
        }

        /// <summary>
        /// Returns true if BatchRetrieveInventoryChangesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchRetrieveInventoryChangesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchRetrieveInventoryChangesRequest other)
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
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.States == other.States ||
                    this.States != null &&
                    this.States.SequenceEqual(other.States)
                ) && 
                (
                    this.UpdatedAfter == other.UpdatedAfter ||
                    this.UpdatedAfter != null &&
                    this.UpdatedAfter.Equals(other.UpdatedAfter)
                ) && 
                (
                    this.UpdatedBefore == other.UpdatedBefore ||
                    this.UpdatedBefore != null &&
                    this.UpdatedBefore.Equals(other.UpdatedBefore)
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
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.States != null)
                    hash = hash * 59 + this.States.GetHashCode();
                if (this.UpdatedAfter != null)
                    hash = hash * 59 + this.UpdatedAfter.GetHashCode();
                if (this.UpdatedBefore != null)
                    hash = hash * 59 + this.UpdatedBefore.GetHashCode();
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