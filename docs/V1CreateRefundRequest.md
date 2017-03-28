# Square.Connect.Model.V1CreateRefundRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | The ID of the payment to refund. If you&#39;re creating a PARTIAL refund for a split tender payment, instead provide the id of the particular tender you want to refund. See Split Tender Payments for details. | 
**Type** | **TypeEnum** | TThe type of refund (FULL or PARTIAL). | 
**Reason** | **string** | The reason for the refund. | 
**RefundedMoney** | [**V1Money**](V1Money.md) | The amount of money to refund. Required only for PARTIAL refunds. | [optional] 
**RequestIdempotenceKey** | **string** | An optional key to ensure idempotence if you issue the same PARTIAL refund request more than once. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**FULL** | "FULL"
**PARTIAL** | "PARTIAL"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

