# Square.Connect.Model.ListPaymentsResponse

### Description

Defines the fields that are included in the response body of a request to the [ListPayments](#endpoint-payments-listpayments) endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Information on errors encountered during the request. | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | The requested list of &#x60;Payment&#x60;s. | [optional] 
**Cursor** | **string** | The pagination cursor to be used in a subsequent request. If empty, this is the final response.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

