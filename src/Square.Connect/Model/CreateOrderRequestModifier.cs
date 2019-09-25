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
    /// __Deprecated__: Please use the [OrderLineItemModifier](#type-orderlineitemmodifier) type instead.  Represents a modifier applied to a single line item.  Modifiers can reference existing objects in a merchant catalog or be constructed ad hoc at the time of purchase by providing a name and price.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestModifier :  IEquatable<CreateOrderRequestModifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestModifier" /> class.
        /// </summary>
        /// <param name="CatalogObjectId">The catalog object ID of a &#x60;CatalogModifier&#x60;..</param>
        /// <param name="Name">Only used for ad hoc modifiers. The name of the modifier. &#x60;name&#x60; cannot exceed 255 characters.  Do not provide a value for &#x60;name&#x60; if you provide a value for &#x60;catalog_object_id&#x60;..</param>
        /// <param name="BasePriceMoney">The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined &#x60;CatalogModifier&#x60; price..</param>
        public CreateOrderRequestModifier(string CatalogObjectId = default(string), string Name = default(string), Money BasePriceMoney = default(Money))
        {
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.BasePriceMoney = BasePriceMoney;
        }
        
        /// <summary>
        /// The catalog object ID of a &#x60;CatalogModifier&#x60;.
        /// </summary>
        /// <value>The catalog object ID of a &#x60;CatalogModifier&#x60;.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// Only used for ad hoc modifiers. The name of the modifier. &#x60;name&#x60; cannot exceed 255 characters.  Do not provide a value for &#x60;name&#x60; if you provide a value for &#x60;catalog_object_id&#x60;.
        /// </summary>
        /// <value>Only used for ad hoc modifiers. The name of the modifier. &#x60;name&#x60; cannot exceed 255 characters.  Do not provide a value for &#x60;name&#x60; if you provide a value for &#x60;catalog_object_id&#x60;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined &#x60;CatalogModifier&#x60; price.
        /// </summary>
        /// <value>The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined &#x60;CatalogModifier&#x60; price.</value>
        [DataMember(Name="base_price_money", EmitDefaultValue=false)]
        public Money BasePriceMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestModifier {\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BasePriceMoney: ").Append(BasePriceMoney).Append("\n");
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
            return this.Equals(obj as CreateOrderRequestModifier);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestModifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BasePriceMoney == other.BasePriceMoney ||
                    this.BasePriceMoney != null &&
                    this.BasePriceMoney.Equals(other.BasePriceMoney)
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
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BasePriceMoney != null)
                    hash = hash * 59 + this.BasePriceMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            yield break;
        }
    }

}
