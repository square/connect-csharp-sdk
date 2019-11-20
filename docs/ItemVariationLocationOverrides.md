# Square.Connect.Model.ItemVariationLocationOverrides

### Description

Price and inventory alerting overrides for a `CatalogItemVariation` at a specific `Location`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationId** | **string** | The ID of the &#x60;Location&#x60;. | [optional] 
**PriceMoney** | [**Money**](Money.md) | The price of the &#x60;CatalogItemVariation&#x60; at the given &#x60;Location&#x60;, or blank for variable pricing. | [optional] 
**PricingType** | **string** | The pricing type (fixed or variable) for the &#x60;CatalogItemVariation&#x60; at the given &#x60;Location&#x60;. See [CatalogPricingType](#type-catalogpricingtype) for possible values | [optional] 
**TrackInventory** | **bool?** | If &#x60;true&#x60;, inventory tracking is active for the &#x60;CatalogItemVariation&#x60; at this &#x60;Location&#x60;. | [optional] 
**InventoryAlertType** | **string** | Indicates whether the &#x60;CatalogItemVariation&#x60; displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values | [optional] 
**InventoryAlertThreshold** | **long?** | If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

