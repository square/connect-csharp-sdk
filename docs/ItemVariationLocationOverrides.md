# Square.Connect.Model.ItemVariationLocationOverrides

### Description

Price and inventory alerting overrides for a [CatalogItemVariation](#type-catalogitemvariation) at a specific [location](#type-location).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationId** | **string** | The ID of the [location](#type-location). | [optional] 
**PriceMoney** | [**Money**](Money.md) | The price of the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location), or blank for variable pricing. | [optional] 
**PricingType** | **PricingTypeEnum** | The pricing type (fixed or variable) for the [CatalogItemVariation](#type-catalogitemvariation) at the given [location](#type-location). See [CatalogPricingType](#type-catalogpricingtype) for possible values | [optional] 
**TrackInventory** | **bool?** | If &#x60;true&#x60;, inventory tracking is active for the [CatalogItemVariation](#type-catalogitemvariation) at this [location](#type-location). | [optional] 
**InventoryAlertType** | **InventoryAlertTypeEnum** | Indicates whether the [CatalogItemVariation](#type-catalogitemvariation) displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values | [optional] 
**InventoryAlertThreshold** | **long?** | If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer. | [optional] 


## PricingTypeEnum

Name | Value
------------ | -------------
**FIXEDPRICING** | "FIXED_PRICING"
**VARIABLEPRICING** | "VARIABLE_PRICING"


## InventoryAlertTypeEnum

Name | Value
------------ | -------------
**NONE** | "NONE"
**LOWQUANTITY** | "LOW_QUANTITY"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

