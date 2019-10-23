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
    /// A rounding adjustment of the money being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.
    /// Note: This endpoint is in beta.
    /// </summary>
    [DataContract]
    public partial class OrderRoundingAdjustment :  IEquatable<OrderRoundingAdjustment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRoundingAdjustment" /> class.
        /// </summary>
        /// <param name="Uid">Unique ID that identifies the rounding adjustment only within this order..</param>
        /// <param name="Name">The name of the rounding adjustment from the original sale Order..</param>
        /// <param name="AmountMoney">Actual rounding adjustment amount..</param>
        public OrderRoundingAdjustment(string Uid = default(string), string Name = default(string), Money AmountMoney = default(Money))
        {
            this.Uid = Uid;
            this.Name = Name;
            this.AmountMoney = AmountMoney;
        }
        
        /// <summary>
        /// Unique ID that identifies the rounding adjustment only within this order.
        /// </summary>
        /// <value>Unique ID that identifies the rounding adjustment only within this order.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// The name of the rounding adjustment from the original sale Order.
        /// </summary>
        /// <value>The name of the rounding adjustment from the original sale Order.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Actual rounding adjustment amount.
        /// </summary>
        /// <value>Actual rounding adjustment amount.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRoundingAdjustment {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
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
            return this.Equals(obj as OrderRoundingAdjustment);
        }

        /// <summary>
        /// Returns true if OrderRoundingAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderRoundingAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRoundingAdjustment other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
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
