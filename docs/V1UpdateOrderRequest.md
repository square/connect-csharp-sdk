# Square.Connect.Model.V1UpdateOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **ActionEnum** | The action to perform on the order (COMPLETE, CANCEL, or REFUND). | 
**ShippedTrackingNumber** | **string** | The tracking number of the shipment associated with the order. Only valid if action is COMPLETE. | [optional] 
**CompletedNote** | **string** | A merchant-specified note about the completion of the order. Only valid if action is COMPLETE. | [optional] 
**RefundedNote** | **string** | A merchant-specified note about the refunding of the order. Only valid if action is REFUND. | [optional] 
**CanceledNote** | **string** | A merchant-specified note about the canceling of the order. Only valid if action is CANCEL. | [optional] 


## ActionEnum

Name | Value
------------ | -------------
**COMPLETE** | "COMPLETE"
**CANCEL** | "CANCEL"
**REFUND** | "REFUND"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

