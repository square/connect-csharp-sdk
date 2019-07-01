# Square.Connect.Model.V1UpdateOrderRequest

### Description

V1UpdateOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The action to perform on the order (COMPLETE, CANCEL, or REFUND). See [V1UpdateOrderRequestAction](#type-v1updateorderrequestaction) for possible values | 
**ShippedTrackingNumber** | **string** | The tracking number of the shipment associated with the order. Only valid if action is COMPLETE. | [optional] 
**CompletedNote** | **string** | A merchant-specified note about the completion of the order. Only valid if action is COMPLETE. | [optional] 
**RefundedNote** | **string** | A merchant-specified note about the refunding of the order. Only valid if action is REFUND. | [optional] 
**CanceledNote** | **string** | A merchant-specified note about the canceling of the order. Only valid if action is CANCEL. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

