# Square.Connect.Api.LaborApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBreakType**](LaborApi.md#createbreaktype) | **POST** /v2/labor/break-types | CreateBreakType
[**CreateShift**](LaborApi.md#createshift) | **POST** /v2/labor/shifts | CreateShift
[**DeleteBreakType**](LaborApi.md#deletebreaktype) | **DELETE** /v2/labor/break-types/{id} | DeleteBreakType
[**DeleteShift**](LaborApi.md#deleteshift) | **DELETE** /v2/labor/shifts/{id} | DeleteShift
[**GetBreakType**](LaborApi.md#getbreaktype) | **GET** /v2/labor/break-types/{id} | GetBreakType
[**GetEmployeeWage**](LaborApi.md#getemployeewage) | **GET** /v2/labor/employee-wages/{id} | GetEmployeeWage
[**GetShift**](LaborApi.md#getshift) | **GET** /v2/labor/shifts/{id} | GetShift
[**ListBreakTypes**](LaborApi.md#listbreaktypes) | **GET** /v2/labor/break-types | ListBreakTypes
[**ListEmployeeWages**](LaborApi.md#listemployeewages) | **GET** /v2/labor/employee-wages | ListEmployeeWages
[**ListWorkweekConfigs**](LaborApi.md#listworkweekconfigs) | **GET** /v2/labor/workweek-configs | ListWorkweekConfigs
[**SearchShifts**](LaborApi.md#searchshifts) | **POST** /v2/labor/shifts/search | SearchShifts
[**UpdateBreakType**](LaborApi.md#updatebreaktype) | **PUT** /v2/labor/break-types/{id} | UpdateBreakType
[**UpdateShift**](LaborApi.md#updateshift) | **PUT** /v2/labor/shifts/{id} | UpdateShift
[**UpdateWorkweekConfig**](LaborApi.md#updateworkweekconfig) | **PUT** /v2/labor/workweek-configs/{id} | UpdateWorkweekConfig


<a name="createbreaktype"></a>
# **CreateBreakType**
> CreateBreakTypeResponse CreateBreakType (CreateBreakTypeRequest body)

CreateBreakType

Creates a new `BreakType`.   A `BreakType` is a template for creating `Break` objects.  You must provide the following values in your request to this endpoint:  - `location_id` - `break_name` - `expected_duration` - `is_paid`  You can only have 3 `BreakType` instances per location. If you attempt to add a 4th `BreakType` for a location, an `INVALID_REQUEST_ERROR` \"Exceeded limit of 3 breaks per location.\" is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateBreakTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var body = new CreateBreakTypeRequest(); // CreateBreakTypeRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateBreakType
                CreateBreakTypeResponse result = apiInstance.CreateBreakType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.CreateBreakType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateBreakTypeRequest**](CreateBreakTypeRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateBreakTypeResponse**](CreateBreakTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshift"></a>
# **CreateShift**
> CreateShiftResponse CreateShift (CreateShiftRequest body)

CreateShift

Creates a new `Shift`.   A `Shift` represents a complete work day for a single employee.  You must provide the following values in your request to this endpoint:  - `location_id` - `employee_id` - `start_at`  An attempt to create a new `Shift` can result in a `BAD_REQUEST` error when: - The `status` of the new `Shift` is `OPEN` and the employee has another  shift with an `OPEN` status.  - The `start_at` date is in the future - the `start_at` or `end_at` overlaps another shift for the same employee - If `Break`s are set in the request, a break `start_at` must not be before the `Shift.start_at`. A break `end_at` must not be after the `Shift.end_at`

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var body = new CreateShiftRequest(); // CreateShiftRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateShift
                CreateShiftResponse result = apiInstance.CreateShift(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.CreateShift: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateShiftRequest**](CreateShiftRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateShiftResponse**](CreateShiftResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebreaktype"></a>
# **DeleteBreakType**
> DeleteBreakTypeResponse DeleteBreakType (string id)

DeleteBreakType

Deletes an existing `BreakType`.   A `BreakType` can be deleted even if it is referenced from a `Shift`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteBreakTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `BreakType` being deleted.

            try
            {
                // DeleteBreakType
                DeleteBreakTypeResponse result = apiInstance.DeleteBreakType(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.DeleteBreakType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;BreakType&#x60; being deleted. | 

### Return type

[**DeleteBreakTypeResponse**](DeleteBreakTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshift"></a>
# **DeleteShift**
> DeleteShiftResponse DeleteShift (string id)

DeleteShift

Deletes a `Shift`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `Shift` being deleted.

            try
            {
                // DeleteShift
                DeleteShiftResponse result = apiInstance.DeleteShift(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.DeleteShift: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;Shift&#x60; being deleted. | 

### Return type

[**DeleteShiftResponse**](DeleteShiftResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreaktype"></a>
# **GetBreakType**
> GetBreakTypeResponse GetBreakType (string id)

GetBreakType

Returns a single `BreakType` specified by id.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class GetBreakTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `BreakType` being retrieved.

            try
            {
                // GetBreakType
                GetBreakTypeResponse result = apiInstance.GetBreakType(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.GetBreakType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;BreakType&#x60; being retrieved. | 

### Return type

[**GetBreakTypeResponse**](GetBreakTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemployeewage"></a>
# **GetEmployeeWage**
> GetEmployeeWageResponse GetEmployeeWage (string id)

GetEmployeeWage

Returns a single `EmployeeWage` specified by id.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class GetEmployeeWageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `EmployeeWage` being retrieved.

            try
            {
                // GetEmployeeWage
                GetEmployeeWageResponse result = apiInstance.GetEmployeeWage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.GetEmployeeWage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;EmployeeWage&#x60; being retrieved. | 

### Return type

[**GetEmployeeWageResponse**](GetEmployeeWageResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshift"></a>
# **GetShift**
> GetShiftResponse GetShift (string id)

GetShift

Returns a single `Shift` specified by id.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class GetShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `Shift` being retrieved.

            try
            {
                // GetShift
                GetShiftResponse result = apiInstance.GetShift(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.GetShift: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;Shift&#x60; being retrieved. | 

### Return type

[**GetShiftResponse**](GetShiftResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbreaktypes"></a>
# **ListBreakTypes**
> ListBreakTypesResponse ListBreakTypes (string locationId = null, int? limit = null, string cursor = null)

ListBreakTypes

Returns a paginated list of `BreakType` instances for a business.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListBreakTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var locationId = locationId_example;  // string | Filter Break Types returned to only those that are associated with the specified location. (optional) 
            var limit = 56;  // int? | Maximum number of Break Types to return per page. Can range between 1 and 200. The default is the maximum at 200. (optional) 
            var cursor = cursor_example;  // string | Pointer to the next page of Break Type results to fetch. (optional) 

            try
            {
                // ListBreakTypes
                ListBreakTypesResponse result = apiInstance.ListBreakTypes(locationId, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.ListBreakTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| Filter Break Types returned to only those that are associated with the specified location. | [optional] 
 **limit** | **int?**| Maximum number of Break Types to return per page. Can range between 1 and 200. The default is the maximum at 200. | [optional] 
 **cursor** | **string**| Pointer to the next page of Break Type results to fetch. | [optional] 

### Return type

[**ListBreakTypesResponse**](ListBreakTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listemployeewages"></a>
# **ListEmployeeWages**
> ListEmployeeWagesResponse ListEmployeeWages (string employeeId = null, int? limit = null, string cursor = null)

ListEmployeeWages

Returns a paginated list of `EmployeeWage` instances for a business.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListEmployeeWagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var employeeId = employeeId_example;  // string | Filter wages returned to only those that are associated with the specified employee. (optional) 
            var limit = 56;  // int? | Maximum number of Employee Wages to return per page. Can range between 1 and 200. The default is the maximum at 200. (optional) 
            var cursor = cursor_example;  // string | Pointer to the next page of Employee Wage results to fetch. (optional) 

            try
            {
                // ListEmployeeWages
                ListEmployeeWagesResponse result = apiInstance.ListEmployeeWages(employeeId, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.ListEmployeeWages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **string**| Filter wages returned to only those that are associated with the specified employee. | [optional] 
 **limit** | **int?**| Maximum number of Employee Wages to return per page. Can range between 1 and 200. The default is the maximum at 200. | [optional] 
 **cursor** | **string**| Pointer to the next page of Employee Wage results to fetch. | [optional] 

### Return type

[**ListEmployeeWagesResponse**](ListEmployeeWagesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listworkweekconfigs"></a>
# **ListWorkweekConfigs**
> ListWorkweekConfigsResponse ListWorkweekConfigs (int? limit = null, string cursor = null)

ListWorkweekConfigs

Returns a list of `WorkweekConfig` instances for a business.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListWorkweekConfigsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var limit = 56;  // int? | Maximum number of Workweek Configs to return per page. (optional) 
            var cursor = cursor_example;  // string | Pointer to the next page of Workweek Config results to fetch. (optional) 

            try
            {
                // ListWorkweekConfigs
                ListWorkweekConfigsResponse result = apiInstance.ListWorkweekConfigs(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.ListWorkweekConfigs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Maximum number of Workweek Configs to return per page. | [optional] 
 **cursor** | **string**| Pointer to the next page of Workweek Config results to fetch. | [optional] 

### Return type

[**ListWorkweekConfigsResponse**](ListWorkweekConfigsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchshifts"></a>
# **SearchShifts**
> SearchShiftsResponse SearchShifts (SearchShiftsRequest body)

SearchShifts

Returns a paginated list of `Shift` records for a business.  The list to be returned can be filtered by: - Location IDs **and** - employee IDs **and** - shift status (`OPEN`, `CLOSED`) **and** - shift start **and** - shift end **and** - work day details  The list can be sorted by: - `start_at` - `end_at` - `created_at` - `updated_at`

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class SearchShiftsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var body = new SearchShiftsRequest(); // SearchShiftsRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // SearchShifts
                SearchShiftsResponse result = apiInstance.SearchShifts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.SearchShifts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SearchShiftsRequest**](SearchShiftsRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**SearchShiftsResponse**](SearchShiftsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebreaktype"></a>
# **UpdateBreakType**
> UpdateBreakTypeResponse UpdateBreakType (string id, UpdateBreakTypeRequest body)

UpdateBreakType

Updates an existing `BreakType`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateBreakTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `BreakType` being updated.
            var body = new UpdateBreakTypeRequest(); // UpdateBreakTypeRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateBreakType
                UpdateBreakTypeResponse result = apiInstance.UpdateBreakType(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.UpdateBreakType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;BreakType&#x60; being updated. | 
 **body** | [**UpdateBreakTypeRequest**](UpdateBreakTypeRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**UpdateBreakTypeResponse**](UpdateBreakTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshift"></a>
# **UpdateShift**
> UpdateShiftResponse UpdateShift (string id, UpdateShiftRequest body)

UpdateShift

Updates an existing `Shift`.   When adding a `Break` to a `Shift`, any earlier `Breaks` in the `Shift` have  the `end_at` property set to a valid RFC-3339 datetime string.   When closing a `Shift`, all `Break` instances in the shift must be complete with `end_at` set on each `Break`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | ID of the object being updated.
            var body = new UpdateShiftRequest(); // UpdateShiftRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateShift
                UpdateShiftResponse result = apiInstance.UpdateShift(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.UpdateShift: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the object being updated. | 
 **body** | [**UpdateShiftRequest**](UpdateShiftRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**UpdateShiftResponse**](UpdateShiftResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkweekconfig"></a>
# **UpdateWorkweekConfig**
> UpdateWorkweekConfigResponse UpdateWorkweekConfig (string id, UpdateWorkweekConfigRequest body)

UpdateWorkweekConfig

Updates a `WorkweekConfig`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateWorkweekConfigExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LaborApi();
            var id = id_example;  // string | UUID for the `WorkweekConfig` object being updated.
            var body = new UpdateWorkweekConfigRequest(); // UpdateWorkweekConfigRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateWorkweekConfig
                UpdateWorkweekConfigResponse result = apiInstance.UpdateWorkweekConfig(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LaborApi.UpdateWorkweekConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the &#x60;WorkweekConfig&#x60; object being updated. | 
 **body** | [**UpdateWorkweekConfigRequest**](UpdateWorkweekConfigRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**UpdateWorkweekConfigResponse**](UpdateWorkweekConfigResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

