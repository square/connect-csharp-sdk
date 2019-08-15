# Square.Connect.Model.ListPaymentRefundsRequest

### Description

Retrieves a list of refunds for the account making the request.  Max results per page: 100

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginTime** | **string** | Timestamp for the beginning of the requested reporting period, in RFC 3339 format.  Default: The current time minus one year. | [optional] 
**EndTime** | **string** | Timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time. | [optional] 
**SortOrder** | **string** | The order in which results are listed. - &#x60;ASC&#x60; - oldest to newest - &#x60;DESC&#x60; - newest to oldest (default). | [optional] 
**Cursor** | **string** | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 
**LocationId** | **string** | ID of location associated with payment. | [optional] 
**Status** | **string** | If provided, only refunds with the given status are returned.  For a list of refund status values, see [PaymentRefund](#type-paymentrefund).  Default: If omitted refunds are returned regardless of status. | [optional] 
**SourceType** | **string** | If provided, only refunds with the given source type are returned.  - &#x60;CARD&#x60; - List refunds only for payments where card was specified as payment  source.  Default: If omitted refunds are returned regardless of source type. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

