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
    public partial class CatalogQueryItemsForTax :  IEquatable<CatalogQueryItemsForTax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQueryItemsForTax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogQueryItemsForTax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQueryItemsForTax" /> class.
        /// </summary>
        /// <param name="TaxIds">A set of &#x60;CatalogTax](#type-catalogtax) IDs to be used to find associated [CatalogItem&#x60;s. (required).</param>
        public CatalogQueryItemsForTax(List<string> TaxIds = default(List<string>))
        {
            // to ensure "TaxIds" is required (not null)
            if (TaxIds == null)
            {
                throw new InvalidDataException("TaxIds is a required property for CatalogQueryItemsForTax and cannot be null");
            }
            else
            {
                this.TaxIds = TaxIds;
            }
        }
        
        /// <summary>
        /// A set of &#x60;CatalogTax](#type-catalogtax) IDs to be used to find associated [CatalogItem&#x60;s.
        /// </summary>
        /// <value>A set of &#x60;CatalogTax](#type-catalogtax) IDs to be used to find associated [CatalogItem&#x60;s.</value>
        [DataMember(Name="tax_ids", EmitDefaultValue=false)]
        public List<string> TaxIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogQueryItemsForTax {\n");
            sb.Append("  TaxIds: ").Append(TaxIds).Append("\n");
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
            return this.Equals(obj as CatalogQueryItemsForTax);
        }

        /// <summary>
        /// Returns true if CatalogQueryItemsForTax instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogQueryItemsForTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogQueryItemsForTax other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaxIds == other.TaxIds ||
                    this.TaxIds != null &&
                    this.TaxIds.SequenceEqual(other.TaxIds)
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
                if (this.TaxIds != null)
                    hash = hash * 59 + this.TaxIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
