# Square.Connect.Model.CreateCustomerRequest

### Description

Defines the body parameters that can be provided in a request to the CreateCustomer endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdempotencyKey** | **string** | The idempotency key for the request. See the [Idempotency](https://developer.squareup.com/docs/basics/api101/idempotency) guide for more information. | [optional] 
**GivenName** | **string** | The customer&#39;s given (i.e., first) name. | [optional] 
**FamilyName** | **string** | The customer&#39;s family (i.e., last) name. | [optional] 
**CompanyName** | **string** | The name of the customer&#39;s company. | [optional] 
**Nickname** | **string** | A nickname for the customer. | [optional] 
**EmailAddress** | **string** | The customer&#39;s email address. | [optional] 
**Address** | [**Address**](Address.md) | The customer&#39;s physical address. | [optional] 
**PhoneNumber** | **string** | The customer&#39;s phone number. | [optional] 
**ReferenceId** | **string** | An optional second ID you can set to associate the customer with an entity in another system. | [optional] 
**Note** | **string** | An optional note to associate with the customer. | [optional] 
**Birthday** | **string** | The customer birthday in RFC-3339 format. Year is optional, timezone and times are not allowed. Example: &#x60;0000-09-01T00:00:00-00:00&#x60; for a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; for a birthday on September 1st 1998. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

