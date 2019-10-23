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
    /// Represents a discount being returned that applies to one or more return line items in an order.  Fixed-amount, order-scoped discounts are distributed across all non-zero return line item totals. The amount distributed to each return line item is relative to that item’s contribution to the order subtotal.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class OrderReturnDiscount :  IEquatable<OrderReturnDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReturnDiscount" /> class.
        /// </summary>
        /// <param name="Uid">Unique ID that identifies the return discount only within this order..</param>
        /// <param name="SourceDiscountUid">&#x60;uid&#x60; of the Discount from the Order which contains the original application of this discount..</param>
        /// <param name="CatalogObjectId">The catalog object id referencing &#x60;CatalogDiscount&#x60;..</param>
        /// <param name="Name">The discount&#39;s name..</param>
        /// <param name="Type">The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  Discounts that don&#39;t reference a catalog object ID must have a type of &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;. See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values.</param>
        /// <param name="Percentage">The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  &#x60;percentage&#x60; is not set for amount-based discounts..</param>
        /// <param name="AmountMoney">The total declared monetary amount of the discount.  &#x60;amount_money&#x60; is not set for percentage-based discounts..</param>
        /// <param name="AppliedMoney">The amount of discount actually applied to this line item. When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items..</param>
        /// <param name="Scope">Indicates the level at which the &#x60;OrderReturnDiscount&#x60; applies. For &#x60;ORDER&#x60; scoped discounts, the server will generate references in &#x60;applied_discounts&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped discounts, the discount will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values.</param>
        public OrderReturnDiscount(string Uid = default(string), string SourceDiscountUid = default(string), string CatalogObjectId = default(string), string Name = default(string), string Type = default(string), string Percentage = default(string), Money AmountMoney = default(Money), Money AppliedMoney = default(Money), string Scope = default(string))
        {
            this.Uid = Uid;
            this.SourceDiscountUid = SourceDiscountUid;
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.Type = Type;
            this.Percentage = Percentage;
            this.AmountMoney = AmountMoney;
            this.AppliedMoney = AppliedMoney;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// Unique ID that identifies the return discount only within this order.
        /// </summary>
        /// <value>Unique ID that identifies the return discount only within this order.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// &#x60;uid&#x60; of the Discount from the Order which contains the original application of this discount.
        /// </summary>
        /// <value>&#x60;uid&#x60; of the Discount from the Order which contains the original application of this discount.</value>
        [DataMember(Name="source_discount_uid", EmitDefaultValue=false)]
        public string SourceDiscountUid { get; set; }
        /// <summary>
        /// The catalog object id referencing &#x60;CatalogDiscount&#x60;.
        /// </summary>
        /// <value>The catalog object id referencing &#x60;CatalogDiscount&#x60;.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The discount&#39;s name.
        /// </summary>
        /// <value>The discount&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  Discounts that don&#39;t reference a catalog object ID must have a type of &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;. See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values
        /// </summary>
        /// <value>The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  Discounts that don&#39;t reference a catalog object ID must have a type of &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;. See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  &#x60;percentage&#x60; is not set for amount-based discounts.
        /// </summary>
        /// <value>The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  &#x60;percentage&#x60; is not set for amount-based discounts.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// The total declared monetary amount of the discount.  &#x60;amount_money&#x60; is not set for percentage-based discounts.
        /// </summary>
        /// <value>The total declared monetary amount of the discount.  &#x60;amount_money&#x60; is not set for percentage-based discounts.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The amount of discount actually applied to this line item. When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items.
        /// </summary>
        /// <value>The amount of discount actually applied to this line item. When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public Money AppliedMoney { get; set; }
        /// <summary>
        /// Indicates the level at which the &#x60;OrderReturnDiscount&#x60; applies. For &#x60;ORDER&#x60; scoped discounts, the server will generate references in &#x60;applied_discounts&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped discounts, the discount will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values
        /// </summary>
        /// <value>Indicates the level at which the &#x60;OrderReturnDiscount&#x60; applies. For &#x60;ORDER&#x60; scoped discounts, the server will generate references in &#x60;applied_discounts&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped discounts, the discount will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReturnDiscount {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SourceDiscountUid: ").Append(SourceDiscountUid).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(obj as OrderReturnDiscount);
        }

        /// <summary>
        /// Returns true if OrderReturnDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderReturnDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReturnDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.SourceDiscountUid == other.SourceDiscountUid ||
                    this.SourceDiscountUid != null &&
                    this.SourceDiscountUid.Equals(other.SourceDiscountUid)
                ) && 
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
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
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                if (this.SourceDiscountUid != null)
                    hash = hash * 59 + this.SourceDiscountUid.GetHashCode();
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Uid (string) maxLength
            if(this.Uid != null && this.Uid.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Uid, length must be less than 60.", new [] { "Uid" });
            }

            // SourceDiscountUid (string) maxLength
            if(this.SourceDiscountUid != null && this.SourceDiscountUid.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SourceDiscountUid, length must be less than 60.", new [] { "SourceDiscountUid" });
            }

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

            // Percentage (string) maxLength
            if(this.Percentage != null && this.Percentage.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Percentage, length must be less than 10.", new [] { "Percentage" });
            }

            yield break;
        }
    }

}
