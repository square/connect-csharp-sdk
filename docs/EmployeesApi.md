# Square.Connect.Api.EmployeesApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListEmployees**](EmployeesApi.md#listemployees) | **GET** /v2/employees | ListEmployees
[**RetrieveEmployee**](EmployeesApi.md#retrieveemployee) | **GET** /v2/employees/{id} | RetrieveEmployee


<a name="listemployees"></a>
# **ListEmployees**
> ListEmployeesResponse ListEmployees (string locationId = null, string status = null, int? limit = null, string cursor = null)

ListEmployees



### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListEmployeesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var locationId = locationId_example;  // string | Filter employees returned to only those that are associated with the specified location. (optional) 
            var status = status_example;  // string | Specifies the EmployeeStatus to filter the employee by. (optional) 
            var limit = 56;  // int? | The number of employees to be returned on each page. (optional) 
            var cursor = cursor_example;  // string | The token required to retrieve the specified page of results. (optional) 

            try
            {
                // ListEmployees
                ListEmployeesResponse result = apiInstance.ListEmployees(locationId, status, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.ListEmployees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| Filter employees returned to only those that are associated with the specified location. | [optional] 
 **status** | **string**| Specifies the EmployeeStatus to filter the employee by. | [optional] 
 **limit** | **int?**| The number of employees to be returned on each page. | [optional] 
 **cursor** | **string**| The token required to retrieve the specified page of results. | [optional] 

### Return type

[**ListEmployeesResponse**](ListEmployeesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveemployee"></a>
# **RetrieveEmployee**
> RetrieveEmployeeResponse RetrieveEmployee (string id)

RetrieveEmployee



### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var id = id_example;  // string | UUID for the employee that was requested.

            try
            {
                // RetrieveEmployee
                RetrieveEmployeeResponse result = apiInstance.RetrieveEmployee(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.RetrieveEmployee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| UUID for the employee that was requested. | 

### Return type

[**RetrieveEmployeeResponse**](RetrieveEmployeeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

