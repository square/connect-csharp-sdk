# Square.Connect.Model.V1Order

### Description

V1Order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Id** | **string** | The order&#39;s unique identifier. | [optional] 
**BuyerEmail** | **string** | The email address of the order&#39;s buyer. | [optional] 
**RecipientName** | **string** | The name of the order&#39;s buyer. | [optional] 
**RecipientPhoneNumber** | **string** | The phone number to use for the order&#39;s delivery. | [optional] 
**State** | **string** | Whether the tax is an ADDITIVE tax or an INCLUSIVE tax. See [V1OrderState](#type-v1orderstate) for possible values | [optional] 
**ShippingAddress** | [**Address**](Address.md) | The address to ship the order to. | [optional] 
**SubtotalMoney** | [**V1Money**](V1Money.md) | The amount of all items purchased in the order, before taxes and shipping. | [optional] 
**TotalShippingMoney** | [**V1Money**](V1Money.md) | The shipping cost for the order. | [optional] 
**TotalTaxMoney** | [**V1Money**](V1Money.md) | The total of all taxes applied to the order. | [optional] 
**TotalPriceMoney** | [**V1Money**](V1Money.md) | The total cost of the order. | [optional] 
**TotalDiscountMoney** | [**V1Money**](V1Money.md) | The total of all discounts applied to the order. | [optional] 
**CreatedAt** | **string** | The time when the order was created, in ISO 8601 format. | [optional] 
**UpdatedAt** | **string** | The time when the order was last modified, in ISO 8601 format. | [optional] 
**ExpiresAt** | **string** | The time when the order expires if no action is taken, in ISO 8601 format. | [optional] 
**PaymentId** | **string** | The unique identifier of the payment associated with the order. | [optional] 
**BuyerNote** | **string** | A note provided by the buyer when the order was created, if any. | [optional] 
**CompletedNote** | **string** | A note provided by the merchant when the order&#39;s state was set to COMPLETED, if any | [optional] 
**RefundedNote** | **string** | A note provided by the merchant when the order&#39;s state was set to REFUNDED, if any. | [optional] 
**CanceledNote** | **string** | A note provided by the merchant when the order&#39;s state was set to CANCELED, if any. | [optional] 
**Tender** | [**V1Tender**](V1Tender.md) | The tender used to pay for the order. | [optional] 
**OrderHistory** | [**List&lt;V1OrderHistoryEntry&gt;**](V1OrderHistoryEntry.md) | The history of actions associated with the order. | [optional] 
**PromoCode** | **string** | The promo code provided by the buyer, if any. | [optional] 
**BtcReceiveAddress** | **string** | For Bitcoin transactions, the address that the buyer sent Bitcoin to. | [optional] 
**BtcPriceSatoshi** | **decimal?** | For Bitcoin transactions, the price of the buyer&#39;s order in satoshi (100 million satoshi equals 1 BTC). | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

