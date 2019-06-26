# Square.Connect.Model.V1CashDrawerShift

### Description

Contains details for a single cash drawer shift.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The shift&#39;s unique ID. | [optional] 
**EventType** | **EventTypeEnum** | The shift&#39;s current state. See [V1CashDrawerShiftEventType](#type-v1cashdrawershifteventtype) for possible values | [optional] 
**OpenedAt** | **string** | The time when the shift began, in ISO 8601 format. | [optional] 
**EndedAt** | **string** | The time when the shift ended, in ISO 8601 format. | [optional] 
**ClosedAt** | **string** | The time when the shift was closed, in ISO 8601 format. | [optional] 
**EmployeeIds** | **List<string>** | The IDs of all employees that were logged into Square Register at some point during the cash drawer shift. | [optional] 
**OpeningEmployeeId** | **string** | The ID of the employee that started the cash drawer shift. | [optional] 
**EndingEmployeeId** | **string** | The ID of the employee that ended the cash drawer shift. | [optional] 
**ClosingEmployeeId** | **string** | The ID of the employee that closed the cash drawer shift by auditing the cash drawer&#39;s contents. | [optional] 
**Description** | **string** | A description of the cash drawer shift. | [optional] 
**StartingCashMoney** | [**V1Money**](V1Money.md) | The amount of money in the cash drawer at the start of the shift. | [optional] 
**CashPaymentMoney** | [**V1Money**](V1Money.md) | The amount of money added to the cash drawer from cash payments. | [optional] 
**CashRefundsMoney** | [**V1Money**](V1Money.md) | The amount of money removed from the cash drawer from cash refunds. This value is always negative or zero. | [optional] 
**CashPaidInMoney** | [**V1Money**](V1Money.md) | The amount of money added to the cash drawer for reasons other than cash payments. | [optional] 
**CashPaidOutMoney** | [**V1Money**](V1Money.md) | The amount of money removed from the cash drawer for reasons other than cash refunds. | [optional] 
**ExpectedCashMoney** | [**V1Money**](V1Money.md) | The amount of money that should be in the cash drawer at the end of the shift, based on the shift&#39;s other money amounts. | [optional] 
**ClosedCashMoney** | [**V1Money**](V1Money.md) | The amount of money found in the cash drawer at the end of the shift by an auditing employee. | [optional] 
**Device** | [**Device**](Device.md) | The device running Square Register that was connected to the cash drawer. | [optional] 
**Events** | [**List&lt;V1CashDrawerEvent&gt;**](V1CashDrawerEvent.md) | All of the events (payments, refunds, and so on) that involved the cash drawer during the shift. | [optional] 


## EventTypeEnum

Name | Value
------------ | -------------
**OPEN** | "OPEN"
**ENDED** | "ENDED"
**CLOSED** | "CLOSED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

