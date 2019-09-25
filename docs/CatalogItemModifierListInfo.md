# Square.Connect.Model.CatalogItemModifierListInfo

### Description

Controls the properties of a [CatalogModifierList](#type-catalogmodifierlist) as it applies to this [CatalogItem](#type-catalogitem).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModifierListId** | **string** | The ID of the &#x60;CatalogModifierList](#type-catalogmodifierlist) controlled by this [CatalogModifierListInfo&#x60;. | 
**ModifierOverrides** | [**List&lt;CatalogModifierOverride&gt;**](CatalogModifierOverride.md) | A set of &#x60;CatalogModifierOverride](#type-catalogmodifieroverride) objects that override whether a given [CatalogModifier&#x60; is enabled by default. | [optional] 
**MinSelectedModifiers** | **int?** | If zero or larger, the smallest number of &#x60;CatalogModifier](#type-catalogmodifier)s that must be selected from this [CatalogModifierList&#x60;. | [optional] 
**MaxSelectedModifiers** | **int?** | If zero or larger, the largest number of &#x60;CatalogModifier](#type-catalogmodifier)s that can be selected from this [CatalogModifierList&#x60;. | [optional] 
**Enabled** | **bool?** | If &#x60;true&#x60;, enable this &#x60;CatalogModifierList&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

