# Square.Connect.Model.ShiftFilter

### Description

Defines a filter used in a search for `Shift` records. `AND` logic is used by Square's servers to apply each filter property specified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationId** | **List<string>** | Fetch shifts for the specified location. | [optional] 
**EmployeeId** | **List<string>** | Fetch shifts for the specified employee. | [optional] 
**Status** | **StatusEnum** | Fetch a &#x60;Shift&#x60; instance by &#x60;Shift.status&#x60;. See [ShiftFilterStatus](#type-shiftfilterstatus) for possible values | [optional] 
**Start** | [**TimeRange**](TimeRange.md) | Fetch &#x60;Shift&#x60;s that start in the time range - Inclusive. | [optional] 
**End** | [**TimeRange**](TimeRange.md) | Fetch the &#x60;Shift&#x60;s that end in the time range - Inclusive. | [optional] 
**Workday** | [**ShiftWorkday**](ShiftWorkday.md) | Fetch the &#x60;Shift&#x60;s based on workday date range. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**OPEN** | "OPEN"
**CLOSED** | "CLOSED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

