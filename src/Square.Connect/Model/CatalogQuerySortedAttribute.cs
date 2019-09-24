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
    public partial class CatalogQuerySortedAttribute :  IEquatable<CatalogQuerySortedAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQuerySortedAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogQuerySortedAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQuerySortedAttribute" /> class.
        /// </summary>
        /// <param name="AttributeName">The attribute whose value should be used as the sort key. (required).</param>
        /// <param name="InitialAttributeValue">The first attribute value to be returned by the query. Ascending sorts will return only objects with this value or greater, while descending sorts will return only objects with this value or less. If unset, start at the beginning (for ascending sorts) or end (for descending sorts)..</param>
        /// <param name="SortOrder">The desired &#x60;SortOrder&#x60;. See [SortOrder](#type-sortorder) for possible values.</param>
        public CatalogQuerySortedAttribute(string AttributeName = default(string), string InitialAttributeValue = default(string), string SortOrder = default(string))
        {
            // to ensure "AttributeName" is required (not null)
            if (AttributeName == null)
            {
                throw new InvalidDataException("AttributeName is a required property for CatalogQuerySortedAttribute and cannot be null");
            }
            else
            {
                this.AttributeName = AttributeName;
            }
            this.InitialAttributeValue = InitialAttributeValue;
            this.SortOrder = SortOrder;
        }
        
        /// <summary>
        /// The attribute whose value should be used as the sort key.
        /// </summary>
        /// <value>The attribute whose value should be used as the sort key.</value>
        [DataMember(Name="attribute_name", EmitDefaultValue=false)]
        public string AttributeName { get; set; }
        /// <summary>
        /// The first attribute value to be returned by the query. Ascending sorts will return only objects with this value or greater, while descending sorts will return only objects with this value or less. If unset, start at the beginning (for ascending sorts) or end (for descending sorts).
        /// </summary>
        /// <value>The first attribute value to be returned by the query. Ascending sorts will return only objects with this value or greater, while descending sorts will return only objects with this value or less. If unset, start at the beginning (for ascending sorts) or end (for descending sorts).</value>
        [DataMember(Name="initial_attribute_value", EmitDefaultValue=false)]
        public string InitialAttributeValue { get; set; }
        /// <summary>
        /// The desired &#x60;SortOrder&#x60;. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The desired &#x60;SortOrder&#x60;. See [SortOrder](#type-sortorder) for possible values</value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public string SortOrder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogQuerySortedAttribute {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  InitialAttributeValue: ").Append(InitialAttributeValue).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(obj as CatalogQuerySortedAttribute);
        }

        /// <summary>
        /// Returns true if CatalogQuerySortedAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogQuerySortedAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogQuerySortedAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AttributeName == other.AttributeName ||
                    this.AttributeName != null &&
                    this.AttributeName.Equals(other.AttributeName)
                ) && 
                (
                    this.InitialAttributeValue == other.InitialAttributeValue ||
                    this.InitialAttributeValue != null &&
                    this.InitialAttributeValue.Equals(other.InitialAttributeValue)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
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
                if (this.AttributeName != null)
                    hash = hash * 59 + this.AttributeName.GetHashCode();
                if (this.InitialAttributeValue != null)
                    hash = hash * 59 + this.InitialAttributeValue.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // AttributeName (string) minLength
            if(this.AttributeName != null && this.AttributeName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for AttributeName, length must be greater than 1.", new [] { "AttributeName" });
            }

            yield break;
        }
    }

}
