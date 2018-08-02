# Square.Connect.Api.ApplePayApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegisterDomain**](ApplePayApi.md#registerdomain) | **POST** /v2/apple-pay/domains | RegisterDomain


<a name="registerdomain"></a>
# **RegisterDomain**
> RegisterDomainResponse RegisterDomain (RegisterDomainRequest body)

RegisterDomain

Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payments/sqpaymentform/overview) guide.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RegisterDomainExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplePayApi();
            var body = new RegisterDomainRequest(); // RegisterDomainRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // RegisterDomain
                RegisterDomainResponse result = apiInstance.RegisterDomain(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplePayApi.RegisterDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegisterDomainRequest**](RegisterDomainRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**RegisterDomainResponse**](RegisterDomainResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

