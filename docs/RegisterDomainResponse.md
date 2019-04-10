# Square.Connect.Model.RegisterDomainResponse

### Description

Defines the fields that are included in the response body of a request to the RegisterDomain endpoint.  Either `errors` or `status` will be present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Status** | **StatusEnum** | Status of the domain registration. See [RegisterDomainResponseStatus](#type-registerdomainresponsestatus) for possible values | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**PENDING** | "PENDING"
**VERIFIED** | "VERIFIED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

