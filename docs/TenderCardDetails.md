# Square.Connect.Model.TenderCardDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | StatusEnum | The credit card payment&#39;s current state (such as &#x60;CAPTURED&#x60;) | [optional] 
**Card** | Card | The credit card&#39;s non-confidential details. | [optional] 
**EntryMethod** | EntryMethodEnum | The method used to read the card. | [optional] 


## StatusEnum

Name | Value
------------ | -------------
**Authorized** | "AUTHORIZED"
**Captured** | "CAPTURED"
**Voided** | "VOIDED"
**Failed** | "FAILED"


## EntryMethodEnum

Name | Value
------------ | -------------
**Swiped** | "SWIPED"
**Keyed** | "KEYED"
**Emv** | "EMV"
**OnFile** | "ON_FILE"
**Contactless** | "CONTACTLESS"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

