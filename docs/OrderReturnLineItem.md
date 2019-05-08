# Square.Connect.Model.OrderReturnLineItem

### Description

The line item being returned in an Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique identifier for this return line item entry. This is a read-only field. | [optional] 
**SourceLineItemUid** | **string** | &#x60;uid&#x60; of the LineItem in the original sale Order. | [optional] 
**Name** | **string** | The name of the line item. | [optional] 
**Quantity** | **string** | The quantity returned, formatted as a decimal number. For example: &#x60;\&quot;3\&quot;&#x60;.  Line items with a &#x60;quantity_unit&#x60; can have non-integer quantities. For example: &#x60;\&quot;1.70000\&quot;&#x60;. | 
**QuantityUnit** | [**OrderQuantityUnit**](OrderQuantityUnit.md) | The unit and precision that this return line item&#39;s quantity is measured in. | [optional] 
**Note** | **string** | The note of the returned line item. | [optional] 
**CatalogObjectId** | **string** | The [CatalogItemVariation](#type-catalogitemvariation) id applied to this returned line item. | [optional] 
**VariationName** | **string** | The name of the variation applied to this returned line item. | [optional] 
**ReturnModifiers** | [**List&lt;OrderReturnLineItemModifier&gt;**](OrderReturnLineItemModifier.md) | The [CatalogModifier](#type-catalogmodifier)s applied to this line item. | [optional] 
**ReturnTaxes** | [**List&lt;OrderReturnTax&gt;**](OrderReturnTax.md) | A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any return-level taxes apportioned to this item. | [optional] 
**ReturnDiscounts** | [**List&lt;OrderReturnDiscount&gt;**](OrderReturnDiscount.md) | A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any return-level discounts apportioned to this item. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item. | [optional] 
**VariationTotalPriceMoney** | [**Money**](Money.md) | The total price of all item variations returned in this line item. Calculated as &#x60;base_price_money&#x60; multiplied by &#x60;quantity&#x60;. Does not include modifiers. | [optional] 
**GrossReturnMoney** | [**Money**](Money.md) | The gross return amount of money calculated as (item base price + modifiers price) * quantity. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to return for the line item. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to return for the line item. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to return for this line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

