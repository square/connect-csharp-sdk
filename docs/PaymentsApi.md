# Square.Connect.Api.PaymentsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPayment**](PaymentsApi.md#cancelpayment) | **POST** /v2/payments/{payment_id}/cancel | CancelPayment
[**CancelPaymentByIdempotencyKey**](PaymentsApi.md#cancelpaymentbyidempotencykey) | **POST** /v2/payments/cancel | CancelPaymentByIdempotencyKey
[**CompletePayment**](PaymentsApi.md#completepayment) | **POST** /v2/payments/{payment_id}/complete | CompletePayment
[**CreatePayment**](PaymentsApi.md#createpayment) | **POST** /v2/payments | CreatePayment
[**GetPayment**](PaymentsApi.md#getpayment) | **GET** /v2/payments/{payment_id} | GetPayment
[**ListPayments**](PaymentsApi.md#listpayments) | **GET** /v2/payments | ListPayments


<a name="cancelpayment"></a>
# **CancelPayment**
> CancelPaymentResponse CancelPayment (string paymentId)

CancelPayment

Cancels a payment. If you set `autocomplete` to false when creating a payment,  you can cancel the payment using this endpoint. For more information, see [Delayed Payments](/payments-api/take-payments#delayed-payments).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CancelPaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var paymentId = paymentId_example;  // string | `payment_id` identifying the payment to be canceled.

            try
            {
                // CancelPayment
                CancelPaymentResponse result = apiInstance.CancelPayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CancelPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| &#x60;payment_id&#x60; identifying the payment to be canceled. | 

### Return type

[**CancelPaymentResponse**](CancelPaymentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelpaymentbyidempotencykey"></a>
# **CancelPaymentByIdempotencyKey**
> CancelPaymentByIdempotencyKeyResponse CancelPaymentByIdempotencyKey (CancelPaymentByIdempotencyKeyRequest body)

CancelPaymentByIdempotencyKey

Cancels a payment identified by the idenpotency key that is specified the request.  Use this method when status of a CreatePayment request is unknown. For example, after you send a CreatePayment request a network error occurs and you don't get a response. In this case, you can direct Square to cancel the payment using this endpoint. In the request, you provide the same idempotency key that you provided in your CreatePayment request you want  to cancel. After cancelling the payment, you can submit your CreatePayment request again. Note that if no payment with the specified idempotency key is found, no action is taken, the end  point returns successfully.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CancelPaymentByIdempotencyKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var body = new CancelPaymentByIdempotencyKeyRequest(); // CancelPaymentByIdempotencyKeyRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CancelPaymentByIdempotencyKey
                CancelPaymentByIdempotencyKeyResponse result = apiInstance.CancelPaymentByIdempotencyKey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CancelPaymentByIdempotencyKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CancelPaymentByIdempotencyKeyRequest**](CancelPaymentByIdempotencyKeyRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CancelPaymentByIdempotencyKeyResponse**](CancelPaymentByIdempotencyKeyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completepayment"></a>
# **CompletePayment**
> CompletePaymentResponse CompletePayment (string paymentId)

CompletePayment

Completes a payment.  By default, payments are set to complete immediately after they are created.  If you set autocomplete to false when creating a payment,  you can complete the payment using this endpoint. For more information, see [Delayed Payments](/payments-api/take-payments#delayed-payments).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CompletePaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var paymentId = paymentId_example;  // string | Unique ID identifying the payment to be completed.

            try
            {
                // CompletePayment
                CompletePaymentResponse result = apiInstance.CompletePayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CompletePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Unique ID identifying the payment to be completed. | 

### Return type

[**CompletePaymentResponse**](CompletePaymentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpayment"></a>
# **CreatePayment**
> CreatePaymentResponse CreatePayment (CreatePaymentRequest body)

CreatePayment

Charges a payment source, for example, a card  represented by customer's card on file or a card nonce. In addition  to the payment source, the request must also include the  amount to accept for the payment.  There are several optional parameters that you can include in the request.  For example, tip money, whether to autocomplete the payment, or a reference ID to correlate this payment with another system.  For more information about these  payment options, see [Take Payments](/payments-api/take-payments).  The `PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS` OAuth permission is required to enable application fees.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var body = new CreatePaymentRequest(); // CreatePaymentRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreatePayment
                CreatePaymentResponse result = apiInstance.CreatePayment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreatePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreatePaymentRequest**](CreatePaymentRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreatePaymentResponse**](CreatePaymentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayment"></a>
# **GetPayment**
> GetPaymentResponse GetPayment (string paymentId)

GetPayment

Retrieves details for a specific Payment.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var paymentId = paymentId_example;  // string | Unique ID for the desired `Payment`.

            try
            {
                // GetPayment
                GetPaymentResponse result = apiInstance.GetPayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Unique ID for the desired &#x60;Payment&#x60;. | 

### Return type

[**GetPaymentResponse**](GetPaymentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpayments"></a>
# **ListPayments**
> ListPaymentsResponse ListPayments (string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null, string locationId = null, long? total = null, string last4 = null, string cardBrand = null)

ListPayments

Retrieves a list of payments taken by the account making the request.  Max results per page: 100

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListPaymentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var beginTime = beginTime_example;  // string | Timestamp for the beginning of the reporting period, in RFC 3339 format. Inclusive. Default: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | Timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed. - `ASC` - oldest to newest - `DESC` - newest to oldest (default). (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information. (optional) 
            var locationId = locationId_example;  // string | ID of location associated with payment (optional) 
            var total = 789;  // long? | The exact amount in the total_money for a `Payment`. (optional) 
            var last4 = last4_example;  // string | The last 4 digits of `Payment` card. (optional) 
            var cardBrand = cardBrand_example;  // string | The brand of `Payment` card. For example, `VISA` (optional) 

            try
            {
                // ListPayments
                ListPaymentsResponse result = apiInstance.ListPayments(beginTime, endTime, sortOrder, cursor, locationId, total, last4, cardBrand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.ListPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beginTime** | **string**| Timestamp for the beginning of the reporting period, in RFC 3339 format. Inclusive. Default: The current time minus one year. | [optional] 
 **endTime** | **string**| Timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed. - &#x60;ASC&#x60; - oldest to newest - &#x60;DESC&#x60; - newest to oldest (default). | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 
 **locationId** | **string**| ID of location associated with payment | [optional] 
 **total** | **long?**| The exact amount in the total_money for a &#x60;Payment&#x60;. | [optional] 
 **last4** | **string**| The last 4 digits of &#x60;Payment&#x60; card. | [optional] 
 **cardBrand** | **string**| The brand of &#x60;Payment&#x60; card. For example, &#x60;VISA&#x60; | [optional] 

### Return type

[**ListPaymentsResponse**](ListPaymentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

