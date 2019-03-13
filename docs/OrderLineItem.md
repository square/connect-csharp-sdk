# Square.Connect.Model.OrderLineItem

### Description

Represents a line item in an order. Each line item describes a different product to purchase, with its own quantity and price details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the line item. | [optional] 
**Quantity** | **string** | The quantity purchased, as a string representation of a number.  This string must have a positive integer value. | 
**Note** | **string** | The note of the line item. | [optional] 
**CatalogObjectId** | **string** | The [CatalogItemVariation](#type-catalogitemvariation) id applied to this line item. | [optional] 
**VariationName** | **string** | The name of the variation applied to this line item. | [optional] 
**Modifiers** | [**List&lt;OrderLineItemModifier&gt;**](OrderLineItemModifier.md) | The [CatalogModifier](#type-catalogmodifier)s applied to this line item. | [optional] 
**Taxes** | [**List&lt;OrderLineItemTax&gt;**](OrderLineItemTax.md) | A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any order-level taxes apportioned to this item. When creating an Order, set your item-level taxes in this list. | [optional] 
**Discounts** | [**List&lt;OrderLineItemDiscount&gt;**](OrderLineItemDiscount.md) | A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any order-level discounts apportioned to this item. When creating an Order, set your item-level discounts in this list. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item. | [optional] 
**GrossSalesMoney** | [**Money**](Money.md) | The gross sales amount of money calculated as (item base price + modifiers price) * quantity. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to collect for the line item. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to collect for the line item. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for this line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

