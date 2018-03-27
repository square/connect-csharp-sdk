# Square.Connect.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The order&#39;s unique ID.  This value is only present for Order objects created by the Orders API through the [CreateOrder](#endpoint-createorder) endpoint. | [optional] 
**LocationId** | **string** | The ID of the merchant location this order is associated with. | 
**ReferenceId** | **string** | A client specified identifier to associate an entity in another system with this order. | [optional] 
**LineItems** | [**List&lt;OrderLineItem&gt;**](OrderLineItem.md) | The line items included in the order. Every order has at least one line item. | 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for the order. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to collect for the order. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to collect for the order. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

