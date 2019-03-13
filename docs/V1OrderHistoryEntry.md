# Square.Connect.Model.V1OrderHistoryEntry

### Description

V1OrderHistoryEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **ActionEnum** | The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values | [optional] 
**CreatedAt** | **string** | The time when the action was performed, in ISO 8601 format. | [optional] 


## ActionEnum

Name | Value
------------ | -------------
**ORDERPLACED** | "ORDER_PLACED"
**DECLINED** | "DECLINED"
**PAYMENTRECEIVED** | "PAYMENT_RECEIVED"
**CANCELED** | "CANCELED"
**COMPLETED** | "COMPLETED"
**REFUNDED** | "REFUNDED"
**EXPIRED** | "EXPIRED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

