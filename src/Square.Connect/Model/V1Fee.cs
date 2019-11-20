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
    /// V1Fee
    /// </summary>
    [DataContract]
    [Obsolete]
    public partial class V1Fee :  IEquatable<V1Fee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Fee" /> class.
        /// </summary>
        /// <param name="Id">The fee&#39;s unique ID..</param>
        /// <param name="Name">The fee&#39;s name..</param>
        /// <param name="Rate">The rate of the fee, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%..</param>
        /// <param name="CalculationPhase">Forthcoming See [V1FeeCalculationPhase](#type-v1feecalculationphase) for possible values.</param>
        /// <param name="AdjustmentType">The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees. See [V1FeeAdjustmentType](#type-v1feeadjustmenttype) for possible values.</param>
        /// <param name="AppliesToCustomAmounts">If true, the fee applies to custom amounts entered into Square Point of Sale that are not associated with a particular item..</param>
        /// <param name="Enabled">If true, the fee is applied to all appropriate items. If false, the fee is not applied at all..</param>
        /// <param name="InclusionType">Whether the fee is ADDITIVE or INCLUSIVE. See [V1FeeInclusionType](#type-v1feeinclusiontype) for possible values.</param>
        /// <param name="Type">In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants. See [V1FeeType](#type-v1feetype) for possible values.</param>
        /// <param name="V2Id">The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID..</param>
        public V1Fee(string Id = default(string), string Name = default(string), string Rate = default(string), string CalculationPhase = default(string), string AdjustmentType = default(string), bool? AppliesToCustomAmounts = default(bool?), bool? Enabled = default(bool?), string InclusionType = default(string), string Type = default(string), string V2Id = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Rate = Rate;
            this.CalculationPhase = CalculationPhase;
            this.AdjustmentType = AdjustmentType;
            this.AppliesToCustomAmounts = AppliesToCustomAmounts;
            this.Enabled = Enabled;
            this.InclusionType = InclusionType;
            this.Type = Type;
            this.V2Id = V2Id;
        }
        
        /// <summary>
        /// The fee&#39;s unique ID.
        /// </summary>
        /// <value>The fee&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The fee&#39;s name.
        /// </summary>
        /// <value>The fee&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The rate of the fee, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        /// <value>The rate of the fee, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%.</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }
        /// <summary>
        /// Forthcoming See [V1FeeCalculationPhase](#type-v1feecalculationphase) for possible values
        /// </summary>
        /// <value>Forthcoming See [V1FeeCalculationPhase](#type-v1feecalculationphase) for possible values</value>
        [DataMember(Name="calculation_phase", EmitDefaultValue=false)]
        public string CalculationPhase { get; set; }
        /// <summary>
        /// The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees. See [V1FeeAdjustmentType](#type-v1feeadjustmenttype) for possible values
        /// </summary>
        /// <value>The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees. See [V1FeeAdjustmentType](#type-v1feeadjustmenttype) for possible values</value>
        [DataMember(Name="adjustment_type", EmitDefaultValue=false)]
        public string AdjustmentType { get; set; }
        /// <summary>
        /// If true, the fee applies to custom amounts entered into Square Point of Sale that are not associated with a particular item.
        /// </summary>
        /// <value>If true, the fee applies to custom amounts entered into Square Point of Sale that are not associated with a particular item.</value>
        [DataMember(Name="applies_to_custom_amounts", EmitDefaultValue=false)]
        public bool? AppliesToCustomAmounts { get; set; }
        /// <summary>
        /// If true, the fee is applied to all appropriate items. If false, the fee is not applied at all.
        /// </summary>
        /// <value>If true, the fee is applied to all appropriate items. If false, the fee is not applied at all.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Whether the fee is ADDITIVE or INCLUSIVE. See [V1FeeInclusionType](#type-v1feeinclusiontype) for possible values
        /// </summary>
        /// <value>Whether the fee is ADDITIVE or INCLUSIVE. See [V1FeeInclusionType](#type-v1feeinclusiontype) for possible values</value>
        [DataMember(Name="inclusion_type", EmitDefaultValue=false)]
        public string InclusionType { get; set; }
        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants. See [V1FeeType](#type-v1feetype) for possible values
        /// </summary>
        /// <value>In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants. See [V1FeeType](#type-v1feetype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID.
        /// </summary>
        /// <value>The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID.</value>
        [DataMember(Name="v2_id", EmitDefaultValue=false)]
        public string V2Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Fee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  CalculationPhase: ").Append(CalculationPhase).Append("\n");
            sb.Append("  AdjustmentType: ").Append(AdjustmentType).Append("\n");
            sb.Append("  AppliesToCustomAmounts: ").Append(AppliesToCustomAmounts).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  InclusionType: ").Append(InclusionType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  V2Id: ").Append(V2Id).Append("\n");
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
            return this.Equals(obj as V1Fee);
        }

        /// <summary>
        /// Returns true if V1Fee instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Fee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Fee other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) && 
                (
                    this.CalculationPhase == other.CalculationPhase ||
                    this.CalculationPhase != null &&
                    this.CalculationPhase.Equals(other.CalculationPhase)
                ) && 
                (
                    this.AdjustmentType == other.AdjustmentType ||
                    this.AdjustmentType != null &&
                    this.AdjustmentType.Equals(other.AdjustmentType)
                ) && 
                (
                    this.AppliesToCustomAmounts == other.AppliesToCustomAmounts ||
                    this.AppliesToCustomAmounts != null &&
                    this.AppliesToCustomAmounts.Equals(other.AppliesToCustomAmounts)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.InclusionType == other.InclusionType ||
                    this.InclusionType != null &&
                    this.InclusionType.Equals(other.InclusionType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.V2Id == other.V2Id ||
                    this.V2Id != null &&
                    this.V2Id.Equals(other.V2Id)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                if (this.CalculationPhase != null)
                    hash = hash * 59 + this.CalculationPhase.GetHashCode();
                if (this.AdjustmentType != null)
                    hash = hash * 59 + this.AdjustmentType.GetHashCode();
                if (this.AppliesToCustomAmounts != null)
                    hash = hash * 59 + this.AppliesToCustomAmounts.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.InclusionType != null)
                    hash = hash * 59 + this.InclusionType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.V2Id != null)
                    hash = hash * 59 + this.V2Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
