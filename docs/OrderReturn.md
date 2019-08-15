# Square.Connect.Model.OrderReturn

### Description

The set of line items, service charges, taxes, discounts, tips, etc. being returned in an Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the return only within this order. | [optional] 
**SourceOrderId** | **string** | Order which contains the original sale of these returned line items. This will be unset for unlinked returns. | [optional] 
**ReturnLineItems** | [**List&lt;OrderReturnLineItem&gt;**](OrderReturnLineItem.md) | Collection of line items which are being returned. | [optional] 
**ReturnServiceCharges** | [**List&lt;OrderReturnServiceCharge&gt;**](OrderReturnServiceCharge.md) | Collection of service charges which are being returned. | [optional] 
**ReturnTaxes** | [**List&lt;OrderReturnTax&gt;**](OrderReturnTax.md) | Collection of references to taxes being returned for an order, including the total applied tax amount to be returned. The taxes must reference a top-level tax ID from the source order. | [optional] 
**ReturnDiscounts** | [**List&lt;OrderReturnDiscount&gt;**](OrderReturnDiscount.md) | Collection of references to discounts being returned for an order, including the total applied discount amount to be returned. The discounts must reference a top-level discount ID from the source order. | [optional] 
**RoundingAdjustment** | [**OrderRoundingAdjustment**](OrderRoundingAdjustment.md) | A positive or negative rounding adjustment to the total value being returned. Commonly used to apply Cash Rounding when the minimum unit of account is smaller than the lowest physical denomination of currency. | [optional] 
**ReturnAmounts** | [**OrderMoneyAmounts**](OrderMoneyAmounts.md) | Aggregate monetary value being returned by this Return entry. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

