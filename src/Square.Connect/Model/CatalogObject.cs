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
    /// The wrapper object for object types in the Catalog data model. The type of a particular &#x60;CatalogObject&#x60; is determined by the value of &#x60;type&#x60; and only the corresponding data field may be set.  - if type &#x3D; &#x60;ITEM&#x60;, only &#x60;item_data&#x60; will be populated and it will contain a valid [CatalogItem](#type-catalogitem) object. - if type &#x3D; &#x60;ITEM_VARIATION&#x60;, only &#x60;item_variation_data&#x60; will be populated and it will contain a valid [CatalogItemVariation](#type-catalogitemvariation) object. - if type &#x3D; &#x60;MODIFIER&#x60;, only &#x60;modifier_data&#x60; will be populated and it will contain a valid [CatalogModifier](#type-catalogmodifier) object. - if type &#x3D; &#x60;MODIFIER_LIST&#x60;, only &#x60;modifier_list_data&#x60; will be populated and it will contain a valid [CatalogModifierList](#type-catalogmodifierlist) object. - if type &#x3D; &#x60;CATEGORY&#x60;, only &#x60;category_data&#x60; will be populated and it will contain a valid [CatalogCategory](#type-catalogcategory) object. - if type &#x3D; &#x60;DISCOUNT&#x60;, only &#x60;discount_data&#x60; will be populated and it will contain a valid [CatalogDiscount](#type-catalogdiscount) object. - if type &#x3D; &#x60;TAX&#x60;, only &#x60;tax_data&#x60; will be populated and it will contain a valid [CatalogTax](#type-catalogtax) object. - if type &#x3D; &#x60;IMAGE&#x60;, only &#x60;image_data&#x60; will be populated and it will contain a valid [CatalogImage](#type-catalogimage) object.  For a more detailed discussion of the Catalog data model, please see the [Catalog Overview](/products/catalog/overview).
    /// </summary>
    [DataContract]
    public partial class CatalogObject :  IEquatable<CatalogObject>, IValidatableObject
    {
        /// <summary>
        /// The type of this object. Each object type has expected properties expressed in a structured format within its corresponding `*_data` field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values
        /// </summary>
        /// <value>The type of this object. Each object type has expected properties expressed in a structured format within its corresponding `*_data` field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum ITEM for "ITEM"
            /// </summary>
            [EnumMember(Value = "ITEM")]
            ITEM,
            
            /// <summary>
            /// Enum IMAGE for "IMAGE"
            /// </summary>
            [EnumMember(Value = "IMAGE")]
            IMAGE,
            
            /// <summary>
            /// Enum CATEGORY for "CATEGORY"
            /// </summary>
            [EnumMember(Value = "CATEGORY")]
            CATEGORY,
            
            /// <summary>
            /// Enum ITEMVARIATION for "ITEM_VARIATION"
            /// </summary>
            [EnumMember(Value = "ITEM_VARIATION")]
            ITEMVARIATION,
            
            /// <summary>
            /// Enum TAX for "TAX"
            /// </summary>
            [EnumMember(Value = "TAX")]
            TAX,
            
            /// <summary>
            /// Enum DISCOUNT for "DISCOUNT"
            /// </summary>
            [EnumMember(Value = "DISCOUNT")]
            DISCOUNT,
            
            /// <summary>
            /// Enum MODIFIERLIST for "MODIFIER_LIST"
            /// </summary>
            [EnumMember(Value = "MODIFIER_LIST")]
            MODIFIERLIST,
            
            /// <summary>
            /// Enum MODIFIER for "MODIFIER"
            /// </summary>
            [EnumMember(Value = "MODIFIER")]
            MODIFIER
        }

        /// <summary>
        /// The type of this object. Each object type has expected properties expressed in a structured format within its corresponding `*_data` field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values
        /// </summary>
        /// <value>The type of this object. Each object type has expected properties expressed in a structured format within its corresponding `*_data` field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogObject" /> class.
        /// </summary>
        /// <param name="Type">The type of this object. Each object type has expected properties expressed in a structured format within its corresponding &#x60;*_data&#x60; field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values (required).</param>
        /// <param name="Id">An identifier to reference this object in the catalog. When a new CatalogObject is inserted, the client should set the id to a temporary identifier starting with a &#x60;&#39;#&#39;&#x60; character. Other objects being inserted or updated within the same request may use this identifier to refer to the new object.  When the server receives the new object, it will supply a unique identifier that replaces the temporary identifier for all future references. (required).</param>
        /// <param name="UpdatedAt">Last modification [timestamp](#workingwithdates) in RFC 3339 format, e.g., &#x60;\&quot;2016-08-15T23:59:33.123Z\&quot;&#x60; would indicate the UTC time (denoted by &#x60;Z&#x60;) of August 15, 2016 at 23:59:33 and 123 milliseconds..</param>
        /// <param name="Version">The version of the object. When updating an object, the version supplied must match the version in the database, otherwise the write will be rejected as conflicting..</param>
        /// <param name="IsDeleted">If &#x60;true&#x60;, the object has been deleted from the database. Must be &#x60;false&#x60; for new objects being inserted. When deleted, the &#x60;updated_at&#x60; field will equal the deletion time..</param>
        /// <param name="CatalogV1Ids">The Connect V1 IDs for this object at each [location](#type-location) where it is present, where they differ from the object&#39;s Connect V2 ID. The field will only be present for objects that have been created or modified by legacy APIs..</param>
        /// <param name="PresentAtAllLocations">If &#x60;true&#x60;, this object is present at all locations (including future locations), except where specified in the &#x60;absent_at_location_ids&#x60; field. If &#x60;false&#x60;, this object is not present at any locations (including future locations), except where specified in the &#x60;present_at_location_ids&#x60; field. If not specified, defaults to &#x60;true&#x60;..</param>
        /// <param name="PresentAtLocationIds">A list of locations where the object is present, even if &#x60;present_at_all_locations&#x60; is &#x60;false&#x60;..</param>
        /// <param name="AbsentAtLocationIds">A list of locations where the object is not present, even if &#x60;present_at_all_locations&#x60; is &#x60;true&#x60;..</param>
        /// <param name="ImageId">Identifies the &#x60;CatalogImage&#x60; attached to this &#x60;CatalogObject&#x60;..</param>
        /// <param name="ItemData">Structured data for a [CatalogItem](#type-catalogitem), set for CatalogObjects of type &#x60;ITEM&#x60;..</param>
        /// <param name="CategoryData">Structured data for a [CatalogCategory](#type-catalogcategory), set for CatalogObjects of type &#x60;CATEGORY&#x60;..</param>
        /// <param name="ItemVariationData">Structured data for a [CatalogItemVariation](#type-catalogitemvariation), set for CatalogObjects of type &#x60;ITEM_VARIATION&#x60;..</param>
        /// <param name="TaxData">Structured data for a [CatalogTax](#type-catalogtax), set for CatalogObjects of type &#x60;TAX&#x60;..</param>
        /// <param name="DiscountData">Structured data for a [CatalogDiscount](#type-catalogdiscount), set for CatalogObjects of type &#x60;DISCOUNT&#x60;..</param>
        /// <param name="ModifierListData">Structured data for a [CatalogModifierList](#type-catalogmodifierlist), set for CatalogObjects of type &#x60;MODIFIER_LIST&#x60;..</param>
        /// <param name="ModifierData">Structured data for a [CatalogModifier](#type-catalogmodifier), set for CatalogObjects of type &#x60;MODIFIER&#x60;..</param>
        /// <param name="ImageData">Structured data for a [CatalogImage](#type-catalogimage), set for CatalogObjects of type &#x60;IMAGE&#x60;..</param>
        public CatalogObject(TypeEnum? Type = default(TypeEnum?), string Id = default(string), string UpdatedAt = default(string), long? Version = default(long?), bool? IsDeleted = default(bool?), List<CatalogV1Id> CatalogV1Ids = default(List<CatalogV1Id>), bool? PresentAtAllLocations = default(bool?), List<string> PresentAtLocationIds = default(List<string>), List<string> AbsentAtLocationIds = default(List<string>), string ImageId = default(string), CatalogItem ItemData = default(CatalogItem), CatalogCategory CategoryData = default(CatalogCategory), CatalogItemVariation ItemVariationData = default(CatalogItemVariation), CatalogTax TaxData = default(CatalogTax), CatalogDiscount DiscountData = default(CatalogDiscount), CatalogModifierList ModifierListData = default(CatalogModifierList), CatalogModifier ModifierData = default(CatalogModifier), CatalogImage ImageData = default(CatalogImage))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CatalogObject and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CatalogObject and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.UpdatedAt = UpdatedAt;
            this.Version = Version;
            this.IsDeleted = IsDeleted;
            this.CatalogV1Ids = CatalogV1Ids;
            this.PresentAtAllLocations = PresentAtAllLocations;
            this.PresentAtLocationIds = PresentAtLocationIds;
            this.AbsentAtLocationIds = AbsentAtLocationIds;
            this.ImageId = ImageId;
            this.ItemData = ItemData;
            this.CategoryData = CategoryData;
            this.ItemVariationData = ItemVariationData;
            this.TaxData = TaxData;
            this.DiscountData = DiscountData;
            this.ModifierListData = ModifierListData;
            this.ModifierData = ModifierData;
            this.ImageData = ImageData;
        }
        
        /// <summary>
        /// An identifier to reference this object in the catalog. When a new CatalogObject is inserted, the client should set the id to a temporary identifier starting with a &#x60;&#39;#&#39;&#x60; character. Other objects being inserted or updated within the same request may use this identifier to refer to the new object.  When the server receives the new object, it will supply a unique identifier that replaces the temporary identifier for all future references.
        /// </summary>
        /// <value>An identifier to reference this object in the catalog. When a new CatalogObject is inserted, the client should set the id to a temporary identifier starting with a &#x60;&#39;#&#39;&#x60; character. Other objects being inserted or updated within the same request may use this identifier to refer to the new object.  When the server receives the new object, it will supply a unique identifier that replaces the temporary identifier for all future references.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Last modification [timestamp](#workingwithdates) in RFC 3339 format, e.g., &#x60;\&quot;2016-08-15T23:59:33.123Z\&quot;&#x60; would indicate the UTC time (denoted by &#x60;Z&#x60;) of August 15, 2016 at 23:59:33 and 123 milliseconds.
        /// </summary>
        /// <value>Last modification [timestamp](#workingwithdates) in RFC 3339 format, e.g., &#x60;\&quot;2016-08-15T23:59:33.123Z\&quot;&#x60; would indicate the UTC time (denoted by &#x60;Z&#x60;) of August 15, 2016 at 23:59:33 and 123 milliseconds.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// The version of the object. When updating an object, the version supplied must match the version in the database, otherwise the write will be rejected as conflicting.
        /// </summary>
        /// <value>The version of the object. When updating an object, the version supplied must match the version in the database, otherwise the write will be rejected as conflicting.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, the object has been deleted from the database. Must be &#x60;false&#x60; for new objects being inserted. When deleted, the &#x60;updated_at&#x60; field will equal the deletion time.
        /// </summary>
        /// <value>If &#x60;true&#x60;, the object has been deleted from the database. Must be &#x60;false&#x60; for new objects being inserted. When deleted, the &#x60;updated_at&#x60; field will equal the deletion time.</value>
        [DataMember(Name="is_deleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// The Connect V1 IDs for this object at each [location](#type-location) where it is present, where they differ from the object&#39;s Connect V2 ID. The field will only be present for objects that have been created or modified by legacy APIs.
        /// </summary>
        /// <value>The Connect V1 IDs for this object at each [location](#type-location) where it is present, where they differ from the object&#39;s Connect V2 ID. The field will only be present for objects that have been created or modified by legacy APIs.</value>
        [DataMember(Name="catalog_v1_ids", EmitDefaultValue=false)]
        public List<CatalogV1Id> CatalogV1Ids { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, this object is present at all locations (including future locations), except where specified in the &#x60;absent_at_location_ids&#x60; field. If &#x60;false&#x60;, this object is not present at any locations (including future locations), except where specified in the &#x60;present_at_location_ids&#x60; field. If not specified, defaults to &#x60;true&#x60;.
        /// </summary>
        /// <value>If &#x60;true&#x60;, this object is present at all locations (including future locations), except where specified in the &#x60;absent_at_location_ids&#x60; field. If &#x60;false&#x60;, this object is not present at any locations (including future locations), except where specified in the &#x60;present_at_location_ids&#x60; field. If not specified, defaults to &#x60;true&#x60;.</value>
        [DataMember(Name="present_at_all_locations", EmitDefaultValue=false)]
        public bool? PresentAtAllLocations { get; set; }
        /// <summary>
        /// A list of locations where the object is present, even if &#x60;present_at_all_locations&#x60; is &#x60;false&#x60;.
        /// </summary>
        /// <value>A list of locations where the object is present, even if &#x60;present_at_all_locations&#x60; is &#x60;false&#x60;.</value>
        [DataMember(Name="present_at_location_ids", EmitDefaultValue=false)]
        public List<string> PresentAtLocationIds { get; set; }
        /// <summary>
        /// A list of locations where the object is not present, even if &#x60;present_at_all_locations&#x60; is &#x60;true&#x60;.
        /// </summary>
        /// <value>A list of locations where the object is not present, even if &#x60;present_at_all_locations&#x60; is &#x60;true&#x60;.</value>
        [DataMember(Name="absent_at_location_ids", EmitDefaultValue=false)]
        public List<string> AbsentAtLocationIds { get; set; }
        /// <summary>
        /// Identifies the &#x60;CatalogImage&#x60; attached to this &#x60;CatalogObject&#x60;.
        /// </summary>
        /// <value>Identifies the &#x60;CatalogImage&#x60; attached to this &#x60;CatalogObject&#x60;.</value>
        [DataMember(Name="image_id", EmitDefaultValue=false)]
        public string ImageId { get; set; }
        /// <summary>
        /// Structured data for a [CatalogItem](#type-catalogitem), set for CatalogObjects of type &#x60;ITEM&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogItem](#type-catalogitem), set for CatalogObjects of type &#x60;ITEM&#x60;.</value>
        [DataMember(Name="item_data", EmitDefaultValue=false)]
        public CatalogItem ItemData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogCategory](#type-catalogcategory), set for CatalogObjects of type &#x60;CATEGORY&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogCategory](#type-catalogcategory), set for CatalogObjects of type &#x60;CATEGORY&#x60;.</value>
        [DataMember(Name="category_data", EmitDefaultValue=false)]
        public CatalogCategory CategoryData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogItemVariation](#type-catalogitemvariation), set for CatalogObjects of type &#x60;ITEM_VARIATION&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogItemVariation](#type-catalogitemvariation), set for CatalogObjects of type &#x60;ITEM_VARIATION&#x60;.</value>
        [DataMember(Name="item_variation_data", EmitDefaultValue=false)]
        public CatalogItemVariation ItemVariationData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogTax](#type-catalogtax), set for CatalogObjects of type &#x60;TAX&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogTax](#type-catalogtax), set for CatalogObjects of type &#x60;TAX&#x60;.</value>
        [DataMember(Name="tax_data", EmitDefaultValue=false)]
        public CatalogTax TaxData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogDiscount](#type-catalogdiscount), set for CatalogObjects of type &#x60;DISCOUNT&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogDiscount](#type-catalogdiscount), set for CatalogObjects of type &#x60;DISCOUNT&#x60;.</value>
        [DataMember(Name="discount_data", EmitDefaultValue=false)]
        public CatalogDiscount DiscountData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogModifierList](#type-catalogmodifierlist), set for CatalogObjects of type &#x60;MODIFIER_LIST&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogModifierList](#type-catalogmodifierlist), set for CatalogObjects of type &#x60;MODIFIER_LIST&#x60;.</value>
        [DataMember(Name="modifier_list_data", EmitDefaultValue=false)]
        public CatalogModifierList ModifierListData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogModifier](#type-catalogmodifier), set for CatalogObjects of type &#x60;MODIFIER&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogModifier](#type-catalogmodifier), set for CatalogObjects of type &#x60;MODIFIER&#x60;.</value>
        [DataMember(Name="modifier_data", EmitDefaultValue=false)]
        public CatalogModifier ModifierData { get; set; }
        /// <summary>
        /// Structured data for a [CatalogImage](#type-catalogimage), set for CatalogObjects of type &#x60;IMAGE&#x60;.
        /// </summary>
        /// <value>Structured data for a [CatalogImage](#type-catalogimage), set for CatalogObjects of type &#x60;IMAGE&#x60;.</value>
        [DataMember(Name="image_data", EmitDefaultValue=false)]
        public CatalogImage ImageData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogObject {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CatalogV1Ids: ").Append(CatalogV1Ids).Append("\n");
            sb.Append("  PresentAtAllLocations: ").Append(PresentAtAllLocations).Append("\n");
            sb.Append("  PresentAtLocationIds: ").Append(PresentAtLocationIds).Append("\n");
            sb.Append("  AbsentAtLocationIds: ").Append(AbsentAtLocationIds).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ItemData: ").Append(ItemData).Append("\n");
            sb.Append("  CategoryData: ").Append(CategoryData).Append("\n");
            sb.Append("  ItemVariationData: ").Append(ItemVariationData).Append("\n");
            sb.Append("  TaxData: ").Append(TaxData).Append("\n");
            sb.Append("  DiscountData: ").Append(DiscountData).Append("\n");
            sb.Append("  ModifierListData: ").Append(ModifierListData).Append("\n");
            sb.Append("  ModifierData: ").Append(ModifierData).Append("\n");
            sb.Append("  ImageData: ").Append(ImageData).Append("\n");
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
            return this.Equals(obj as CatalogObject);
        }

        /// <summary>
        /// Returns true if CatalogObject instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.IsDeleted == other.IsDeleted ||
                    this.IsDeleted != null &&
                    this.IsDeleted.Equals(other.IsDeleted)
                ) && 
                (
                    this.CatalogV1Ids == other.CatalogV1Ids ||
                    this.CatalogV1Ids != null &&
                    this.CatalogV1Ids.SequenceEqual(other.CatalogV1Ids)
                ) && 
                (
                    this.PresentAtAllLocations == other.PresentAtAllLocations ||
                    this.PresentAtAllLocations != null &&
                    this.PresentAtAllLocations.Equals(other.PresentAtAllLocations)
                ) && 
                (
                    this.PresentAtLocationIds == other.PresentAtLocationIds ||
                    this.PresentAtLocationIds != null &&
                    this.PresentAtLocationIds.SequenceEqual(other.PresentAtLocationIds)
                ) && 
                (
                    this.AbsentAtLocationIds == other.AbsentAtLocationIds ||
                    this.AbsentAtLocationIds != null &&
                    this.AbsentAtLocationIds.SequenceEqual(other.AbsentAtLocationIds)
                ) && 
                (
                    this.ImageId == other.ImageId ||
                    this.ImageId != null &&
                    this.ImageId.Equals(other.ImageId)
                ) && 
                (
                    this.ItemData == other.ItemData ||
                    this.ItemData != null &&
                    this.ItemData.Equals(other.ItemData)
                ) && 
                (
                    this.CategoryData == other.CategoryData ||
                    this.CategoryData != null &&
                    this.CategoryData.Equals(other.CategoryData)
                ) && 
                (
                    this.ItemVariationData == other.ItemVariationData ||
                    this.ItemVariationData != null &&
                    this.ItemVariationData.Equals(other.ItemVariationData)
                ) && 
                (
                    this.TaxData == other.TaxData ||
                    this.TaxData != null &&
                    this.TaxData.Equals(other.TaxData)
                ) && 
                (
                    this.DiscountData == other.DiscountData ||
                    this.DiscountData != null &&
                    this.DiscountData.Equals(other.DiscountData)
                ) && 
                (
                    this.ModifierListData == other.ModifierListData ||
                    this.ModifierListData != null &&
                    this.ModifierListData.Equals(other.ModifierListData)
                ) && 
                (
                    this.ModifierData == other.ModifierData ||
                    this.ModifierData != null &&
                    this.ModifierData.Equals(other.ModifierData)
                ) && 
                (
                    this.ImageData == other.ImageData ||
                    this.ImageData != null &&
                    this.ImageData.Equals(other.ImageData)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.IsDeleted != null)
                    hash = hash * 59 + this.IsDeleted.GetHashCode();
                if (this.CatalogV1Ids != null)
                    hash = hash * 59 + this.CatalogV1Ids.GetHashCode();
                if (this.PresentAtAllLocations != null)
                    hash = hash * 59 + this.PresentAtAllLocations.GetHashCode();
                if (this.PresentAtLocationIds != null)
                    hash = hash * 59 + this.PresentAtLocationIds.GetHashCode();
                if (this.AbsentAtLocationIds != null)
                    hash = hash * 59 + this.AbsentAtLocationIds.GetHashCode();
                if (this.ImageId != null)
                    hash = hash * 59 + this.ImageId.GetHashCode();
                if (this.ItemData != null)
                    hash = hash * 59 + this.ItemData.GetHashCode();
                if (this.CategoryData != null)
                    hash = hash * 59 + this.CategoryData.GetHashCode();
                if (this.ItemVariationData != null)
                    hash = hash * 59 + this.ItemVariationData.GetHashCode();
                if (this.TaxData != null)
                    hash = hash * 59 + this.TaxData.GetHashCode();
                if (this.DiscountData != null)
                    hash = hash * 59 + this.DiscountData.GetHashCode();
                if (this.ModifierListData != null)
                    hash = hash * 59 + this.ModifierListData.GetHashCode();
                if (this.ModifierData != null)
                    hash = hash * 59 + this.ModifierData.GetHashCode();
                if (this.ImageData != null)
                    hash = hash * 59 + this.ImageData.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
