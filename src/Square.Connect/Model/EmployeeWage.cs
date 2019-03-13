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
    /// The hourly wage rate that an employee will earn on a &#x60;Shift&#x60; for doing the job specified by the &#x60;title&#x60; property of this object.
    /// </summary>
    [DataContract]
    public partial class EmployeeWage :  IEquatable<EmployeeWage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmployeeWage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWage" /> class.
        /// </summary>
        /// <param name="Id">UUID for this object..</param>
        /// <param name="EmployeeId">The &#x60;Employee&#x60; that this wage is assigned to. (required).</param>
        /// <param name="Title">The job title that this wage relates to..</param>
        /// <param name="HourlyRate">Can be a custom-set hourly wage or the calculated effective hourly wage based on annual wage and hours worked per week..</param>
        public EmployeeWage(string Id = default(string), string EmployeeId = default(string), string Title = default(string), Money HourlyRate = default(Money))
        {
            // to ensure "EmployeeId" is required (not null)
            if (EmployeeId == null)
            {
                throw new InvalidDataException("EmployeeId is a required property for EmployeeWage and cannot be null");
            }
            else
            {
                this.EmployeeId = EmployeeId;
            }
            this.Id = Id;
            this.Title = Title;
            this.HourlyRate = HourlyRate;
        }
        
        /// <summary>
        /// UUID for this object.
        /// </summary>
        /// <value>UUID for this object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The &#x60;Employee&#x60; that this wage is assigned to.
        /// </summary>
        /// <value>The &#x60;Employee&#x60; that this wage is assigned to.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// The job title that this wage relates to.
        /// </summary>
        /// <value>The job title that this wage relates to.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Can be a custom-set hourly wage or the calculated effective hourly wage based on annual wage and hours worked per week.
        /// </summary>
        /// <value>Can be a custom-set hourly wage or the calculated effective hourly wage based on annual wage and hours worked per week.</value>
        [DataMember(Name="hourly_rate", EmitDefaultValue=false)]
        public Money HourlyRate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeWage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
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
            return this.Equals(obj as EmployeeWage);
        }

        /// <summary>
        /// Returns true if EmployeeWage instances are equal
        /// </summary>
        /// <param name="other">Instance of EmployeeWage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeWage other)
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
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.HourlyRate == other.HourlyRate ||
                    this.HourlyRate != null &&
                    this.HourlyRate.Equals(other.HourlyRate)
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
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.HourlyRate != null)
                    hash = hash * 59 + this.HourlyRate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // EmployeeId (string) minLength
            if(this.EmployeeId != null && this.EmployeeId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for EmployeeId, length must be greater than 1.", new [] { "EmployeeId" });
            }

            yield break;
        }
    }

}
