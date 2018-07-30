# Square.Connect.Api.TransactionsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CaptureTransaction**](TransactionsApi.md#capturetransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/capture | CaptureTransaction
[**Charge**](TransactionsApi.md#charge) | **POST** /v2/locations/{location_id}/transactions | Charge
[**CreateRefund**](TransactionsApi.md#createrefund) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/refund | CreateRefund
[**ListRefunds**](TransactionsApi.md#listrefunds) | **GET** /v2/locations/{location_id}/refunds | ListRefunds
[**ListTransactions**](TransactionsApi.md#listtransactions) | **GET** /v2/locations/{location_id}/transactions | ListTransactions
[**RetrieveTransaction**](TransactionsApi.md#retrievetransaction) | **GET** /v2/locations/{location_id}/transactions/{transaction_id} | RetrieveTransaction
[**VoidTransaction**](TransactionsApi.md#voidtransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/void | VoidTransaction


<a name="capturetransaction"></a>
# **CaptureTransaction**
> CaptureTransactionResponse CaptureTransaction (string locationId, string transactionId)

CaptureTransaction

Captures a transaction that was created with the [Charge](#endpoint-charge) endpoint with a `delay_capture` value of `true`.  See [Delayed capture transactions](/payments/transactions/overview#delayed-capture) for more information.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CaptureTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                // CaptureTransaction
                CaptureTransactionResponse result = apiInstance.CaptureTransaction(locationId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CaptureTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

[**CaptureTransactionResponse**](CaptureTransactionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="charge"></a>
# **Charge**
> ChargeResponse Charge (string locationId, ChargeRequest body)

Charge

Charges a card represented by a card nonce or a customer's card on file.  Your request to this endpoint must include _either_:  - A value for the `card_nonce` parameter (to charge a card nonce generated with the `SqPaymentForm`) - Values for the `customer_card_id` and `customer_id` parameters (to charge a customer's card on file)  In order for an eCommerce payment to potentially qualify for [Square chargeback protection](https://squareup.com/help/article/5394), you _must_ provide values for the following parameters in your request:  - `buyer_email_address` - At least one of `billing_address` or `shipping_address`  When this response is returned, the amount of Square's processing fee might not yet be calculated. To obtain the processing fee, wait about ten seconds and call [RetrieveTransaction](#endpoint-retrievetransaction). See the `processing_fee_money` field of each [Tender included](#type-tender) in the transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ChargeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to associate the created transaction with.
            var body = new ChargeRequest(); // ChargeRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Charge
                ChargeResponse result = apiInstance.Charge(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.Charge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to associate the created transaction with. | 
 **body** | [**ChargeRequest**](ChargeRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**ChargeResponse**](ChargeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrefund"></a>
# **CreateRefund**
> CreateRefundResponse CreateRefund (string locationId, string transactionId, CreateRefundRequest body)

CreateRefund

Initiates a refund for a previously charged tender.  You must issue a refund within 120 days of the associated payment. See [this article](https://squareup.com/help/us/en/article/5060) for more information on refund behavior.  *NOTE**: Card-present transactions with Interac credit cards **cannot be refunded using the Connect API**. Interac transactions must refunded in-person (e.g., dipping the card using POS app).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateRefundExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the original transaction's associated location.
            var transactionId = transactionId_example;  // string | The ID of the original transaction that includes the tender to refund.
            var body = new CreateRefundRequest(); // CreateRefundRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateRefund
                CreateRefundResponse result = apiInstance.CreateRefund(locationId, transactionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the original transaction&#39;s associated location. | 
 **transactionId** | **string**| The ID of the original transaction that includes the tender to refund. | 
 **body** | [**CreateRefundRequest**](CreateRefundRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateRefundResponse**](CreateRefundResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrefunds"></a>
# **ListRefunds**
> ListRefundsResponse ListRefunds (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

ListRefunds

Lists refunds for one of a business's locations.  In addition to full or partial tender refunds processed through Square APIs, refunds may result from itemized returns or exchanges through Square's Point of Sale applications.  Refunds with a `status` of `PENDING` are not currently included in this endpoint's response.  Max results per [page](#paginatingresults): 50

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListRefundsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list refunds for.
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. (optional) 

            try
            {
                // ListRefunds
                ListRefundsResponse result = apiInstance.ListRefunds(locationId, beginTime, endTime, sortOrder, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list refunds for. | 
 **beginTime** | **string**| The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 

### Return type

[**ListRefundsResponse**](ListRefundsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactions"></a>
# **ListTransactions**
> ListTransactionsResponse ListTransactions (string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)

ListTransactions

Lists transactions for a particular location.  Transactions include payment information from sales and exchanges and refund information from returns and exchanges.  Max results per [page](#paginatingresults): 50

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list transactions for.
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. (optional) 
            var sortOrder = sortOrder_example;  // string | The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` (optional) 
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. (optional) 

            try
            {
                // ListTransactions
                ListTransactionsResponse result = apiInstance.ListTransactions(locationId, beginTime, endTime, sortOrder, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list transactions for. | 
 **beginTime** | **string**| The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time. | [optional] 
 **sortOrder** | **string**| The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; | [optional] 
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 

### Return type

[**ListTransactionsResponse**](ListTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievetransaction"></a>
# **RetrieveTransaction**
> RetrieveTransactionResponse RetrieveTransaction (string locationId, string transactionId)

RetrieveTransaction

Retrieves details for a single transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the transaction's associated location.
            var transactionId = transactionId_example;  // string | The ID of the transaction to retrieve.

            try
            {
                // RetrieveTransaction
                RetrieveTransactionResponse result = apiInstance.RetrieveTransaction(locationId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.RetrieveTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the transaction&#39;s associated location. | 
 **transactionId** | **string**| The ID of the transaction to retrieve. | 

### Return type

[**RetrieveTransactionResponse**](RetrieveTransactionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidtransaction"></a>
# **VoidTransaction**
> VoidTransactionResponse VoidTransaction (string locationId, string transactionId)

VoidTransaction

Cancels a transaction that was created with the [Charge](#endpoint-charge) endpoint with a `delay_capture` value of `true`.  See [Delayed capture transactions](/payments/transactions/overview#delayed-capture) for more information.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class VoidTransactionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var locationId = locationId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                // VoidTransaction
                VoidTransactionResponse result = apiInstance.VoidTransaction(locationId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.VoidTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

[**VoidTransactionResponse**](VoidTransactionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

