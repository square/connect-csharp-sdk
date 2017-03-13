# Square.Connect.Api.CustomerCardApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**CreateCustomerCard**](CustomerCardApi.md#createcustomercard) | **POST** /v2/customers/{customer_id}/cards
[**DeleteCustomerCard**](CustomerCardApi.md#deletecustomercard) | **DELETE** /v2/customers/{customer_id}/cards/{card_id}


# **CreateCustomerCard**
> CreateCustomerCardResponse CreateCustomerCard (string customerId, CreateCustomerCardRequest body)

### Description

Adds a card on file to an existing customer.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **customerId** | **string**| 
 **body** | [**CreateCustomerCardRequest**](CreateCustomerCardRequest.md)| 

### Return type

[**CreateCustomerCardResponse**](CreateCustomerCardResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteCustomerCard**
> DeleteCustomerCardResponse DeleteCustomerCard (string customerId, string cardId)

### Description

Removes a card on file from a customer.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **customerId** | **string**| 
 **cardId** | **string**| 

### Return type

[**DeleteCustomerCardResponse**](DeleteCustomerCardResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

