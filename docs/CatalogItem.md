# Square.Connect.Model.CatalogItem

### Description

An item (i.e., product family) in the Catalog object model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The item&#39;s name. Searchable. This field must not be empty. This field has max length of 512 Unicode code points. | [optional] 
**Description** | **string** | The item&#39;s description. Searchable. This field has max length of 4096 Unicode code points. | [optional] 
**Abbreviation** | **string** | The text of the item&#39;s display label in the Square Point of Sale app. Only up to the first five characters of the string are used. Searchable. This field has max length of 24 Unicode code points. | [optional] 
**LabelColor** | **string** | The color of the item&#39;s display label in the Square Point of Sale app. This must be a valid hex color code. | [optional] 
**AvailableOnline** | **bool?** | If &#x60;true&#x60;, the item can be added to shipping orders from the merchant&#39;s online store. | [optional] 
**AvailableForPickup** | **bool?** | If &#x60;true&#x60;, the item can be added to pickup orders from the merchant&#39;s online store. | [optional] 
**AvailableElectronically** | **bool?** | If &#x60;true&#x60;, the item can be added to electronically fulfilled orders from the merchant&#39;s online store. | [optional] 
**CategoryId** | **string** | The ID of the item&#39;s category, if any. | [optional] 
**TaxIds** | **List<string>** | A set of IDs indicating the &#x60;CatalogTax&#x60;es that are enabled for this item. When updating an item, any taxes listed here will be added to the item. &#x60;CatalogTax&#x60;es may also be added to or deleted from an item using &#x60;UpdateItemTaxes&#x60;. | [optional] 
**ModifierListInfo** | [**List&lt;CatalogItemModifierListInfo&gt;**](CatalogItemModifierListInfo.md) | A set of &#x60;CatalogItemModifierListInfo&#x60; objects representing the modifier lists that apply to this item, along with the overrides and min and max limits that are specific to this item. &#x60;CatalogModifierList&#x60;s may also be added to or deleted from an item using &#x60;UpdateItemModifierLists&#x60;. | [optional] 
**Variations** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | A list of &#x60;CatalogObject&#x60;s containing the &#x60;CatalogItemVariation&#x60;s for this item.  Maximum: 250 item variations | [optional] 
**ProductType** | **string** | The product type of the item. May not be changed once an item has been created.  Only items of product type &#x60;REGULAR&#x60; or &#x60;APPOINTMENTS_SERVICE&#x60; may be created by this API; items with other product types are read-only. See [CatalogItemProductType](#type-catalogitemproducttype) for possible values | [optional] 
**SkipModifierScreen** | **bool?** | If &#x60;false&#x60;, the Square Point of Sale app will present the &#x60;CatalogItem&#x60;&#39;s details screen immediately, allowing the merchant to choose &#x60;CatalogModifier&#x60;s before adding the item to the cart.  This is the default behavior.  If &#x60;true&#x60;, the Square Point of Sale app will immediately add the item to the cart with the pre-selected modifiers, and merchants can edit modifiers by drilling down onto the item&#39;s details.  Third-party clients are encouraged to implement similar behaviors. | [optional] 
**ItemOptions** | [**List&lt;CatalogItemOptionForItem&gt;**](CatalogItemOptionForItem.md) | List of item options IDs for this item. Used to manage and group item variations in a specified order.  Maximum: 6 item options. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

