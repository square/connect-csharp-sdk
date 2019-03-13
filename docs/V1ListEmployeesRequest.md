# Square.Connect.Model.V1ListEmployeesRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **OrderEnum** | The order in which employees are listed in the response, based on their created_at field.      Default value: ASC See [SortOrder](#type-sortorder) for possible values | [optional] 
**BeginUpdatedAt** | **string** | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format | [optional] 
**EndUpdatedAt** | **string** | If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
**BeginCreatedAt** | **string** | If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
**EndCreatedAt** | **string** | If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
**Status** | **StatusEnum** | If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE). See [V1ListEmployeesRequestStatus](#type-v1listemployeesrequeststatus) for possible values | [optional] 
**ExternalId** | **string** | If provided, the endpoint returns only employee entities with the specified external_id. | [optional] 
**Limit** | **int?** | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. | [optional] 
**BatchToken** | **string** | A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 


## OrderEnum

Name | Value
------------ | -------------
**DESC** | "DESC"
**ASC** | "ASC"


## StatusEnum

Name | Value
------------ | -------------
**ACTIVE** | "ACTIVE"
**INACTIVE** | "INACTIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

