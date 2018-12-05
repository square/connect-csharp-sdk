# Square.Connect.Model.V1Refund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | The type of refund  | [optional] 
**Reason** | **string** | The merchant-specified reason for the refund. | [optional] 
**RefundedMoney** | [**V1Money**](V1Money.md) | The amount of money refunded. This amount is always negative. | [optional] 
**RefundedProcessingFeeMoney** | [**V1Money**](V1Money.md) | The amount of processing fee money refunded. This amount is always positive. | [optional] 
**RefundedTaxMoney** | [**V1Money**](V1Money.md) | The total amount of tax money refunded. This amount is always negative. | [optional] 
**RefundedAdditiveTaxMoney** | [**V1Money**](V1Money.md) | The amount of additive tax money refunded. This amount is always negative. | [optional] 
**RefundedAdditiveTax** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | All of the additive taxes associated with the refund. | [optional] 
**RefundedInclusiveTaxMoney** | [**V1Money**](V1Money.md) | The amount of inclusive tax money refunded. This amount is always negative. | [optional] 
**RefundedInclusiveTax** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | All of the inclusive taxes associated with the refund. | [optional] 
**RefundedTipMoney** | [**V1Money**](V1Money.md) | The amount of tip money refunded. This amount is always negative. | [optional] 
**RefundedDiscountMoney** | [**V1Money**](V1Money.md) | The amount of discount money refunded. This amount is always positive. | [optional] 
**RefundedSurchargeMoney** | [**V1Money**](V1Money.md) | The amount of surcharge money refunded. This amount is always negative. | [optional] 
**RefundedSurcharges** | [**List&lt;V1PaymentSurcharge&gt;**](V1PaymentSurcharge.md) | A list of all surcharges associated with the refund. | [optional] 
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

