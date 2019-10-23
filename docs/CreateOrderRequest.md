# Square.Connect.Model.CreateOrderRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | [**Order**](Order.md) | The order to create. If this field is set, then the only other top-level field that can be set is the idempotency_key. | [optional] 
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this order among orders you&#39;ve created.  If you&#39;re unsure whether a particular order was created successfully, you can reattempt it with the same idempotency key without worrying about creating duplicate orders.  See [Idempotency](https://developer.squareup.com/docs/basics/api101/idempotency) for more information. | [optional] 
**ReferenceId** | **string** | __Deprecated__: Please set the reference_id on the nested &#x60;order&#x60; field instead.  An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters. | [optional] [deprecated]
**LineItems** | [**List&lt;CreateOrderRequestLineItem&gt;**](CreateOrderRequestLineItem.md) | __Deprecated__: Please set the line_items on the nested &#x60;order&#x60; field instead.  The line items to associate with this order.  Each line item represents a different product to include in a purchase. | [optional] [deprecated]
**Taxes** | [**List&lt;CreateOrderRequestTax&gt;**](CreateOrderRequestTax.md) | __Deprecated__: Please set the taxes on the nested &#x60;order&#x60; field instead.  The taxes to include on the order. | [optional] [deprecated]
**Discounts** | [**List&lt;CreateOrderRequestDiscount&gt;**](CreateOrderRequestDiscount.md) | __Deprecated__: Please set the discounts on the nested &#x60;order&#x60; field instead.  The discounts to include on the order. | [optional] [deprecated]



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

