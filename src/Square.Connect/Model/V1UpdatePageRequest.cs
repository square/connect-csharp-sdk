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
    [Obsolete]
    public partial class V1UpdatePageRequest :  IEquatable<V1UpdatePageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1UpdatePageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePageRequest" /> class.
        /// </summary>
        /// <param name="Body">An object containing the fields to POST for the request.  See the corresponding object definition for field details. (required).</param>
        public V1UpdatePageRequest(V1Page Body = default(V1Page))
        {
            // to ensure "Body" is required (not null)
            if (Body == null)
            {
                throw new InvalidDataException("Body is a required property for V1UpdatePageRequest and cannot be null");
            }
            else
            {
                this.Body = Body;
            }
        }
        
        /// <summary>
        /// An object containing the fields to POST for the request.  See the corresponding object definition for field details.
        /// </summary>
        /// <value>An object containing the fields to POST for the request.  See the corresponding object definition for field details.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public V1Page Body { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1UpdatePageRequest {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(obj as V1UpdatePageRequest);
        }

        /// <summary>
        /// Returns true if V1UpdatePageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1UpdatePageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1UpdatePageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
