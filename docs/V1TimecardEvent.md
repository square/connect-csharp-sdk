# Square.Connect.Model.V1TimecardEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The event&#39;s unique ID. | [optional] 
**EventType** | **EventTypeEnum** | The ID of the timecard to list events for. | [optional] 
**ClockinTime** | **string** | The time the employee clocked in, in ISO 8601 format. | [optional] 
**ClockoutTime** | **string** | The time the employee clocked out, in ISO 8601 format. | [optional] 
**CreatedAt** | **string** | The time when the event was created, in ISO 8601 format. | [optional] 


## EventTypeEnum

Name | Value
------------ | -------------
**APICREATE** | "API_CREATE"
**APIEDIT** | "API_EDIT"
**APIDELETE** | "API_DELETE"
**REGISTERCLOCKIN** | "REGISTER_CLOCKIN"
**REGISTERCLOCKOUT** | "REGISTER_CLOCKOUT"
**DASHBOARDSUPERVISORCLOSE** | "DASHBOARD_SUPERVISOR_CLOSE"
**DASHBOARDEDIT** | "DASHBOARD_EDIT"
**DASHBOARDDELETE** | "DASHBOARD_DELETE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

