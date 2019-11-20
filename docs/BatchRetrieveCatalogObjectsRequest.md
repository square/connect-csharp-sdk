# Square.Connect.Model.BatchRetrieveCatalogObjectsRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectIds** | **List<string>** | The IDs of the CatalogObjects to be retrieved. | 
**IncludeRelatedObjects** | **bool?** | If &#x60;true&#x60;, the response will include additional objects that are related to the requested objects, as follows:  If the &#x60;objects&#x60; field of the response contains a CatalogItem, its associated CatalogCategory objects, CatalogTax objects, CatalogImage objects and CatalogModifierLists will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;objects&#x60; field of the response contains a CatalogItemVariation, its parent CatalogItem will be returned in the &#x60;related_objects&#x60; field of the response. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

