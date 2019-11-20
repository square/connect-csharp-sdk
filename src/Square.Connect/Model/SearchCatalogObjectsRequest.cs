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
    public partial class SearchCatalogObjectsRequest :  IEquatable<SearchCatalogObjectsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCatalogObjectsRequest" /> class.
        /// </summary>
        /// <param name="Cursor">The pagination cursor returned in the previous response. Leave unset for an initial request. See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information..</param>
        /// <param name="ObjectTypes">The desired set of object types to appear in the search results. The legal values are taken from the CatalogObjectType enum: &#x60;\&quot;ITEM\&quot;&#x60;, &#x60;\&quot;ITEM_VARIATION\&quot;&#x60;, &#x60;\&quot;CATEGORY\&quot;&#x60;, &#x60;\&quot;DISCOUNT\&quot;&#x60;, &#x60;\&quot;TAX\&quot;&#x60;, &#x60;\&quot;MODIFIER\&quot;&#x60;, or &#x60;\&quot;MODIFIER_LIST\&quot;&#x60;. See [CatalogObjectType](#type-catalogobjecttype) for possible values.</param>
        /// <param name="IncludeDeletedObjects">If &#x60;true&#x60;, deleted objects will be included in the results. Deleted objects will have their &#x60;is_deleted&#x60; field set to &#x60;true&#x60;..</param>
        /// <param name="IncludeRelatedObjects">If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If a CatalogItem is returned in the object field of the response, its associated CatalogCategory, CatalogTax objects, CatalogImage objects and CatalogModifierList objects will be included in the &#x60;related_objects&#x60; field of the response.  If a CatalogItemVariation is returned in the object field of the response, its parent CatalogItem will be included in the &#x60;related_objects&#x60; field of the response..</param>
        /// <param name="BeginTime">Return objects modified after this [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates), in RFC 3339 format, e.g., &#x60;2016-09-04T23:59:33.123Z&#x60;. The timestamp is exclusive - objects with a timestamp equal to &#x60;begin_time&#x60; will not be included in the response..</param>
        /// <param name="Query">A query to be used to filter or sort the results. If no query is specified, the entire catalog will be returned..</param>
        /// <param name="Limit">A limit on the number of results to be returned in a single page. The limit is advisory - the implementation may return more or fewer results. If the supplied limit is negative, zero, or is higher than the maximum limit of 1,000, it will be ignored..</param>
        public SearchCatalogObjectsRequest(string Cursor = default(string), List<string> ObjectTypes = default(List<string>), bool? IncludeDeletedObjects = default(bool?), bool? IncludeRelatedObjects = default(bool?), string BeginTime = default(string), CatalogQuery Query = default(CatalogQuery), int? Limit = default(int?))
        {
            this.Cursor = Cursor;
            this.ObjectTypes = ObjectTypes;
            this.IncludeDeletedObjects = IncludeDeletedObjects;
            this.IncludeRelatedObjects = IncludeRelatedObjects;
            this.BeginTime = BeginTime;
            this.Query = Query;
            this.Limit = Limit;
        }
        
        /// <summary>
        /// The pagination cursor returned in the previous response. Leave unset for an initial request. See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information.
        /// </summary>
        /// <value>The pagination cursor returned in the previous response. Leave unset for an initial request. See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// The desired set of object types to appear in the search results. The legal values are taken from the CatalogObjectType enum: &#x60;\&quot;ITEM\&quot;&#x60;, &#x60;\&quot;ITEM_VARIATION\&quot;&#x60;, &#x60;\&quot;CATEGORY\&quot;&#x60;, &#x60;\&quot;DISCOUNT\&quot;&#x60;, &#x60;\&quot;TAX\&quot;&#x60;, &#x60;\&quot;MODIFIER\&quot;&#x60;, or &#x60;\&quot;MODIFIER_LIST\&quot;&#x60;. See [CatalogObjectType](#type-catalogobjecttype) for possible values
        /// </summary>
        /// <value>The desired set of object types to appear in the search results. The legal values are taken from the CatalogObjectType enum: &#x60;\&quot;ITEM\&quot;&#x60;, &#x60;\&quot;ITEM_VARIATION\&quot;&#x60;, &#x60;\&quot;CATEGORY\&quot;&#x60;, &#x60;\&quot;DISCOUNT\&quot;&#x60;, &#x60;\&quot;TAX\&quot;&#x60;, &#x60;\&quot;MODIFIER\&quot;&#x60;, or &#x60;\&quot;MODIFIER_LIST\&quot;&#x60;. See [CatalogObjectType](#type-catalogobjecttype) for possible values</value>
        [DataMember(Name="object_types", EmitDefaultValue=false)]
        public List<string> ObjectTypes { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, deleted objects will be included in the results. Deleted objects will have their &#x60;is_deleted&#x60; field set to &#x60;true&#x60;.
        /// </summary>
        /// <value>If &#x60;true&#x60;, deleted objects will be included in the results. Deleted objects will have their &#x60;is_deleted&#x60; field set to &#x60;true&#x60;.</value>
        [DataMember(Name="include_deleted_objects", EmitDefaultValue=false)]
        public bool? IncludeDeletedObjects { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If a CatalogItem is returned in the object field of the response, its associated CatalogCategory, CatalogTax objects, CatalogImage objects and CatalogModifierList objects will be included in the &#x60;related_objects&#x60; field of the response.  If a CatalogItemVariation is returned in the object field of the response, its parent CatalogItem will be included in the &#x60;related_objects&#x60; field of the response.
        /// </summary>
        /// <value>If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If a CatalogItem is returned in the object field of the response, its associated CatalogCategory, CatalogTax objects, CatalogImage objects and CatalogModifierList objects will be included in the &#x60;related_objects&#x60; field of the response.  If a CatalogItemVariation is returned in the object field of the response, its parent CatalogItem will be included in the &#x60;related_objects&#x60; field of the response.</value>
        [DataMember(Name="include_related_objects", EmitDefaultValue=false)]
        public bool? IncludeRelatedObjects { get; set; }
        /// <summary>
        /// Return objects modified after this [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates), in RFC 3339 format, e.g., &#x60;2016-09-04T23:59:33.123Z&#x60;. The timestamp is exclusive - objects with a timestamp equal to &#x60;begin_time&#x60; will not be included in the response.
        /// </summary>
        /// <value>Return objects modified after this [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates), in RFC 3339 format, e.g., &#x60;2016-09-04T23:59:33.123Z&#x60;. The timestamp is exclusive - objects with a timestamp equal to &#x60;begin_time&#x60; will not be included in the response.</value>
        [DataMember(Name="begin_time", EmitDefaultValue=false)]
        public string BeginTime { get; set; }
        /// <summary>
        /// A query to be used to filter or sort the results. If no query is specified, the entire catalog will be returned.
        /// </summary>
        /// <value>A query to be used to filter or sort the results. If no query is specified, the entire catalog will be returned.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public CatalogQuery Query { get; set; }
        /// <summary>
        /// A limit on the number of results to be returned in a single page. The limit is advisory - the implementation may return more or fewer results. If the supplied limit is negative, zero, or is higher than the maximum limit of 1,000, it will be ignored.
        /// </summary>
        /// <value>A limit on the number of results to be returned in a single page. The limit is advisory - the implementation may return more or fewer results. If the supplied limit is negative, zero, or is higher than the maximum limit of 1,000, it will be ignored.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchCatalogObjectsRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  ObjectTypes: ").Append(ObjectTypes).Append("\n");
            sb.Append("  IncludeDeletedObjects: ").Append(IncludeDeletedObjects).Append("\n");
            sb.Append("  IncludeRelatedObjects: ").Append(IncludeRelatedObjects).Append("\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as SearchCatalogObjectsRequest);
        }

        /// <summary>
        /// Returns true if SearchCatalogObjectsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchCatalogObjectsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchCatalogObjectsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
                ) && 
                (
                    this.ObjectTypes == other.ObjectTypes ||
                    this.ObjectTypes != null &&
                    this.ObjectTypes.SequenceEqual(other.ObjectTypes)
                ) && 
                (
                    this.IncludeDeletedObjects == other.IncludeDeletedObjects ||
                    this.IncludeDeletedObjects != null &&
                    this.IncludeDeletedObjects.Equals(other.IncludeDeletedObjects)
                ) && 
                (
                    this.IncludeRelatedObjects == other.IncludeRelatedObjects ||
                    this.IncludeRelatedObjects != null &&
                    this.IncludeRelatedObjects.Equals(other.IncludeRelatedObjects)
                ) && 
                (
                    this.BeginTime == other.BeginTime ||
                    this.BeginTime != null &&
                    this.BeginTime.Equals(other.BeginTime)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                if (this.ObjectTypes != null)
                    hash = hash * 59 + this.ObjectTypes.GetHashCode();
                if (this.IncludeDeletedObjects != null)
                    hash = hash * 59 + this.IncludeDeletedObjects.GetHashCode();
                if (this.IncludeRelatedObjects != null)
                    hash = hash * 59 + this.IncludeRelatedObjects.GetHashCode();
                if (this.BeginTime != null)
                    hash = hash * 59 + this.BeginTime.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
