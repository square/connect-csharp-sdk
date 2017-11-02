# Square.Connect.Model.AdditionalRecipientReceivable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The additional recipient receivable&#39;s unique ID, issued by Square payments servers. | 
**TransactionId** | **string** | The ID of the transaction that the additional recipient receivable was applied to. | 
**TransactionLocationId** | **string** | The ID of the location that created the receivable. This is the location ID on the associated transaction. | 
**AmountMoney** | [**Money**](Money.md) | The amount of the receivable. This will always be non-negative. | 
**CreatedAt** | **string** | The time when the additional recipient receivable was created, in RFC 3339 format. | [optional] 
**Refunds** | [**List&lt;AdditionalRecipientReceivableRefund&gt;**](AdditionalRecipientReceivableRefund.md) | Any refunds of the receivable that have been applied. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

