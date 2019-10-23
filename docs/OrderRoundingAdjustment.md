# Square.Connect.Model.OrderRoundingAdjustment

### Description

A rounding adjustment of the money being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency.
**Note: This model is in beta.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the rounding adjustment only within this order. | [optional] 
**Name** | **string** | The name of the rounding adjustment from the original sale Order. | [optional] 
**AmountMoney** | [**Money**](Money.md) | Actual rounding adjustment amount. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

