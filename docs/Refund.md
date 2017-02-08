# Square.Connect.Model.Refund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | string | The refund&#39;s unique ID. | 
**LocationId** | string | The ID of the refund&#39;s associated location. | 
**TransactionId** | string | The ID of the transaction that the refunded tender is part of. | 
**TenderId** | string | The ID of the refunded tender. | 
**CreatedAt** | string | The time when the refund was created, in RFC 3339 format. | [optional] 
**Reason** | string | The reason for the refund being issued. | 
**AmountMoney** | Money | The amount of money refunded to the buyer. | 
**Status** | StatusEnum | The current status of the refund (&#x60;PENDING&#x60;, &#x60;APPROVED&#x60;, &#x60;REJECTED&#x60;, or &#x60;FAILED&#x60;). | 
**ProcessingFeeMoney** | Money | The amount of Square processing fee money refunded to the *merchant*. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**PENDING** | "PENDING"
**APPROVED** | "APPROVED"
**REJECTED** | "REJECTED"
**FAILED** | "FAILED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

