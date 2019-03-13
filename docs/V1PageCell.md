# Square.Connect.Model.V1PageCell

### Description

V1PageCell

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageId** | **string** | The unique identifier of the page the cell is included on. | [optional] 
**Row** | **int?** | The row of the cell. Always an integer between 0 and 4, inclusive. | [optional] 
**Column** | **int?** | The column of the cell. Always an integer between 0 and 4, inclusive. | [optional] 
**ObjectType** | **ObjectTypeEnum** | The type of entity represented in the cell (ITEM, DISCOUNT, CATEGORY, or PLACEHOLDER). See [V1PageCellObjectType](#type-v1pagecellobjecttype) for possible values | [optional] 
**ObjectId** | **string** | The unique identifier of the entity represented in the cell. Not present for cells with an object_type of PLACEHOLDER. | [optional] 
**PlaceholderType** | **PlaceholderTypeEnum** | For a cell with an object_type of PLACEHOLDER, this value indicates the cell&#39;s special behavior. See [V1PageCellPlaceholderType](#type-v1pagecellplaceholdertype) for possible values | [optional] 


## ObjectTypeEnum

Name | Value
------------ | -------------
**ITEM** | "ITEM"
**DISCOUNT** | "DISCOUNT"
**CATEGORY** | "CATEGORY"
**PLACEHOLDER** | "PLACEHOLDER"


## PlaceholderTypeEnum

Name | Value
------------ | -------------
**ALLITEMS** | "ALL_ITEMS"
**DISCOUNTSCATEGORY** | "DISCOUNTS_CATEGORY"
**REWARDSFINDER** | "REWARDS_FINDER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

