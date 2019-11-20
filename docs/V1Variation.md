# Square.Connect.Model.V1Variation

### Description

V1Variation
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The item variation&#39;s unique ID. | [optional] 
**Name** | **string** | The item variation&#39;s name. | [optional] 
**ItemId** | **string** | The ID of the variation&#39;s associated item. | [optional] 
**Ordinal** | **int?** | Indicates the variation&#39;s list position when displayed in Square Point of Sale and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order | [optional] 
**PricingType** | **string** | Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values | [optional] 
**PriceMoney** | [**V1Money**](V1Money.md) | The item variation&#39;s price, if any. | [optional] 
**Sku** | **string** | The item variation&#39;s SKU, if any. | [optional] 
**TrackInventory** | **bool?** | If true, inventory tracking is active for the variation. | [optional] 
**InventoryAlertType** | **string** | Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values | [optional] 
**InventoryAlertThreshold** | **int?** | If the inventory quantity for the variation is less than or equal to this value and inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard. | [optional] 
**UserData** | **string** | Arbitrary metadata associated with the variation. Cannot exceed 255 characters. | [optional] 
**V2Id** | **string** | The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

