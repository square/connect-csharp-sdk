# Square.Connect.Model.OrderFulfillmentPickupDetails

### Description

Contains details necessary to fulfill a pickup order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Recipient** | [**OrderFulfillmentRecipient**](OrderFulfillmentRecipient.md) | Information on the person meant to pick up this fulfillment from a physical location. | [optional] 
**ExpiresAt** | **string** | The [timestamp](#workingwithdates) indicating when this fulfillment will expire if it is not accepted. Must be in RFC 3339 format e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. Expiration time can only be set up to 7 days in the future. If &#x60;expires_at&#x60; is not set, this pickup fulfillment will be automatically accepted when placed. | [optional] 
**AutoCompleteDuration** | **string** | The duration of time after which an open and accepted pickup fulfillment will automatically move to the &#x60;COMPLETED&#x60; state. Must be in RFC3339 duration format e.g., \&quot;P1W3D\&quot;.  If not set, this pickup fulfillment will remain accepted until it is canceled or completed. | [optional] 
**ScheduleType** | **string** | The schedule type of the pickup fulfillment. Defaults to &#x60;SCHEDULED&#x60;. See [OrderFulfillmentPickupDetailsScheduleType](#type-orderfulfillmentpickupdetailsscheduletype) for possible values | [optional] 
**PickupAt** | **string** | The [timestamp](#workingwithdates) that represents the start of the pickup window. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. For fulfillments with the schedule type &#x60;ASAP&#x60;, this is automatically set to the current time plus the expected duration to prepare the fulfillment. | [optional] 
**PickupWindowDuration** | **string** | The window of time in which the order should be picked up after the &#x60;pickup_at&#x60; timestamp. Must be in RFC3339 duration format, e.g., \&quot;P1W3D\&quot;. Can be used as an informational guideline for merchants. | [optional] 
**PrepTimeDuration** | **string** | The duration of time it takes to prepare this fulfillment. Must be in RFC3339 duration format, e.g., \&quot;P1W3D\&quot;. | [optional] 
**Note** | **string** | A note meant to provide additional instructions about the pickup fulfillment displayed in the Square Point of Sale and set by the API. | [optional] 
**PlacedAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment was placed. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**AcceptedAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment was accepted. In RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**RejectedAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment was rejected. In RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**ReadyAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment is marked as ready for pickup. In RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**ExpiredAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment expired. In RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**PickedUpAt** | **string** | The [timestamp](#workingwithdates) indicating when the fulfillment was picked up by the recipient. In RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**CanceledAt** | **string** | The [timestamp](#workingwithdates) in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;, indicating when the fulfillment was canceled. | [optional] 
**CancelReason** | **string** | A description of why the pickup was canceled. Max length: 100 characters. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

