# Square.Connect.Model.CreateOrderRequestLineItem

### Description

__Deprecated__: Please use the [OrderLineItem](#type-orderlineitem) type in the order field of [CreateOrderRequest](#type-createorderrequest) instead.  Represents a line item to include in an order. Each line item describes a different product to purchase, with its own quantity and price details.  Line items can either reference objects from the merchant's catalog, or can alternatively specify a name and price instead.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Only used for ad hoc line items. The name of the line item. This value cannot exceed 500 characters.  Do not provide a value for this field if you provide a value for &#x60;catalog_object_id&#x60;. | [optional] 
**Quantity** | **string** | The quantity to purchase, as a string representation of a number.  This string must have a positive integer value. | 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item.  &#x60;base_price_money&#x60; is required for ad hoc line items and variable priced &#x60;CatalogItemVariation&#x60;s. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the CatalogItemVariation&#39;s price. | [optional] 
**VariationName** | **string** | Only used for ad hoc line items. The variation name of the line item. This value cannot exceed 255 characters.  If this value is not set for an ad hoc line item, the default value of &#x60;Regular&#x60; is used.  Do not provide a value for this field if you provide a value for the &#x60;catalog_object_id&#x60;. | [optional] 
**Note** | **string** | The note of the line item. This value cannot exceed 500 characters. | [optional] 
**CatalogObjectId** | **string** | Only used for Catalog line items. The catalog object ID for an existing &#x60;CatalogItemVariation&#x60;.  Do not provide a value for this field if you provide a value for &#x60;name&#x60; and &#x60;base_price_money&#x60;. | [optional] 
**Modifiers** | [**List&lt;CreateOrderRequestModifier&gt;**](CreateOrderRequestModifier.md) | Only used for Catalog line items. The modifiers to include on the line item. | [optional] 
**Taxes** | [**List&lt;CreateOrderRequestTax&gt;**](CreateOrderRequestTax.md) | The taxes to include on the line item. | [optional] 
**Discounts** | [**List&lt;CreateOrderRequestDiscount&gt;**](CreateOrderRequestDiscount.md) | The discounts to include on the line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

