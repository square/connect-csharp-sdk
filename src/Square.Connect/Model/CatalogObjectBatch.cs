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
    /// A batch of catalog objects.
    /// </summary>
    [DataContract]
    public partial class CatalogObjectBatch :  IEquatable<CatalogObjectBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogObjectBatch" /> class.
        /// </summary>
        /// <param name="Objects">A list of CatalogObjects belonging to this batch..</param>
        public CatalogObjectBatch(List<CatalogObject> Objects = default(List<CatalogObject>))
        {
            this.Objects = Objects;
        }
        
        /// <summary>
        /// A list of CatalogObjects belonging to this batch.
        /// </summary>
        /// <value>A list of CatalogObjects belonging to this batch.</value>
        [DataMember(Name="objects", EmitDefaultValue=false)]
        public List<CatalogObject> Objects { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogObjectBatch {\n");
            sb.Append("  Objects: ").Append(Objects).Append("\n");
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
            return this.Equals(obj as CatalogObjectBatch);
        }

        /// <summary>
        /// Returns true if CatalogObjectBatch instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogObjectBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogObjectBatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Objects == other.Objects ||
                    this.Objects != null &&
                    this.Objects.SequenceEqual(other.Objects)
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
                if (this.Objects != null)
                    hash = hash * 59 + this.Objects.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
