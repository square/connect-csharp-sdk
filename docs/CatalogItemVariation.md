# Square.Connect.Model.CatalogItemVariation

### Description

An item variation (i.e., product) in the Catalog object model. Each item may have a maximum of 250 item variations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | The ID of the &#x60;CatalogItem&#x60; associated with this item variation. Searchable. | [optional] 
**Name** | **string** | The item variation&#39;s name. Searchable. This field has max length of 255 Unicode code points. | [optional] 
**Sku** | **string** | The item variation&#39;s SKU, if any. Searchable. | [optional] 
**Upc** | **string** | The item variation&#39;s UPC, if any. Searchable in the Connect API. This field is only exposed in the Connect API. It is not exposed in Square&#39;s Dashboard, Square Point of Sale app or Retail Point of Sale app. | [optional] 
**Ordinal** | **int?** | The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal for each item variation within a parent &#x60;CatalogItem&#x60; is set according to the item variations&#39;s position. On reads, the value is not guaranteed to be sequential or unique. | [optional] 
**PricingType** | **string** | Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [CatalogPricingType](#type-catalogpricingtype) for possible values | [optional] 
**PriceMoney** | [**Money**](Money.md) | The item variation&#39;s price, if fixed pricing is used. | [optional] 
**LocationOverrides** | [**List&lt;ItemVariationLocationOverrides&gt;**](ItemVariationLocationOverrides.md) | Per-&#x60;location&#x60; price and inventory overrides. | [optional] 
**TrackInventory** | **bool?** | If &#x60;true&#x60;, inventory tracking is active for the variation. | [optional] 
**InventoryAlertType** | **string** | Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values | [optional] 
**InventoryAlertThreshold** | **long?** | If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer. | [optional] 
**UserData** | **string** | Arbitrary user metadata to associate with the item variation. Cannot exceed 255 characters. Searchable. | [optional] 
**ServiceDuration** | **long?** | If the &#x60;CatalogItem&#x60; that owns this item variation is of type &#x60;APPOINTMENTS_SERVICE&#x60;, then this is the duration of the service in milliseconds. For example, a 30 minute appointment would have the value &#x60;1800000&#x60;, which is equal to 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second). | [optional] 
**ItemOptionValues** | [**List&lt;CatalogItemOptionValueForItemVariation&gt;**](CatalogItemOptionValueForItemVariation.md) | List of item option values associated with this item variation. Listed in the same order as the item options of the parent item. | [optional] [beta]
**MeasurementUnitId** | **string** | ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity sold of this item variation. If left unset, the item will be sold in whole quantities. | [optional] [beta]



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

