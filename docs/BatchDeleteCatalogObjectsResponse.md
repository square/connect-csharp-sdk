# Square.Connect.Model.BatchDeleteCatalogObjectsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The set of [Error](#type-error)s encountered. | [optional] 
**DeletedObjectIds** | **List<string>** | The IDs of all [CatalogObject](#type-catalogobject)s deleted by this request. | [optional] 
**DeletedAt** | **string** | The database [timestamp](#workingwithdates) of this deletion in RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

