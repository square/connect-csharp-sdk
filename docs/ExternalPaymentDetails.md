# Square.Connect.Model.ExternalPaymentDetails

### Description

Additional details about EXTERNAL type payments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of External payment which can be one of: CHECK - Paid by a physical check BANK_TRANSFER - Paid by ACH or other bank transfer OTHER_GIFT_CARD - Paid by a non-square gift card CRYPTO - Paid via a crypto currency SQUARE_CASH - Paid via Square Cash app SOCIAL - Venmo, WeChatPay, AliPay, etc. EXTERNAL - A 3rd party application gathered this payment outside of Square EMONEY - A Japanese e-money brand Square doesn’t support CREDIT/DEBIT - A credit/debit card Square doesn’t support OTHER - A type not listed here | 
**Source** | **string** | A description of the source of the external payment, e.g. “Uber Eats”, “Stripe”, “Shopify”.  Limit 255 characters | 
**SourceId** | **string** | An ID to associate this payment to its originating source  Limit 255 characters. | [optional] 
**SourceFeeMoney** | [**Money**](Money.md) | The total of fees paid to the source. (amount_money - source_fee_money) &#x3D; net money to the merchant | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

