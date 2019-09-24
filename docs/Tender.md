# Square.Connect.Model.Tender

### Description

Represents a tender (i.e., a method of payment) used in a Square transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The tender&#39;s unique ID. | [optional] 
**LocationId** | **string** | The ID of the transaction&#39;s associated location. | [optional] 
**TransactionId** | **string** | The ID of the tender&#39;s associated transaction. | [optional] 
**CreatedAt** | **string** | The time when the tender was created, in RFC 3339 format. | [optional] 
**Note** | **string** | An optional note associated with the tender at the time of payment. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The total amount of the tender, including &#x60;tip_money&#x60;. If the tender has a &#x60;payment_id&#x60;, the &#x60;total_money&#x60; of the corresponding &#x60;Payment&#x60; will be equal to the &#x60;amount_money&#x60; of the tender. | [optional] 
**TipMoney** | [**Money**](Money.md) | The tip&#39;s amount of the tender. | [optional] 
**ProcessingFeeMoney** | [**Money**](Money.md) | The amount of any Square processing fees applied to the tender.  This field is not immediately populated when a new transaction is created. It is usually available after about ten seconds. | [optional] 
**CustomerId** | **string** | If the tender is associated with a customer or represents a customer&#39;s card on file, this is the ID of the associated customer. | [optional] 
**Type** | **string** | The type of tender, such as &#x60;CARD&#x60; or &#x60;CASH&#x60;. See [TenderType](#type-tendertype) for possible values | 
**CardDetails** | [**TenderCardDetails**](TenderCardDetails.md) | The details of the card tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CARD&#x60;. | [optional] 
**CashDetails** | [**TenderCashDetails**](TenderCashDetails.md) | The details of the cash tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CASH&#x60;. | [optional] 
**AdditionalRecipients** | [**List&lt;AdditionalRecipient&gt;**](AdditionalRecipient.md) | Additional recipients (other than the merchant) receiving a portion of this tender. For example, fees assessed on the purchase by a third party integration. | [optional] 
**PaymentId** | **string** | The ID of the &#x60;Payment&#x60; that corresponds to this tender. This value is only present for payments created with the v2 Payments API. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

