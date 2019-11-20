# Square.Connect.Model.RetrieveCatalogObjectRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeRelatedObjects** | **bool?** | If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If the &#x60;object&#x60; field of the response contains a CatalogItem, its associated CatalogCategory, CatalogTax objects, CatalogImages and CatalogModifierLists will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;object&#x60; field of the response contains a CatalogItemVariation, its parent CatalogItem will be returned in the &#x60;related_objects&#x60; field of the response.  Default value: &#x60;false&#x60; | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

