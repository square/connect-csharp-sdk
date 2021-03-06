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
    /// A refund of an [AdditionalRecipientReceivable](#type-additionalrecipientreceivable). This includes the ID of the additional recipient receivable associated to this object, as well as a reference to the [Refund](#type-refund) that created this receivable refund.
    /// </summary>
    [DataContract]
    [Obsolete]
    public partial class AdditionalRecipientReceivableRefund :  IEquatable<AdditionalRecipientReceivableRefund>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalRecipientReceivableRefund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalRecipientReceivableRefund() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalRecipientReceivableRefund" /> class.
        /// </summary>
        /// <param name="Id">The receivable refund&#39;s unique ID, issued by Square payments servers. (required).</param>
        /// <param name="ReceivableId">The ID of the receivable that the refund was applied to. (required).</param>
        /// <param name="RefundId">The ID of the refund that is associated to this receivable refund. (required).</param>
        /// <param name="TransactionLocationId">The ID of the location that created the receivable. This is the location ID on the associated transaction. (required).</param>
        /// <param name="AmountMoney">The amount of the refund. This will always be non-negative. (required).</param>
        /// <param name="CreatedAt">The time when the refund was created, in RFC 3339 format..</param>
        public AdditionalRecipientReceivableRefund(string Id = default(string), string ReceivableId = default(string), string RefundId = default(string), string TransactionLocationId = default(string), Money AmountMoney = default(Money), string CreatedAt = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for AdditionalRecipientReceivableRefund and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ReceivableId" is required (not null)
            if (ReceivableId == null)
            {
                throw new InvalidDataException("ReceivableId is a required property for AdditionalRecipientReceivableRefund and cannot be null");
            }
            else
            {
                this.ReceivableId = ReceivableId;
            }
            // to ensure "RefundId" is required (not null)
            if (RefundId == null)
            {
                throw new InvalidDataException("RefundId is a required property for AdditionalRecipientReceivableRefund and cannot be null");
            }
            else
            {
                this.RefundId = RefundId;
            }
            // to ensure "TransactionLocationId" is required (not null)
            if (TransactionLocationId == null)
            {
                throw new InvalidDataException("TransactionLocationId is a required property for AdditionalRecipientReceivableRefund and cannot be null");
            }
            else
            {
                this.TransactionLocationId = TransactionLocationId;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for AdditionalRecipientReceivableRefund and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.CreatedAt = CreatedAt;
        }
        
        /// <summary>
        /// The receivable refund&#39;s unique ID, issued by Square payments servers.
        /// </summary>
        /// <value>The receivable refund&#39;s unique ID, issued by Square payments servers.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the receivable that the refund was applied to.
        /// </summary>
        /// <value>The ID of the receivable that the refund was applied to.</value>
        [DataMember(Name="receivable_id", EmitDefaultValue=false)]
        public string ReceivableId { get; set; }
        /// <summary>
        /// The ID of the refund that is associated to this receivable refund.
        /// </summary>
        /// <value>The ID of the refund that is associated to this receivable refund.</value>
        [DataMember(Name="refund_id", EmitDefaultValue=false)]
        public string RefundId { get; set; }
        /// <summary>
        /// The ID of the location that created the receivable. This is the location ID on the associated transaction.
        /// </summary>
        /// <value>The ID of the location that created the receivable. This is the location ID on the associated transaction.</value>
        [DataMember(Name="transaction_location_id", EmitDefaultValue=false)]
        public string TransactionLocationId { get; set; }
        /// <summary>
        /// The amount of the refund. This will always be non-negative.
        /// </summary>
        /// <value>The amount of the refund. This will always be non-negative.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The time when the refund was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the refund was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalRecipientReceivableRefund {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReceivableId: ").Append(ReceivableId).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  TransactionLocationId: ").Append(TransactionLocationId).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(obj as AdditionalRecipientReceivableRefund);
        }

        /// <summary>
        /// Returns true if AdditionalRecipientReceivableRefund instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalRecipientReceivableRefund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalRecipientReceivableRefund other)
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
                    this.ReceivableId == other.ReceivableId ||
                    this.ReceivableId != null &&
                    this.ReceivableId.Equals(other.ReceivableId)
                ) && 
                (
                    this.RefundId == other.RefundId ||
                    this.RefundId != null &&
                    this.RefundId.Equals(other.RefundId)
                ) && 
                (
                    this.TransactionLocationId == other.TransactionLocationId ||
                    this.TransactionLocationId != null &&
                    this.TransactionLocationId.Equals(other.TransactionLocationId)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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
                if (this.ReceivableId != null)
                    hash = hash * 59 + this.ReceivableId.GetHashCode();
                if (this.RefundId != null)
                    hash = hash * 59 + this.RefundId.GetHashCode();
                if (this.TransactionLocationId != null)
                    hash = hash * 59 + this.TransactionLocationId.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // ReceivableId (string) minLength
            if(this.ReceivableId != null && this.ReceivableId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ReceivableId, length must be greater than 1.", new [] { "ReceivableId" });
            }

            // RefundId (string) minLength
            if(this.RefundId != null && this.RefundId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RefundId, length must be greater than 1.", new [] { "RefundId" });
            }

            // TransactionLocationId (string) minLength
            if(this.TransactionLocationId != null && this.TransactionLocationId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for TransactionLocationId, length must be greater than 1.", new [] { "TransactionLocationId" });
            }

            yield break;
        }
    }

}
