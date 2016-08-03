# Square.Connect.Model.Tender
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | string | The tender&#39;s unique ID. | [optional] 
**LocationId** | string | The ID of the tender&#39;s associated location. | [optional] 
**TransactionId** | string | The ID of the tender&#39;s associated transaction. | [optional] 
**CreatedAt** | string | The time when the tender was created, in RFC 3339 format. | [optional] 
**Note** | string | An optional note associated with the tender at the time of payment. | [optional] 
**AmountMoney** | Money | The amount of the tender. | [optional] 
**ProcessingFeeMoney** | Money | The amount of any Square processing fees applied to the tender. | [optional] 
**CustomerId** | string | If the tender represents a customer&#39;s card on file, this is the ID of the associated customer. | [optional] 
**Type** | TypeEnum | The type of tender. | 
**CardDetails** | TenderCardDetails | The details of the card tender. This value is present only if the value of &#x60;type&#x60; is &#x60;CARD&#x60;. | [optional] 
**CashDetails** | TenderCashDetails | The details of the cash tender. This value is present only if the value of &#x60;type&#x60; is &#x60;CASH&#x60;. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**Other** | "OTHER"
**Card** | "CARD"
**Cash** | "CASH"
**ThirdPartyCard** | "THIRD_PARTY_CARD"
**SquareGiftCard** | "SQUARE_GIFT_CARD"
**NoSale** | "NO_SALE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

