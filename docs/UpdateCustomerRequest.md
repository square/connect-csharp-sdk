# Square.Connect.Model.UpdateCustomerRequest

### Description

Defines the body parameters that can be provided in a request to the UpdateCustomer endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GivenName** | **string** | The given (i.e., first) name associated with the customer profile. | [optional] 
**FamilyName** | **string** | The family (i.e., last) name associated with the customer profile. | [optional] 
**CompanyName** | **string** | A business name associated with the customer profile. | [optional] 
**Nickname** | **string** | A nickname for the customer profile. | [optional] 
**EmailAddress** | **string** | The email address associated with the customer profile. | [optional] 
**Address** | [**Address**](Address.md) | The physical address associated with the customer profile. | [optional] 
**PhoneNumber** | **string** | The 11-digit phone number associated with the customer profile. | [optional] 
**ReferenceId** | **string** | An optional, second ID used to associate the customer profile with an entity in another system. | [optional] 
**Note** | **string** | A custom note associated with the customer profile. | [optional] 
**Birthday** | **string** | The birthday associated with the customer profile, in RFC-3339 format. Year is optional, timezone and times are not allowed. For example: &#x60;0000-09-01T00:00:00-00:00&#x60; indicates a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; indications a birthday on September 1st __1998__. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

