# Square.Connect.Model.OrderEntry

### Description

A lightweight description of an [Order](#type-order) that is returned when `returned_entries` is true on a [SearchOrderRequest](#type-searchorderrequest)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | The id of the Order | [optional] 
**Version** | **int?** | Version number which is incremented each time an update is committed to the order. Orders that were not created through the API will not include a version and thus cannot be updated.  [Read more about working with versions](/orders-api/manage-orders#update-orders). | [optional] 
**LocationId** | **string** | The location id the Order belongs to. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

