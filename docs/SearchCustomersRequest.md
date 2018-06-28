# Square.Connect.Model.SearchCustomersRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | **string** | Include the pagination cursor in subsequent calls to this endpoint to retrieve the next set of results associated with the original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 
**Limit** | **long?** | A limit on the number of results to be returned in a single page. The limit is advisory - the implementation may return more or fewer results. If the supplied limit is negative, zero, or is higher than the maximum limit of 1,000, it will be ignored. | [optional] 
**Query** | [**CustomerQuery**](CustomerQuery.md) | Query customers based on the given conditions and sort order. Calling SearchCustomers without an explicit query parameter will return all customers ordered alphabetically based on &#x60;given_name&#x60; and &#x60;family_name&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

