# Square.Connect.Model.OrderReturnDiscount

### Description

Represents a discount being returned that applies to one or more return line items in an order.  Fixed-amount, order-scoped discounts are distributed across all non-zero return line item totals. The amount distributed to each return line item is relative to that item’s contribution to the order subtotal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the return discount only within this order. | [optional] 
**SourceDiscountUid** | **string** | &#x60;uid&#x60; of the Discount from the Order which contains the original application of this discount. | [optional] 
**CatalogObjectId** | **string** | The catalog object id referencing &#x60;CatalogDiscount&#x60;. | [optional] 
**Name** | **string** | The discount&#39;s name. | [optional] 
**Type** | **string** | The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  Discounts that don&#39;t reference a catalog object ID must have a type of &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;. See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  &#x60;percentage&#x60; is not set for amount-based discounts. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The total declared monetary amount of the discount.  &#x60;amount_money&#x60; is not set for percentage-based discounts. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of discount actually applied to this line item. When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items. | [optional] 
**Scope** | **string** | Indicates the level at which the &#x60;OrderReturnDiscount&#x60; applies. For &#x60;ORDER&#x60; scoped discounts, the server will generate references in &#x60;applied_discounts&#x60; on all &#x60;OrderReturnLineItem&#x60;s. For &#x60;LINE_ITEM&#x60; scoped discounts, the discount will only apply to &#x60;OrderReturnLineItem&#x60;s with references in their &#x60;applied_discounts&#x60; field. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

