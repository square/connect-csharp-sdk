# Square.Connect.Model.CreateOrderRequestModifier

### Description

__Deprecated__: Please use the [OrderLineItemModifier](#type-orderlineitemmodifier) type instead.  Represents a modifier applied to a single line item.  Modifiers can reference existing objects in a merchant catalog or be constructed ad hoc at the time of purchase by providing a name and price.
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogObjectId** | **string** | The catalog object ID of a &#x60;CatalogModifier&#x60;. | [optional] 
**Name** | **string** | Only used for ad hoc modifiers. The name of the modifier. &#x60;name&#x60; cannot exceed 255 characters.  Do not provide a value for &#x60;name&#x60; if you provide a value for &#x60;catalog_object_id&#x60;. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined &#x60;CatalogModifier&#x60; price. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

