# Square.Connect.Model.SearchCustomersResponse

### Description

Defines the fields that are included in the response body of a request to the SearchCustomers endpoint.  One of `errors` or `customers` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Customers** | [**List&lt;Customer&gt;**](Customer.md) | An array of &#x60;Customer&#x60; objects that match a query. | [optional] 
**Cursor** | **string** | A pagination cursor that can be used during subsequent calls to SearchCustomers to retrieve the next set of results associated with the original query. Pagination cursors are only present when a request succeeds and additional results are available.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

