# Square.Connect.Model.V1Variation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The item variation&#39;s unique ID. | [optional] 
**Name** | **string** | The item variation&#39;s name. | [optional] 
**ItemId** | **string** | The ID of the variation&#39;s associated item. | [optional] 
**PricingType** | **PricingTypeEnum** | Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. | [optional] 
**PriceMoney** | [**V1Money**](V1Money.md) | The item variation&#39;s price, if any. | [optional] 
**Sku** | **string** | The item variation&#39;s SKU, if any. | [optional] 
**TrackInventory** | **bool?** | If true, inventory tracking is active for the variation. | [optional] 
**InventoryAlertType** | **InventoryAlertTypeEnum** | Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. | [optional] 
**InventoryAlertThreshold** | **int?** | If the inventory quantity for the variation is less than or equal to this value and inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard. | [optional] 
**UserData** | **string** | Arbitrary metadata associated with the variation. Cannot exceed 255 characters. | [optional] 


## PricingTypeEnum

Name | Value
------------ | -------------
**FIXEDPRICING** | "FIXED_PRICING"
**VARIABLEPRICING** | "VARIABLE_PRICING"


## InventoryAlertTypeEnum

Name | Value
------------ | -------------
**LOWQUANTITY** | "LOW_QUANTITY"
**NONE** | "NONE"
**INVESTMENT** | "INVESTMENT"
**LOAN** | "LOAN"
**SAVINGS** | "SAVINGS"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

