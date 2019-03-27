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
    /// Price and inventory alerting overrides for a [CatalogItemVariation](#type-catalogitemvariation) at a specific [location](#type-location).
    /// </summary>
    [DataContract]
    public partial class ItemVariationLocationOverrides :  IEquatable<ItemVariationLocationOverrides>, IValidatableObject
    {
        /// <summary>
        /// The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values
        /// </summary>
        /// <value>The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PricingTypeEnum
        {
            
            /// <summary>
            /// Enum FIXEDPRICING for "FIXED_PRICING"
            /// </summary>
            [EnumMember(Value = "FIXED_PRICING")]
            FIXEDPRICING,
            
            /// <summary>
            /// Enum VARIABLEPRICING for "VARIABLE_PRICING"
            /// </summary>
            [EnumMember(Value = "VARIABLE_PRICING")]
            VARIABLEPRICING
        }

        /// <summary>
        /// Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its `inventory_alert_threshold`. See [InventoryAlertType](#type-inventoryalerttype) for possible values
        /// </summary>
        /// <value>Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its `inventory_alert_threshold`. See [InventoryAlertType](#type-inventoryalerttype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InventoryAlertTypeEnum
        {
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum LOWQUANTITY for "LOW_QUANTITY"
            /// </summary>
            [EnumMember(Value = "LOW_QUANTITY")]
            LOWQUANTITY
        }

        /// <summary>
        /// The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values
        /// </summary>
        /// <value>The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values</value>
        [DataMember(Name="pricing_type", EmitDefaultValue=false)]
        public PricingTypeEnum? PricingType { get; set; }
        /// <summary>
        /// Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its `inventory_alert_threshold`. See [InventoryAlertType](#type-inventoryalerttype) for possible values
        /// </summary>
        /// <value>Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its `inventory_alert_threshold`. See [InventoryAlertType](#type-inventoryalerttype) for possible values</value>
        [DataMember(Name="inventory_alert_type", EmitDefaultValue=false)]
        public InventoryAlertTypeEnum? InventoryAlertType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemVariationLocationOverrides" /> class.
        /// </summary>
        /// <param name="LocationId">The ID of the [location](#type-location)..</param>
        /// <param name="PriceMoney">The price of the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location), or blank for variable pricing..</param>
        /// <param name="PricingType">The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values.</param>
        /// <param name="TrackInventory">If &#x60;true&#x60;, inventory tracking is active for the [CatalogItemVariation](#type-catalogitemvariation) at this [location](#type-location)..</param>
        /// <param name="InventoryAlertType">Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values.</param>
        /// <param name="InventoryAlertThreshold">If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer..</param>
        public ItemVariationLocationOverrides(string LocationId = default(string), Money PriceMoney = default(Money), PricingTypeEnum? PricingType = default(PricingTypeEnum?), bool? TrackInventory = default(bool?), InventoryAlertTypeEnum? InventoryAlertType = default(InventoryAlertTypeEnum?), long? InventoryAlertThreshold = default(long?))
        {
            this.LocationId = LocationId;
            this.PriceMoney = PriceMoney;
            this.PricingType = PricingType;
            this.TrackInventory = TrackInventory;
            this.InventoryAlertType = InventoryAlertType;
            this.InventoryAlertThreshold = InventoryAlertThreshold;
        }
        
        /// <summary>
        /// The ID of the [location](#type-location).
        /// </summary>
        /// <value>The ID of the [location](#type-location).</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The price of the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location), or blank for variable pricing.
        /// </summary>
        /// <value>The price of the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location), or blank for variable pricing.</value>
        [DataMember(Name="price_money", EmitDefaultValue=false)]
        public Money PriceMoney { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, inventory tracking is active for the [CatalogItemVariation](#type-catalogitemvariation) at this [location](#type-location).
        /// </summary>
        /// <value>If &#x60;true&#x60;, inventory tracking is active for the [CatalogItemVariation](#type-catalogitemvariation) at this [location](#type-location).</value>
        [DataMember(Name="track_inventory", EmitDefaultValue=false)]
        public bool? TrackInventory { get; set; }
        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer.
        /// </summary>
        /// <value>If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer.</value>
        [DataMember(Name="inventory_alert_threshold", EmitDefaultValue=false)]
        public long? InventoryAlertThreshold { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemVariationLocationOverrides {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  PriceMoney: ").Append(PriceMoney).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  TrackInventory: ").Append(TrackInventory).Append("\n");
            sb.Append("  InventoryAlertType: ").Append(InventoryAlertType).Append("\n");
            sb.Append("  InventoryAlertThreshold: ").Append(InventoryAlertThreshold).Append("\n");
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
            return this.Equals(obj as ItemVariationLocationOverrides);
        }

        /// <summary>
        /// Returns true if ItemVariationLocationOverrides instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemVariationLocationOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemVariationLocationOverrides other)
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
                    this.PriceMoney == other.PriceMoney ||
                    this.PriceMoney != null &&
                    this.PriceMoney.Equals(other.PriceMoney)
                ) && 
                (
                    this.PricingType == other.PricingType ||
                    this.PricingType != null &&
                    this.PricingType.Equals(other.PricingType)
                ) && 
                (
                    this.TrackInventory == other.TrackInventory ||
                    this.TrackInventory != null &&
                    this.TrackInventory.Equals(other.TrackInventory)
                ) && 
                (
                    this.InventoryAlertType == other.InventoryAlertType ||
                    this.InventoryAlertType != null &&
                    this.InventoryAlertType.Equals(other.InventoryAlertType)
                ) && 
                (
                    this.InventoryAlertThreshold == other.InventoryAlertThreshold ||
                    this.InventoryAlertThreshold != null &&
                    this.InventoryAlertThreshold.Equals(other.InventoryAlertThreshold)
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
                if (this.PriceMoney != null)
                    hash = hash * 59 + this.PriceMoney.GetHashCode();
                if (this.PricingType != null)
                    hash = hash * 59 + this.PricingType.GetHashCode();
                if (this.TrackInventory != null)
                    hash = hash * 59 + this.TrackInventory.GetHashCode();
                if (this.InventoryAlertType != null)
                    hash = hash * 59 + this.InventoryAlertType.GetHashCode();
                if (this.InventoryAlertThreshold != null)
                    hash = hash * 59 + this.InventoryAlertThreshold.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
