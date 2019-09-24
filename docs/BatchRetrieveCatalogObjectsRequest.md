# Square.Connect.Model.BatchRetrieveCatalogObjectsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectIds** | **List<string>** | The IDs of the &#x60;CatalogObject&#x60;s to be retrieved. | 
**IncludeRelatedObjects** | **bool?** | If &#x60;true&#x60;, the response will include additional objects that are related to the requested objects, as follows:  If the &#x60;objects&#x60; field of the response contains a &#x60;CatalogItem&#x60;,  its associated &#x60;CatalogCategory](#type-catalogcategory), [CatalogTax&#x60;es, &#x60;CatalogImage](#type-catalogimage)s and [CatalogModifierList&#x60;s will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;objects&#x60; field of the response contains a &#x60;CatalogItemVariation&#x60;, its parent &#x60;CatalogItem&#x60; will be returned in the &#x60;related_objects&#x60; field of the response. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

