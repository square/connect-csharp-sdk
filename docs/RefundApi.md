# Square.Connect.Api.RefundApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**CreateRefund**](RefundApi.md#createrefund) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/refund
[**ListRefunds**](RefundApi.md#listrefunds) | **GET** /v2/locations/{location_id}/refunds


# **CreateRefund**
> CreateRefundResponse CreateRefund (string locationId, string transactionId, CreateRefundRequest body)

### Description

Initiates a refund for a previously charged tender.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **transactionId** | **string**| 
 **body** | [**CreateRefundRequest**](CreateRefundRequest.md)| 

### Return type

[**CreateRefundResponse**](CreateRefundResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListRefunds**
> ListRefundsResponse ListRefunds (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

### Description

Lists refunds for one of a business's locations.  Refunds with a `status` of `PENDING` are not currently included in this endpoint's response.  Max results per [page](#paginatingresults): 50

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **locationId** | **string**| 
 **beginTime** | **string**| [optional] 
 **endTime** | **string**| [optional] 
 **sortOrder** | **string**| [optional] 
 **cursor** | **string**| [optional] 

### Return type

[**ListRefundsResponse**](ListRefundsResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

