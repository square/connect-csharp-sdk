# Square.Connect.Api.ReportingApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAdditionalRecipientReceivableRefunds**](ReportingApi.md#listadditionalrecipientreceivablerefunds) | **GET** /v2/locations/{location_id}/additional-recipient-receivable-refunds | ListAdditionalRecipientReceivableRefunds
[**ListAdditionalRecipientReceivables**](ReportingApi.md#listadditionalrecipientreceivables) | **GET** /v2/locations/{location_id}/additional-recipient-receivables | ListAdditionalRecipientReceivables


<a name="listadditionalrecipientreceivablerefunds"></a>
# **ListAdditionalRecipientReceivableRefunds**
> ListAdditionalRecipientReceivableRefundsResponse ListAdditionalRecipientReceivableRefunds (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

ListAdditionalRecipientReceivableRefunds

Returns a list of refunded transactions (across all possible originating locations) relating to monies credited to the provided location ID by another Square account using the `additional_recipients` field in a transaction.  Max results per [page](#paginatingresults): 50

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListAdditionalRecipientReceivableRefundsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingApi();
            var locationId = locationId_example;  // string | The ID of the location to list AdditionalRecipientReceivableRefunds for.
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. (optional) 

            try
            {
                // ListAdditionalRecipientReceivableRefunds
                ListAdditionalRecipientReceivableRefundsResponse result = apiInstance.ListAdditionalRecipientReceivableRefunds(locationId, beginTime, endTime, sortOrder, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.ListAdditionalRecipientReceivableRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list AdditionalRecipientReceivableRefunds for. | 
 **beginTime** | **string**| The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 

### Return type

[**ListAdditionalRecipientReceivableRefundsResponse**](ListAdditionalRecipientReceivableRefundsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listadditionalrecipientreceivables"></a>
# **ListAdditionalRecipientReceivables**
> ListAdditionalRecipientReceivablesResponse ListAdditionalRecipientReceivables (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

ListAdditionalRecipientReceivables

Returns a list of receivables (across all possible sending locations) representing monies credited to the provided location ID by another Square account using the `additional_recipients` field in a transaction.  Max results per [page](#paginatingresults): 50

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListAdditionalRecipientReceivablesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingApi();
            var locationId = locationId_example;  // string | The ID of the location to list AdditionalRecipientReceivables for.
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. (optional) 

            try
            {
                // ListAdditionalRecipientReceivables
                ListAdditionalRecipientReceivablesResponse result = apiInstance.ListAdditionalRecipientReceivables(locationId, beginTime, endTime, sortOrder, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.ListAdditionalRecipientReceivables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list AdditionalRecipientReceivables for. | 
 **beginTime** | **string**| The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 

### Return type

[**ListAdditionalRecipientReceivablesResponse**](ListAdditionalRecipientReceivablesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

