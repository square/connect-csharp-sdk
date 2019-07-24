# Square.Connect.Model.CatalogItemOption

### Description

A group of variations for a [CatalogItem](#type-catalogitem)'s.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The item option&#39;s display name for the seller. Must be unique across all item options. Searchable. | [optional] 
**DisplayName** | **string** | The item option&#39;s display name for the customer. Searchable. | [optional] 
**Description** | **string** | The item option&#39;s human-readable description. Displays for in the Square Point of Sale app for the seller and in the Online Store or on receipts for the buyer. | [optional] 
**ShowColors** | **bool?** | If true, display colors for entries in &#x60;values&#x60; when present. | [optional] 
**Values** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | A list of [CatalogObject](#type-catalogobject)s containing the [CatalogItemOptionValue](#type-catalogitemoptionvalue)s for this item. | [optional] 
**ItemCount** | **long?** | The number of [CatalogItem](#type-catalogitem)s currently associated with this item option. Present only if the &#x60;include_counts&#x60; was specified in the request. Any count over 100 will be returned as &#x60;100&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

