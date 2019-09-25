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
    public partial class UpsertCatalogObjectResponse :  IEquatable<UpsertCatalogObjectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertCatalogObjectResponse" /> class.
        /// </summary>
        /// <param name="Errors">The set of &#x60;Error&#x60;s encountered..</param>
        /// <param name="CatalogObject">The created &#x60;CatalogObject&#x60;..</param>
        /// <param name="IdMappings">The mapping between client and server IDs for this Upsert..</param>
        public UpsertCatalogObjectResponse(List<Error> Errors = default(List<Error>), CatalogObject CatalogObject = default(CatalogObject), List<CatalogIdMapping> IdMappings = default(List<CatalogIdMapping>))
        {
            this.Errors = Errors;
            this.CatalogObject = CatalogObject;
            this.IdMappings = IdMappings;
        }
        
        /// <summary>
        /// The set of &#x60;Error&#x60;s encountered.
        /// </summary>
        /// <value>The set of &#x60;Error&#x60;s encountered.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// The created &#x60;CatalogObject&#x60;.
        /// </summary>
        /// <value>The created &#x60;CatalogObject&#x60;.</value>
        [DataMember(Name="catalog_object", EmitDefaultValue=false)]
        public CatalogObject CatalogObject { get; set; }
        /// <summary>
        /// The mapping between client and server IDs for this Upsert.
        /// </summary>
        /// <value>The mapping between client and server IDs for this Upsert.</value>
        [DataMember(Name="id_mappings", EmitDefaultValue=false)]
        public List<CatalogIdMapping> IdMappings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertCatalogObjectResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  CatalogObject: ").Append(CatalogObject).Append("\n");
            sb.Append("  IdMappings: ").Append(IdMappings).Append("\n");
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
            return this.Equals(obj as UpsertCatalogObjectResponse);
        }

        /// <summary>
        /// Returns true if UpsertCatalogObjectResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UpsertCatalogObjectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertCatalogObjectResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.CatalogObject == other.CatalogObject ||
                    this.CatalogObject != null &&
                    this.CatalogObject.Equals(other.CatalogObject)
                ) && 
                (
                    this.IdMappings == other.IdMappings ||
                    this.IdMappings != null &&
                    this.IdMappings.SequenceEqual(other.IdMappings)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.CatalogObject != null)
                    hash = hash * 59 + this.CatalogObject.GetHashCode();
                if (this.IdMappings != null)
                    hash = hash * 59 + this.IdMappings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
