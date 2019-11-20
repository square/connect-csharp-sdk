# Square.Connect.Api.InventoryApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchChangeInventory**](InventoryApi.md#batchchangeinventory) | **POST** /v2/inventory/batch-change | BatchChangeInventory
[**BatchRetrieveInventoryChanges**](InventoryApi.md#batchretrieveinventorychanges) | **POST** /v2/inventory/batch-retrieve-changes | BatchRetrieveInventoryChanges
[**BatchRetrieveInventoryCounts**](InventoryApi.md#batchretrieveinventorycounts) | **POST** /v2/inventory/batch-retrieve-counts | BatchRetrieveInventoryCounts
[**RetrieveInventoryAdjustment**](InventoryApi.md#retrieveinventoryadjustment) | **GET** /v2/inventory/adjustment/{adjustment_id} | RetrieveInventoryAdjustment
[**RetrieveInventoryChanges**](InventoryApi.md#retrieveinventorychanges) | **GET** /v2/inventory/{catalog_object_id}/changes | RetrieveInventoryChanges
[**RetrieveInventoryCount**](InventoryApi.md#retrieveinventorycount) | **GET** /v2/inventory/{catalog_object_id} | RetrieveInventoryCount
[**RetrieveInventoryPhysicalCount**](InventoryApi.md#retrieveinventoryphysicalcount) | **GET** /v2/inventory/physical-count/{physical_count_id} | RetrieveInventoryPhysicalCount


<a name="batchchangeinventory"></a>
# **BatchChangeInventory**
> BatchChangeInventoryResponse BatchChangeInventory (BatchChangeInventoryRequest body)

BatchChangeInventory

Applies adjustments and counts to the provided item quantities.  On success: returns the current calculated counts for all objects referenced in the request. On failure: returns a list of related errors.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class BatchChangeInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var body = new BatchChangeInventoryRequest(); // BatchChangeInventoryRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // BatchChangeInventory
                BatchChangeInventoryResponse result = apiInstance.BatchChangeInventory(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.BatchChangeInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchChangeInventoryRequest**](BatchChangeInventoryRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**BatchChangeInventoryResponse**](BatchChangeInventoryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchretrieveinventorychanges"></a>
# **BatchRetrieveInventoryChanges**
> BatchRetrieveInventoryChangesResponse BatchRetrieveInventoryChanges (BatchRetrieveInventoryChangesRequest body)

BatchRetrieveInventoryChanges

Returns historical physical counts and adjustments based on the provided filter criteria.  Results are paginated and sorted in ascending order according their `occurred_at` timestamp (oldest first).  BatchRetrieveInventoryChanges is a catch-all query endpoint for queries that cannot be handled by other, simpler endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class BatchRetrieveInventoryChangesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var body = new BatchRetrieveInventoryChangesRequest(); // BatchRetrieveInventoryChangesRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // BatchRetrieveInventoryChanges
                BatchRetrieveInventoryChangesResponse result = apiInstance.BatchRetrieveInventoryChanges(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.BatchRetrieveInventoryChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchRetrieveInventoryChangesRequest**](BatchRetrieveInventoryChangesRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**BatchRetrieveInventoryChangesResponse**](BatchRetrieveInventoryChangesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchretrieveinventorycounts"></a>
# **BatchRetrieveInventoryCounts**
> BatchRetrieveInventoryCountsResponse BatchRetrieveInventoryCounts (BatchRetrieveInventoryCountsRequest body)

BatchRetrieveInventoryCounts

Returns current counts for the provided [CatalogObject](#type-catalogobject)s at the requested [Location](#type-location)s.  Results are paginated and sorted in descending order according to their `calculated_at` timestamp (newest first).  When `updated_after` is specified, only counts that have changed since that time (based on the server timestamp for the most recent change) are returned. This allows clients to perform a \"sync\" operation, for example in response to receiving a Webhook notification.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class BatchRetrieveInventoryCountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var body = new BatchRetrieveInventoryCountsRequest(); // BatchRetrieveInventoryCountsRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // BatchRetrieveInventoryCounts
                BatchRetrieveInventoryCountsResponse result = apiInstance.BatchRetrieveInventoryCounts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.BatchRetrieveInventoryCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchRetrieveInventoryCountsRequest**](BatchRetrieveInventoryCountsRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**BatchRetrieveInventoryCountsResponse**](BatchRetrieveInventoryCountsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveinventoryadjustment"></a>
# **RetrieveInventoryAdjustment**
> RetrieveInventoryAdjustmentResponse RetrieveInventoryAdjustment (string adjustmentId)

RetrieveInventoryAdjustment

Returns the [InventoryAdjustment](#type-inventoryadjustment) object with the provided `adjustment_id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveInventoryAdjustmentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var adjustmentId = adjustmentId_example;  // string | ID of the `InventoryAdjustment` to retrieve.

            try
            {
                // RetrieveInventoryAdjustment
                RetrieveInventoryAdjustmentResponse result = apiInstance.RetrieveInventoryAdjustment(adjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RetrieveInventoryAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adjustmentId** | **string**| ID of the &#x60;InventoryAdjustment&#x60; to retrieve. | 

### Return type

[**RetrieveInventoryAdjustmentResponse**](RetrieveInventoryAdjustmentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveinventorychanges"></a>
# **RetrieveInventoryChanges**
> RetrieveInventoryChangesResponse RetrieveInventoryChanges (string catalogObjectId, string locationIds = null, string cursor = null)

RetrieveInventoryChanges

Returns a set of physical counts and inventory adjustments for the provided [CatalogObject](#type-catalogobject) at the requested [Location](#type-location)s.  Results are paginated and sorted in descending order according to their `occurred_at` timestamp (newest first).  There are no limits on how far back the caller can page. This endpoint is useful when displaying recent changes for a specific item. For more sophisticated queries, use a batch endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveInventoryChangesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var catalogObjectId = catalogObjectId_example;  // string | ID of the `CatalogObject` to retrieve.
            var locationIds = locationIds_example;  // string | The `Location` IDs to look up as a comma-separated list. An empty list queries all locations. (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination) guide for more information. (optional) 

            try
            {
                // RetrieveInventoryChanges
                RetrieveInventoryChangesResponse result = apiInstance.RetrieveInventoryChanges(catalogObjectId, locationIds, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RetrieveInventoryChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogObjectId** | **string**| ID of the &#x60;CatalogObject&#x60; to retrieve. | 
 **locationIds** | **string**| The &#x60;Location&#x60; IDs to look up as a comma-separated list. An empty list queries all locations. | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination) guide for more information. | [optional] 

### Return type

[**RetrieveInventoryChangesResponse**](RetrieveInventoryChangesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveinventorycount"></a>
# **RetrieveInventoryCount**
> RetrieveInventoryCountResponse RetrieveInventoryCount (string catalogObjectId, string locationIds = null, string cursor = null)

RetrieveInventoryCount

Retrieves the current calculated stock count for a given [CatalogObject](#type-catalogobject) at a given set of [Location](#type-location)s. Responses are paginated and unsorted. For more sophisticated queries, use a batch endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveInventoryCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var catalogObjectId = catalogObjectId_example;  // string | ID of the `CatalogObject` to retrieve.
            var locationIds = locationIds_example;  // string | The `Location` IDs to look up as a comma-separated list. An empty list queries all locations. (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination) guide for more information. (optional) 

            try
            {
                // RetrieveInventoryCount
                RetrieveInventoryCountResponse result = apiInstance.RetrieveInventoryCount(catalogObjectId, locationIds, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RetrieveInventoryCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogObjectId** | **string**| ID of the &#x60;CatalogObject&#x60; to retrieve. | 
 **locationIds** | **string**| The &#x60;Location&#x60; IDs to look up as a comma-separated list. An empty list queries all locations. | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination) guide for more information. | [optional] 

### Return type

[**RetrieveInventoryCountResponse**](RetrieveInventoryCountResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveinventoryphysicalcount"></a>
# **RetrieveInventoryPhysicalCount**
> RetrieveInventoryPhysicalCountResponse RetrieveInventoryPhysicalCount (string physicalCountId)

RetrieveInventoryPhysicalCount

Returns the [InventoryPhysicalCount](#type-inventoryphysicalcount) object with the provided `physical_count_id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveInventoryPhysicalCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi();
            var physicalCountId = physicalCountId_example;  // string | ID of the `InventoryPhysicalCount` to retrieve.

            try
            {
                // RetrieveInventoryPhysicalCount
                RetrieveInventoryPhysicalCountResponse result = apiInstance.RetrieveInventoryPhysicalCount(physicalCountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RetrieveInventoryPhysicalCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **physicalCountId** | **string**| ID of the &#x60;InventoryPhysicalCount&#x60; to retrieve. | 

### Return type

[**RetrieveInventoryPhysicalCountResponse**](RetrieveInventoryPhysicalCountResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

