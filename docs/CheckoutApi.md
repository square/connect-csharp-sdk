# Square.Connect.Api.CheckoutApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**CreateCheckout**](CheckoutApi.md#createcheckout) | **POST** /v2/locations/{location_id}/checkouts


# **CreateCheckout**
> CreateCheckoutResponse CreateCheckout (string authorization, string locationId, CreateCheckoutRequest body)

### Description

Creates a [Checkout](#type-checkout) response that links a `checkoutId` and `checkout_page_url` that customers can be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **locationId** | **string**| 
 **body** | [**CreateCheckoutRequest**](CreateCheckoutRequest.md)| 

### Return type

[**CreateCheckoutResponse**](CreateCheckoutResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

