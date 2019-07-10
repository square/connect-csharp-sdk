# Square.Connect.Model.V1PaymentSurcharge

### Description

V1PaymentSurcharge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the surcharge. | [optional] 
**AppliedMoney** | [**V1Money**](V1Money.md) | The amount of money applied to the order as a result of the surcharge. | [optional] 
**Rate** | **string** | The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage. For example, \&quot;0.7\&quot; corresponds to a 7% surcharge. Exactly one of rate or amount_money should be set. | [optional] 
**AmountMoney** | [**V1Money**](V1Money.md) | The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set. | [optional] 
**Type** | **string** | Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group. See [V1PaymentSurchargeType](#type-v1paymentsurchargetype) for possible values | [optional] 
**Taxable** | **bool?** | Indicates whether the surcharge is taxable. | [optional] 
**Taxes** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | The list of taxes that should be applied to the surcharge. | [optional] 
**SurchargeId** | **string** | A Square-issued unique identifier associated with the surcharge. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

