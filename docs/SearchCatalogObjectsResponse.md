# Square.Connect.Model.SearchCatalogObjectsResponse

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The set of [Error](#type-error)s encountered. | [optional] 
**Cursor** | **string** | The pagination cursor to be used in a subsequent request. If unset, this is the final response. See [Pagination](/basics/api101/pagination) for more information. | [optional] 
**Objects** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | The [CatalogObject](#type-catalogobject)s returned. | [optional] 
**RelatedObjects** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | A list of [CatalogObject](#type-catalogobject)s referenced by the objects in the &#x60;objects&#x60; field. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

