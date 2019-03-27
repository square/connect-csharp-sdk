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
    /// Sets the sort order of search results.
    /// </summary>
    [DataContract]
    public partial class ShiftSort :  IEquatable<ShiftSort>, IValidatableObject
    {
        /// <summary>
        /// The field to sort on. See [ShiftSortField](#type-shiftsortfield) for possible values
        /// </summary>
        /// <value>The field to sort on. See [ShiftSortField](#type-shiftsortfield) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            
            /// <summary>
            /// Enum STARTAT for "START_AT"
            /// </summary>
            [EnumMember(Value = "START_AT")]
            STARTAT,
            
            /// <summary>
            /// Enum ENDAT for "END_AT"
            /// </summary>
            [EnumMember(Value = "END_AT")]
            ENDAT,
            
            /// <summary>
            /// Enum CREATEDAT for "CREATED_AT"
            /// </summary>
            [EnumMember(Value = "CREATED_AT")]
            CREATEDAT,
            
            /// <summary>
            /// Enum UPDATEDAT for "UPDATED_AT"
            /// </summary>
            [EnumMember(Value = "UPDATED_AT")]
            UPDATEDAT
        }

        /// <summary>
        /// The order in which results are returned. Defaults to DESC. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The order in which results are returned. Defaults to DESC. See [SortOrder](#type-sortorder) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum DESC for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC,
            
            /// <summary>
            /// Enum ASC for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC
        }

        /// <summary>
        /// The field to sort on. See [ShiftSortField](#type-shiftsortfield) for possible values
        /// </summary>
        /// <value>The field to sort on. See [ShiftSortField](#type-shiftsortfield) for possible values</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// The order in which results are returned. Defaults to DESC. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The order in which results are returned. Defaults to DESC. See [SortOrder](#type-sortorder) for possible values</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftSort" /> class.
        /// </summary>
        /// <param name="Field">The field to sort on. See [ShiftSortField](#type-shiftsortfield) for possible values.</param>
        /// <param name="Order">The order in which results are returned. Defaults to DESC. See [SortOrder](#type-sortorder) for possible values.</param>
        public ShiftSort(FieldEnum? Field = default(FieldEnum?), OrderEnum? Order = default(OrderEnum?))
        {
            this.Field = Field;
            this.Order = Order;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftSort {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as ShiftSort);
        }

        /// <summary>
        /// Returns true if ShiftSort instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftSort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
