# Square.Connect.Model.BatchRetrieveInventoryCountsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogObjectIds** | **List<string>** | Filters results by &#x60;CatalogObject&#x60; ID. Only applied when set. Default: unset. | [optional] 
**LocationIds** | **List<string>** | Filters results by &#x60;Location&#x60; ID. Only applied when set. Default: unset. | [optional] 
**UpdatedAfter** | **string** | Provided as an RFC 3339 timestamp. Returns results whose &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;). | [optional] 
**Cursor** | **string** | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

