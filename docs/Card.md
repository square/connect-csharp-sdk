# Square.Connect.Model.Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The card&#39;s unique ID, if any. | [optional] 
**CardBrand** | **CardBrandEnum** | The card&#39;s brand (such as &#x60;VISA&#x60;). See [CardBrand](#type-cardbrand) for all possible values. | [optional] 
**Last4** | **string** | The last 4 digits of the card&#39;s number. | [optional] 
**ExpMonth** | **long?** | The month of the card&#39;s expiration date. This value is always between &#x60;1&#x60; and &#x60;12&#x60;, inclusive. | [optional] 
**ExpYear** | **long?** | The four-digit year of the card&#39;s expiration date. | [optional] 
**CardholderName** | **string** | The cardholder name. This value is present only if this object represents a customer&#39;s card on file. | [optional] 
**BillingAddress** | [**Address**](Address.md) | The card&#39;s billing address. This value is present only if this object represents a customer&#39;s card on file. | [optional] 
**Fingerprint** | **string** | The unique string fingerprint for the card.  The fingerprint is based on the credit card number and is unique to the merchant.  If a card is used at multiple locations for the same merchant, it will have the same fingerprint in each case. Note: Fingerprint may not exist on old transactions. | [optional] 


## CardBrandEnum

Name | Value
------------ | -------------
**OTHERBRAND** | "OTHER_BRAND"
**VISA** | "VISA"
**MASTERCARD** | "MASTERCARD"
**AMERICANEXPRESS** | "AMERICAN_EXPRESS"
**DISCOVER** | "DISCOVER"
**DISCOVERDINERS** | "DISCOVER_DINERS"
**JCB** | "JCB"
**CHINAUNIONPAY** | "CHINA_UNIONPAY"
**SQUAREGIFTCARD** | "SQUARE_GIFT_CARD"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

