# Square.Connect.Model.V1ListTimecardsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **OrderEnum** | The order in which timecards are listed in the response, based on their created_at field. See [SortOrder](#type-sortorder) for possible values | [optional] 
**EmployeeId** | **string** | If provided, the endpoint returns only timecards for the employee with the specified ID. | [optional] 
**BeginClockinTime** | **string** | If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
**EndClockinTime** | **string** | If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
**BeginClockoutTime** | **string** | If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
**EndClockoutTime** | **string** | If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
**BeginUpdatedAt** | **string** | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
**EndUpdatedAt** | **string** | If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
**Deleted** | **bool?** | If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don&#39;t provide this parameter, both valid and deleted timecards are returned. | [optional] 
**Limit** | **int?** | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. | [optional] 
**BatchToken** | **string** | A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 


## OrderEnum

Name | Value
------------ | -------------
**DESC** | "DESC"
**ASC** | "ASC"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

