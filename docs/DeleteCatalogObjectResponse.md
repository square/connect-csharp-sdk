# Square.Connect.Model.DeleteCatalogObjectResponse

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The set of &#x60;Error&#x60;s encountered. | [optional] 
**DeletedObjectIds** | **List<string>** | The IDs of all &#x60;CatalogObject&#x60;s deleted by this request. Multiple IDs may be returned when associated objects are also deleted, for example a &#x60;CatalogItemVariation&#x60; when its parent &#x60;CatalogItem&#x60; is deleted. | [optional] 
**DeletedAt** | **string** | The database [timestamp](#workingwithdates) of this deletion in RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

