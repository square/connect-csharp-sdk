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
    /// Specifies idempotency key of a payment to cancel.
    /// </summary>
    [DataContract]
    public partial class CancelPaymentByIdempotencyKeyRequest :  IEquatable<CancelPaymentByIdempotencyKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelPaymentByIdempotencyKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelPaymentByIdempotencyKeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelPaymentByIdempotencyKeyRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">&#x60;idempotency_key&#x60; identifying the payment to be canceled. (required).</param>
        public CancelPaymentByIdempotencyKeyRequest(string IdempotencyKey = default(string))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for CancelPaymentByIdempotencyKeyRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
        }
        
        /// <summary>
        /// &#x60;idempotency_key&#x60; identifying the payment to be canceled.
        /// </summary>
        /// <value>&#x60;idempotency_key&#x60; identifying the payment to be canceled.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelPaymentByIdempotencyKeyRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
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
            return this.Equals(obj as CancelPaymentByIdempotencyKeyRequest);
        }

        /// <summary>
        /// Returns true if CancelPaymentByIdempotencyKeyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelPaymentByIdempotencyKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelPaymentByIdempotencyKeyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
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
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
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

            yield break;
        }
    }

}
