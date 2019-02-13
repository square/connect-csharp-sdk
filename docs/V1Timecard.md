# Square.Connect.Model.V1Timecard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The timecard&#39;s unique ID. | [optional] 
**EmployeeId** | **string** | The ID of the employee the timecard is associated with. | 
**Deleted** | **bool?** | If true, the timecard was deleted by the merchant, and it is no longer valid. | [optional] 
**ClockinTime** | **string** | The clock-in time for the timecard, in ISO 8601 format. | [optional] 
**ClockoutTime** | **string** | The clock-out time for the timecard, in ISO 8601 format. Provide this value only if importing timecard information from another system. | [optional] 
**ClockinLocationId** | **string** | The ID of the location the employee clocked in from. We strongly reccomend providing a clockin_location_id. Square uses the clockin_location_id to determine a timecard���s timezone and overtime rules. | [optional] 
**ClockoutLocationId** | **string** | The ID of the location the employee clocked out from. Provide this value only if importing timecard information from another system. | [optional] 
**CreatedAt** | **string** | The time when the timecard was created, in ISO 8601 format. | [optional] 
**UpdatedAt** | **string** | The time when the timecard was most recently updated, in ISO 8601 format. | [optional] 
**RegularSecondsWorked** | **decimal?** | The total number of regular (non-overtime) seconds worked in the timecard. | [optional] 
**OvertimeSecondsWorked** | **decimal?** | The total number of overtime seconds worked in the timecard. | [optional] 
**DoubletimeSecondsWorked** | **decimal?** | The total number of doubletime seconds worked in the timecard. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

