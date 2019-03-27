# Square.Connect.Model.ListTransactionsRequest

### Description

Defines the query parameters that can be included in a request to the [ListTransactions](#endpoint-listtransactions) endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginTime** | **string** | The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. | [optional] 
**EndTime** | **string** | The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. | [optional] 
**SortOrder** | **SortOrderEnum** | The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; See [SortOrder](#type-sortorder) for possible values | [optional] 
**Cursor** | **string** | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 


## SortOrderEnum

Name | Value
------------ | -------------
**DESC** | "DESC"
**ASC** | "ASC"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

