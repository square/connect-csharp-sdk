# Square.Connect.Model.BatchRetrieveOrdersResponse

### Description

Defines the fields that are included in the response body of a request to the BatchRetrieveOrders endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Orders** | [**List&lt;Order&gt;**](Order.md) | The requested orders. This will omit any requested orders that do not exist or are not charged. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**UnconvertibleTransactionIds** | **List<string>** | List of transaction ids within the requested set of ids that encountered transformation issues when being converted to an Order. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

