# Square.Connect.Api.CheckoutApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCheckout**](CheckoutApi.md#createcheckout) | **POST** /v2/locations/{location_id}/checkouts | CreateCheckout


<a name="createcheckout"></a>
# **CreateCheckout**
> CreateCheckoutResponse CreateCheckout (string locationId, CreateCheckoutRequest body)

CreateCheckout

Creates a [Checkout](#type-checkout) response that links a `checkoutId` and `checkout_page_url` that customers can be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateCheckoutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckoutApi();
            var locationId = locationId_example;  // string | The ID of the business location to associate the checkout with.
            var body = new CreateCheckoutRequest(); // CreateCheckoutRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateCheckout
                CreateCheckoutResponse result = apiInstance.CreateCheckout(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CreateCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the business location to associate the checkout with. | 
 **body** | [**CreateCheckoutRequest**](CreateCheckoutRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateCheckoutResponse**](CreateCheckoutResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

