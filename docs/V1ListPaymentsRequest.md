# Square.Connect.Model.V1ListPaymentsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **string** | The order in which payments are listed in the response. See [SortOrder](#type-sortorder) for possible values | [optional] 
**BeginTime** | **string** | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. | [optional] 
**EndTime** | **string** | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. | [optional] 
**Limit** | **int?** | The maximum number of payments to return in a single response. This value cannot exceed 200. | [optional] 
**BatchToken** | **string** | A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 
**IncludePartial** | **bool?** | Indicates whether or not to include partial payments in the response. Partial payments will have the tenders collected so far, but the itemizations will be empty until the payment is completed. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

