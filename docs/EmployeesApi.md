# Square.Connect.Api.EmployeesApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CreateEmployee**](EmployeesApi.md#v1createemployee) | **POST** /v1/me/employees | Creates an employee for a business.
[**V1CreateEmployeeRole**](EmployeesApi.md#v1createemployeerole) | **POST** /v1/me/roles | Creates an employee role you can then assign to employees.
[**V1CreateTimecard**](EmployeesApi.md#v1createtimecard) | **POST** /v1/me/timecards | Creates a timecard for an employee. Each timecard corresponds to a single shift.
[**V1DeleteTimecard**](EmployeesApi.md#v1deletetimecard) | **DELETE** /v1/me/timecards/{timecard_id} | Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.
[**V1ListCashDrawerShifts**](EmployeesApi.md#v1listcashdrawershifts) | **GET** /v1/{location_id}/cash-drawer-shifts | Provides the details for all of a location&#39;s cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.
[**V1ListEmployeeRoles**](EmployeesApi.md#v1listemployeeroles) | **GET** /v1/me/roles | Provides summary information for all of a business&#39;s employee roles.
[**V1ListEmployees**](EmployeesApi.md#v1listemployees) | **GET** /v1/me/employees | Provides summary information for all of a business&#39;s employees.
[**V1ListTimecardEvents**](EmployeesApi.md#v1listtimecardevents) | **GET** /v1/me/timecards/{timecard_id}/events | Provides summary information for all events associated with a particular timecard.
[**V1ListTimecards**](EmployeesApi.md#v1listtimecards) | **GET** /v1/me/timecards | Provides summary information for all of a business&#39;s employee timecards.
[**V1RetrieveCashDrawerShift**](EmployeesApi.md#v1retrievecashdrawershift) | **GET** /v1/{location_id}/cash-drawer-shifts/{shift_id} | Provides the details for a single cash drawer shift, including all events that occurred during the shift.
[**V1RetrieveEmployee**](EmployeesApi.md#v1retrieveemployee) | **GET** /v1/me/employees/{employee_id} | Provides the details for a single employee.
[**V1RetrieveEmployeeRole**](EmployeesApi.md#v1retrieveemployeerole) | **GET** /v1/me/roles/{role_id} | Provides the details for a single employee role.
[**V1RetrieveTimecard**](EmployeesApi.md#v1retrievetimecard) | **GET** /v1/me/timecards/{timecard_id} | Provides the details for a single timecard.
[**V1UpdateEmployee**](EmployeesApi.md#v1updateemployee) | **PUT** /v1/me/employees/{employee_id} | v1UpdateEmployee
[**V1UpdateEmployeeRole**](EmployeesApi.md#v1updateemployeerole) | **PUT** /v1/me/roles/{role_id} | Modifies the details of an employee role.
[**V1UpdateTimecard**](EmployeesApi.md#v1updatetimecard) | **PUT** /v1/me/timecards/{timecard_id} | Modifies a timecard&#39;s details. This creates an API_EDIT event for the timecard. You can view a timecard&#39;s event history with the List Timecard Events endpoint.


<a name="v1createemployee"></a>
# **V1CreateEmployee**
> V1Employee V1CreateEmployee (V1Employee body)

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
    public class V1CreateEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var body = new V1Employee(); // V1Employee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an employee for a business.
                V1Employee result = apiInstance.V1CreateEmployee(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1CreateEmployee: " + e.Message );
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

<a name="v1createemployeerole"></a>
# **V1CreateEmployeeRole**
> V1EmployeeRole V1CreateEmployeeRole (V1EmployeeRole employeeRole)

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
    public class V1CreateEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var employeeRole = new V1EmployeeRole(); // V1EmployeeRole | An EmployeeRole object with a name and permissions, and an optional owner flag.

            try
            {
                // Creates an employee role you can then assign to employees.
                V1EmployeeRole result = apiInstance.V1CreateEmployeeRole(employeeRole);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1CreateEmployeeRole: " + e.Message );
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

<a name="v1createtimecard"></a>
# **V1CreateTimecard**
> V1Timecard V1CreateTimecard (V1Timecard body)

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
    public class V1CreateTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var body = new V1Timecard(); // V1Timecard | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates a timecard for an employee. Each timecard corresponds to a single shift.
                V1Timecard result = apiInstance.V1CreateTimecard(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1CreateTimecard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1Timecard**](V1Timecard.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Timecard**](V1Timecard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1deletetimecard"></a>
# **V1DeleteTimecard**
> Object V1DeleteTimecard (string timecardId)

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
    public class V1DeleteTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var timecardId = timecardId_example;  // string | The ID of the timecard to delete.

            try
            {
                // Deletes a timecard. Deleted timecards are still accessible from Connect API endpoints, but the value of their deleted field is set to true. See Handling deleted timecards for more information.
                Object result = apiInstance.V1DeleteTimecard(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1DeleteTimecard: " + e.Message );
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

<a name="v1listcashdrawershifts"></a>
# **V1ListCashDrawerShifts**
> List<V1CashDrawerShift> V1ListCashDrawerShifts (string locationId, string order = null, string beginTime = null, string endTime = null)

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
    public class V1ListCashDrawerShiftsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var locationId = locationId_example;  // string | The ID of the location to list cash drawer shifts for.
            var order = order_example;  // string | The order in which cash drawer shifts are listed in the response, based on their created_at field. Default value: ASC (optional) 
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time minus 90 days. (optional) 
            var endTime = endTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. Default value: The current time. (optional) 

            try
            {
                // Provides the details for all of a location's cash drawer shifts during a date range. The date range you specify cannot exceed 90 days.
                List&lt;V1CashDrawerShift&gt; result = apiInstance.V1ListCashDrawerShifts(locationId, order, beginTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1ListCashDrawerShifts: " + e.Message );
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

<a name="v1listemployeeroles"></a>
# **V1ListEmployeeRoles**
> List<V1EmployeeRole> V1ListEmployeeRoles (string order = null, int? limit = null, string cursor = null)

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
    public class V1ListEmployeeRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var order = order_example;  // string | The order in which employees are listed in the response, based on their created_at field.Default value: ASC  (optional) 
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional) 
            var cursor = cursor_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all of a business's employee roles.
                List&lt;V1EmployeeRole&gt; result = apiInstance.V1ListEmployeeRoles(order, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1ListEmployeeRoles: " + e.Message );
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
 **cursor** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1EmployeeRole>**](V1EmployeeRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1listemployees"></a>
# **V1ListEmployees**
> List<V1Employee> V1ListEmployees (string order = null, string beginUpdatedAt = null, string endUpdatedAt = null, string beginCreatedAt = null, string endCreatedAt = null, string status = null, string externalId = null, int? limit = null)

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
    public class V1ListEmployeesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var order = order_example;  // string | The order in which employees are listed in the response, based on their created_at field.      Default value: ASC  (optional) 
            var beginUpdatedAt = beginUpdatedAt_example;  // string | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format (optional) 
            var endUpdatedAt = endUpdatedAt_example;  // string | If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var beginCreatedAt = beginCreatedAt_example;  // string | If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format. (optional) 
            var endCreatedAt = endCreatedAt_example;  // string | If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format. (optional) 
            var status = status_example;  // string | If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE). (optional) 
            var externalId = externalId_example;  // string | If provided, the endpoint returns only employee entities with the specified external_id. (optional) 
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional) 

            try
            {
                // Provides summary information for all of a business's employees.
                List&lt;V1Employee&gt; result = apiInstance.V1ListEmployees(order, beginUpdatedAt, endUpdatedAt, beginCreatedAt, endCreatedAt, status, externalId, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1ListEmployees: " + e.Message );
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

### Return type

[**List<V1Employee>**](V1Employee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1listtimecardevents"></a>
# **V1ListTimecardEvents**
> List<V1TimecardEvent> V1ListTimecardEvents (string timecardId)

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
    public class V1ListTimecardEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var timecardId = timecardId_example;  // string | The ID of the timecard to list events for.

            try
            {
                // Provides summary information for all events associated with a particular timecard.
                List&lt;V1TimecardEvent&gt; result = apiInstance.V1ListTimecardEvents(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1ListTimecardEvents: " + e.Message );
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

<a name="v1listtimecards"></a>
# **V1ListTimecards**
> List<V1Timecard> V1ListTimecards (string order = null, string employeeId = null, string beginClockinTime = null, string endClockinTime = null, string beginClockoutTime = null, string endClockoutTime = null, string beginUpdatedAt = null, string endUpdatedAt = null, bool? deleted = null, int? limit = null, string cursor = null)

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
    public class V1ListTimecardsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
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
                List&lt;V1Timecard&gt; result = apiInstance.V1ListTimecards(order, employeeId, beginClockinTime, endClockinTime, beginClockoutTime, endClockoutTime, beginUpdatedAt, endUpdatedAt, deleted, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1ListTimecards: " + e.Message );
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

<a name="v1retrievecashdrawershift"></a>
# **V1RetrieveCashDrawerShift**
> V1CashDrawerShift V1RetrieveCashDrawerShift (string locationId, string shiftId)

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
    public class V1RetrieveCashDrawerShiftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var locationId = locationId_example;  // string | The ID of the location to list cash drawer shifts for.
            var shiftId = shiftId_example;  // string | The shift's ID.

            try
            {
                // Provides the details for a single cash drawer shift, including all events that occurred during the shift.
                V1CashDrawerShift result = apiInstance.V1RetrieveCashDrawerShift(locationId, shiftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1RetrieveCashDrawerShift: " + e.Message );
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

<a name="v1retrieveemployee"></a>
# **V1RetrieveEmployee**
> V1Employee V1RetrieveEmployee (string employeeId)

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
    public class V1RetrieveEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var employeeId = employeeId_example;  // string | The employee's ID.

            try
            {
                // Provides the details for a single employee.
                V1Employee result = apiInstance.V1RetrieveEmployee(employeeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1RetrieveEmployee: " + e.Message );
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

<a name="v1retrieveemployeerole"></a>
# **V1RetrieveEmployeeRole**
> V1EmployeeRole V1RetrieveEmployeeRole (string roleId)

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
    public class V1RetrieveEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var roleId = roleId_example;  // string | The role's ID.

            try
            {
                // Provides the details for a single employee role.
                V1EmployeeRole result = apiInstance.V1RetrieveEmployeeRole(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1RetrieveEmployeeRole: " + e.Message );
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

<a name="v1retrievetimecard"></a>
# **V1RetrieveTimecard**
> V1Timecard V1RetrieveTimecard (string timecardId)

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
    public class V1RetrieveTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var timecardId = timecardId_example;  // string | The timecard's ID.

            try
            {
                // Provides the details for a single timecard.
                V1Timecard result = apiInstance.V1RetrieveTimecard(timecardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1RetrieveTimecard: " + e.Message );
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

<a name="v1updateemployee"></a>
# **V1UpdateEmployee**
> V1Employee V1UpdateEmployee (string employeeId, V1Employee body)

v1UpdateEmployee

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class V1UpdateEmployeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var employeeId = employeeId_example;  // string | The ID of the role to modify.
            var body = new V1Employee(); // V1Employee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // v1UpdateEmployee
                V1Employee result = apiInstance.V1UpdateEmployee(employeeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1UpdateEmployee: " + e.Message );
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

<a name="v1updateemployeerole"></a>
# **V1UpdateEmployeeRole**
> V1EmployeeRole V1UpdateEmployeeRole (string roleId, V1EmployeeRole body)

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
    public class V1UpdateEmployeeRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var roleId = roleId_example;  // string | The ID of the role to modify.
            var body = new V1EmployeeRole(); // V1EmployeeRole | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an employee role.
                V1EmployeeRole result = apiInstance.V1UpdateEmployeeRole(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1UpdateEmployeeRole: " + e.Message );
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

<a name="v1updatetimecard"></a>
# **V1UpdateTimecard**
> V1Timecard V1UpdateTimecard (string timecardId, V1Timecard body)

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
    public class V1UpdateTimecardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeesApi();
            var timecardId = timecardId_example;  // string | TThe ID of the timecard to modify.
            var body = new V1Timecard(); // V1Timecard | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies a timecard's details. This creates an API_EDIT event for the timecard. You can view a timecard's event history with the List Timecard Events endpoint.
                V1Timecard result = apiInstance.V1UpdateTimecard(timecardId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1UpdateTimecard: " + e.Message );
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

