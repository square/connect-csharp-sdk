# Square.Connect.Model.ProcessingFee

### Description

Represents Square processing fee.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **string** | Timestamp of when the fee takes effect, in RFC 3339 format. | [optional] 
**Type** | **string** | The type of fee assessed or adjusted. Can be one of: &#x60;INITIAL&#x60;, &#x60;ADJUSTMENT&#x60;. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The fee amount assessed or adjusted by Square. May be negative.  Positive values represent funds being assessed, while negative values represent funds being returned. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

