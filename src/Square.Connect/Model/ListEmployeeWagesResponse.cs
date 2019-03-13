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
    /// The response to a request for a set of &#x60;EmployeeWage&#x60; objects. Contains  a set of &#x60;EmployeeWage&#x60;.
    /// </summary>
    [DataContract]
    public partial class ListEmployeeWagesResponse :  IEquatable<ListEmployeeWagesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmployeeWagesResponse" /> class.
        /// </summary>
        /// <param name="EmployeeWages">A page of Employee Wage results..</param>
        /// <param name="Cursor">Value supplied in the subsequent request to fetch the next next page of Employee Wage results..</param>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        public ListEmployeeWagesResponse(List<EmployeeWage> EmployeeWages = default(List<EmployeeWage>), string Cursor = default(string), List<Error> Errors = default(List<Error>))
        {
            this.EmployeeWages = EmployeeWages;
            this.Cursor = Cursor;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// A page of Employee Wage results.
        /// </summary>
        /// <value>A page of Employee Wage results.</value>
        [DataMember(Name="employee_wages", EmitDefaultValue=false)]
        public List<EmployeeWage> EmployeeWages { get; set; }
        /// <summary>
        /// Value supplied in the subsequent request to fetch the next next page of Employee Wage results.
        /// </summary>
        /// <value>Value supplied in the subsequent request to fetch the next next page of Employee Wage results.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEmployeeWagesResponse {\n");
            sb.Append("  EmployeeWages: ").Append(EmployeeWages).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as ListEmployeeWagesResponse);
        }

        /// <summary>
        /// Returns true if ListEmployeeWagesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListEmployeeWagesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListEmployeeWagesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmployeeWages == other.EmployeeWages ||
                    this.EmployeeWages != null &&
                    this.EmployeeWages.SequenceEqual(other.EmployeeWages)
                ) && 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.EmployeeWages != null)
                    hash = hash * 59 + this.EmployeeWages.GetHashCode();
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
