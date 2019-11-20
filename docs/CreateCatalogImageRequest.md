# Square.Connect.Model.CreateCatalogImageRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdempotencyKey** | **string** | A unique string that identifies this CreateCatalogImage request. Keys can be any valid string but must be unique for every CreateCatalogImage request.  See [Idempotency keys](https://developer.squareup.com/docs/basics/api101/idempotency) for more information. | 
**ObjectId** | **string** | Unique ID of the &#x60;CatalogObject&#x60; to attach to this &#x60;CatalogImage&#x60;. Leave this field empty to create unattached images, for example if you are building an integration where these images can be attached to catalog items at a later time. | [optional] 
**Image** | [**CatalogObject**](CatalogObject.md) | The new &#x60;IMAGE&#x60;-type &#x60;CatalogObject&#x60; to be attached to this &#x60;CatalogImage&#x60;. If the &#x60;CatalogObject&#x60; already has a &#x60;CatalogImage&#x60;, this call will overwrite it. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

