# Square.Connect.Model.CatalogItemModifierListInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModifierListId** | **string** | The ID of the [CatalogModifierList](#type-catalogmodifierlist) controlled by this [CatalogModifierListInfo](#type-catalogmodifierlistinfo). | 
**ModifierOverrides** | [**List&lt;CatalogModifierOverride&gt;**](CatalogModifierOverride.md) | A set of [CatalogModifierOverride](#type-catalogmodifieroverride) objects that override whether a given [CatalogModifier](#type-catalogmodifier) is enabled by default. | [optional] 
**MinSelectedModifiers** | **int?** | If zero or larger, the smallest number of [CatalogModifier](#type-catalogmodifier)s that must be selected from this [CatalogModifierList](#type-catalogmodifierlist). | [optional] 
**MaxSelectedModifiers** | **int?** | If zero or larger, the largest number of [CatalogModifier](#type-catalogmodifier)s that can be selected from this [CatalogModifierList](#type-catalogmodifierlist). | [optional] 
**Enabled** | **bool?** | If &#x60;true&#x60;, enable this [CatalogModifierList](#type-catalogmodifierlist). | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

