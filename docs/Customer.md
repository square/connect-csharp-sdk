# Square.Connect.Model.Customer

### Description

Represents a Square customer profile, which can have one or more cards on file associated with it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique, Square-assigned object ID. | 
**CreatedAt** | **string** | The time when the customer profile was created, in RFC 3339 format. | 
**UpdatedAt** | **string** | The time when the customer profile was last updated, in RFC 3339 format. | 
**Cards** | [**List&lt;Card&gt;**](Card.md) | Payment details of cards stored on file for the customer profile. | [optional] 
**GivenName** | **string** | The given (i.e., first) name associated with the customer profile. | [optional] 
**FamilyName** | **string** | The family (i.e., last) name associated with the customer profile. | [optional] 
**Nickname** | **string** | A nickname for the customer profile. | [optional] 
**CompanyName** | **string** | A business name associated with the customer profile. | [optional] 
**EmailAddress** | **string** | The email address associated with the customer profile. | [optional] 
**Address** | [**Address**](Address.md) | The physical address associated with the customer profile. | [optional] 
**PhoneNumber** | **string** | The 11-digit phone number associated with the customer profile. | [optional] 
**Birthday** | **string** | The birthday associated with the customer profile, in RFC-3339 format. Year is optional, timezone and times are not allowed. For example: &#x60;0000-09-01T00:00:00-00:00&#x60; indicates a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; indications a birthday on September 1st __1998__. | [optional] 
**ReferenceId** | **string** | An optional, second ID used to associate the customer profile with an entity in another system. | [optional] 
**Note** | **string** | A custom note associated with the customer profile. | [optional] 
**Preferences** | [**CustomerPreferences**](CustomerPreferences.md) | Represents general customer preferences. | [optional] 
**Groups** | [**List&lt;CustomerGroupInfo&gt;**](CustomerGroupInfo.md) | The groups the customer belongs to. | [optional] 
**CreationSource** | **string** | A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

