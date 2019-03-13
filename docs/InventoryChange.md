# Square.Connect.Model.InventoryChange

### Description

Represents a single physical count, inventory, adjustment, or transfer that is part of the history of inventory changes for a particular [CatalogObject](#type-catalogobject).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for all possible values. | [optional] 
**PhysicalCount** | [**InventoryPhysicalCount**](InventoryPhysicalCount.md) | Contains details about the physical count when &#x60;type&#x60; is &#x60;PHYSICAL_COUNT&#x60; and unset for all other types. | [optional] 
**Adjustment** | [**InventoryAdjustment**](InventoryAdjustment.md) | Contains details about the inventory adjustment when &#x60;type&#x60; is &#x60;ADJUSTMENT&#x60; and unset for all other types. | [optional] 
**Transfer** | [**InventoryTransfer**](InventoryTransfer.md) | Contains details about the inventory transfer when &#x60;type&#x60; is &#x60;TRANSFER&#x60; and unset for all other types. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**PHYSICALCOUNT** | "PHYSICAL_COUNT"
**ADJUSTMENT** | "ADJUSTMENT"
**TRANSFER** | "TRANSFER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

