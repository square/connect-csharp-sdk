# Square.Connect.Model.ChargeResponse

### Description

Defines the fields that are included in the response body of a request to the Charge endpoint.  One of `errors` or `transaction` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Transaction** | [**Transaction**](Transaction.md) | The created transaction. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

