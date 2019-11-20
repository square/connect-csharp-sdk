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
    public partial class CatalogQueryFilteredItemsCustomAttributeFilter :  IEquatable<CatalogQueryFilteredItemsCustomAttributeFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogQueryFilteredItemsCustomAttributeFilter" /> class.
        /// </summary>
        /// <param name="FilterType"> See [CatalogQueryFilteredItemsCustomAttributeFilterFilterType](#type-catalogqueryfiltereditemscustomattributefilterfiltertype) for possible values.</param>
        /// <param name="CustomAttributeDefinitionIds">.</param>
        /// <param name="CustomAttributeValueExact">.</param>
        /// <param name="CustomAttributeValuePrefix">.</param>
        /// <param name="CustomAttributeMinValue">.</param>
        /// <param name="CustomAttributeMaxValue">.</param>
        public CatalogQueryFilteredItemsCustomAttributeFilter(string FilterType = default(string), List<string> CustomAttributeDefinitionIds = default(List<string>), string CustomAttributeValueExact = default(string), string CustomAttributeValuePrefix = default(string), string CustomAttributeMinValue = default(string), string CustomAttributeMaxValue = default(string))
        {
            this.FilterType = FilterType;
            this.CustomAttributeDefinitionIds = CustomAttributeDefinitionIds;
            this.CustomAttributeValueExact = CustomAttributeValueExact;
            this.CustomAttributeValuePrefix = CustomAttributeValuePrefix;
            this.CustomAttributeMinValue = CustomAttributeMinValue;
            this.CustomAttributeMaxValue = CustomAttributeMaxValue;
        }
        
        /// <summary>
        ///  See [CatalogQueryFilteredItemsCustomAttributeFilterFilterType](#type-catalogqueryfiltereditemscustomattributefilterfiltertype) for possible values
        /// </summary>
        /// <value> See [CatalogQueryFilteredItemsCustomAttributeFilterFilterType](#type-catalogqueryfiltereditemscustomattributefilterfiltertype) for possible values</value>
        [DataMember(Name="filter_type", EmitDefaultValue=false)]
        public string FilterType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="custom_attribute_definition_ids", EmitDefaultValue=false)]
        public List<string> CustomAttributeDefinitionIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="custom_attribute_value_exact", EmitDefaultValue=false)]
        public string CustomAttributeValueExact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="custom_attribute_value_prefix", EmitDefaultValue=false)]
        public string CustomAttributeValuePrefix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="custom_attribute_min_value", EmitDefaultValue=false)]
        public string CustomAttributeMinValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="custom_attribute_max_value", EmitDefaultValue=false)]
        public string CustomAttributeMaxValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogQueryFilteredItemsCustomAttributeFilter {\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  CustomAttributeDefinitionIds: ").Append(CustomAttributeDefinitionIds).Append("\n");
            sb.Append("  CustomAttributeValueExact: ").Append(CustomAttributeValueExact).Append("\n");
            sb.Append("  CustomAttributeValuePrefix: ").Append(CustomAttributeValuePrefix).Append("\n");
            sb.Append("  CustomAttributeMinValue: ").Append(CustomAttributeMinValue).Append("\n");
            sb.Append("  CustomAttributeMaxValue: ").Append(CustomAttributeMaxValue).Append("\n");
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
            return this.Equals(obj as CatalogQueryFilteredItemsCustomAttributeFilter);
        }

        /// <summary>
        /// Returns true if CatalogQueryFilteredItemsCustomAttributeFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogQueryFilteredItemsCustomAttributeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogQueryFilteredItemsCustomAttributeFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FilterType == other.FilterType ||
                    this.FilterType != null &&
                    this.FilterType.Equals(other.FilterType)
                ) && 
                (
                    this.CustomAttributeDefinitionIds == other.CustomAttributeDefinitionIds ||
                    this.CustomAttributeDefinitionIds != null &&
                    this.CustomAttributeDefinitionIds.SequenceEqual(other.CustomAttributeDefinitionIds)
                ) && 
                (
                    this.CustomAttributeValueExact == other.CustomAttributeValueExact ||
                    this.CustomAttributeValueExact != null &&
                    this.CustomAttributeValueExact.Equals(other.CustomAttributeValueExact)
                ) && 
                (
                    this.CustomAttributeValuePrefix == other.CustomAttributeValuePrefix ||
                    this.CustomAttributeValuePrefix != null &&
                    this.CustomAttributeValuePrefix.Equals(other.CustomAttributeValuePrefix)
                ) && 
                (
                    this.CustomAttributeMinValue == other.CustomAttributeMinValue ||
                    this.CustomAttributeMinValue != null &&
                    this.CustomAttributeMinValue.Equals(other.CustomAttributeMinValue)
                ) && 
                (
                    this.CustomAttributeMaxValue == other.CustomAttributeMaxValue ||
                    this.CustomAttributeMaxValue != null &&
                    this.CustomAttributeMaxValue.Equals(other.CustomAttributeMaxValue)
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
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();
                if (this.CustomAttributeDefinitionIds != null)
                    hash = hash * 59 + this.CustomAttributeDefinitionIds.GetHashCode();
                if (this.CustomAttributeValueExact != null)
                    hash = hash * 59 + this.CustomAttributeValueExact.GetHashCode();
                if (this.CustomAttributeValuePrefix != null)
                    hash = hash * 59 + this.CustomAttributeValuePrefix.GetHashCode();
                if (this.CustomAttributeMinValue != null)
                    hash = hash * 59 + this.CustomAttributeMinValue.GetHashCode();
                if (this.CustomAttributeMaxValue != null)
                    hash = hash * 59 + this.CustomAttributeMaxValue.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
