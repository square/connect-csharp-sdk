# Square.Connect.Model.ListTransactionsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginTime** | string | The beginning of the requested reporting period, in RFC 3339 format. | [optional] 
**EndTime** | string | The end of the requested reporting period, in RFC 3339 format. | [optional] 
**SortOrder** | SortOrderEnum | The order in which results are listed in the response (&#x60;ASC&#x60; for chronological, &#x60;DESC&#x60; for reverse-chronological). | [optional] 
**Cursor** | string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 


## SortOrderEnum

Name | Value
------------ | -------------
**Desc** | "DESC"
**Asc** | "ASC"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

