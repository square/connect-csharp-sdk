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
    /// The set of line items, service charges, taxes, discounts, tips, etc. being returned in an Order.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class OrderReturn :  IEquatable<OrderReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReturn" /> class.
        /// </summary>
        /// <param name="Uid">Unique ID that identifies the return only within this order..</param>
        /// <param name="SourceOrderId">Order which contains the original sale of these returned line items. This will be unset for unlinked returns..</param>
        /// <param name="ReturnLineItems">Collection of line items which are being returned..</param>
        /// <param name="ReturnServiceCharges">Collection of service charges which are being returned..</param>
        /// <param name="ReturnTaxes">Collection of references to taxes being returned for an order, including the total applied tax amount to be returned. The taxes must reference a top-level tax ID from the source order..</param>
        /// <param name="ReturnDiscounts">Collection of references to discounts being returned for an order, including the total applied discount amount to be returned. The discounts must reference a top-level discount ID from the source order..</param>
        /// <param name="RoundingAdjustment">A positive or negative rounding adjustment to the total value being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency..</param>
        /// <param name="ReturnAmounts">Aggregate monetary value being returned by this Return entry..</param>
        public OrderReturn(string Uid = default(string), string SourceOrderId = default(string), List<OrderReturnLineItem> ReturnLineItems = default(List<OrderReturnLineItem>), List<OrderReturnServiceCharge> ReturnServiceCharges = default(List<OrderReturnServiceCharge>), List<OrderReturnTax> ReturnTaxes = default(List<OrderReturnTax>), List<OrderReturnDiscount> ReturnDiscounts = default(List<OrderReturnDiscount>), OrderRoundingAdjustment RoundingAdjustment = default(OrderRoundingAdjustment), OrderMoneyAmounts ReturnAmounts = default(OrderMoneyAmounts))
        {
            this.Uid = Uid;
            this.SourceOrderId = SourceOrderId;
            this.ReturnLineItems = ReturnLineItems;
            this.ReturnServiceCharges = ReturnServiceCharges;
            this.ReturnTaxes = ReturnTaxes;
            this.ReturnDiscounts = ReturnDiscounts;
            this.RoundingAdjustment = RoundingAdjustment;
            this.ReturnAmounts = ReturnAmounts;
        }
        
        /// <summary>
        /// Unique ID that identifies the return only within this order.
        /// </summary>
        /// <value>Unique ID that identifies the return only within this order.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// Order which contains the original sale of these returned line items. This will be unset for unlinked returns.
        /// </summary>
        /// <value>Order which contains the original sale of these returned line items. This will be unset for unlinked returns.</value>
        [DataMember(Name="source_order_id", EmitDefaultValue=false)]
        public string SourceOrderId { get; set; }
        /// <summary>
        /// Collection of line items which are being returned.
        /// </summary>
        /// <value>Collection of line items which are being returned.</value>
        [DataMember(Name="return_line_items", EmitDefaultValue=false)]
        public List<OrderReturnLineItem> ReturnLineItems { get; set; }
        /// <summary>
        /// Collection of service charges which are being returned.
        /// </summary>
        /// <value>Collection of service charges which are being returned.</value>
        [DataMember(Name="return_service_charges", EmitDefaultValue=false)]
        public List<OrderReturnServiceCharge> ReturnServiceCharges { get; set; }
        /// <summary>
        /// Collection of references to taxes being returned for an order, including the total applied tax amount to be returned. The taxes must reference a top-level tax ID from the source order.
        /// </summary>
        /// <value>Collection of references to taxes being returned for an order, including the total applied tax amount to be returned. The taxes must reference a top-level tax ID from the source order.</value>
        [DataMember(Name="return_taxes", EmitDefaultValue=false)]
        public List<OrderReturnTax> ReturnTaxes { get; set; }
        /// <summary>
        /// Collection of references to discounts being returned for an order, including the total applied discount amount to be returned. The discounts must reference a top-level discount ID from the source order.
        /// </summary>
        /// <value>Collection of references to discounts being returned for an order, including the total applied discount amount to be returned. The discounts must reference a top-level discount ID from the source order.</value>
        [DataMember(Name="return_discounts", EmitDefaultValue=false)]
        public List<OrderReturnDiscount> ReturnDiscounts { get; set; }
        /// <summary>
        /// A positive or negative rounding adjustment to the total value being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.
        /// </summary>
        /// <value>A positive or negative rounding adjustment to the total value being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.</value>
        [DataMember(Name="rounding_adjustment", EmitDefaultValue=false)]
        public OrderRoundingAdjustment RoundingAdjustment { get; set; }
        /// <summary>
        /// Aggregate monetary value being returned by this Return entry.
        /// </summary>
        /// <value>Aggregate monetary value being returned by this Return entry.</value>
        [DataMember(Name="return_amounts", EmitDefaultValue=false)]
        public OrderMoneyAmounts ReturnAmounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReturn {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SourceOrderId: ").Append(SourceOrderId).Append("\n");
            sb.Append("  ReturnLineItems: ").Append(ReturnLineItems).Append("\n");
            sb.Append("  ReturnServiceCharges: ").Append(ReturnServiceCharges).Append("\n");
            sb.Append("  ReturnTaxes: ").Append(ReturnTaxes).Append("\n");
            sb.Append("  ReturnDiscounts: ").Append(ReturnDiscounts).Append("\n");
            sb.Append("  RoundingAdjustment: ").Append(RoundingAdjustment).Append("\n");
            sb.Append("  ReturnAmounts: ").Append(ReturnAmounts).Append("\n");
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
            return this.Equals(obj as OrderReturn);
        }

        /// <summary>
        /// Returns true if OrderReturn instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReturn other)
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
                    this.SourceOrderId == other.SourceOrderId ||
                    this.SourceOrderId != null &&
                    this.SourceOrderId.Equals(other.SourceOrderId)
                ) && 
                (
                    this.ReturnLineItems == other.ReturnLineItems ||
                    this.ReturnLineItems != null &&
                    this.ReturnLineItems.SequenceEqual(other.ReturnLineItems)
                ) && 
                (
                    this.ReturnServiceCharges == other.ReturnServiceCharges ||
                    this.ReturnServiceCharges != null &&
                    this.ReturnServiceCharges.SequenceEqual(other.ReturnServiceCharges)
                ) && 
                (
                    this.ReturnTaxes == other.ReturnTaxes ||
                    this.ReturnTaxes != null &&
                    this.ReturnTaxes.SequenceEqual(other.ReturnTaxes)
                ) && 
                (
                    this.ReturnDiscounts == other.ReturnDiscounts ||
                    this.ReturnDiscounts != null &&
                    this.ReturnDiscounts.SequenceEqual(other.ReturnDiscounts)
                ) && 
                (
                    this.RoundingAdjustment == other.RoundingAdjustment ||
                    this.RoundingAdjustment != null &&
                    this.RoundingAdjustment.Equals(other.RoundingAdjustment)
                ) && 
                (
                    this.ReturnAmounts == other.ReturnAmounts ||
                    this.ReturnAmounts != null &&
                    this.ReturnAmounts.Equals(other.ReturnAmounts)
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
                if (this.SourceOrderId != null)
                    hash = hash * 59 + this.SourceOrderId.GetHashCode();
                if (this.ReturnLineItems != null)
                    hash = hash * 59 + this.ReturnLineItems.GetHashCode();
                if (this.ReturnServiceCharges != null)
                    hash = hash * 59 + this.ReturnServiceCharges.GetHashCode();
                if (this.ReturnTaxes != null)
                    hash = hash * 59 + this.ReturnTaxes.GetHashCode();
                if (this.ReturnDiscounts != null)
                    hash = hash * 59 + this.ReturnDiscounts.GetHashCode();
                if (this.RoundingAdjustment != null)
                    hash = hash * 59 + this.RoundingAdjustment.GetHashCode();
                if (this.ReturnAmounts != null)
                    hash = hash * 59 + this.ReturnAmounts.GetHashCode();
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

            yield break;
        }
    }

}
