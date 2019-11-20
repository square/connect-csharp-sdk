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
    public partial class ListEmployeesResponse :  IEquatable<ListEmployeesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmployeesResponse" /> class.
        /// </summary>
        /// <param name="Employees">List of employees returned from the request..</param>
        /// <param name="Cursor">The token to be used to retrieve the next page of results..</param>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        public ListEmployeesResponse(List<Employee> Employees = default(List<Employee>), string Cursor = default(string), List<Error> Errors = default(List<Error>))
        {
            this.Employees = Employees;
            this.Cursor = Cursor;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// List of employees returned from the request.
        /// </summary>
        /// <value>List of employees returned from the request.</value>
        [DataMember(Name="employees", EmitDefaultValue=false)]
        public List<Employee> Employees { get; set; }
        /// <summary>
        /// The token to be used to retrieve the next page of results.
        /// </summary>
        /// <value>The token to be used to retrieve the next page of results.</value>
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
            sb.Append("class ListEmployeesResponse {\n");
            sb.Append("  Employees: ").Append(Employees).Append("\n");
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
            return this.Equals(obj as ListEmployeesResponse);
        }

        /// <summary>
        /// Returns true if ListEmployeesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListEmployeesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListEmployeesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Employees == other.Employees ||
                    this.Employees != null &&
                    this.Employees.SequenceEqual(other.Employees)
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
                if (this.Employees != null)
                    hash = hash * 59 + this.Employees.GetHashCode();
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
