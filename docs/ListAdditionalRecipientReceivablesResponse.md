# Square.Connect.Model.ListAdditionalRecipientReceivablesResponse

### Description

Defines the fields that are included in the response body of a request to the [ListAdditionalRecipientReceivables](#endpoint-listadditionalrecipientreceivables) endpoint.  One of `errors` or `additional_recipient_receivables` is present in a given response (never both).
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Receivables** | [**List&lt;AdditionalRecipientReceivable&gt;**](AdditionalRecipientReceivable.md) | An array of AdditionalRecipientReceivables that match your query. | [optional] 
**Cursor** | **string** | A pagination cursor for retrieving the next set of results, if any remain. Provide this value as the &#x60;cursor&#x60; parameter in a subsequent request to this endpoint.  See [Paginating results](#paginatingresults) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

