# Square.Connect.Model.V1SettlementEntry

### Description

V1SettlementEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | The settlement&#39;s unique identifier. | [optional] 
**Type** | **string** | The settlement&#39;s current status. See [V1SettlementEntryType](#type-v1settlemententrytype) for possible values | [optional] 
**AmountMoney** | [**V1Money**](V1Money.md) | The total amount of money this entry contributes to the total settlement amount. | [optional] 
**FeeMoney** | [**V1Money**](V1Money.md) | The amount of all Square fees associated with this settlement entry. This value is always negative or zero. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

