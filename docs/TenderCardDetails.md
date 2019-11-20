# Square.Connect.Model.TenderCardDetails

### Description

Represents additional details of a tender with `type` `CARD` or `SQUARE_GIFT_CARD`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The credit card payment&#39;s current state (such as &#x60;AUTHORIZED&#x60; or &#x60;CAPTURED&#x60;). See &#x60;TenderCardDetailsStatus&#x60; for possible values. See [TenderCardDetailsStatus](#type-tendercarddetailsstatus) for possible values | [optional] 
**Card** | [**Card**](Card.md) | The credit card&#39;s non-confidential details. | [optional] 
**EntryMethod** | **string** | The method used to enter the card&#39;s details for the transaction. See [TenderCardDetailsEntryMethod](#type-tendercarddetailsentrymethod) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

