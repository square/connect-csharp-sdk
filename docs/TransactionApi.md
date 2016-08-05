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
> CaptureTransactionResponse CaptureTransaction (string authorization, string locationId, string transactionId)

### Description

Captures a transaction that was created with the **Charge** endpoint with a `delay_capture` value of `true`.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
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
> ChargeResponse Charge (string authorization, string locationId, ChargeRequest body)

### Description

Charges a card represented by a token.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
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
> ListTransactionsResponse ListTransactions (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

### Description

Lists transactions for a particular location.  When making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must include both `begin_time` and `end_time` with an optional `sort_order`.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
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
> RetrieveTransactionResponse RetrieveTransaction (string authorization, string locationId, string transactionId)

### Description

Retrieves details for a single transaction.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
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
> VoidTransactionResponse VoidTransaction (string authorization, string locationId, string transactionId)

### Description

Cancels a transaction that was created with the **Charge** endpoint with a `delay_capture` value of `true`.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
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

