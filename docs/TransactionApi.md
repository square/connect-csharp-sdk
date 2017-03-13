# Square.Connect.Api.TransactionApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**CaptureTransaction**](TransactionApi.md#capturetransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/capture
[**Charge**](TransactionApi.md#charge) | **POST** /v2/locations/{location_id}/transactions
[**ListTransactions**](TransactionApi.md#listtransactions) | **GET** /v2/locations/{location_id}/transactions
[**RetrieveTransaction**](TransactionApi.md#retrievetransaction) | **GET** /v2/locations/{location_id}/transactions/{transaction_id}
[**VoidTransaction**](TransactionApi.md#voidtransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/void


# **CaptureTransaction**
> CaptureTransactionResponse CaptureTransaction (string locationId, string transactionId)

### Description

Captures a transaction that was created with the [Charge](#endpoint-charge) endpoint with a `delay_capture` value of `true`.  See [Delayed capture transactions](/articles/delayed-capture-transactions/) for more information.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **transactionId** | **string**| 

### Return type

[**CaptureTransactionResponse**](CaptureTransactionResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **Charge**
> ChargeResponse Charge (string locationId, ChargeRequest body)

### Description

Charges a card represented by a card nonce or a customer's card on file.  Your request to this endpoint must include _either_:  - A value for the `card_nonce` parameter (to charge a card nonce generated with the `SqPaymentForm`) - Values for the `customer_card_id` and `customer_id` parameters (to charge a customer's card on file)  In order for an e-commerce payment to potentially qualify for [Square chargeback protection](https://squareup.com/help/article/5394), you _must_ provide values for the following parameters in your request:  - `buyer_email_address` - At least one of `billing_address` or `shipping_address`  When this response is returned, the amount of Square's processing fee might not yet be calculated. To obtain the processing fee, wait about ten seconds and call [RetrieveTransaction](#endpoint-retrievetransaction). See the `processing_fee_money` field of each [Tender included](#type-tender) in the transaction.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **body** | [**ChargeRequest**](ChargeRequest.md)| 

### Return type

[**ChargeResponse**](ChargeResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListTransactions**
> ListTransactionsResponse ListTransactions (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

### Description

Lists transactions for a particular location.  Max results per [page](#paginatingresults): 50

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **beginTime** | **string**| [optional] 
 **endTime** | **string**| [optional] 
 **sortOrder** | **string**| [optional] 
 **cursor** | **string**| [optional] 

### Return type

[**ListTransactionsResponse**](ListTransactionsResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **RetrieveTransaction**
> RetrieveTransactionResponse RetrieveTransaction (string locationId, string transactionId)

### Description

Retrieves details for a single transaction.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **transactionId** | **string**| 

### Return type

[**RetrieveTransactionResponse**](RetrieveTransactionResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **VoidTransaction**
> VoidTransactionResponse VoidTransaction (string locationId, string transactionId)

### Description

Cancels a transaction that was created with the [Charge](#endpoint-charge) endpoint with a `delay_capture` value of `true`.  See [Delayed capture transactions](/articles/delayed-capture-transactions/) for more information.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **transactionId** | **string**| 

### Return type

[**VoidTransactionResponse**](VoidTransactionResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

