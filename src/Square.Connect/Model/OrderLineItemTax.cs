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
    /// Represents a tax that applies to one or more line items in an order.
    /// </summary>
    [DataContract]
    public partial class OrderLineItemTax :  IEquatable<OrderLineItemTax>, IValidatableObject
    {
        /// <summary>
        /// Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values
        /// </summary>
        /// <value>Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum UNKNOWNTAX for "UNKNOWN_TAX"
            /// </summary>
            [EnumMember(Value = "UNKNOWN_TAX")]
            UNKNOWNTAX,
            
            /// <summary>
            /// Enum ADDITIVE for "ADDITIVE"
            /// </summary>
            [EnumMember(Value = "ADDITIVE")]
            ADDITIVE,
            
            /// <summary>
            /// Enum INCLUSIVE for "INCLUSIVE"
            /// </summary>
            [EnumMember(Value = "INCLUSIVE")]
            INCLUSIVE
        }

        /// <summary>
        /// Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values
        /// </summary>
        /// <value>Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum OTHERTAXSCOPE for "OTHER_TAX_SCOPE"
            /// </summary>
            [EnumMember(Value = "OTHER_TAX_SCOPE")]
            OTHERTAXSCOPE,
            
            /// <summary>
            /// Enum LINEITEM for "LINE_ITEM"
            /// </summary>
            [EnumMember(Value = "LINE_ITEM")]
            LINEITEM,
            
            /// <summary>
            /// Enum ORDER for "ORDER"
            /// </summary>
            [EnumMember(Value = "ORDER")]
            ORDER
        }

        /// <summary>
        /// Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values
        /// </summary>
        /// <value>Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values
        /// </summary>
        /// <value>Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemTax" /> class.
        /// </summary>
        /// <param name="CatalogObjectId">The catalog object id referencing [CatalogTax](#type-catalogtax)..</param>
        /// <param name="Name">The tax&#39;s name..</param>
        /// <param name="Type">Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values.</param>
        /// <param name="Percentage">The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%..</param>
        /// <param name="AppliedMoney">The amount of the money applied by the tax in an order..</param>
        /// <param name="Scope">Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values.</param>
        public OrderLineItemTax(string CatalogObjectId = default(string), string Name = default(string), TypeEnum? Type = default(TypeEnum?), string Percentage = default(string), Money AppliedMoney = default(Money), ScopeEnum? Scope = default(ScopeEnum?))
        {
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.Type = Type;
            this.Percentage = Percentage;
            this.AppliedMoney = AppliedMoney;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// The catalog object id referencing [CatalogTax](#type-catalogtax).
        /// </summary>
        /// <value>The catalog object id referencing [CatalogTax](#type-catalogtax).</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The tax&#39;s name.
        /// </summary>
        /// <value>The tax&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.
        /// </summary>
        /// <value>The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// The amount of the money applied by the tax in an order.
        /// </summary>
        /// <value>The amount of the money applied by the tax in an order.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public Money AppliedMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemTax {\n");
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
            return this.Equals(obj as OrderLineItemTax);
        }

        /// <summary>
        /// Returns true if OrderLineItemTax instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLineItemTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItemTax other)
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
