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
    /// Contains all information related to a single order to process with Square, including line items that specify the products to purchase. Order objects also include information on any associated tenders, refunds, and returns.  All Connect V2 Transactions have all been converted to Orders including all associated itemization data.
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Order() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Id">The order&#39;s unique ID..</param>
        /// <param name="LocationId">The ID of the merchant location this order is associated with. (required).</param>
        /// <param name="ReferenceId">A client specified identifier to associate an entity in another system with this order..</param>
        /// <param name="Source">The origination details of the order..</param>
        /// <param name="CustomerId">[beta] The &#x60;Customer&#x60; ID of the customer associated with the order..</param>
        /// <param name="LineItems">The line items included in the order..</param>
        /// <param name="Taxes">The list of all taxes associated with the order.  Taxes can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For taxes with &#x60;LINE_ITEM&#x60; scope, an &#x60;OrderLineItemAppliedTax&#x60; must be added to each line item that the tax applies to. For taxes with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedTax&#x60; for every line item.  On reads, each tax in the list will include the total amount of that tax applied to the order.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any taxes in this field, usage of the deprecated &#x60;line_items.taxes&#x60; field will result in an error. Please use &#x60;line_items.applied_taxes&#x60; instead..</param>
        /// <param name="Discounts">The list of all discounts associated with the order.  Discounts can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For discounts scoped to &#x60;LINE_ITEM&#x60;, an &#x60;OrderLineItemAppliedDiscount&#x60; must be added to each line item that the discount applies to. For discounts with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedDiscount&#x60; for every line item.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any discounts in this field, usage of the deprecated &#x60;line_items.discounts&#x60; field will result in an error. Please use &#x60;line_items.applied_discounts&#x60; instead..</param>
        /// <param name="ServiceCharges">A list of service charges applied to the order..</param>
        /// <param name="Fulfillments">Details on order fulfillment.  Orders can only be created with at most one fulfillment. However, orders returned by the API may contain multiple fulfillments..</param>
        /// <param name="Returns">[beta] Collection of items from sale Orders being returned in this one. Normally part of an Itemized Return or Exchange.  There will be exactly one &#x60;Return&#x60; object per sale Order being referenced..</param>
        /// <param name="ReturnAmounts">Rollup of returned money amounts..</param>
        /// <param name="NetAmounts">Net money amounts (sale money - return money)..</param>
        /// <param name="RoundingAdjustment">A positive or negative rounding adjustment to the total of the order, commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency..</param>
        /// <param name="Tenders">[beta] The Tenders which were used to pay for the Order..</param>
        /// <param name="Refunds">[beta] The Refunds that are part of this Order..</param>
        /// <param name="Metadata">[beta] Application-defined data attached to this order. Metadata fields are intended to store descriptive references or associations with an entity in another system or store brief information about the object. Square does not process this field; it only stores and returns it in relevant API calls. Do not use metadata to store any sensitive information (personally identifiable information, card details, etc.).  Keys written by applications must be 60 characters or less and must be in the character set &#x60;[a-zA-Z0-9_-]&#x60;. Entries may also include metadata generated by Square. These keys are prefixed with a namespace, separated from the key with a &#39;:&#39; character.  Values have a max length of 255 characters.  An application may have up to 10 entries per metadata field.  Entries written by applications are private and can only be read or modified by the same application.  See [Metadata](https://developer.squareup.com/docs/build-basics/metadata) for more information..</param>
        /// <param name="CreatedAt">Timestamp for when the order was created. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="UpdatedAt">Timestamp for when the order was last updated. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="ClosedAt">Timestamp for when the order was closed. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="State">The current state of the order. &#x60;OPEN&#x60;,&#x60;COMPLETED&#x60;,&#x60;CANCELED&#x60; See [OrderState](#type-orderstate) for possible values.</param>
        /// <param name="Version">[beta] Version number which is incremented each time an update is committed to the order. Orders that were not created through the API will not include a version and thus cannot be updated.  [Read more about working with versions](https://developer.squareup.com/docs/orders-api/manage-orders#update-orders)..</param>
        /// <param name="TotalMoney">The total amount of money to collect for the order..</param>
        /// <param name="TotalTaxMoney">The total tax amount of money to collect for the order..</param>
        /// <param name="TotalDiscountMoney">The total discount amount of money to collect for the order..</param>
        /// <param name="TotalServiceChargeMoney">The total amount of money collected in service charges for the order.  Note: &#x60;total_service_charge_money&#x60; is the sum of &#x60;applied_money&#x60; fields for each individual service charge. Therefore, &#x60;total_service_charge_money&#x60; will only include inclusive tax amounts, not additive tax amounts..</param>
        public Order(string Id = default(string), string LocationId = default(string), string ReferenceId = default(string), OrderSource Source = default(OrderSource), string CustomerId = default(string), List<OrderLineItem> LineItems = default(List<OrderLineItem>), List<OrderLineItemTax> Taxes = default(List<OrderLineItemTax>), List<OrderLineItemDiscount> Discounts = default(List<OrderLineItemDiscount>), List<OrderServiceCharge> ServiceCharges = default(List<OrderServiceCharge>), List<OrderFulfillment> Fulfillments = default(List<OrderFulfillment>), List<OrderReturn> Returns = default(List<OrderReturn>), OrderMoneyAmounts ReturnAmounts = default(OrderMoneyAmounts), OrderMoneyAmounts NetAmounts = default(OrderMoneyAmounts), OrderRoundingAdjustment RoundingAdjustment = default(OrderRoundingAdjustment), List<Tender> Tenders = default(List<Tender>), List<Refund> Refunds = default(List<Refund>), Dictionary<string, string> Metadata = default(Dictionary<string, string>), string CreatedAt = default(string), string UpdatedAt = default(string), string ClosedAt = default(string), string State = default(string), int? Version = default(int?), Money TotalMoney = default(Money), Money TotalTaxMoney = default(Money), Money TotalDiscountMoney = default(Money), Money TotalServiceChargeMoney = default(Money))
        {
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for Order and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            this.Id = Id;
            this.ReferenceId = ReferenceId;
            this.Source = Source;
            this.CustomerId = CustomerId;
            this.LineItems = LineItems;
            this.Taxes = Taxes;
            this.Discounts = Discounts;
            this.ServiceCharges = ServiceCharges;
            this.Fulfillments = Fulfillments;
            this.Returns = Returns;
            this.ReturnAmounts = ReturnAmounts;
            this.NetAmounts = NetAmounts;
            this.RoundingAdjustment = RoundingAdjustment;
            this.Tenders = Tenders;
            this.Refunds = Refunds;
            this.Metadata = Metadata;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.ClosedAt = ClosedAt;
            this.State = State;
            this.Version = Version;
            this.TotalMoney = TotalMoney;
            this.TotalTaxMoney = TotalTaxMoney;
            this.TotalDiscountMoney = TotalDiscountMoney;
            this.TotalServiceChargeMoney = TotalServiceChargeMoney;
        }
        
        /// <summary>
        /// The order&#39;s unique ID.
        /// </summary>
        /// <value>The order&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the merchant location this order is associated with.
        /// </summary>
        /// <value>The ID of the merchant location this order is associated with.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// A client specified identifier to associate an entity in another system with this order.
        /// </summary>
        /// <value>A client specified identifier to associate an entity in another system with this order.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// The origination details of the order.
        /// </summary>
        /// <value>The origination details of the order.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public OrderSource Source { get; set; }
        /// <summary>
        /// The &#x60;Customer&#x60; ID of the customer associated with the order.
        /// </summary>
        /// <value>The &#x60;Customer&#x60; ID of the customer associated with the order.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// The line items included in the order.
        /// </summary>
        /// <value>The line items included in the order.</value>
        [DataMember(Name="line_items", EmitDefaultValue=false)]
        public List<OrderLineItem> LineItems { get; set; }
        /// <summary>
        /// The list of all taxes associated with the order.  Taxes can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For taxes with &#x60;LINE_ITEM&#x60; scope, an &#x60;OrderLineItemAppliedTax&#x60; must be added to each line item that the tax applies to. For taxes with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedTax&#x60; for every line item.  On reads, each tax in the list will include the total amount of that tax applied to the order.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any taxes in this field, usage of the deprecated &#x60;line_items.taxes&#x60; field will result in an error. Please use &#x60;line_items.applied_taxes&#x60; instead.
        /// </summary>
        /// <value>The list of all taxes associated with the order.  Taxes can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For taxes with &#x60;LINE_ITEM&#x60; scope, an &#x60;OrderLineItemAppliedTax&#x60; must be added to each line item that the tax applies to. For taxes with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedTax&#x60; for every line item.  On reads, each tax in the list will include the total amount of that tax applied to the order.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any taxes in this field, usage of the deprecated &#x60;line_items.taxes&#x60; field will result in an error. Please use &#x60;line_items.applied_taxes&#x60; instead.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<OrderLineItemTax> Taxes { get; set; }
        /// <summary>
        /// The list of all discounts associated with the order.  Discounts can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For discounts scoped to &#x60;LINE_ITEM&#x60;, an &#x60;OrderLineItemAppliedDiscount&#x60; must be added to each line item that the discount applies to. For discounts with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedDiscount&#x60; for every line item.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any discounts in this field, usage of the deprecated &#x60;line_items.discounts&#x60; field will result in an error. Please use &#x60;line_items.applied_discounts&#x60; instead.
        /// </summary>
        /// <value>The list of all discounts associated with the order.  Discounts can be scoped to either &#x60;ORDER&#x60; or &#x60;LINE_ITEM&#x60;. For discounts scoped to &#x60;LINE_ITEM&#x60;, an &#x60;OrderLineItemAppliedDiscount&#x60; must be added to each line item that the discount applies to. For discounts with &#x60;ORDER&#x60; scope, the server will generate an &#x60;OrderLineItemAppliedDiscount&#x60; for every line item.  __IMPORTANT__: If &#x60;LINE_ITEM&#x60; scope is set on any discounts in this field, usage of the deprecated &#x60;line_items.discounts&#x60; field will result in an error. Please use &#x60;line_items.applied_discounts&#x60; instead.</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public List<OrderLineItemDiscount> Discounts { get; set; }
        /// <summary>
        /// A list of service charges applied to the order.
        /// </summary>
        /// <value>A list of service charges applied to the order.</value>
        [DataMember(Name="service_charges", EmitDefaultValue=false)]
        public List<OrderServiceCharge> ServiceCharges { get; set; }
        /// <summary>
        /// Details on order fulfillment.  Orders can only be created with at most one fulfillment. However, orders returned by the API may contain multiple fulfillments.
        /// </summary>
        /// <value>Details on order fulfillment.  Orders can only be created with at most one fulfillment. However, orders returned by the API may contain multiple fulfillments.</value>
        [DataMember(Name="fulfillments", EmitDefaultValue=false)]
        public List<OrderFulfillment> Fulfillments { get; set; }
        /// <summary>
        /// Collection of items from sale Orders being returned in this one. Normally part of an Itemized Return or Exchange.  There will be exactly one &#x60;Return&#x60; object per sale Order being referenced.
        /// </summary>
        /// <value>Collection of items from sale Orders being returned in this one. Normally part of an Itemized Return or Exchange.  There will be exactly one &#x60;Return&#x60; object per sale Order being referenced.</value>
        [DataMember(Name="returns", EmitDefaultValue=false)]
        public List<OrderReturn> Returns { get; set; }
        /// <summary>
        /// Rollup of returned money amounts.
        /// </summary>
        /// <value>Rollup of returned money amounts.</value>
        [DataMember(Name="return_amounts", EmitDefaultValue=false)]
        public OrderMoneyAmounts ReturnAmounts { get; set; }
        /// <summary>
        /// Net money amounts (sale money - return money).
        /// </summary>
        /// <value>Net money amounts (sale money - return money).</value>
        [DataMember(Name="net_amounts", EmitDefaultValue=false)]
        public OrderMoneyAmounts NetAmounts { get; set; }
        /// <summary>
        /// A positive or negative rounding adjustment to the total of the order, commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.
        /// </summary>
        /// <value>A positive or negative rounding adjustment to the total of the order, commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.</value>
        [DataMember(Name="rounding_adjustment", EmitDefaultValue=false)]
        public OrderRoundingAdjustment RoundingAdjustment { get; set; }
        /// <summary>
        /// The Tenders which were used to pay for the Order.
        /// </summary>
        /// <value>The Tenders which were used to pay for the Order.</value>
        [DataMember(Name="tenders", EmitDefaultValue=false)]
        public List<Tender> Tenders { get; set; }
        /// <summary>
        /// The Refunds that are part of this Order.
        /// </summary>
        /// <value>The Refunds that are part of this Order.</value>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<Refund> Refunds { get; set; }
        /// <summary>
        /// Application-defined data attached to this order. Metadata fields are intended to store descriptive references or associations with an entity in another system or store brief information about the object. Square does not process this field; it only stores and returns it in relevant API calls. Do not use metadata to store any sensitive information (personally identifiable information, card details, etc.).  Keys written by applications must be 60 characters or less and must be in the character set &#x60;[a-zA-Z0-9_-]&#x60;. Entries may also include metadata generated by Square. These keys are prefixed with a namespace, separated from the key with a &#39;:&#39; character.  Values have a max length of 255 characters.  An application may have up to 10 entries per metadata field.  Entries written by applications are private and can only be read or modified by the same application.  See [Metadata](https://developer.squareup.com/docs/build-basics/metadata) for more information.
        /// </summary>
        /// <value>Application-defined data attached to this order. Metadata fields are intended to store descriptive references or associations with an entity in another system or store brief information about the object. Square does not process this field; it only stores and returns it in relevant API calls. Do not use metadata to store any sensitive information (personally identifiable information, card details, etc.).  Keys written by applications must be 60 characters or less and must be in the character set &#x60;[a-zA-Z0-9_-]&#x60;. Entries may also include metadata generated by Square. These keys are prefixed with a namespace, separated from the key with a &#39;:&#39; character.  Values have a max length of 255 characters.  An application may have up to 10 entries per metadata field.  Entries written by applications are private and can only be read or modified by the same application.  See [Metadata](https://developer.squareup.com/docs/build-basics/metadata) for more information.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }
        /// <summary>
        /// Timestamp for when the order was created. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>Timestamp for when the order was created. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Timestamp for when the order was last updated. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>Timestamp for when the order was last updated. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Timestamp for when the order was closed. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>Timestamp for when the order was closed. In RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="closed_at", EmitDefaultValue=false)]
        public string ClosedAt { get; set; }
        /// <summary>
        /// The current state of the order. &#x60;OPEN&#x60;,&#x60;COMPLETED&#x60;,&#x60;CANCELED&#x60; See [OrderState](#type-orderstate) for possible values
        /// </summary>
        /// <value>The current state of the order. &#x60;OPEN&#x60;,&#x60;COMPLETED&#x60;,&#x60;CANCELED&#x60; See [OrderState](#type-orderstate) for possible values</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Version number which is incremented each time an update is committed to the order. Orders that were not created through the API will not include a version and thus cannot be updated.  [Read more about working with versions](https://developer.squareup.com/docs/orders-api/manage-orders#update-orders).
        /// </summary>
        /// <value>Version number which is incremented each time an update is committed to the order. Orders that were not created through the API will not include a version and thus cannot be updated.  [Read more about working with versions](https://developer.squareup.com/docs/orders-api/manage-orders#update-orders).</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// The total amount of money to collect for the order.
        /// </summary>
        /// <value>The total amount of money to collect for the order.</value>
        [DataMember(Name="total_money", EmitDefaultValue=false)]
        public Money TotalMoney { get; set; }
        /// <summary>
        /// The total tax amount of money to collect for the order.
        /// </summary>
        /// <value>The total tax amount of money to collect for the order.</value>
        [DataMember(Name="total_tax_money", EmitDefaultValue=false)]
        public Money TotalTaxMoney { get; set; }
        /// <summary>
        /// The total discount amount of money to collect for the order.
        /// </summary>
        /// <value>The total discount amount of money to collect for the order.</value>
        [DataMember(Name="total_discount_money", EmitDefaultValue=false)]
        public Money TotalDiscountMoney { get; set; }
        /// <summary>
        /// The total amount of money collected in service charges for the order.  Note: &#x60;total_service_charge_money&#x60; is the sum of &#x60;applied_money&#x60; fields for each individual service charge. Therefore, &#x60;total_service_charge_money&#x60; will only include inclusive tax amounts, not additive tax amounts.
        /// </summary>
        /// <value>The total amount of money collected in service charges for the order.  Note: &#x60;total_service_charge_money&#x60; is the sum of &#x60;applied_money&#x60; fields for each individual service charge. Therefore, &#x60;total_service_charge_money&#x60; will only include inclusive tax amounts, not additive tax amounts.</value>
        [DataMember(Name="total_service_charge_money", EmitDefaultValue=false)]
        public Money TotalServiceChargeMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  ServiceCharges: ").Append(ServiceCharges).Append("\n");
            sb.Append("  Fulfillments: ").Append(Fulfillments).Append("\n");
            sb.Append("  Returns: ").Append(Returns).Append("\n");
            sb.Append("  ReturnAmounts: ").Append(ReturnAmounts).Append("\n");
            sb.Append("  NetAmounts: ").Append(NetAmounts).Append("\n");
            sb.Append("  RoundingAdjustment: ").Append(RoundingAdjustment).Append("\n");
            sb.Append("  Tenders: ").Append(Tenders).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
            sb.Append("  TotalTaxMoney: ").Append(TotalTaxMoney).Append("\n");
            sb.Append("  TotalDiscountMoney: ").Append(TotalDiscountMoney).Append("\n");
            sb.Append("  TotalServiceChargeMoney: ").Append(TotalServiceChargeMoney).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
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
                ) && 
                (
                    this.ServiceCharges == other.ServiceCharges ||
                    this.ServiceCharges != null &&
                    this.ServiceCharges.SequenceEqual(other.ServiceCharges)
                ) && 
                (
                    this.Fulfillments == other.Fulfillments ||
                    this.Fulfillments != null &&
                    this.Fulfillments.SequenceEqual(other.Fulfillments)
                ) && 
                (
                    this.Returns == other.Returns ||
                    this.Returns != null &&
                    this.Returns.SequenceEqual(other.Returns)
                ) && 
                (
                    this.ReturnAmounts == other.ReturnAmounts ||
                    this.ReturnAmounts != null &&
                    this.ReturnAmounts.Equals(other.ReturnAmounts)
                ) && 
                (
                    this.NetAmounts == other.NetAmounts ||
                    this.NetAmounts != null &&
                    this.NetAmounts.Equals(other.NetAmounts)
                ) && 
                (
                    this.RoundingAdjustment == other.RoundingAdjustment ||
                    this.RoundingAdjustment != null &&
                    this.RoundingAdjustment.Equals(other.RoundingAdjustment)
                ) && 
                (
                    this.Tenders == other.Tenders ||
                    this.Tenders != null &&
                    this.Tenders.SequenceEqual(other.Tenders)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(other.Metadata)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ClosedAt == other.ClosedAt ||
                    this.ClosedAt != null &&
                    this.ClosedAt.Equals(other.ClosedAt)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.TotalMoney == other.TotalMoney ||
                    this.TotalMoney != null &&
                    this.TotalMoney.Equals(other.TotalMoney)
                ) && 
                (
                    this.TotalTaxMoney == other.TotalTaxMoney ||
                    this.TotalTaxMoney != null &&
                    this.TotalTaxMoney.Equals(other.TotalTaxMoney)
                ) && 
                (
                    this.TotalDiscountMoney == other.TotalDiscountMoney ||
                    this.TotalDiscountMoney != null &&
                    this.TotalDiscountMoney.Equals(other.TotalDiscountMoney)
                ) && 
                (
                    this.TotalServiceChargeMoney == other.TotalServiceChargeMoney ||
                    this.TotalServiceChargeMoney != null &&
                    this.TotalServiceChargeMoney.Equals(other.TotalServiceChargeMoney)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.Discounts != null)
                    hash = hash * 59 + this.Discounts.GetHashCode();
                if (this.ServiceCharges != null)
                    hash = hash * 59 + this.ServiceCharges.GetHashCode();
                if (this.Fulfillments != null)
                    hash = hash * 59 + this.Fulfillments.GetHashCode();
                if (this.Returns != null)
                    hash = hash * 59 + this.Returns.GetHashCode();
                if (this.ReturnAmounts != null)
                    hash = hash * 59 + this.ReturnAmounts.GetHashCode();
                if (this.NetAmounts != null)
                    hash = hash * 59 + this.NetAmounts.GetHashCode();
                if (this.RoundingAdjustment != null)
                    hash = hash * 59 + this.RoundingAdjustment.GetHashCode();
                if (this.Tenders != null)
                    hash = hash * 59 + this.Tenders.GetHashCode();
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.ClosedAt != null)
                    hash = hash * 59 + this.ClosedAt.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.TotalMoney != null)
                    hash = hash * 59 + this.TotalMoney.GetHashCode();
                if (this.TotalTaxMoney != null)
                    hash = hash * 59 + this.TotalTaxMoney.GetHashCode();
                if (this.TotalDiscountMoney != null)
                    hash = hash * 59 + this.TotalDiscountMoney.GetHashCode();
                if (this.TotalServiceChargeMoney != null)
                    hash = hash * 59 + this.TotalServiceChargeMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // LocationId (string) minLength
            if(this.LocationId != null && this.LocationId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for LocationId, length must be greater than 1.", new [] { "LocationId" });
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
