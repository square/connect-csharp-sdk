# Square.Connect.Api.V1LocationApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLocations**](V1LocationApi.md#listlocations) | **GET** /v1/me/locations | Provides details for a business&#39;s locations, including their IDs.
[**RetrieveBusiness**](V1LocationApi.md#retrievebusiness) | **GET** /v1/me | Get a business&#39;s information.


<a name="listlocations"></a>
# **ListLocations**
> List<V1Merchant> ListLocations ()

Provides details for a business's locations, including their IDs.

Provides details for a business's locations, including their IDs.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListLocationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1LocationApi();

            try
            {
                // Provides details for a business's locations, including their IDs.
                List&lt;V1Merchant&gt; result = apiInstance.ListLocations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1LocationApi.ListLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<V1Merchant>**](V1Merchant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievebusiness"></a>
# **RetrieveBusiness**
> V1Merchant RetrieveBusiness ()

Get a business's information.

Get a business's information.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveBusinessExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1LocationApi();

            try
            {
                // Get a business's information.
                V1Merchant result = apiInstance.RetrieveBusiness();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1LocationApi.RetrieveBusiness: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**V1Merchant**](V1Merchant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

