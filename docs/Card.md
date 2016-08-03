# Square.Connect.Model.Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | string | The card&#39;s unique ID, if any. | [optional] 
**CardBrand** | CardBrandEnum | The card&#39;s brand (such as &#x60;VISA&#x60;). | [optional] 
**Last4** | string | The last 4 digits of the card&#39;s number. | [optional] 
**ExpMonth** | int? | The month of the card&#39;s expiration date, which must be between 1-12. | [optional] 
**ExpYear** | int? | The year of the card&#39;s expiration date, which must be a 4-digit year. | [optional] 
**CardholderName** | string | The cardholder name for the card on file. | [optional] 
**BillingAddress** | Address | The billing address for the card on file. | [optional] 


## CardBrandEnum

Name | Value
------------ | -------------
**OtherBrand** | "OTHER_BRAND"
**Visa** | "VISA"
**Mastercard** | "MASTERCARD"
**AmericanExpress** | "AMERICAN_EXPRESS"
**Discover** | "DISCOVER"
**DiscoverDiners** | "DISCOVER_DINERS"
**Jcb** | "JCB"
**ChinaUnionpay** | "CHINA_UNIONPAY"
**SquareGiftCard** | "SQUARE_GIFT_CARD"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

