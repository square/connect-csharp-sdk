# Square.Connect.Model.OrderLineItem

### Description

Represents a line item in an order. Each line item describes a different product to purchase, with its own quantity and price details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the line item only within this order. | [optional] 
**Name** | **string** | The name of the line item. | [optional] 
**Quantity** | **string** | The quantity purchased, formatted as a decimal number. For example: &#x60;\&quot;3\&quot;&#x60;.  Line items with a &#x60;quantity_unit&#x60; can have non-integer quantities. For example: &#x60;\&quot;1.70000\&quot;&#x60;. | 
**QuantityUnit** | [**OrderQuantityUnit**](OrderQuantityUnit.md) | The unit and precision that this line item&#39;s quantity is measured in. | [optional] 
**Note** | **string** | The note of the line item. | [optional] 
**CatalogObjectId** | **string** | The [CatalogItemVariation](#type-catalogitemvariation) id applied to this line item. | [optional] 
**VariationName** | **string** | The name of the variation applied to this line item. | [optional] 
**Modifiers** | [**List&lt;OrderLineItemModifier&gt;**](OrderLineItemModifier.md) | The [CatalogModifier](#type-catalogmodifier)s applied to this line item. | [optional] 
**Taxes** | [**List&lt;OrderLineItemTax&gt;**](OrderLineItemTax.md) | A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any order-level taxes apportioned to this item. When creating an Order, set your item-level taxes in this list.  This field has been deprecated in favour of &#x60;applied_taxes&#x60;. Usage of both this field and &#x60;applied_taxes&#x60; when creating an order will result in an error. Usage of this field when sending requests to the UpdateOrder endpoint will result in an error. | [optional] 
**Discounts** | [**List&lt;OrderLineItemDiscount&gt;**](OrderLineItemDiscount.md) | A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any order-level discounts apportioned to this item. When creating an Order, set your item-level discounts in this list.  This field has been deprecated in favour of &#x60;applied_discounts&#x60;. Usage of both this field and &#x60;applied_discounts&#x60; when creating an order will result in an error. Usage of this field when sending requests to the UpdateOrder endpoint will result in an error. | [optional] 
**AppliedTaxes** | [**List&lt;OrderLineItemAppliedTax&gt;**](OrderLineItemAppliedTax.md) | The list of references to taxes applied to this line item. Each &#x60;OrderLineItemAppliedTax&#x60; has a &#x60;tax_uid&#x60; that references the &#x60;uid&#x60; of a top-level &#x60;OrderLineItemTax&#x60; applied to the line item. On reads, the amount applied is populated.  An &#x60;OrderLineItemAppliedTax&#x60; will be automatically created on every line item for all &#x60;ORDER&#x60; scoped taxes added to the order. &#x60;OrderLineItemAppliedTax&#x60; records for &#x60;LINE_ITEM&#x60; scoped taxes must be added in requests for the tax to apply to any line items.  To change the amount of a tax, modify the referenced top-level tax. | [optional] 
**AppliedDiscounts** | [**List&lt;OrderLineItemAppliedDiscount&gt;**](OrderLineItemAppliedDiscount.md) | The list of references to discounts applied to this line item. Each &#x60;OrderLineItemAppliedDiscount&#x60; has a &#x60;discount_uid&#x60; that references the &#x60;uid&#x60; of a top-level &#x60;OrderLineItemDiscounts&#x60; applied to the line item. On reads, the amount applied is populated.  An &#x60;OrderLineItemAppliedDiscount&#x60; will be automatically created on every line item for all &#x60;ORDER&#x60; scoped discounts that are added to the order. &#x60;OrderLineItemAppliedDiscount&#x60; records for &#x60;LINE_ITEM&#x60; scoped discounts must be added in requests for the discount to apply to any line items.  To change the amount of a discount, modify the referenced top-level discount. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item. | [optional] 
**VariationTotalPriceMoney** | [**Money**](Money.md) | The total price of all item variations sold in this line item. Calculated as &#x60;base_price_money&#x60; multiplied by &#x60;quantity&#x60;. Does not include modifiers. | [optional] 
**GrossSalesMoney** | [**Money**](Money.md) | The amount of money made in gross sales for this line item. Calculated as the sum of the variation&#39;s total price and each modifier&#39;s total price. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to collect for the line item. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to collect for the line item. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for this line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

