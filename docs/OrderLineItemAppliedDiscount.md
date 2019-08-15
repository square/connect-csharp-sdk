# Square.Connect.Model.OrderLineItemAppliedDiscount

### Description

Represents an applied portion of a discount to a line item in an order.  Order scoped discounts will automatically have applied discounts present for each line item. Line item scoped discounts must have applied discounts added manually for any applicable line items. The corresponding applied money will automatically be computed based on participating line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the applied discount only within this order. | [optional] 
**DiscountUid** | **string** | The &#x60;uid&#x60; of the discount the applied discount represents. Must reference a discount present in the &#x60;order.discounts&#x60; field.  This field is immutable. To change which discounts apply to a line item, you must delete the discount and re-add it as a new &#x60;OrderLineItemAppliedDiscount&#x60;. | 
**AppliedMoney** | [**Money**](Money.md) | The amount of money applied by the discount to the line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

