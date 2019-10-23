# Square.Connect.Model.CreateRefundRequest

### Description

Defines the body parameters that can be included in a request to the [CreateRefund](#endpoint-createrefund) endpoint.  Deprecated - recommend using [RefundPayment](#endpoint-refunds-refundpayment)
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this refund among refunds you&#39;ve created for the tender.  If you&#39;re unsure whether a particular refund succeeded, you can reattempt it with the same idempotency key without worrying about duplicating the refund.  See [Idempotency](https://developer.squareup.com/docs/basics/api101/idempotency) for more information. | 
**TenderId** | **string** | The ID of the tender to refund.  A &#x60;&#x60;Transaction&#x60;&#x60; has one or more &#x60;tenders&#x60; (i.e., methods of payment) associated with it, and you refund each tender separately with the Connect API. | 
**Reason** | **string** | A description of the reason for the refund.  Default value: &#x60;Refund via API&#x60; | [optional] 
**AmountMoney** | [**Money**](Money.md) | The amount of money to refund.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts) for details.  This amount cannot exceed the amount that was originally charged to the tender that corresponds to &#x60;tender_id&#x60;. | 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

