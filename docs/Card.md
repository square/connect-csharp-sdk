# Square.Connect.Model.Card

### Description

Represents the payment details of a card to be used for payments. These details are determined by the `card_nonce` generated by `SqPaymentForm`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID for this card. Generated by Square. | [optional] 
**CardBrand** | **string** | The card&#39;s brand (such as &#x60;VISA&#x60;). See &#x60;CardBrand&#x60; for all possible values. See [CardBrand](#type-cardbrand) for possible values | [optional] 
**Last4** | **string** | The last 4 digits of the card number. | [optional] 
**ExpMonth** | **long?** | The expiration month of the associated card as an integer between 1 and 12. | [optional] 
**ExpYear** | **long?** | The four-digit year of the card&#39;s expiration date. | [optional] 
**CardholderName** | **string** | The name of the cardholder. | [optional] 
**BillingAddress** | [**Address**](Address.md) | The billing address for this card. | [optional] 
**Fingerprint** | **string** | __Not currently set.__ Intended as a Square-assigned identifier, based  on the card number, to identify the card across multiple locations within a single application. | [optional] 
**Bin** | **string** | The first six digits of the card number, known as the Bank Identification Number (BIN). Only the Payments API returns this field. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

