# Square.Connect.Model.V1Tender
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The tender&#39;s unique ID. | [optional] 
**Type** | **TypeEnum** | The type of tender. | [optional] 
**Name** | **string** | A human-readable description of the tender. | [optional] 
**EmployeeId** | **string** | The ID of the employee that processed the tender. | [optional] 
**ReceiptUrl** | **string** | The URL of the receipt for the tender. | [optional] 
**CardBrand** | **CardBrandEnum** | The brand of credit card provided. | [optional] 
**PanSuffix** | **string** | The last four digits of the provided credit card&#39;s account number. | [optional] 
**EntryMethod** | **EntryMethodEnum** | The tender&#39;s unique ID. | [optional] 
**PaymentNote** | **string** | Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type: OTHER. | [optional] 
**TotalMoney** | [**V1Money**](V1Money.md) | The total amount of money provided in this form of tender. | [optional] 
**TenderedMoney** | [**V1Money**](V1Money.md) | The amount of total_money applied to the payment. | [optional] 
**ChangeBackMoney** | [**V1Money**](V1Money.md) | The amount of total_money returned to the buyer as change. | [optional] 
**RefundedMoney** | [**V1Money**](V1Money.md) | The total of all refunds applied to this tender. This amount is always negative or zero. | [optional] 
**IsExchange** | **bool?** | Indicates whether or not the tender is associated with an exchange. If is_exchange is true, the tender represents the value of goods returned in an exchange not the actual money paid. The exchange value reduces the tender amounts needed to pay for items purchased in the exchange. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**CREDITCARD** | "CREDIT_CARD"
**CASH** | "CASH"
**THIRDPARTYCARD** | "THIRD_PARTY_CARD"
**NOSALE** | "NO_SALE"
**SQUAREWALLET** | "SQUARE_WALLET"
**SQUAREGIFTCARD** | "SQUARE_GIFT_CARD"
**UNKNOWN** | "UNKNOWN"
**OTHER** | "OTHER"


## CardBrandEnum

Name | Value
------------ | -------------
**OTHERBRAND** | "OTHER_BRAND"
**VISA** | "VISA"
**MASTERCARD** | "MASTER_CARD"
**AMERICANEXPRESS** | "AMERICAN_EXPRESS"
**DISCOVER** | "DISCOVER"
**DISCOVERDINERS** | "DISCOVER_DINERS"
**JCB** | "JCB"
**CHINAUNIONPAY** | "CHINA_UNIONPAY"
**SQUAREGIFTCARD** | "SQUARE_GIFT_CARD"


## EntryMethodEnum

Name | Value
------------ | -------------
**MANUAL** | "MANUAL"
**SCANNED** | "SCANNED"
**SQUARECASH** | "SQUARE_CASH"
**SQUAREWALLET** | "SQUARE_WALLET"
**SWIPED** | "SWIPED"
**WEBFORM** | "WEB_FORM"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

