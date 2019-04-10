# Square.Connect.Model.CreateCustomerResponse

### Description

Defines the fields that are included in the response body of a request to the CreateCustomer endpoint.  One of `errors` or `customer` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Customer** | [**Customer**](Customer.md) | The created customer. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

