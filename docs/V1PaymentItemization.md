# Square.Connect.Model.V1PaymentItemization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The item&#39;s name. | [optional] 
**Quantity** | **decimal?** | The quantity of the item purchased. This can be a decimal value. | [optional] 
**ItemizationType** | **ItemizationTypeEnum** | The type of purchase that the itemization represents, such as an ITEM or CUSTOM_AMOUNT | [optional] 
**ItemDetail** | [**V1PaymentItemDetail**](V1PaymentItemDetail.md) | Details of the item, including its unique identifier and the identifier of the item variation purchased. | [optional] 
**Notes** | **string** | Notes entered by the merchant about the item at the time of payment, if any. | [optional] 
**ItemVariationName** | **string** | The name of the item variation purchased, if any. | [optional] 
**TotalMoney** | [**V1Money**](V1Money.md) | The total cost of the item, including all taxes and discounts. | [optional] 
**SingleQuantityMoney** | [**V1Money**](V1Money.md) | The cost of a single unit of this item. | [optional] 
**GrossSalesMoney** | [**V1Money**](V1Money.md) | The total cost of the itemization and its modifiers, not including taxes or discounts. | [optional] 
**DiscountMoney** | [**V1Money**](V1Money.md) | The total of all discounts applied to the itemization. This value is always negative or zero. | [optional] 
**NetSalesMoney** | [**V1Money**](V1Money.md) | The sum of gross_sales_money and discount_money. | [optional] 
**Taxes** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | All taxes applied to this itemization. | [optional] 
**Discounts** | [**List&lt;V1PaymentDiscount&gt;**](V1PaymentDiscount.md) | All discounts applied to this itemization. | [optional] 
**Modifiers** | [**List&lt;V1PaymentModifier&gt;**](V1PaymentModifier.md) | All modifier options applied to this itemization. | [optional] 


## ItemizationTypeEnum

Name | Value
------------ | -------------
**ITEM** | "ITEM"
**CUSTOMAMOUNT** | "CUSTOM_AMOUNT"
**GIFTCARDACTIVATION** | "GIFT_CARD_ACTIVATION"
**GIFTCARDRELOAD** | "GIFT_CARD_RELOAD"
**GIFTCARDUNKNOWN** | "GIFT_CARD_UNKNOWN"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

