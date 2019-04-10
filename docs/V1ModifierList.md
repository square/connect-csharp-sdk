# Square.Connect.Model.V1ModifierList

### Description

V1ModifierList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The modifier list&#39;s unique ID. | [optional] 
**Name** | **string** | The modifier list&#39;s name. | [optional] 
**SelectionType** | **SelectionTypeEnum** | Indicates whether MULTIPLE options or a SINGLE option from the modifier list can be applied to a single item. See [V1ModifierListSelectionType](#type-v1modifierlistselectiontype) for possible values | [optional] 
**ModifierOptions** | [**List&lt;V1ModifierOption&gt;**](V1ModifierOption.md) | The options included in the modifier list. | [optional] 
**V2Id** | **string** | The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID. | [optional] 


## SelectionTypeEnum

Name | Value
------------ | -------------
**SINGLE** | "SINGLE"
**MULTIPLE** | "MULTIPLE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

