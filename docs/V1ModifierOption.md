# Square.Connect.Model.V1ModifierOption

### Description

V1ModifierOption
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The modifier option&#39;s unique ID. | [optional] 
**Name** | **string** | The modifier option&#39;s name. | [optional] 
**PriceMoney** | [**V1Money**](V1Money.md) | The modifier option&#39;s price. | [optional] 
**OnByDefault** | **bool?** | If true, the modifier option is the default option in a modifier list for which selection_type is SINGLE. | [optional] 
**Ordinal** | **int?** | Indicates the modifier option&#39;s list position when displayed in Square Point of Sale and the merchant dashboard. If more than one modifier option in the same modifier list has the same ordinal value, those options are displayed in alphabetical order. | [optional] 
**ModifierListId** | **string** | The ID of the modifier list the option belongs to. | [optional] 
**V2Id** | **string** | The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

