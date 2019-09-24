# Square.Connect.Api.MerchantsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveMerchant**](MerchantsApi.md#retrievemerchant) | **GET** /v2/merchants/{merchant_id} | RetrieveMerchant


<a name="retrievemerchant"></a>
# **RetrieveMerchant**
> RetrieveMerchantResponse RetrieveMerchant (string merchantId)

RetrieveMerchant

Retrieve a `Merchant` object for the given `merchant_id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveMerchantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MerchantsApi();
            var merchantId = merchantId_example;  // string | The ID of the merchant to retrieve

            try
            {
                // RetrieveMerchant
                RetrieveMerchantResponse result = apiInstance.RetrieveMerchant(merchantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantsApi.RetrieveMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| The ID of the merchant to retrieve | 

### Return type

[**RetrieveMerchantResponse**](RetrieveMerchantResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

