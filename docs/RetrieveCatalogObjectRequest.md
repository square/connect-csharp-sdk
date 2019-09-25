# Square.Connect.Model.RetrieveCatalogObjectRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeRelatedObjects** | **bool?** | If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If the &#x60;object&#x60; field of the response contains a &#x60;CatalogItem&#x60;, its associated &#x60;CatalogCategory](#type-catalogcategory), [CatalogTax&#x60;es, &#x60;CatalogImage](#type-catalogimage)s and [CatalogModifierList&#x60;s will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;object&#x60; field of the response contains a &#x60;CatalogItemVariation&#x60;, its parent &#x60;CatalogItem&#x60; will be returned in the &#x60;related_objects&#x60; field of  the response.  Default value: &#x60;false&#x60; | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

