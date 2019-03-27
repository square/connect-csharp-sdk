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
    /// Represents one of a business&#39;s customers, which can have one or more cards on file associated with it.
    /// </summary>
    [DataContract]
    public partial class Customer :  IEquatable<Customer>, IValidatableObject
    {
        /// <summary>
        /// A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values
        /// </summary>
        /// <value>A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreationSourceEnum
        {
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER,
            
            /// <summary>
            /// Enum APPOINTMENTS for "APPOINTMENTS"
            /// </summary>
            [EnumMember(Value = "APPOINTMENTS")]
            APPOINTMENTS,
            
            /// <summary>
            /// Enum COUPON for "COUPON"
            /// </summary>
            [EnumMember(Value = "COUPON")]
            COUPON,
            
            /// <summary>
            /// Enum DELETIONRECOVERY for "DELETION_RECOVERY"
            /// </summary>
            [EnumMember(Value = "DELETION_RECOVERY")]
            DELETIONRECOVERY,
            
            /// <summary>
            /// Enum DIRECTORY for "DIRECTORY"
            /// </summary>
            [EnumMember(Value = "DIRECTORY")]
            DIRECTORY,
            
            /// <summary>
            /// Enum EGIFTING for "EGIFTING"
            /// </summary>
            [EnumMember(Value = "EGIFTING")]
            EGIFTING,
            
            /// <summary>
            /// Enum EMAILCOLLECTION for "EMAIL_COLLECTION"
            /// </summary>
            [EnumMember(Value = "EMAIL_COLLECTION")]
            EMAILCOLLECTION,
            
            /// <summary>
            /// Enum FEEDBACK for "FEEDBACK"
            /// </summary>
            [EnumMember(Value = "FEEDBACK")]
            FEEDBACK,
            
            /// <summary>
            /// Enum IMPORT for "IMPORT"
            /// </summary>
            [EnumMember(Value = "IMPORT")]
            IMPORT,
            
            /// <summary>
            /// Enum INVOICES for "INVOICES"
            /// </summary>
            [EnumMember(Value = "INVOICES")]
            INVOICES,
            
            /// <summary>
            /// Enum LOYALTY for "LOYALTY"
            /// </summary>
            [EnumMember(Value = "LOYALTY")]
            LOYALTY,
            
            /// <summary>
            /// Enum MARKETING for "MARKETING"
            /// </summary>
            [EnumMember(Value = "MARKETING")]
            MARKETING,
            
            /// <summary>
            /// Enum MERGE for "MERGE"
            /// </summary>
            [EnumMember(Value = "MERGE")]
            MERGE,
            
            /// <summary>
            /// Enum ONLINESTORE for "ONLINE_STORE"
            /// </summary>
            [EnumMember(Value = "ONLINE_STORE")]
            ONLINESTORE,
            
            /// <summary>
            /// Enum INSTANTPROFILE for "INSTANT_PROFILE"
            /// </summary>
            [EnumMember(Value = "INSTANT_PROFILE")]
            INSTANTPROFILE,
            
            /// <summary>
            /// Enum TERMINAL for "TERMINAL"
            /// </summary>
            [EnumMember(Value = "TERMINAL")]
            TERMINAL,
            
            /// <summary>
            /// Enum THIRDPARTY for "THIRD_PARTY"
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY")]
            THIRDPARTY,
            
            /// <summary>
            /// Enum THIRDPARTYIMPORT for "THIRD_PARTY_IMPORT"
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY_IMPORT")]
            THIRDPARTYIMPORT,
            
            /// <summary>
            /// Enum UNMERGERECOVERY for "UNMERGE_RECOVERY"
            /// </summary>
            [EnumMember(Value = "UNMERGE_RECOVERY")]
            UNMERGERECOVERY
        }

        /// <summary>
        /// A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values
        /// </summary>
        /// <value>A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values</value>
        [DataMember(Name="creation_source", EmitDefaultValue=false)]
        public CreationSourceEnum? CreationSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Customer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        /// <param name="Id">The customer&#39;s unique ID. (required).</param>
        /// <param name="CreatedAt">The time when the customer was created, in RFC 3339 format. (required).</param>
        /// <param name="UpdatedAt">The time when the customer was last updated, in RFC 3339 format. (required).</param>
        /// <param name="Cards">The payment details of the customer&#39;s cards on file..</param>
        /// <param name="GivenName">The customer&#39;s given (i.e., first) name..</param>
        /// <param name="FamilyName">The customer&#39;s family (i.e., last) name..</param>
        /// <param name="Nickname">The customer&#39;s nickname..</param>
        /// <param name="CompanyName">The name of the customer&#39;s company..</param>
        /// <param name="EmailAddress">The customer&#39;s email address..</param>
        /// <param name="Address">The customer&#39;s physical address..</param>
        /// <param name="PhoneNumber">The customer&#39;s phone number..</param>
        /// <param name="Birthday">The customer&#39;s birthday in RFC-3339 format. Year is optional, timezone and times are not allowed. Example: &#x60;0000-09-01T00:00:00-00:00&#x60; for a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; for a birthday on September 1st 1998..</param>
        /// <param name="ReferenceId">A second ID you can set to associate the customer with an entity in another system..</param>
        /// <param name="Note">A note to associate with the customer..</param>
        /// <param name="Preferences">The customer&#39;s preferences..</param>
        /// <param name="Groups">The groups the customer belongs to..</param>
        /// <param name="CreationSource">A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values.</param>
        public Customer(string Id = default(string), string CreatedAt = default(string), string UpdatedAt = default(string), List<Card> Cards = default(List<Card>), string GivenName = default(string), string FamilyName = default(string), string Nickname = default(string), string CompanyName = default(string), string EmailAddress = default(string), Address Address = default(Address), string PhoneNumber = default(string), string Birthday = default(string), string ReferenceId = default(string), string Note = default(string), CustomerPreferences Preferences = default(CustomerPreferences), List<CustomerGroupInfo> Groups = default(List<CustomerGroupInfo>), CreationSourceEnum? CreationSource = default(CreationSourceEnum?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Customer and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for Customer and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for Customer and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            this.Cards = Cards;
            this.GivenName = GivenName;
            this.FamilyName = FamilyName;
            this.Nickname = Nickname;
            this.CompanyName = CompanyName;
            this.EmailAddress = EmailAddress;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Birthday = Birthday;
            this.ReferenceId = ReferenceId;
            this.Note = Note;
            this.Preferences = Preferences;
            this.Groups = Groups;
            this.CreationSource = CreationSource;
        }
        
        /// <summary>
        /// The customer&#39;s unique ID.
        /// </summary>
        /// <value>The customer&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The time when the customer was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the customer was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// The time when the customer was last updated, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the customer was last updated, in RFC 3339 format.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// The payment details of the customer&#39;s cards on file.
        /// </summary>
        /// <value>The payment details of the customer&#39;s cards on file.</value>
        [DataMember(Name="cards", EmitDefaultValue=false)]
        public List<Card> Cards { get; set; }
        /// <summary>
        /// The customer&#39;s given (i.e., first) name.
        /// </summary>
        /// <value>The customer&#39;s given (i.e., first) name.</value>
        [DataMember(Name="given_name", EmitDefaultValue=false)]
        public string GivenName { get; set; }
        /// <summary>
        /// The customer&#39;s family (i.e., last) name.
        /// </summary>
        /// <value>The customer&#39;s family (i.e., last) name.</value>
        [DataMember(Name="family_name", EmitDefaultValue=false)]
        public string FamilyName { get; set; }
        /// <summary>
        /// The customer&#39;s nickname.
        /// </summary>
        /// <value>The customer&#39;s nickname.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }
        /// <summary>
        /// The name of the customer&#39;s company.
        /// </summary>
        /// <value>The name of the customer&#39;s company.</value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// The customer&#39;s physical address.
        /// </summary>
        /// <value>The customer&#39;s physical address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
        /// <summary>
        /// The customer&#39;s phone number.
        /// </summary>
        /// <value>The customer&#39;s phone number.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The customer&#39;s birthday in RFC-3339 format. Year is optional, timezone and times are not allowed. Example: &#x60;0000-09-01T00:00:00-00:00&#x60; for a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; for a birthday on September 1st 1998.
        /// </summary>
        /// <value>The customer&#39;s birthday in RFC-3339 format. Year is optional, timezone and times are not allowed. Example: &#x60;0000-09-01T00:00:00-00:00&#x60; for a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; for a birthday on September 1st 1998.</value>
        [DataMember(Name="birthday", EmitDefaultValue=false)]
        public string Birthday { get; set; }
        /// <summary>
        /// A second ID you can set to associate the customer with an entity in another system.
        /// </summary>
        /// <value>A second ID you can set to associate the customer with an entity in another system.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// A note to associate with the customer.
        /// </summary>
        /// <value>A note to associate with the customer.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// The customer&#39;s preferences.
        /// </summary>
        /// <value>The customer&#39;s preferences.</value>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public CustomerPreferences Preferences { get; set; }
        /// <summary>
        /// The groups the customer belongs to.
        /// </summary>
        /// <value>The groups the customer belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<CustomerGroupInfo> Groups { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CreationSource: ").Append(CreationSource).Append("\n");
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
            return this.Equals(obj as Customer);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
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
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Cards == other.Cards ||
                    this.Cards != null &&
                    this.Cards.SequenceEqual(other.Cards)
                ) && 
                (
                    this.GivenName == other.GivenName ||
                    this.GivenName != null &&
                    this.GivenName.Equals(other.GivenName)
                ) && 
                (
                    this.FamilyName == other.FamilyName ||
                    this.FamilyName != null &&
                    this.FamilyName.Equals(other.FamilyName)
                ) && 
                (
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Birthday == other.Birthday ||
                    this.Birthday != null &&
                    this.Birthday.Equals(other.Birthday)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.Preferences == other.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.Equals(other.Preferences)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.CreationSource == other.CreationSource ||
                    this.CreationSource != null &&
                    this.CreationSource.Equals(other.CreationSource)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Cards != null)
                    hash = hash * 59 + this.Cards.GetHashCode();
                if (this.GivenName != null)
                    hash = hash * 59 + this.GivenName.GetHashCode();
                if (this.FamilyName != null)
                    hash = hash * 59 + this.FamilyName.GetHashCode();
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Birthday != null)
                    hash = hash * 59 + this.Birthday.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.Preferences != null)
                    hash = hash * 59 + this.Preferences.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.CreationSource != null)
                    hash = hash * 59 + this.CreationSource.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
