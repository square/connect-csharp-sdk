# Square.Connect.Model.OrderLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The line item&#39;s ID, unique only within this order. | [optional] 
**Name** | **string** | The name of the line item. | [optional] 
**Quantity** | **string** | The quantity of the product to purchase. Currently, this string must have an integer value. | [optional] 
**Taxes** | [**List&lt;OrderLineItemTax&gt;**](OrderLineItemTax.md) | The taxes applied to this line item. | [optional] 
**Discounts** | [**List&lt;OrderLineItemDiscount&gt;**](OrderLineItemDiscount.md) | The discounts applied to this line item. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to collect for the line item. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to collect for the line item. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for this line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

