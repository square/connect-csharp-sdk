# Square.Connect.Model.Refund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | string | The unique ID of the refund. | 
**LocationId** | string | The ID of the refund&#39;s associated location. | 
**TransactionId** | string | The ID of the transaction refunded. | 
**TenderId** | string | The ID of the tender refunded. | 
**CreatedAt** | string | The time when the refund was created, in RFC 3339 format. | [optional] 
**Reason** | string | The reason for the refund being issued. | 
**AmountMoney** | Money | The amount of money refunded. | 
**Status** | StatusEnum |  | 
**ProcessingFeeMoney** | Money | The amount of processing fee refunded. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**Pending** | "PENDING"
**Approved** | "APPROVED"
**Rejected** | "REJECTED"
**Failed** | "FAILED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

