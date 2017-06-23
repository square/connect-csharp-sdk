# Square.Connect.Api.V1EmployeesApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmployee**](V1EmployeesApi.md#createemployee) | **POST** /v1/me/employees | Creates an employee for a business.
[**CreateEmployeeRole**](V1EmployeesApi.md#createemployeerole) | **POST** /v1/me/roles | Creates an employee role you can then assign to employees.
[**CreateTimecard**](V1EmployeesApi.md#createtimecard) | **POST** /v1/me/timecards | Creates a timecard for an employee. Each timecard corresponds to a single shift.
[**DeleteTimecard**](V1EmployeesApi.md#deletetimecard) | **DELETE** /v1/me/timecards/{timecard_id} | Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.
[**ListCashDrawerShifts**](V1EmployeesApi.md#listcashdrawershifts) | **GET** /v1/{location_id}/cash-drawer-shifts | Provides the details for all of a location&#39;s cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.
[**ListEmployeeRoles**](V1EmployeesApi.md#listemployeeroles) | **GET** /v1/me/roles | Provides summary information for all of a business&#39;s employee roles.
[**ListEmployees**](V1EmployeesApi.md#listemployees) | **GET** /v1/me/employees | Provides summary information for all of a business&#39;s employees.
[**ListTimecardEvents**](V1EmployeesApi.md#listtimecardevents) | **GET** /v1/me/timecards/{timecard_id}/events | Provides summary information for all events associated with a particular timecard.
[**ListTimecards**](V1EmployeesApi.md#listtimecards) | **GET** /v1/me/timecards | Provides summary information for all of a business&#39;s employee timecards.
[**RetrieveCashDrawerShift**](V1EmployeesApi.md#retrievecashdrawershift) | **GET** /v1/{location_id}/cash-drawer-shifts/{shift_id} | Provides the details for a single cash drawer shift, including all events that occurred during the shift.
[**RetrieveEmployee**](V1EmployeesApi.md#retrieveemployee) | **GET** /v1/me/employees/{employee_id} | Provides the details for a single employee.
[**RetrieveEmployeeRole**](V1EmployeesApi.md#retrieveemployeerole) | **GET** /v1/me/roles/{role_id} | Provides the details for a single employee role.
[**RetrieveTimecard**](V1EmployeesApi.md#retrievetimecard) | **GET** /v1/me/timecards/{timecard_id} | Provides the details for a single timecard.
[**UpdateEmployee**](V1EmployeesApi.md#updateemployee) | **PUT** /v1/me/employees/{employee_id} | V1 UpdateEmployee
[**UpdateEmployeeRole**](V1EmployeesApi.md#updateemployeerole) | **PUT** /v1/me/roles/{role_id} | Modifies the details of an employee role.
[**UpdateTimecard**](V1EmployeesApi.md#updatetimecard) | **PUT** /v1/me/timecards/{timecard_id} | Modifies a timecard&#39;s details. This creates an API_EDIT event for the timecard. You can view a timecard&#39;s event history with the List Timecard Events endpoint.


<a name="createemployee"></a>
# **CreateEmployee**
> V1Employee CreateEmployee (V1Employee body)

Creates an employee for a business.

Creates an employee for a business.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var body = new V1Employee(); // V1Employee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an employee for a business.
                V1Employee result = apiInstance.CreateEmployee(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.CreateEmployee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1Employee**](V1Employee.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Employee**](V1Employee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemployeerole"></a>
# **CreateEmployeeRole**
> V1EmployeeRole CreateEmployeeRole (V1EmployeeRole employeeRole)

Creates an employee role you can then assign to employees.

Creates an employee role you can then assign to employees.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var employeeRole = new V1EmployeeRole(); // V1EmployeeRole | An EmployeeRole object with a name and permissions, and an optional owner flag.

            try
            {
                // Creates an employee role you can then assign to employees.
                V1EmployeeRole result = apiInstance.CreateEmployeeRole(employeeRole);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.CreateEmployeeRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeRole** | [**V1EmployeeRole**](V1EmployeeRole.md)| An EmployeeRole object with a name and permissions, and an optional owner flag. | 

### Return type

[**V1EmployeeRole**](V1EmployeeRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtimecard"></a>
# **CreateTimecard**
> V1Timecard CreateTimecard (V1Timecard body, string batchToken = null)

Creates a timecard for an employee. Each timecard corresponds to a single shift.

Creates a timecard for an employee. Each timecard corresponds to a single shift.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var body = new V1Timecard(); // V1Timecard | An object containing the fields to POST for the request.  See the corresponding object definition for field details.
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Creates a timecard for an employee. Each timecard corresponds to a single shift.
                V1Timecard result = apiInstance.CreateTimecard(body, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.CreateTimecard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1Timecard**](V1Timecard.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**V1Timecard**](V1Timecard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetimecard"></a>
# **DeleteTimecard**
> Object DeleteTimecard (string timecardId)

Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.

Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var timecardId = timecardId_example;  // string | The ID of the timecard to delete.

            try
            {
                // Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.
                Object result = apiInstance.DeleteTimecard(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.DeleteTimecard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timecardId** | **string**| The ID of the timecard to delete. | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcashdrawershifts"></a>
# **ListCashDrawerShifts**
> List<V1CashDrawerShift> ListCashDrawerShifts (string locationId, string order = null, string beginTime = null, string endTime = null)

Provides the details for all of a location's cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.

Provides the details for all of a location's cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListCashDrawerShiftsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var locationId = locationId_example;  // string | The ID of the location to list cash drawer shifts for.
            var order = order_example;  // string | The order in which cash drawer shifts are listed in the response, based on their created_at field. Default value: ASC (optional) 
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time minus 90 days. (optional) 
            var endTime = endTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time. (optional) 

            try
            {
                // Provides the details for all of a location's cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.
                List&lt;V1CashDrawerShift&gt; result = apiInstance.ListCashDrawerShifts(locationId, order, beginTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListCashDrawerShifts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list cash drawer shifts for. | 
 **order** | **string**| The order in which cash drawer shifts are listed in the response, based on their created_at field. Default value: ASC | [optional] 
 **beginTime** | **string**| The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time minus 90 days. | [optional] 
 **endTime** | **string**| The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time. | [optional] 

### Return type

[**List<V1CashDrawerShift>**](V1CashDrawerShift.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listemployeeroles"></a>
# **ListEmployeeRoles**
> List<V1EmployeeRole> ListEmployeeRoles (string order = null, int? limit = null, string batchToken = null)

Provides summary information for all of a business's employee roles.

Provides summary information for all of a business's employee roles.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListEmployeeRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var order = order_example;  // string | The order in which employees are listed in the response, based on their created_at field.Default value: ASC  (optional) 
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all of a business's employee roles.
                List&lt;V1EmployeeRole&gt; result = apiInstance.ListEmployeeRoles(order, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListEmployeeRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | **string**| The order in which employees are listed in the response, based on their created_at field.Default value: ASC  | [optional] 
 **limit** | **int?**| The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1EmployeeRole>**](V1EmployeeRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listemployees"></a>
# **ListEmployees**
> List<V1Employee> ListEmployees (string order = null, string beginUpdatedAt = null, string endUpdatedAt = null, string beginCreatedAt = null, string endCreatedAt = null, string status = null, string externalId = null, int? limit = null, string batchToken = null)

Provides summary information for all of a business's employees.

Provides summary information for all of a business's employees.

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

            var apiInstance = new V1EmployeesApi();
            var order = order_example;  // string | The order in which employees are listed in the response, based on their created_at field.      Default value: ASC  (optional) 
            var beginUpdatedAt = beginUpdatedAt_example;  // string | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format (optional) 
            var endUpdatedAt = endUpdatedAt_example;  // string | If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var beginCreatedAt = beginCreatedAt_example;  // string | If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format. (optional) 
            var endCreatedAt = endCreatedAt_example;  // string | If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var status = status_example;  // string | If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE). (optional) 
            var externalId = externalId_example;  // string | If provided, the endpoint returns only employee entities with the specified external_id. (optional) 
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all of a business's employees.
                List&lt;V1Employee&gt; result = apiInstance.ListEmployees(order, beginUpdatedAt, endUpdatedAt, beginCreatedAt, endCreatedAt, status, externalId, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListEmployees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | **string**| The order in which employees are listed in the response, based on their created_at field.      Default value: ASC  | [optional] 
 **beginUpdatedAt** | **string**| If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format | [optional] 
 **endUpdatedAt** | **string**| If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
 **beginCreatedAt** | **string**| If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
 **endCreatedAt** | **string**| If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
 **status** | **string**| If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE). | [optional] 
 **externalId** | **string**| If provided, the endpoint returns only employee entities with the specified external_id. | [optional] 
 **limit** | **int?**| The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Employee>**](V1Employee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimecardevents"></a>
# **ListTimecardEvents**
> List<V1TimecardEvent> ListTimecardEvents (string timecardId)

Provides summary information for all events associated with a particular timecard.

Provides summary information for all events associated with a particular timecard.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListTimecardEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var timecardId = timecardId_example;  // string | The ID of the timecard to list events for.

            try
            {
                // Provides summary information for all events associated with a particular timecard.
                List&lt;V1TimecardEvent&gt; result = apiInstance.ListTimecardEvents(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListTimecardEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timecardId** | **string**| The ID of the timecard to list events for. | 

### Return type

[**List<V1TimecardEvent>**](V1TimecardEvent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimecards"></a>
# **ListTimecards**
> List<V1Timecard> ListTimecards (string order = null, string employeeId = null, string beginClockinTime = null, string endClockinTime = null, string beginClockoutTime = null, string endClockoutTime = null, string beginUpdatedAt = null, string endUpdatedAt = null, bool? deleted = null, int? limit = null, string cursor = null)

Provides summary information for all of a business's employee timecards.

Provides summary information for all of a business's employee timecards.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListTimecardsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var order = order_example;  // string | The order in which timecards are listed in the response, based on their created_at field. (optional) 
            var employeeId = employeeId_example;  // string | If provided, the endpoint returns only timecards for the employee with the specified ID. (optional) 
            var beginClockinTime = beginClockinTime_example;  // string | If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format. (optional) 
            var endClockinTime = endClockinTime_example;  // string | If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var beginClockoutTime = beginClockoutTime_example;  // string | If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format. (optional) 
            var endClockoutTime = endClockoutTime_example;  // string | If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var beginUpdatedAt = beginUpdatedAt_example;  // string | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format. (optional) 
            var endUpdatedAt = endUpdatedAt_example;  // string | If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var deleted = true;  // bool? | If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don't provide this parameter, both valid and deleted timecards are returned. (optional) 
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional) 
            var cursor = cursor_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all of a business's employee timecards.
                List&lt;V1Timecard&gt; result = apiInstance.ListTimecards(order, employeeId, beginClockinTime, endClockinTime, beginClockoutTime, endClockoutTime, beginUpdatedAt, endUpdatedAt, deleted, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListTimecards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | **string**| The order in which timecards are listed in the response, based on their created_at field. | [optional] 
 **employeeId** | **string**| If provided, the endpoint returns only timecards for the employee with the specified ID. | [optional] 
 **beginClockinTime** | **string**| If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
 **endClockinTime** | **string**| If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
 **beginClockoutTime** | **string**| If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
 **endClockoutTime** | **string**| If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
 **beginUpdatedAt** | **string**| If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format. | [optional] 
 **endUpdatedAt** | **string**| If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format. | [optional] 
 **deleted** | **bool?**| If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don&#39;t provide this parameter, both valid and deleted timecards are returned. | [optional] 
 **limit** | **int?**| The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. | [optional] 
 **cursor** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Timecard>**](V1Timecard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievecashdrawershift"></a>
# **RetrieveCashDrawerShift**
> V1CashDrawerShift RetrieveCashDrawerShift (string locationId, string shiftId)

Provides the details for a single cash drawer shift, including all events that occurred during the shift.

Provides the details for a single cash drawer shift, including all events that occurred during the shift.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveCashDrawerShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var locationId = locationId_example;  // string | The ID of the location to list cash drawer shifts for.
            var shiftId = shiftId_example;  // string | The shift's ID.

            try
            {
                // Provides the details for a single cash drawer shift, including all events that occurred during the shift.
                V1CashDrawerShift result = apiInstance.RetrieveCashDrawerShift(locationId, shiftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.RetrieveCashDrawerShift: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list cash drawer shifts for. | 
 **shiftId** | **string**| The shift&#39;s ID. | 

### Return type

[**V1CashDrawerShift**](V1CashDrawerShift.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveemployee"></a>
# **RetrieveEmployee**
> V1Employee RetrieveEmployee (string employeeId)

Provides the details for a single employee.

Provides the details for a single employee.

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

            var apiInstance = new V1EmployeesApi();
            var employeeId = employeeId_example;  // string | The employee's ID.

            try
            {
                // Provides the details for a single employee.
                V1Employee result = apiInstance.RetrieveEmployee(employeeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.RetrieveEmployee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **string**| The employee&#39;s ID. | 

### Return type

[**V1Employee**](V1Employee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveemployeerole"></a>
# **RetrieveEmployeeRole**
> V1EmployeeRole RetrieveEmployeeRole (string roleId)

Provides the details for a single employee role.

Provides the details for a single employee role.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var roleId = roleId_example;  // string | The role's ID.

            try
            {
                // Provides the details for a single employee role.
                V1EmployeeRole result = apiInstance.RetrieveEmployeeRole(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.RetrieveEmployeeRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleId** | **string**| The role&#39;s ID. | 

### Return type

[**V1EmployeeRole**](V1EmployeeRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievetimecard"></a>
# **RetrieveTimecard**
> V1Timecard RetrieveTimecard (string timecardId)

Provides the details for a single timecard.

Provides the details for a single timecard.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var timecardId = timecardId_example;  // string | The timecard's ID.

            try
            {
                // Provides the details for a single timecard.
                V1Timecard result = apiInstance.RetrieveTimecard(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.RetrieveTimecard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timecardId** | **string**| The timecard&#39;s ID. | 

### Return type

[**V1Timecard**](V1Timecard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemployee"></a>
# **UpdateEmployee**
> V1Employee UpdateEmployee (string employeeId, V1Employee body)

V1 UpdateEmployee

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var employeeId = employeeId_example;  // string | The ID of the role to modify.
            var body = new V1Employee(); // V1Employee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // V1 UpdateEmployee
                V1Employee result = apiInstance.UpdateEmployee(employeeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.UpdateEmployee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **string**| The ID of the role to modify. | 
 **body** | [**V1Employee**](V1Employee.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Employee**](V1Employee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemployeerole"></a>
# **UpdateEmployeeRole**
> V1EmployeeRole UpdateEmployeeRole (string roleId, V1EmployeeRole body)

Modifies the details of an employee role.

Modifies the details of an employee role.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var roleId = roleId_example;  // string | The ID of the role to modify.
            var body = new V1EmployeeRole(); // V1EmployeeRole | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an employee role.
                V1EmployeeRole result = apiInstance.UpdateEmployeeRole(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.UpdateEmployeeRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleId** | **string**| The ID of the role to modify. | 
 **body** | [**V1EmployeeRole**](V1EmployeeRole.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1EmployeeRole**](V1EmployeeRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetimecard"></a>
# **UpdateTimecard**
> V1Timecard UpdateTimecard (string timecardId, V1Timecard body)

Modifies a timecard's details. This creates an API_EDIT event for the timecard. You can view a timecard's event history with the List Timecard Events endpoint.

Modifies a timecard's details. This creates an API_EDIT event for the timecard. You can view a timecard's event history with the List Timecard Events endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var timecardId = timecardId_example;  // string | TThe ID of the timecard to modify.
            var body = new V1Timecard(); // V1Timecard | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies a timecard's details. This creates an API_EDIT event for the timecard. You can view a timecard's event history with the List Timecard Events endpoint.
                V1Timecard result = apiInstance.UpdateTimecard(timecardId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.UpdateTimecard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timecardId** | **string**| TThe ID of the timecard to modify. | 
 **body** | [**V1Timecard**](V1Timecard.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Timecard**](V1Timecard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

