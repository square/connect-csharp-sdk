# Square.Connect.Model.RefundPaymentResponse

### Description

Defines the fields that are included in the response body of a request to the [RefundPayment](#endpoint-refunds-refundpayment) endpoint.  Note: if there are errors processing the request, the refund field may not be present, or it may be present in a FAILED state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Information on errors encountered during the request. | [optional] 
**Refund** | [**PaymentRefund**](PaymentRefund.md) | The successfully created &#x60;PaymentRefund&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

