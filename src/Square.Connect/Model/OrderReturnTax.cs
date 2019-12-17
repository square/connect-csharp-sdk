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
    /// Represents a tax being returned that applies to one or more return line items in an order.  Fixed-amount, order-scoped taxes are distributed across all non-zero return line item totals. The amount distributed to each return line item is relative to that item’s contribution to the order subtotal.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class OrderReturnTax :  IEquatable<OrderReturnTax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReturnTax" /> class.
        /// </summary>
        /// <param name="Uid">Unique ID that identifies the return tax only within this order..</param>
        /// <param name="SourceTaxUid">&#x60;uid&#x60; of the Tax from the Order which contains the original charge of this tax..</param>
        /// <param name="CatalogObjectId">The catalog object id referencing &#x60;CatalogTax&#x60;..</param>
        /// <param name="Name">The tax&#39;s name..</param>
        /// <param name="Type">Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values.</param>
        /// <param name="Percentage">The percentage of the tax, as a string representation of a decimal number. For example, a value of &#x60;\&quot;7.25\&quot;&#x60; corresponds to a percentage of 7.25%..</param>
        /// <param name="AppliedMoney">The amount of the money applied by the tax in an order..</param>
        /// <param name="Scope">Indicates the level at which the &#x60;OrderReturnTax&#x60; applies. For &#x60;ORDER&#x60; scoped taxes, Square generates references in &#x60;applied_taxes&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped taxes, the tax will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values.</param>
        public OrderReturnTax(string Uid = default(string), string SourceTaxUid = default(string), string CatalogObjectId = default(string), string Name = default(string), string Type = default(string), string Percentage = default(string), Money AppliedMoney = default(Money), string Scope = default(string))
        {
            this.Uid = Uid;
            this.SourceTaxUid = SourceTaxUid;
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.Type = Type;
            this.Percentage = Percentage;
            this.AppliedMoney = AppliedMoney;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// Unique ID that identifies the return tax only within this order.
        /// </summary>
        /// <value>Unique ID that identifies the return tax only within this order.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// &#x60;uid&#x60; of the Tax from the Order which contains the original charge of this tax.
        /// </summary>
        /// <value>&#x60;uid&#x60; of the Tax from the Order which contains the original charge of this tax.</value>
        [DataMember(Name="source_tax_uid", EmitDefaultValue=false)]
        public string SourceTaxUid { get; set; }
        /// <summary>
        /// The catalog object id referencing &#x60;CatalogTax&#x60;.
        /// </summary>
        /// <value>The catalog object id referencing &#x60;CatalogTax&#x60;.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The tax&#39;s name.
        /// </summary>
        /// <value>The tax&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values
        /// </summary>
        /// <value>Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number. For example, a value of &#x60;\&quot;7.25\&quot;&#x60; corresponds to a percentage of 7.25%.
        /// </summary>
        /// <value>The percentage of the tax, as a string representation of a decimal number. For example, a value of &#x60;\&quot;7.25\&quot;&#x60; corresponds to a percentage of 7.25%.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// The amount of the money applied by the tax in an order.
        /// </summary>
        /// <value>The amount of the money applied by the tax in an order.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public Money AppliedMoney { get; set; }
        /// <summary>
        /// Indicates the level at which the &#x60;OrderReturnTax&#x60; applies. For &#x60;ORDER&#x60; scoped taxes, Square generates references in &#x60;applied_taxes&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped taxes, the tax will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values
        /// </summary>
        /// <value>Indicates the level at which the &#x60;OrderReturnTax&#x60; applies. For &#x60;ORDER&#x60; scoped taxes, Square generates references in &#x60;applied_taxes&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped taxes, the tax will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReturnTax {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SourceTaxUid: ").Append(SourceTaxUid).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(obj as OrderReturnTax);
        }

        /// <summary>
        /// Returns true if OrderReturnTax instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderReturnTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReturnTax other)
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
                    this.SourceTaxUid == other.SourceTaxUid ||
                    this.SourceTaxUid != null &&
                    this.SourceTaxUid.Equals(other.SourceTaxUid)
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
                if (this.SourceTaxUid != null)
                    hash = hash * 59 + this.SourceTaxUid.GetHashCode();
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
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

            // SourceTaxUid (string) maxLength
            if(this.SourceTaxUid != null && this.SourceTaxUid.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SourceTaxUid, length must be less than 60.", new [] { "SourceTaxUid" });
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