# Square.Connect.Model.BatchUpsertCatalogObjectsResponse

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The set of [Error](#type-error)s encountered. | [optional] 
**Objects** | [**List&lt;CatalogObject&gt;**](CatalogObject.md) | The created [CatalogObject](#type-catalogobject)s | [optional] 
**UpdatedAt** | **string** | The database [timestamp](#workingwithdates) of this update in RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 
**IdMappings** | [**List&lt;CatalogIdMapping&gt;**](CatalogIdMapping.md) | The mapping between client and server IDs for this Upsert. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

