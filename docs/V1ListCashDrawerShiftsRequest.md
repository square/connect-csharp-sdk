# Square.Connect.Model.V1ListCashDrawerShiftsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **OrderEnum** | The order in which cash drawer shifts are listed in the response, based on their created_at field. Default value: ASC See [SortOrder](#type-sortorder) for possible values | [optional] 
**BeginTime** | **string** | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time minus 90 days. | [optional] 
**EndTime** | **string** | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time. | [optional] 


## OrderEnum

Name | Value
------------ | -------------
**DESC** | "DESC"
**ASC** | "ASC"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

