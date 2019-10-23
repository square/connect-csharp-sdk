# Square.Connect.Model.OrderReturnLineItemModifier

### Description

A line item modifier being returned.
**Note: This model is in beta.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the return modifier only within this order. | [optional] 
**SourceModifierUid** | **string** | &#x60;uid&#x60; of the Modifier from the LineItem from the Order which contains the original sale of this line item modifier. | [optional] 
**CatalogObjectId** | **string** | The catalog object id referencing &#x60;CatalogModifier&#x60;. | [optional] 
**Name** | **string** | The name of the item modifier. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined &#x60;CatalogModifier&#x60; price. | [optional] 
**TotalPriceMoney** | [**Money**](Money.md) | The total price of the item modifier for its line item. This is the modifier&#39;s &#x60;base_price_money&#x60; multiplied by the line item&#39;s quantity. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

