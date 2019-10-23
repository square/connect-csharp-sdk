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
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class CatalogQueryItemsForItemOptions :  IEquatable<CatalogQueryItemsForItemOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQueryItemsForItemOptions" /> class.
        /// </summary>
        /// <param name="ItemOptionIds">A set of &#x60;CatalogItemOption&#x60; IDs to be used to find associated &#x60;CatalogItem&#x60; will be returned..</param>
        public CatalogQueryItemsForItemOptions(List<string> ItemOptionIds = default(List<string>))
        {
            this.ItemOptionIds = ItemOptionIds;
        }
        
        /// <summary>
        /// A set of &#x60;CatalogItemOption&#x60; IDs to be used to find associated &#x60;CatalogItem&#x60; will be returned.
        /// </summary>
        /// <value>A set of &#x60;CatalogItemOption&#x60; IDs to be used to find associated &#x60;CatalogItem&#x60; will be returned.</value>
        [DataMember(Name="item_option_ids", EmitDefaultValue=false)]
        public List<string> ItemOptionIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogQueryItemsForItemOptions {\n");
            sb.Append("  ItemOptionIds: ").Append(ItemOptionIds).Append("\n");
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
            return this.Equals(obj as CatalogQueryItemsForItemOptions);
        }

        /// <summary>
        /// Returns true if CatalogQueryItemsForItemOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogQueryItemsForItemOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogQueryItemsForItemOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemOptionIds == other.ItemOptionIds ||
                    this.ItemOptionIds != null &&
                    this.ItemOptionIds.SequenceEqual(other.ItemOptionIds)
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
                if (this.ItemOptionIds != null)
                    hash = hash * 59 + this.ItemOptionIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
