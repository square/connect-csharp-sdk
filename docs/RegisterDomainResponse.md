# Square.Connect.Model.RegisterDomainResponse

### Description

Defines the fields that are included in the response body of a request to the __RegisterDomain__ endpoint.  Either `errors` or `status` will be present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Status** | **string** | Status of the domain registration.  See &#x60;RegisterDomainResponseStatus&#x60; for possible values. See [RegisterDomainResponseStatus](#type-registerdomainresponsestatus) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

