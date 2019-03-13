# Square.Connect.Model.EmployeeWage

### Description

The hourly wage rate that an employee will earn on a `Shift` for doing the job specified by the `title` property of this object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this object. | [optional] 
**EmployeeId** | **string** | The &#x60;Employee&#x60; that this wage is assigned to. | 
**Title** | **string** | The job title that this wage relates to. | [optional] 
**HourlyRate** | [**Money**](Money.md) | Can be a custom-set hourly wage or the calculated effective hourly wage based on annual wage and hours worked per week. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

