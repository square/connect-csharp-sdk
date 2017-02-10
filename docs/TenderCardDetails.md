# Square.Connect.Model.TenderCardDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **StatusEnum** | The credit card payment&#39;s current state (such as &#x60;AUTHORIZED&#x60; or &#x60;CAPTURED&#x60;). See [TenderCardDetailsStatus](#type-tendercarddetailsstatus) for possible values. | [optional] 
**Card** | [**Card**](Card.md) | The credit card&#39;s non-confidential details. | [optional] 
**EntryMethod** | **EntryMethodEnum** | The method used to enter the card&#39;s details for the transaction. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**AUTHORIZED** | "AUTHORIZED"
**CAPTURED** | "CAPTURED"
**VOIDED** | "VOIDED"
**FAILED** | "FAILED"


## EntryMethodEnum

Name | Value
------------ | -------------
**SWIPED** | "SWIPED"
**KEYED** | "KEYED"
**EMV** | "EMV"
**ONFILE** | "ON_FILE"
**CONTACTLESS** | "CONTACTLESS"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

