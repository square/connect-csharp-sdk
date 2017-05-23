# Square.Connect.Model.V1Refund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | The type of refund  | [optional] 
**Reason** | **string** | The merchant-specified reason for the refund. | [optional] 
**RefundedMoney** | [**V1Money**](V1Money.md) | The amount of money refunded. This amount is always negative. | [optional] 
**CreatedAt** | **string** | The time when the merchant initiated the refund for Square to process, in ISO 8601 format.. | [optional] 
**ProcessedAt** | **string** | The time when Square processed the refund on behalf of the merchant, in ISO 8601 format. | [optional] 
**PaymentId** | **string** | The Square-issued ID of the payment the refund is applied to. | [optional] 
**MerchantId** | **string** |  | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**FULL** | "FULL"
**PARTIAL** | "PARTIAL"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

