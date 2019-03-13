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
    public partial class CreateOrderRequest :  IEquatable<CreateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        /// <param name="Order">The order to create. If this field is set, then the only other top-level field that can be set is the idempotency_key..</param>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this order among orders you&#39;ve created.  If you&#39;re unsure whether a particular order was created successfully, you can reattempt it with the same idempotency key without worrying about creating duplicate orders.  See [Idempotency](/basics/api101/idempotency) for more information..</param>
        /// <param name="ReferenceId">__Deprecated__: Please set the reference_id on the nested [order](#type-order) field instead.  An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters..</param>
        /// <param name="LineItems">__Deprecated__: Please set the line_items on the nested [order](#type-order) field instead.  The line items to associate with this order.  Each line item represents a different product to include in a purchase..</param>
        /// <param name="Taxes">__Deprecated__: Please set the taxes on the nested [order](#type-order) field instead.  The taxes to include on the order..</param>
        /// <param name="Discounts">__Deprecated__: Please set the discounts on the nested [order](#type-order) field instead.  The discounts to include on the order..</param>
        public CreateOrderRequest(Order Order = default(Order), string IdempotencyKey = default(string), string ReferenceId = default(string), List<CreateOrderRequestLineItem> LineItems = default(List<CreateOrderRequestLineItem>), List<CreateOrderRequestTax> Taxes = default(List<CreateOrderRequestTax>), List<CreateOrderRequestDiscount> Discounts = default(List<CreateOrderRequestDiscount>))
        {
            this.Order = Order;
            this.IdempotencyKey = IdempotencyKey;
            this.ReferenceId = ReferenceId;
            this.LineItems = LineItems;
            this.Taxes = Taxes;
            this.Discounts = Discounts;
        }
        
        /// <summary>
        /// The order to create. If this field is set, then the only other top-level field that can be set is the idempotency_key.
        /// </summary>
        /// <value>The order to create. If this field is set, then the only other top-level field that can be set is the idempotency_key.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }
        /// <summary>
        /// A value you specify that uniquely identifies this order among orders you&#39;ve created.  If you&#39;re unsure whether a particular order was created successfully, you can reattempt it with the same idempotency key without worrying about creating duplicate orders.  See [Idempotency](/basics/api101/idempotency) for more information.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this order among orders you&#39;ve created.  If you&#39;re unsure whether a particular order was created successfully, you can reattempt it with the same idempotency key without worrying about creating duplicate orders.  See [Idempotency](/basics/api101/idempotency) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// __Deprecated__: Please set the reference_id on the nested [order](#type-order) field instead.  An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters.
        /// </summary>
        /// <value>__Deprecated__: Please set the reference_id on the nested [order](#type-order) field instead.  An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// __Deprecated__: Please set the line_items on the nested [order](#type-order) field instead.  The line items to associate with this order.  Each line item represents a different product to include in a purchase.
        /// </summary>
        /// <value>__Deprecated__: Please set the line_items on the nested [order](#type-order) field instead.  The line items to associate with this order.  Each line item represents a different product to include in a purchase.</value>
        [DataMember(Name="line_items", EmitDefaultValue=false)]
        public List<CreateOrderRequestLineItem> LineItems { get; set; }
        /// <summary>
        /// __Deprecated__: Please set the taxes on the nested [order](#type-order) field instead.  The taxes to include on the order.
        /// </summary>
        /// <value>__Deprecated__: Please set the taxes on the nested [order](#type-order) field instead.  The taxes to include on the order.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<CreateOrderRequestTax> Taxes { get; set; }
        /// <summary>
        /// __Deprecated__: Please set the discounts on the nested [order](#type-order) field instead.  The discounts to include on the order.
        /// </summary>
        /// <value>__Deprecated__: Please set the discounts on the nested [order](#type-order) field instead.  The discounts to include on the order.</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public List<CreateOrderRequestDiscount> Discounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequest {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
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
            return this.Equals(obj as CreateOrderRequest);
        }

        /// <summary>
        /// Returns true if CreateOrderRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(other.Taxes)
                ) && 
                (
                    this.Discounts == other.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.SequenceEqual(other.Discounts)
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
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.Discounts != null)
                    hash = hash * 59 + this.Discounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) maxLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length > 192)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be less than 192.", new [] { "IdempotencyKey" });
            }

            // ReferenceId (string) maxLength
            if(this.ReferenceId != null && this.ReferenceId.Length > 40)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 40.", new [] { "ReferenceId" });
            }

            yield break;
        }
    }

}
