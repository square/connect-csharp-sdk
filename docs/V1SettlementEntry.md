# Square.Connect.Model.V1SettlementEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | The settlement&#39;s unique identifier. | [optional] 
**Type** | **TypeEnum** | The settlement&#39;s current status. | [optional] 
**AmountMoney** | [**V1Money**](V1Money.md) | The total amount of money this entry contributes to the total settlement amount. | [optional] 
**FeeMoney** | [**V1Money**](V1Money.md) | The amount of all Square fees associated with this settlement entry. This value is always negative or zero. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**ADJUSTMENT** | "ADJUSTMENT"
**BALANCECHARGE** | "BALANCE_CHARGE"
**CHARGE** | "CHARGE"
**FREEPROCESSING** | "FREE_PROCESSING"
**HOLDADJUSTMENT** | "HOLD_ADJUSTMENT"
**PAIDSERVICEFEE** | "PAID_SERVICE_FEE"
**PAIDSERVICEFEEREFUND** | "PAID_SERVICE_FEE_REFUND"
**REDEMPTIONCODE** | "REDEMPTION_CODE"
**REFUND** | "REFUND"
**RETURNEDPAYOUT** | "RETURNED_PAYOUT"
**SQUARECAPITALADVANCE** | "SQUARE_CAPITAL_ADVANCE"
**SQUARECAPITALPAYMENT** | "SQUARE_CAPITAL_PAYMENT"
**SQUARECAPITALREVERSEDPAYMENT** | "SQUARE_CAPITAL_REVERSED_PAYMENT"
**SUBSCRIPTIONFEE** | "SUBSCRIPTION_FEE"
**SUBSCRIPTIONFEEREFUND** | "SUBSCRIPTION_FEE_REFUND"
**OTHER** | "OTHER"
**INCENTEDPAYMENT** | "INCENTED_PAYMENT"
**RETURNEDACHENTRY** | "RETURNED_ACH_ENTRY"
**RETURNEDSQUARE275** | "RETURNED_SQUARE_275"
**SQUARE275** | "SQUARE_275"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

