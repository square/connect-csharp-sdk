# Square.Connect.Model.CardPaymentDetails

### Description

Reflects the current status of a card payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The card payment&#39;s current state. It can be one of: &#x60;AUTHORIZED&#x60;, &#x60;CAPTURED&#x60;, &#x60;VOIDED&#x60;, &#x60;FAILED&#x60;. | [optional] 
**Card** | [**Card**](Card.md) | The credit card&#39;s non-confidential details. | [optional] 
**EntryMethod** | **string** | The method used to enter the card&#39;s details for the payment.  Can be &#x60;KEYED&#x60;, &#x60;SWIPED&#x60;, &#x60;EMV&#x60;, &#x60;ON_FILE&#x60;, or &#x60;CONTACTLESS&#x60;. | [optional] 
**CvvStatus** | **string** | Status code returned from the Card Verification Value (CVV) check. | [optional] 
**AvsStatus** | **string** | Status code returned from the Address Verification System (AVS) check. | [optional] 
**AuthResultCode** | **string** | Status code returned by the card issuer that describes the payment&#39;s authorization status. | [optional] 
**ApplicationIdentifier** | **string** | For EMV payments, identifies the EMV application used for the payment | [optional] 
**ApplicationName** | **string** | For EMV payments, the human-readable name of the EMV application used for the payment. | [optional] 
**ApplicationCryptogram** | **string** | For EMV payments, the cryptogram generated for the payment. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Information on errors encountered during the request. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

