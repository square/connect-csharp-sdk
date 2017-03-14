# Square.Connect.Api.LocationApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLocations**](LocationApi.md#listlocations) | **GET** /v2/locations | ListLocations


<a name="listlocations"></a>
# **ListLocations**
> ListLocationsResponse ListLocations ()

ListLocations

Provides the details for all of a business's locations.  Most other Connect API endpoints have a required `location_id` path parameter. The `id` field of the [`Location`](#type-location) objects returned by this endpoint correspond to that `location_id` parameter.

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

            var apiInstance = new LocationApi();

            try
            {
                // ListLocations
                ListLocationsResponse result = apiInstance.ListLocations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.ListLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ListLocationsResponse**](ListLocationsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

