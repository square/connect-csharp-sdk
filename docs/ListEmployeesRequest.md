# Square.Connect.Model.ListEmployeesRequest

### Description

Retrieve a paged-list of employees for a Square account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationId** | **string** | Filter employees returned to only those that are associated with the specified location. | [optional] 
**Status** | **StatusEnum** | Specifies the EmployeeStatus to filter the employee by. | [optional] 
**Limit** | **int?** | The number of employees to be returned on each page. | [optional] 
**Cursor** | **string** | The token required to retrieve the specified page of results. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**ACTIVE** | "ACTIVE"
**INACTIVE** | "INACTIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

