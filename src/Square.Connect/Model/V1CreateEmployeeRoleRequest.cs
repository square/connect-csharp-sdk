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
    public partial class V1CreateEmployeeRoleRequest :  IEquatable<V1CreateEmployeeRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateEmployeeRoleRequest" /> class.
        /// </summary>
        /// <param name="EmployeeRole">An EmployeeRole object with a name and permissions, and an optional owner flag..</param>
        public V1CreateEmployeeRoleRequest(V1EmployeeRole EmployeeRole = default(V1EmployeeRole))
        {
            this.EmployeeRole = EmployeeRole;
        }
        
        /// <summary>
        /// An EmployeeRole object with a name and permissions, and an optional owner flag.
        /// </summary>
        /// <value>An EmployeeRole object with a name and permissions, and an optional owner flag.</value>
        [DataMember(Name="employee_role", EmitDefaultValue=false)]
        public V1EmployeeRole EmployeeRole { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1CreateEmployeeRoleRequest {\n");
            sb.Append("  EmployeeRole: ").Append(EmployeeRole).Append("\n");
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
            return this.Equals(obj as V1CreateEmployeeRoleRequest);
        }

        /// <summary>
        /// Returns true if V1CreateEmployeeRoleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1CreateEmployeeRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1CreateEmployeeRoleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmployeeRole == other.EmployeeRole ||
                    this.EmployeeRole != null &&
                    this.EmployeeRole.Equals(other.EmployeeRole)
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
                if (this.EmployeeRole != null)
                    hash = hash * 59 + this.EmployeeRole.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
