# Square.Connect.Model.V1Payment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The payment&#39;s unique identifier. | [optional] 
**MerchantId** | **string** | The unique identifier of the merchant that took the payment. | [optional] 
**CreatedAt** | **string** | The time when the payment was created, in ISO 8601 format. | [optional] 
**CreatorId** | **string** | The unique identifier of the Square account that took the payment. | [optional] 
**Device** | [**Device**](Device.md) | The device that took the payment. | [optional] 
**PaymentUrl** | **string** | The URL of the payment&#39;s detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page. | [optional] 
**ReceiptUrl** | **string** | The URL of the receipt for the payment. Note that for split tender payments, this URL corresponds to the receipt for the first tender listed in the payment&#39;s tender field. Each Tender object has its own receipt_url field you can use to get the other receipts associated with a split tender payment. | [optional] 
**InclusiveTaxMoney** | [**V1Money**](V1Money.md) | The sum of all inclusive taxes associated with the payment. | [optional] 
**AdditiveTaxMoney** | [**V1Money**](V1Money.md) | The sum of all additive taxes associated with the payment. | [optional] 
**TaxMoney** | [**V1Money**](V1Money.md) | The total of all taxes applied to the payment. This is always the sum of inclusive_tax_money and additive_tax_money. | [optional] 
**TipMoney** | [**V1Money**](V1Money.md) | The total of all tips applied to the payment. | [optional] 
**DiscountMoney** | [**V1Money**](V1Money.md) | The total of all discounts applied to the payment. | [optional] 
**TotalCollectedMoney** | [**V1Money**](V1Money.md) | The total of all discounts applied to the payment. | [optional] 
**ProcessingFeeMoney** | [**V1Money**](V1Money.md) | The total of all processing fees collected by Square for the payment. | [optional] 
**NetTotalMoney** | [**V1Money**](V1Money.md) | The amount to be deposited into the merchant&#39;s bank account for the payment. | [optional] 
**RefundedMoney** | [**V1Money**](V1Money.md) | The total of all refunds applied to the payment. | [optional] 
**SwedishRoundingMoney** | [**V1Money**](V1Money.md) | The total of all sales, including any applicable taxes, rounded to the smallest legal unit of currency (e.g., the nearest penny in USD, the nearest nickel in CAD) | [optional] 
**GrossSalesMoney** | [**V1Money**](V1Money.md) | The total of all sales, including any applicable taxes. | [optional] 
**NetSalesMoney** | [**V1Money**](V1Money.md) | The total of all sales, minus any applicable taxes. | [optional] 
**InclusiveTax** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | All of the inclusive taxes associated with the payment. | [optional] 
**AdditiveTax** | [**List&lt;V1PaymentTax&gt;**](V1PaymentTax.md) | All of the additive taxes associated with the payment. | [optional] 
**Tender** | [**List&lt;V1Tender&gt;**](V1Tender.md) | All of the additive taxes associated with the payment. | [optional] 
**Refunds** | [**List&lt;V1Refund&gt;**](V1Refund.md) | All of the refunds applied to the payment. Note that the value of all refunds on a payment can exceed the value of all tenders if a merchant chooses to refund money to a tender after previously accepting returned goods as part of an exchange. | [optional] 
**Itemizations** | [**List&lt;V1PaymentItemization&gt;**](V1PaymentItemization.md) | The items purchased in the payment. | [optional] 
**SurchargeMoney** | [**V1Money**](V1Money.md) | The total of all surcharges applied to the payment. | [optional] 
**Surcharges** | [**List&lt;V1PaymentSurcharge&gt;**](V1PaymentSurcharge.md) | A list of all surcharges associated with the payment. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

