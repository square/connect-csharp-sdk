# Square.Connect.Api.OrdersApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchRetrieveOrders**](OrdersApi.md#batchretrieveorders) | **POST** /v2/locations/{location_id}/orders/batch-retrieve | BatchRetrieveOrders
[**CreateOrder**](OrdersApi.md#createorder) | **POST** /v2/locations/{location_id}/orders | CreateOrder


<a name="batchretrieveorders"></a>
# **BatchRetrieveOrders**
> BatchRetrieveOrdersResponse BatchRetrieveOrders (string locationId, BatchRetrieveOrdersRequest body)

BatchRetrieveOrders

Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class BatchRetrieveOrdersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var locationId = locationId_example;  // string | The ID of the orders' associated location.
            var body = new BatchRetrieveOrdersRequest(); // BatchRetrieveOrdersRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // BatchRetrieveOrders
                BatchRetrieveOrdersResponse result = apiInstance.BatchRetrieveOrders(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.BatchRetrieveOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the orders&#39; associated location. | 
 **body** | [**BatchRetrieveOrdersRequest**](BatchRetrieveOrdersRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**BatchRetrieveOrdersResponse**](BatchRetrieveOrdersResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorder"></a>
# **CreateOrder**
> CreateOrderResponse CreateOrder (string locationId, CreateOrderRequest body)

CreateOrder

Creates an [Order](#type-order) that can then be referenced as `order_id` in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order's `id` in the `order_id` field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](/products/orders/overview).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var locationId = locationId_example;  // string | The ID of the business location to associate the order with.
            var body = new CreateOrderRequest(); // CreateOrderRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateOrder
                CreateOrderResponse result = apiInstance.CreateOrder(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the business location to associate the order with. | 
 **body** | [**CreateOrderRequest**](CreateOrderRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateOrderResponse**](CreateOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

