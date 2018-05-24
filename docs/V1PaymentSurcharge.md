# Square.Connect.Model.V1PaymentSurcharge
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the surcharge. | [optional] 
**AppliedMoney** | [**V1Money**](V1Money.md) | The amount of money applied to the order as a result of the surcharge. | [optional] 
**Rate** | **string** | The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage. For example, \&quot;0.7\&quot; corresponds to a 7% surcharge. Exactly one of rate or amount_money should be set. | [optional] 
**AmountMoney** | [**V1Money**](V1Money.md) | The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set. | [optional] 
**Type** | **TypeEnum** | Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group. | [optional] 
**Taxable** | **bool?** | Indicates whether the surcharge is taxable. | [optional] 
**Taxes** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | The list of taxes that should be applied to the surcharge. | [optional] 
**SurchargeId** | **string** |  | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**UNKNOWN** | "UNKNOWN"
**AUTOGRATUITY** | "AUTO_GRATUITY"
**CUSTOM** | "CUSTOM"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

