# Square.Connect.Model.UpdateOrderRequest

### Description

Defines the fields that are included in requests to the [UpdateOrder](#endpoint-orders-updateorder) endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | [**Order**](Order.md) | The [sparse order](https://developer.squareup.com/docs/orders-api/manage-orders#sparse-order-objects) containing only the fields to update and the version the update is being applied to. | [optional] 
**FieldsToClear** | **List<string>** | The [dot notation paths](https://developer.squareup.com/docs/orders-api/manage-orders#on-dot-notation) fields to clear. For example, &#x60;line_items[uid].note&#x60; [Read more about Deleting fields](https://developer.squareup.com/docs/orders-api/manage-orders#delete-fields). | [optional] 
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this update request  If you&#39;re unsure whether a particular update was applied to an order successfully, you can reattempt it with the same idempotency key without worrying about creating duplicate updates to the order. The latest order version will be returned.  See [Idempotency](https://developer.squareup.com/docs/basics/api101/idempotency) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

