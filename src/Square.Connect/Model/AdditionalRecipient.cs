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
    /// Represents an additional recipient (other than the merchant) receiving a portion of this tender.
    /// </summary>
    [DataContract]
    public partial class AdditionalRecipient :  IEquatable<AdditionalRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalRecipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalRecipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalRecipient" /> class.
        /// </summary>
        /// <param name="LocationId">The location ID for a recipient (other than the merchant) receiving a portion of this tender. (required).</param>
        /// <param name="Description">The description of the additional recipient. (required).</param>
        /// <param name="AmountMoney">The amount of money distributed to the recipient. (required).</param>
        /// <param name="ReceivableId">The unique ID for this &#x60;AdditionalRecipientReceivable&#x60;, assigned by the server..</param>
        public AdditionalRecipient(string LocationId = default(string), string Description = default(string), Money AmountMoney = default(Money), string ReceivableId = default(string))
        {
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for AdditionalRecipient and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for AdditionalRecipient and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for AdditionalRecipient and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.ReceivableId = ReceivableId;
        }
        
        /// <summary>
        /// The location ID for a recipient (other than the merchant) receiving a portion of this tender.
        /// </summary>
        /// <value>The location ID for a recipient (other than the merchant) receiving a portion of this tender.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The description of the additional recipient.
        /// </summary>
        /// <value>The description of the additional recipient.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The amount of money distributed to the recipient.
        /// </summary>
        /// <value>The amount of money distributed to the recipient.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The unique ID for this &#x60;AdditionalRecipientReceivable&#x60;, assigned by the server.
        /// </summary>
        /// <value>The unique ID for this &#x60;AdditionalRecipientReceivable&#x60;, assigned by the server.</value>
        [DataMember(Name="receivable_id", EmitDefaultValue=false)]
        public string ReceivableId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalRecipient {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  ReceivableId: ").Append(ReceivableId).Append("\n");
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
            return this.Equals(obj as AdditionalRecipient);
        }
        /// <summary>
        /// Returns true if AdditionalRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.ReceivableId == other.ReceivableId ||
                    this.ReceivableId != null &&
                    this.ReceivableId.Equals(other.ReceivableId)
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
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.ReceivableId != null)
                    hash = hash * 59 + this.ReceivableId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // LocationId (string) maxLength
            if(this.LocationId != null && this.LocationId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for LocationId, length must be less than 50.", new [] { "LocationId" });
            }

            // LocationId (string) minLength
            if(this.LocationId != null && this.LocationId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for LocationId, length must be greater than 1.", new [] { "LocationId" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 100.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }

}
