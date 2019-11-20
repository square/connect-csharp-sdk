# Square.Connect.Api.RefundsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentRefund**](RefundsApi.md#getpaymentrefund) | **GET** /v2/refunds/{refund_id} | GetPaymentRefund
[**ListPaymentRefunds**](RefundsApi.md#listpaymentrefunds) | **GET** /v2/refunds | ListPaymentRefunds
[**RefundPayment**](RefundsApi.md#refundpayment) | **POST** /v2/refunds | RefundPayment


<a name="getpaymentrefund"></a>
# **GetPaymentRefund**
> GetPaymentRefundResponse GetPaymentRefund (string refundId)

GetPaymentRefund

Retrieves a specific `Refund` using the `refund_id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class GetPaymentRefundExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi();
            var refundId = refundId_example;  // string | Unique ID for the desired `PaymentRefund`.

            try
            {
                // GetPaymentRefund
                GetPaymentRefundResponse result = apiInstance.GetPaymentRefund(refundId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.GetPaymentRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refundId** | **string**| Unique ID for the desired &#x60;PaymentRefund&#x60;. | 

### Return type

[**GetPaymentRefundResponse**](GetPaymentRefundResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpaymentrefunds"></a>
# **ListPaymentRefunds**
> ListPaymentRefundsResponse ListPaymentRefunds (string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null, string locationId = null, string status = null, string sourceType = null)

ListPaymentRefunds

Retrieves a list of refunds for the account making the request.  Max results per page: 100

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListPaymentRefundsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi();
            var beginTime = beginTime_example;  // string | Timestamp for the beginning of the requested reporting period, in RFC 3339 format.  Default: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | Timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed. - `ASC` - oldest to newest - `DESC` - newest to oldest (default). (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. (optional) 
            var locationId = locationId_example;  // string | ID of location associated with payment. (optional) 
            var status = status_example;  // string | If provided, only refunds with the given status are returned. For a list of refund status values, see `PaymentRefund`.  Default: If omitted refunds are returned regardless of status. (optional) 
            var sourceType = sourceType_example;  // string | If provided, only refunds with the given source type are returned. - `CARD` - List refunds only for payments where card was specified as payment source.  Default: If omitted refunds are returned regardless of source type. (optional) 

            try
            {
                // ListPaymentRefunds
                ListPaymentRefundsResponse result = apiInstance.ListPaymentRefunds(beginTime, endTime, sortOrder, cursor, locationId, status, sourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.ListPaymentRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beginTime** | **string**| Timestamp for the beginning of the requested reporting period, in RFC 3339 format.  Default: The current time minus one year. | [optional] 
 **endTime** | **string**| Timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed. - &#x60;ASC&#x60; - oldest to newest - &#x60;DESC&#x60; - newest to oldest (default). | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. | [optional] 
 **locationId** | **string**| ID of location associated with payment. | [optional] 
 **status** | **string**| If provided, only refunds with the given status are returned. For a list of refund status values, see &#x60;PaymentRefund&#x60;.  Default: If omitted refunds are returned regardless of status. | [optional] 
 **sourceType** | **string**| If provided, only refunds with the given source type are returned. - &#x60;CARD&#x60; - List refunds only for payments where card was specified as payment source.  Default: If omitted refunds are returned regardless of source type. | [optional] 

### Return type

[**ListPaymentRefundsResponse**](ListPaymentRefundsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundpayment"></a>
# **RefundPayment**
> RefundPaymentResponse RefundPayment (RefundPaymentRequest body)

RefundPayment

Refunds a payment. You can refund the entire payment amount or a  portion of it. For more information, see  [Payments and Refunds Overview](/payments-api/overview).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RefundPaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi();
            var body = new RefundPaymentRequest(); // RefundPaymentRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // RefundPayment
                RefundPaymentResponse result = apiInstance.RefundPayment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.RefundPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefundPaymentRequest**](RefundPaymentRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**RefundPaymentResponse**](RefundPaymentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

