# Square.Connect.Model.V1Employee

### Description

Represents one of a business's employees.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The employee&#39;s unique ID. | [optional] 
**FirstName** | **string** | The employee&#39;s first name. | 
**LastName** | **string** | The employee&#39;s last name. | 
**RoleIds** | **List<string>** | The ids of the employee&#39;s associated roles. Currently, you can specify only one or zero roles per employee. | [optional] 
**AuthorizedLocationIds** | **List<string>** | The IDs of the locations the employee is allowed to clock in at. | [optional] 
**Email** | **string** | The employee&#39;s email address. | [optional] 
**Status** | **StatusEnum** | CWhether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard. See [V1EmployeeStatus](#type-v1employeestatus) for possible values | [optional] 
**ExternalId** | **string** | An ID the merchant can set to associate the employee with an entity in another system. | [optional] 
**CreatedAt** | **string** | The time when the employee entity was created, in ISO 8601 format. | [optional] 
**UpdatedAt** | **string** | The time when the employee entity was most recently updated, in ISO 8601 format. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**ACTIVE** | "ACTIVE"
**INACTIVE** | "INACTIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

