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
    public partial class V1ListOrdersRequest :  IEquatable<V1ListOrdersRequest>, IValidatableObject
    {
        /// <summary>
        /// TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values</value>
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
        /// TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOrdersRequest" /> class.
        /// </summary>
        /// <param name="Order">TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values.</param>
        /// <param name="Limit">The maximum number of payments to return in a single response. This value cannot exceed 200..</param>
        /// <param name="BatchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint..</param>
        public V1ListOrdersRequest(OrderEnum? Order = default(OrderEnum?), int? Limit = default(int?), string BatchToken = default(string))
        {
            this.Order = Order;
            this.Limit = Limit;
            this.BatchToken = BatchToken;
        }
        
        /// <summary>
        /// The maximum number of payments to return in a single response. This value cannot exceed 200.
        /// </summary>
        /// <value>The maximum number of payments to return in a single response. This value cannot exceed 200.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// A pagination cursor to retrieve the next set of results for your original query to the endpoint.
        /// </summary>
        /// <value>A pagination cursor to retrieve the next set of results for your original query to the endpoint.</value>
        [DataMember(Name="batch_token", EmitDefaultValue=false)]
        public string BatchToken { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ListOrdersRequest {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  BatchToken: ").Append(BatchToken).Append("\n");
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
            return this.Equals(obj as V1ListOrdersRequest);
        }

        /// <summary>
        /// Returns true if V1ListOrdersRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ListOrdersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ListOrdersRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.BatchToken == other.BatchToken ||
                    this.BatchToken != null &&
                    this.BatchToken.Equals(other.BatchToken)
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
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.BatchToken != null)
                    hash = hash * 59 + this.BatchToken.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}