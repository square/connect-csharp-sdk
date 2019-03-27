# Square.Connect.Model.Shift

### Description

A record of the hourly rate, start, and end times for a single work shift  for an employee. May include a record of the start and end times for breaks  taken during the shift.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this object | [optional] 
**EmployeeId** | **string** | The ID of the employee this shift belongs to. | 
**LocationId** | **string** | The ID of the location this shift occurred at. Should be based on where the employee clocked in. | [optional] 
**Timezone** | **string** | Read-only convenience value that is calculated from the location based on &#x60;location_id&#x60;. Format: the IANA Timezone Database identifier for the location timezone. | [optional] 
**StartAt** | **string** | RFC 3339; shifted to location timezone + offset. Precision up to the minute is respected; seconds are truncated. | 
**EndAt** | **string** | RFC 3339; shifted to timezone + offset. Precision up to the minute is respected; seconds are truncated. The &#x60;end_at&#x60; minute is not counted when the shift length is calculated. For example, a shift from &#x60;00:00&#x60; to &#x60;08:01&#x60; is considered an 8 hour shift (midnight to 8am). | [optional] 
**Wage** | [**ShiftWage**](ShiftWage.md) | Job and pay related information. | [optional] 
**Breaks** | [**List&lt;ModelBreak&gt;**](ModelBreak.md) | A list of any paid or unpaid breaks that were taken during this shift. | [optional] 
**Status** | **StatusEnum** | Describes working state of the current &#x60;Shift&#x60;. See [ShiftStatus](#type-shiftstatus) for possible values | [optional] 
**Version** | **int?** | Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If not provided, Square executes a blind write; potentially overwriting data from another write. | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format; presented in UTC. | [optional] 
**UpdatedAt** | **string** | A read-only timestamp in RFC 3339 format; presented in UTC. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**OPEN** | "OPEN"
**CLOSED** | "CLOSED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

