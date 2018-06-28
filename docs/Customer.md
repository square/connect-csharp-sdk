# Square.Connect.Model.Customer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The customer&#39;s unique ID. | 
**CreatedAt** | **string** | The time when the customer was created, in RFC 3339 format. | 
**UpdatedAt** | **string** | The time when the customer was last updated, in RFC 3339 format. | 
**Cards** | [**List&lt;Card&gt;**](Card.md) | The non-confidential details of the customer&#39;s cards on file. | [optional] 
**GivenName** | **string** | The customer&#39;s given (i.e., first) name. | [optional] 
**FamilyName** | **string** | The customer&#39;s family (i.e., last) name. | [optional] 
**Nickname** | **string** | The customer&#39;s nickname. | [optional] 
**CompanyName** | **string** | The name of the customer&#39;s company. | [optional] 
**EmailAddress** | **string** | The customer&#39;s email address. | [optional] 
**Address** | [**Address**](Address.md) | The customer&#39;s physical address. | [optional] 
**PhoneNumber** | **string** | The customer&#39;s phone number. | [optional] 
**ReferenceId** | **string** | A second ID you can set to associate the customer with an entity in another system. | [optional] 
**Note** | **string** | A note to associate with the customer. | [optional] 
**Preferences** | [**CustomerPreferences**](CustomerPreferences.md) | The customer&#39;s preferences. | [optional] 
**Groups** | [**List&lt;CustomerGroupInfo&gt;**](CustomerGroupInfo.md) | The groups the customer belongs to. | [optional] 
**CreationSource** | **CreationSourceEnum** | A creation source represents the method used to create the customer profile. | [optional] 


## CreationSourceEnum

Name | Value
------------ | -------------
**OTHER** | "OTHER"
**APPOINTMENTS** | "APPOINTMENTS"
**COUPON** | "COUPON"
**DELETIONRECOVERY** | "DELETION_RECOVERY"
**DIRECTORY** | "DIRECTORY"
**EGIFTING** | "EGIFTING"
**EMAILCOLLECTION** | "EMAIL_COLLECTION"
**FEEDBACK** | "FEEDBACK"
**IMPORT** | "IMPORT"
**INVOICES** | "INVOICES"
**LOYALTY** | "LOYALTY"
**MARKETING** | "MARKETING"
**MERGE** | "MERGE"
**ONLINESTORE** | "ONLINE_STORE"
**INSTANTPROFILE** | "INSTANT_PROFILE"
**TERMINAL** | "TERMINAL"
**THIRDPARTY** | "THIRD_PARTY"
**THIRDPARTYIMPORT** | "THIRD_PARTY_IMPORT"
**UNMERGERECOVERY** | "UNMERGE_RECOVERY"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

