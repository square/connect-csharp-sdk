# Square.Connect.Model.SearchOrdersRequest

### Description

The request does not have any required fields. When given no query criteria, SearchOrders will return all results for all of the merchant’s locations. When fetching additional pages using a `cursor`, the `query` must be equal to the `query` used to fetch the first page of results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationIds** | **List<string>** | The location IDs for the orders to query. All locations must belong to the same merchant.  Min: 1 location IDs.  Max: 10 location IDs. | [optional] 
**Cursor** | **string** | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query. See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. | [optional] 
**Query** | [**SearchOrdersQuery**](SearchOrdersQuery.md) | Query conditions used to filter or sort the results. Note that when fetching additional pages using a cursor, the query must be equal to the query used to fetch the first page of results. | [optional] 
**Limit** | **int?** | Maximum number of results to be returned in a single page. It is possible to receive fewer results than the specified limit on a given page.  Default: &#x60;500&#x60; | [optional] 
**ReturnEntries** | **bool?** | Boolean that controls the format of the search results. If &#x60;true&#x60;, SearchOrders will return &#x60;&#x60;OrderEntry&#x60;&#x60; objects. If &#x60;false&#x60;, SearchOrders will return complete Order objects.  Default: &#x60;false&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

