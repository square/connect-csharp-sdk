# Square.Connect.Api.V1LocationsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLocations**](V1LocationsApi.md#listlocations) | **GET** /v1/me/locations | ListLocations
[**RetrieveBusiness**](V1LocationsApi.md#retrievebusiness) | **GET** /v1/me | RetrieveBusiness


<a name="listlocations"></a>
# **ListLocations**
> List<V1Merchant> ListLocations ()

ListLocations

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

            var apiInstance = new V1LocationsApi();

            try
            {
                // ListLocations
                List&lt;V1Merchant&gt; result = apiInstance.ListLocations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1LocationsApi.ListLocations: " + e.Message );
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

RetrieveBusiness

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

            var apiInstance = new V1LocationsApi();

            try
            {
                // RetrieveBusiness
                V1Merchant result = apiInstance.RetrieveBusiness();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1LocationsApi.RetrieveBusiness: " + e.Message );
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

