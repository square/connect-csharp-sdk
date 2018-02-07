# Square.Connect.Model.CatalogModifierList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The [CatalogModifierList](#type-catalogmodifierlist)&#39;s name. Searchable. | [optional] 
**SelectionType** | **SelectionTypeEnum** | Indicates whether multiple options from the [CatalogModifierList](#type-catalogmodifierlist) can be applied to a single [CatalogItem](#type-catalogitem). See [CatalogModifierListSelectionType](#type-catalogmodifierlistselectiontype) for all possible values. | [optional] 
**Modifiers** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | The options included in the [CatalogModifierList](#type-catalogmodifierlist). You must include at least one [CatalogModifier](#type-catalogmodifier). Each [CatalogObject](#type-catalogobject) must have type &#x60;MODIFIER&#x60; and contain [CatalogModifier](#type-catalogmodifier) data. | [optional] 


## SelectionTypeEnum

Name | Value
------------ | -------------
**SINGLE** | "SINGLE"
**MULTIPLE** | "MULTIPLE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

