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
    /// Creates a payment from the source (nonce, card on file, etc.)  The &#x60;PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS&#x60; OAuth permission is required to enable application fees.  For more information, see [Payments and Refunds Overview](/payments-api/overview).  For information about application fees in a payment, see  [Collect Fees](/payments-api/take-payments-and-collect-fees).
    /// </summary>
    [DataContract]
    public partial class CreatePaymentRequest :  IEquatable<CreatePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest" /> class.
        /// </summary>
        /// <param name="SourceId">The ID for the source of funds for this payment.  This can be a nonce generated by the Payment Form or a card on file made with the Customers API. (required).</param>
        /// <param name="IdempotencyKey">A unique string that identifies this CreatePayment request. Keys can be any valid string but must be unique for every CreatePayment request.   Max: 45 characters  See [Idempotency keys](https://developer.squareup.com/docs/basics/api101/idempotency) for more information. (required).</param>
        /// <param name="AmountMoney">The amount of money to accept for this payment, not including &#x60;tip_money&#x60;.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment. (required).</param>
        /// <param name="TipMoney">The amount designated as a tip, in addition to &#x60;amount_money&#x60;  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment..</param>
        /// <param name="AppFeeMoney">The amount of money the developer is taking as a fee for facilitating the payment on behalf of the seller.  Cannot be more than 90% of the total amount of the Payment.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.  For more information about the application fee scenario, see   [Collect Fees](https://developer.squareup.com/docs/payments-api/take-payments-and-collect-fees)..</param>
        /// <param name="Autocomplete">If set to &#x60;true&#x60;, this payment will be completed when possible. If set to &#x60;false&#x60;, this payment will be held in an approved state until either explicitly completed (captured) or canceled (voided). For more information, see  [Delayed Payments](https://developer.squareup.com/docs/payments-api/take-payments#delayed-payments).  Default: true.</param>
        /// <param name="OrderId">Associate a previously created order with this payment.</param>
        /// <param name="CustomerId">The ID of the customer associated with the payment. Required if the &#x60;source_id&#x60; refers to a card on file created using the Customers API..</param>
        /// <param name="LocationId">The location ID to associate with the payment. If not specified, the default location is used..</param>
        /// <param name="ReferenceId">A user-defined ID to associate with the payment. You can use this field to associate the payment to an entity in an external system. For example, you might specify an order ID that is generated by a third-party shopping cart.  Limit 40 characters..</param>
        /// <param name="VerificationToken">An identifying token generated by &#x60;SqPaymentForm.verifyBuyer()&#x60;. Verification tokens encapsulate customer device information and 3-D Secure challenge results to indicate that Square has verified the buyer identity.  See the [SCA Overview](https://developer.squareup.com/sca-overview) for more..</param>
        /// <param name="AcceptPartialAuthorization">[beta] If set to true and charging a Square Gift Card, a payment may be returned with amount_money equal to less than what was requested.  Example, a request for $20 when charging a Square Gift Card with balance of $5 wil result in an APPROVED payment of $5.  You may choose to prompt the buyer for an additional payment to cover the remainder, or cancel the gift card payment.  Cannot be &#x60;true&#x60; when &#x60;autocomplete &#x3D; true&#x60;.  For more information, see  [Partial amount with Square gift cards](https://developer.squareup.com/docs/payments-api/take-payments#partial-payment-gift-card).  Default: false.</param>
        /// <param name="BuyerEmailAddress">The buyer&#39;s e-mail address.</param>
        /// <param name="BillingAddress">The buyer&#39;s billing address..</param>
        /// <param name="ShippingAddress">The buyer&#39;s shipping address..</param>
        /// <param name="Note">An optional note to be entered by the developer when creating a payment  Limit 500 characters..</param>
        /// <param name="StatementDescriptionIdentifier">[beta] Optional additional payment information to include on the customer&#39;s card statement as part of statement description. This can be, for example, an invoice number, ticket number, or short description that uniquely identifies the purchase.  Limit 20 characters.  Note that the statement_description_identifier may get truncated on the statement description to fit the required information including the Square identifier (SQ *) and name of the merchant taking the payment..</param>
        public CreatePaymentRequest(string SourceId = default(string), string IdempotencyKey = default(string), Money AmountMoney = default(Money), Money TipMoney = default(Money), Money AppFeeMoney = default(Money), bool? Autocomplete = default(bool?), string OrderId = default(string), string CustomerId = default(string), string LocationId = default(string), string ReferenceId = default(string), string VerificationToken = default(string), bool? AcceptPartialAuthorization = default(bool?), string BuyerEmailAddress = default(string), Address BillingAddress = default(Address), Address ShippingAddress = default(Address), string Note = default(string), string StatementDescriptionIdentifier = default(string))
        {
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for CreatePaymentRequest and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for CreatePaymentRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for CreatePaymentRequest and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.TipMoney = TipMoney;
            this.AppFeeMoney = AppFeeMoney;
            this.Autocomplete = Autocomplete;
            this.OrderId = OrderId;
            this.CustomerId = CustomerId;
            this.LocationId = LocationId;
            this.ReferenceId = ReferenceId;
            this.VerificationToken = VerificationToken;
            this.AcceptPartialAuthorization = AcceptPartialAuthorization;
            this.BuyerEmailAddress = BuyerEmailAddress;
            this.BillingAddress = BillingAddress;
            this.ShippingAddress = ShippingAddress;
            this.Note = Note;
            this.StatementDescriptionIdentifier = StatementDescriptionIdentifier;
        }
        
        /// <summary>
        /// The ID for the source of funds for this payment.  This can be a nonce generated by the Payment Form or a card on file made with the Customers API.
        /// </summary>
        /// <value>The ID for the source of funds for this payment.  This can be a nonce generated by the Payment Form or a card on file made with the Customers API.</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public string SourceId { get; set; }
        /// <summary>
        /// A unique string that identifies this CreatePayment request. Keys can be any valid string but must be unique for every CreatePayment request.   Max: 45 characters  See [Idempotency keys](https://developer.squareup.com/docs/basics/api101/idempotency) for more information.
        /// </summary>
        /// <value>A unique string that identifies this CreatePayment request. Keys can be any valid string but must be unique for every CreatePayment request.   Max: 45 characters  See [Idempotency keys](https://developer.squareup.com/docs/basics/api101/idempotency) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// The amount of money to accept for this payment, not including &#x60;tip_money&#x60;.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.
        /// </summary>
        /// <value>The amount of money to accept for this payment, not including &#x60;tip_money&#x60;.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The amount designated as a tip, in addition to &#x60;amount_money&#x60;  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.
        /// </summary>
        /// <value>The amount designated as a tip, in addition to &#x60;amount_money&#x60;  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.</value>
        [DataMember(Name="tip_money", EmitDefaultValue=false)]
        public Money TipMoney { get; set; }
        /// <summary>
        /// The amount of money the developer is taking as a fee for facilitating the payment on behalf of the seller.  Cannot be more than 90% of the total amount of the Payment.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.  For more information about the application fee scenario, see   [Collect Fees](https://developer.squareup.com/docs/payments-api/take-payments-and-collect-fees).
        /// </summary>
        /// <value>The amount of money the developer is taking as a fee for facilitating the payment on behalf of the seller.  Cannot be more than 90% of the total amount of the Payment.  Must be specified in the smallest denomination of the applicable currency. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  The currency code must match the currency associated with the business that is accepting the payment.  For more information about the application fee scenario, see   [Collect Fees](https://developer.squareup.com/docs/payments-api/take-payments-and-collect-fees).</value>
        [DataMember(Name="app_fee_money", EmitDefaultValue=false)]
        public Money AppFeeMoney { get; set; }
        /// <summary>
        /// If set to &#x60;true&#x60;, this payment will be completed when possible. If set to &#x60;false&#x60;, this payment will be held in an approved state until either explicitly completed (captured) or canceled (voided). For more information, see  [Delayed Payments](https://developer.squareup.com/docs/payments-api/take-payments#delayed-payments).  Default: true
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, this payment will be completed when possible. If set to &#x60;false&#x60;, this payment will be held in an approved state until either explicitly completed (captured) or canceled (voided). For more information, see  [Delayed Payments](https://developer.squareup.com/docs/payments-api/take-payments#delayed-payments).  Default: true</value>
        [DataMember(Name="autocomplete", EmitDefaultValue=false)]
        public bool? Autocomplete { get; set; }
        /// <summary>
        /// Associate a previously created order with this payment
        /// </summary>
        /// <value>Associate a previously created order with this payment</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }
        /// <summary>
        /// The ID of the customer associated with the payment. Required if the &#x60;source_id&#x60; refers to a card on file created using the Customers API.
        /// </summary>
        /// <value>The ID of the customer associated with the payment. Required if the &#x60;source_id&#x60; refers to a card on file created using the Customers API.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// The location ID to associate with the payment. If not specified, the default location is used.
        /// </summary>
        /// <value>The location ID to associate with the payment. If not specified, the default location is used.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// A user-defined ID to associate with the payment. You can use this field to associate the payment to an entity in an external system. For example, you might specify an order ID that is generated by a third-party shopping cart.  Limit 40 characters.
        /// </summary>
        /// <value>A user-defined ID to associate with the payment. You can use this field to associate the payment to an entity in an external system. For example, you might specify an order ID that is generated by a third-party shopping cart.  Limit 40 characters.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// An identifying token generated by &#x60;SqPaymentForm.verifyBuyer()&#x60;. Verification tokens encapsulate customer device information and 3-D Secure challenge results to indicate that Square has verified the buyer identity.  See the [SCA Overview](https://developer.squareup.com/sca-overview) for more.
        /// </summary>
        /// <value>An identifying token generated by &#x60;SqPaymentForm.verifyBuyer()&#x60;. Verification tokens encapsulate customer device information and 3-D Secure challenge results to indicate that Square has verified the buyer identity.  See the [SCA Overview](https://developer.squareup.com/sca-overview) for more.</value>
        [DataMember(Name="verification_token", EmitDefaultValue=false)]
        public string VerificationToken { get; set; }
        /// <summary>
        /// If set to true and charging a Square Gift Card, a payment may be returned with amount_money equal to less than what was requested.  Example, a request for $20 when charging a Square Gift Card with balance of $5 wil result in an APPROVED payment of $5.  You may choose to prompt the buyer for an additional payment to cover the remainder, or cancel the gift card payment.  Cannot be &#x60;true&#x60; when &#x60;autocomplete &#x3D; true&#x60;.  For more information, see  [Partial amount with Square gift cards](https://developer.squareup.com/docs/payments-api/take-payments#partial-payment-gift-card).  Default: false
        /// </summary>
        /// <value>If set to true and charging a Square Gift Card, a payment may be returned with amount_money equal to less than what was requested.  Example, a request for $20 when charging a Square Gift Card with balance of $5 wil result in an APPROVED payment of $5.  You may choose to prompt the buyer for an additional payment to cover the remainder, or cancel the gift card payment.  Cannot be &#x60;true&#x60; when &#x60;autocomplete &#x3D; true&#x60;.  For more information, see  [Partial amount with Square gift cards](https://developer.squareup.com/docs/payments-api/take-payments#partial-payment-gift-card).  Default: false</value>
        [DataMember(Name="accept_partial_authorization", EmitDefaultValue=false)]
        public bool? AcceptPartialAuthorization { get; set; }
        /// <summary>
        /// The buyer&#39;s e-mail address
        /// </summary>
        /// <value>The buyer&#39;s e-mail address</value>
        [DataMember(Name="buyer_email_address", EmitDefaultValue=false)]
        public string BuyerEmailAddress { get; set; }
        /// <summary>
        /// The buyer&#39;s billing address.
        /// </summary>
        /// <value>The buyer&#39;s billing address.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
        /// <summary>
        /// The buyer&#39;s shipping address.
        /// </summary>
        /// <value>The buyer&#39;s shipping address.</value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }
        /// <summary>
        /// An optional note to be entered by the developer when creating a payment  Limit 500 characters.
        /// </summary>
        /// <value>An optional note to be entered by the developer when creating a payment  Limit 500 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// Optional additional payment information to include on the customer&#39;s card statement as part of statement description. This can be, for example, an invoice number, ticket number, or short description that uniquely identifies the purchase.  Limit 20 characters.  Note that the statement_description_identifier may get truncated on the statement description to fit the required information including the Square identifier (SQ *) and name of the merchant taking the payment.
        /// </summary>
        /// <value>Optional additional payment information to include on the customer&#39;s card statement as part of statement description. This can be, for example, an invoice number, ticket number, or short description that uniquely identifies the purchase.  Limit 20 characters.  Note that the statement_description_identifier may get truncated on the statement description to fit the required information including the Square identifier (SQ *) and name of the merchant taking the payment.</value>
        [DataMember(Name="statement_description_identifier", EmitDefaultValue=false)]
        public string StatementDescriptionIdentifier { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentRequest {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  TipMoney: ").Append(TipMoney).Append("\n");
            sb.Append("  AppFeeMoney: ").Append(AppFeeMoney).Append("\n");
            sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  VerificationToken: ").Append(VerificationToken).Append("\n");
            sb.Append("  AcceptPartialAuthorization: ").Append(AcceptPartialAuthorization).Append("\n");
            sb.Append("  BuyerEmailAddress: ").Append(BuyerEmailAddress).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  StatementDescriptionIdentifier: ").Append(StatementDescriptionIdentifier).Append("\n");
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
            return this.Equals(obj as CreatePaymentRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.TipMoney == other.TipMoney ||
                    this.TipMoney != null &&
                    this.TipMoney.Equals(other.TipMoney)
                ) && 
                (
                    this.AppFeeMoney == other.AppFeeMoney ||
                    this.AppFeeMoney != null &&
                    this.AppFeeMoney.Equals(other.AppFeeMoney)
                ) && 
                (
                    this.Autocomplete == other.Autocomplete ||
                    this.Autocomplete != null &&
                    this.Autocomplete.Equals(other.Autocomplete)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
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
                    this.VerificationToken == other.VerificationToken ||
                    this.VerificationToken != null &&
                    this.VerificationToken.Equals(other.VerificationToken)
                ) && 
                (
                    this.AcceptPartialAuthorization == other.AcceptPartialAuthorization ||
                    this.AcceptPartialAuthorization != null &&
                    this.AcceptPartialAuthorization.Equals(other.AcceptPartialAuthorization)
                ) && 
                (
                    this.BuyerEmailAddress == other.BuyerEmailAddress ||
                    this.BuyerEmailAddress != null &&
                    this.BuyerEmailAddress.Equals(other.BuyerEmailAddress)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.StatementDescriptionIdentifier == other.StatementDescriptionIdentifier ||
                    this.StatementDescriptionIdentifier != null &&
                    this.StatementDescriptionIdentifier.Equals(other.StatementDescriptionIdentifier)
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
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.TipMoney != null)
                    hash = hash * 59 + this.TipMoney.GetHashCode();
                if (this.AppFeeMoney != null)
                    hash = hash * 59 + this.AppFeeMoney.GetHashCode();
                if (this.Autocomplete != null)
                    hash = hash * 59 + this.Autocomplete.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.VerificationToken != null)
                    hash = hash * 59 + this.VerificationToken.GetHashCode();
                if (this.AcceptPartialAuthorization != null)
                    hash = hash * 59 + this.AcceptPartialAuthorization.GetHashCode();
                if (this.BuyerEmailAddress != null)
                    hash = hash * 59 + this.BuyerEmailAddress.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.StatementDescriptionIdentifier != null)
                    hash = hash * 59 + this.StatementDescriptionIdentifier.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // SourceId (string) minLength
            if(this.SourceId != null && this.SourceId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for SourceId, length must be greater than 1.", new [] { "SourceId" });
            }

            // IdempotencyKey (string) maxLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length > 45)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be less than 45.", new [] { "IdempotencyKey" });
            }

            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            // ReferenceId (string) maxLength
            if(this.ReferenceId != null && this.ReferenceId.Length > 40)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 40.", new [] { "ReferenceId" });
            }

            // BuyerEmailAddress (string) maxLength
            if(this.BuyerEmailAddress != null && this.BuyerEmailAddress.Length > 255)
            {
                yield return new ValidationResult("Invalid value for BuyerEmailAddress, length must be less than 255.", new [] { "BuyerEmailAddress" });
            }

            // Note (string) maxLength
            if(this.Note != null && this.Note.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Note, length must be less than 500.", new [] { "Note" });
            }

            // StatementDescriptionIdentifier (string) maxLength
            if(this.StatementDescriptionIdentifier != null && this.StatementDescriptionIdentifier.Length > 20)
            {
                yield return new ValidationResult("Invalid value for StatementDescriptionIdentifier, length must be less than 20.", new [] { "StatementDescriptionIdentifier" });
            }

            yield break;
        }
    }

}
