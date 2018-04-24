# Square.Connect.Model.V1Refund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | The type of refund  | [optional] 
**Reason** | **string** | The merchant-specified reason for the refund. | [optional] 
**RefundedMoney** | [**V1Money**](V1Money.md) | The amount of money refunded. This amount is always negative. | [optional] 
**CreatedAt** | **string** | The time when the merchant initiated the refund for Square to process, in ISO 8601 format. | [optional] 
**ProcessedAt** | **string** | The time when Square processed the refund on behalf of the merchant, in ISO 8601 format. | [optional] 
**PaymentId** | **string** | A Square-issued ID associated with the refund. For single-tender refunds, payment_id is the ID of the original payment ID. For split-tender refunds, payment_id is the ID of the original tender. For exchange-based refunds (is_exchange &#x3D;&#x3D; true), payment_id is the ID of the original payment ID even if the payment includes other tenders. | [optional] 
**MerchantId** | **string** |  | [optional] 
**IsExchange** | **bool?** | Indicates whether or not the refund is associated with an exchange. If is_exchange is true, the refund reflects the value of goods returned in the exchange not the total money refunded. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**FULL** | "FULL"
**PARTIAL** | "PARTIAL"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

