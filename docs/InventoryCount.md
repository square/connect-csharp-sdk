# Square.Connect.Model.InventoryCount

### Description

Represents the estimated quantity of items in a particular state at a particular location based on the known history of physical counts and inventory adjustments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogObjectId** | **string** | The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked. | [optional] 
**CatalogObjectType** | **string** | The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked. Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type. | [optional] 
**State** | **StateEnum** | The current [InventoryState](#type-inventorystate) for the related quantity of items. | [optional] 
**LocationId** | **string** | The Square ID of the [Location](#type-location) where the related quantity of items are being tracked. | [optional] 
**Quantity** | **string** | The number of items in the count as a decimal string. Fractional quantities are not supported. | [optional] 
**CalculatedAt** | **string** | A read-only timestamp in RFC 3339 format that indicates when Square received the most recent physical count or adjustment that had an affect on the estimated count. | [optional] 


## StateEnum

Name | Value
------------ | -------------
**CUSTOM** | "CUSTOM"
**INSTOCK** | "IN_STOCK"
**SOLD** | "SOLD"
**RETURNEDBYCUSTOMER** | "RETURNED_BY_CUSTOMER"
**RESERVEDFORSALE** | "RESERVED_FOR_SALE"
**SOLDONLINE** | "SOLD_ONLINE"
**ORDEREDFROMVENDOR** | "ORDERED_FROM_VENDOR"
**RECEIVEDFROMVENDOR** | "RECEIVED_FROM_VENDOR"
**INTRANSITTO** | "IN_TRANSIT_TO"
**NONE** | "NONE"
**WASTE** | "WASTE"
**UNLINKEDRETURN** | "UNLINKED_RETURN"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

