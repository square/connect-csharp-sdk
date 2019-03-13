# Square.Connect.Model.ListAdditionalRecipientReceivableRefundsResponse

### Description

Defines the fields that are included in the response body of a request to the [ListAdditionalRecipientReceivableRefunds](#endpoint-listadditionalrecipientreceivablerefunds) endpoint.  One of `errors` or `additional_recipient_receivable_refunds` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**ReceivableRefunds** | [**List&lt;AdditionalRecipientReceivableRefund&gt;**](AdditionalRecipientReceivableRefund.md) | An array of AdditionalRecipientReceivableRefunds that match your query. | [optional] 
**Cursor** | **string** | A pagination cursor for retrieving the next set of results, if any remain. Provide this value as the &#x60;cursor&#x60; parameter in a subsequent request to this endpoint.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

