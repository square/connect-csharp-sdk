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
    public partial class V1ListRefundsRequest :  IEquatable<V1ListRefundsRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="V1ListRefundsRequest" /> class.
        /// </summary>
        /// <param name="Order">TThe order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values.</param>
        /// <param name="BeginTime">The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year..</param>
        /// <param name="EndTime">The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time..</param>
        /// <param name="Limit">The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods..</param>
        /// <param name="BatchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint..</param>
        public V1ListRefundsRequest(OrderEnum? Order = default(OrderEnum?), string BeginTime = default(string), string EndTime = default(string), int? Limit = default(int?), string BatchToken = default(string))
        {
            this.Order = Order;
            this.BeginTime = BeginTime;
            this.EndTime = EndTime;
            this.Limit = Limit;
            this.BatchToken = BatchToken;
        }
        
        /// <summary>
        /// The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year.
        /// </summary>
        /// <value>The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year.</value>
        [DataMember(Name="begin_time", EmitDefaultValue=false)]
        public string BeginTime { get; set; }
        /// <summary>
        /// The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time.
        /// </summary>
        /// <value>The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }
        /// <summary>
        /// The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods.
        /// </summary>
        /// <value>The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods.</value>
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
            sb.Append("class V1ListRefundsRequest {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(obj as V1ListRefundsRequest);
        }

        /// <summary>
        /// Returns true if V1ListRefundsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ListRefundsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ListRefundsRequest other)
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
                    this.BeginTime == other.BeginTime ||
                    this.BeginTime != null &&
                    this.BeginTime.Equals(other.BeginTime)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
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
                if (this.BeginTime != null)
                    hash = hash * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
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
