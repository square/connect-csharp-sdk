# Square.Connect.Api.V1TransactionsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRefund**](V1TransactionsApi.md#createrefund) | **POST** /v1/{location_id}/refunds | Issues a refund for a previously processed payment. You must issue a refund within 60 days of the associated payment.
[**ListBankAccounts**](V1TransactionsApi.md#listbankaccounts) | **GET** /v1/{location_id}/bank-accounts | Provides non-confidential details for all of a location&#39;s associated bank accounts. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.
[**ListOrders**](V1TransactionsApi.md#listorders) | **GET** /v1/{location_id}/orders | Provides summary information for a merchant&#39;s online store orders.
[**ListPayments**](V1TransactionsApi.md#listpayments) | **GET** /v1/{location_id}/payments | Provides summary information for all payments taken by a merchant or any of the merchant&#39;s mobile staff during a date range. Date ranges cannot exceed one year in length. See Date ranges for details of inclusive and exclusive dates.
[**ListRefunds**](V1TransactionsApi.md#listrefunds) | **GET** /v1/{location_id}/refunds | Provides the details for all refunds initiated by a merchant or any of the merchant&#39;s mobile staff during a date range. Date ranges cannot exceed one year in length.
[**ListSettlements**](V1TransactionsApi.md#listsettlements) | **GET** /v1/{location_id}/settlements | Provides summary information for all deposits and withdrawals initiated by Square to a merchant&#39;s bank account during a date range. Date ranges cannot exceed one year in length.
[**RetrieveBankAccount**](V1TransactionsApi.md#retrievebankaccount) | **GET** /v1/{location_id}/bank-accounts/{bank_account_id} | Provides non-confidential details for a merchant&#39;s associated bank account. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.
[**RetrieveOrder**](V1TransactionsApi.md#retrieveorder) | **GET** /v1/{location_id}/orders/{order_id} | Provides comprehensive information for a single online store order, including the order&#39;s history.
[**RetrievePayment**](V1TransactionsApi.md#retrievepayment) | **GET** /v1/{location_id}/payments/{payment_id} | Provides comprehensive information for a single payment.
[**RetrieveSettlement**](V1TransactionsApi.md#retrievesettlement) | **GET** /v1/{location_id}/settlements/{settlement_id} | Provides comprehensive information for a single settlement, including the entries that contribute to the settlement&#39;s total.
[**UpdateOrder**](V1TransactionsApi.md#updateorder) | **PUT** /v1/{location_id}/orders/{order_id} | Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:


<a name="createrefund"></a>
# **CreateRefund**
> V1Refund CreateRefund (string locationId, V1CreateRefundRequest body)

Issues a refund for a previously processed payment. You must issue a refund within 60 days of the associated payment.

Issues a refund for a previously processed payment. You must issue a refund within 60 days of the associated payment.

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

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the original payment's associated location.
            var body = new V1CreateRefundRequest(); // V1CreateRefundRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Issues a refund for a previously processed payment. You must issue a refund within 60 days of the associated payment.
                V1Refund result = apiInstance.CreateRefund(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.CreateRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the original payment&#39;s associated location. | 
 **body** | [**V1CreateRefundRequest**](V1CreateRefundRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Refund**](V1Refund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbankaccounts"></a>
# **ListBankAccounts**
> List<V1BankAccount> ListBankAccounts (string locationId)

Provides non-confidential details for all of a location's associated bank accounts. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.

Provides non-confidential details for all of a location's associated bank accounts. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListBankAccountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list bank accounts for.

            try
            {
                // Provides non-confidential details for all of a location's associated bank accounts. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.
                List&lt;V1BankAccount&gt; result = apiInstance.ListBankAccounts(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.ListBankAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list bank accounts for. | 

### Return type

[**List<V1BankAccount>**](V1BankAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorders"></a>
# **ListOrders**
> List<V1Order> ListOrders (string locationId, string order = null, int? limit = null, string batchToken = null)

Provides summary information for a merchant's online store orders.

Provides summary information for a merchant's online store orders.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list online store orders for.
            var order = order_example;  // string | TThe order in which payments are listed in the response. (optional) 
            var limit = 56;  // int? | The maximum number of payments to return in a single response. This value cannot exceed 200. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for a merchant's online store orders.
                List&lt;V1Order&gt; result = apiInstance.ListOrders(locationId, order, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.ListOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list online store orders for. | 
 **order** | **string**| TThe order in which payments are listed in the response. | [optional] 
 **limit** | **int?**| The maximum number of payments to return in a single response. This value cannot exceed 200. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Order>**](V1Order.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpayments"></a>
# **ListPayments**
> List<V1Payment> ListPayments (string locationId, string order = null, string beginTime = null, string endTime = null, int? limit = null, string batchToken = null)

Provides summary information for all payments taken by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length. See Date ranges for details of inclusive and exclusive dates.

Provides summary information for all payments taken by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length. See Date ranges for details of inclusive and exclusive dates.

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

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list payments for. If you specify me, this endpoint returns payments aggregated from all of the business's locations.
            var order = order_example;  // string | The order in which payments are listed in the response. (optional) 
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. (optional) 
            var limit = 56;  // int? | The maximum number of payments to return in a single response. This value cannot exceed 200. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all payments taken by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length. See Date ranges for details of inclusive and exclusive dates.
                List&lt;V1Payment&gt; result = apiInstance.ListPayments(locationId, order, beginTime, endTime, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.ListPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list payments for. If you specify me, this endpoint returns payments aggregated from all of the business&#39;s locations. | 
 **order** | **string**| The order in which payments are listed in the response. | [optional] 
 **beginTime** | **string**| The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. | [optional] 
 **limit** | **int?**| The maximum number of payments to return in a single response. This value cannot exceed 200. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Payment>**](V1Payment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrefunds"></a>
# **ListRefunds**
> List<V1Refund> ListRefunds (string locationId, string order = null, string beginTime = null, string endTime = null, int? limit = null, string batchToken = null)

Provides the details for all refunds initiated by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length.

Provides the details for all refunds initiated by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length.

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

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list refunds for.
            var order = order_example;  // string | TThe order in which payments are listed in the response. (optional) 
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. (optional) 
            var limit = 56;  // int? | The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides the details for all refunds initiated by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length.
                List&lt;V1Refund&gt; result = apiInstance.ListRefunds(locationId, order, beginTime, endTime, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.ListRefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list refunds for. | 
 **order** | **string**| TThe order in which payments are listed in the response. | [optional] 
 **beginTime** | **string**| The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. | [optional] 
 **limit** | **int?**| The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Refund>**](V1Refund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsettlements"></a>
# **ListSettlements**
> List<V1Settlement> ListSettlements (string locationId, string order = null, string beginTime = null, string endTime = null, int? limit = null, string status = null, string batchToken = null)

Provides summary information for all deposits and withdrawals initiated by Square to a merchant's bank account during a date range. Date ranges cannot exceed one year in length.

Provides summary information for all deposits and withdrawals initiated by Square to a merchant's bank account during a date range. Date ranges cannot exceed one year in length. 

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListSettlementsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the location to list settlements for. If you specify me, this endpoint returns payments aggregated from all of the business's locations.
            var order = order_example;  // string | TThe order in which payments are listed in the response. (optional) 
            var beginTime = beginTime_example;  // string | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. (optional) 
            var endTime = endTime_example;  // string | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. (optional) 
            var limit = 56;  // int? | The maximum number of payments to return in a single response. This value cannot exceed 200. (optional) 
            var status = status_example;  // string | Provide this parameter to retrieve only settlements with a particular status (SENT or FAILED). (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // Provides summary information for all deposits and withdrawals initiated by Square to a merchant's bank account during a date range. Date ranges cannot exceed one year in length.
                List&lt;V1Settlement&gt; result = apiInstance.ListSettlements(locationId, order, beginTime, endTime, limit, status, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.ListSettlements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list settlements for. If you specify me, this endpoint returns payments aggregated from all of the business&#39;s locations. | 
 **order** | **string**| TThe order in which payments are listed in the response. | [optional] 
 **beginTime** | **string**| The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. | [optional] 
 **endTime** | **string**| The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. | [optional] 
 **limit** | **int?**| The maximum number of payments to return in a single response. This value cannot exceed 200. | [optional] 
 **status** | **string**| Provide this parameter to retrieve only settlements with a particular status (SENT or FAILED). | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Settlement>**](V1Settlement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievebankaccount"></a>
# **RetrieveBankAccount**
> V1BankAccount RetrieveBankAccount (string locationId, string bankAccountId)

Provides non-confidential details for a merchant's associated bank account. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.

Provides non-confidential details for a merchant's associated bank account. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveBankAccountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the bank account's associated location.
            var bankAccountId = bankAccountId_example;  // string | The bank account's Square-issued ID. You obtain this value from Settlement objects returned.

            try
            {
                // Provides non-confidential details for a merchant's associated bank account. This endpoint does not provide full bank account numbers, and there is no way to obtain a full bank account number with the Connect API.
                V1BankAccount result = apiInstance.RetrieveBankAccount(locationId, bankAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.RetrieveBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the bank account&#39;s associated location. | 
 **bankAccountId** | **string**| The bank account&#39;s Square-issued ID. You obtain this value from Settlement objects returned. | 

### Return type

[**V1BankAccount**](V1BankAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveorder"></a>
# **RetrieveOrder**
> V1Order RetrieveOrder (string locationId, string orderId)

Provides comprehensive information for a single online store order, including the order's history.

Provides comprehensive information for a single online store order, including the order's history.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveOrderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the order's associated location.
            var orderId = orderId_example;  // string | The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint

            try
            {
                // Provides comprehensive information for a single online store order, including the order's history.
                V1Order result = apiInstance.RetrieveOrder(locationId, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.RetrieveOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the order&#39;s associated location. | 
 **orderId** | **string**| The order&#39;s Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint | 

### Return type

[**V1Order**](V1Order.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievepayment"></a>
# **RetrievePayment**
> V1Payment RetrievePayment (string locationId, string paymentId)

Provides comprehensive information for a single payment.

Provides comprehensive information for a single payment.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrievePaymentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the payment's associated location.
            var paymentId = paymentId_example;  // string | The Square-issued payment ID. payment_id comes from Payment objects returned by the List Payments endpoint, Settlement objects returned by the List Settlements endpoint, or Refund objects returned by the List Refunds endpoint.

            try
            {
                // Provides comprehensive information for a single payment.
                V1Payment result = apiInstance.RetrievePayment(locationId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.RetrievePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the payment&#39;s associated location. | 
 **paymentId** | **string**| The Square-issued payment ID. payment_id comes from Payment objects returned by the List Payments endpoint, Settlement objects returned by the List Settlements endpoint, or Refund objects returned by the List Refunds endpoint. | 

### Return type

[**V1Payment**](V1Payment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievesettlement"></a>
# **RetrieveSettlement**
> V1Settlement RetrieveSettlement (string locationId, string settlementId)

Provides comprehensive information for a single settlement, including the entries that contribute to the settlement's total.

Provides comprehensive information for a single settlement, including the entries that contribute to the settlement's total.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveSettlementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the settlements's associated location.
            var settlementId = settlementId_example;  // string | The settlement's Square-issued ID. You obtain this value from Settlement objects returned by the List Settlements endpoint.

            try
            {
                // Provides comprehensive information for a single settlement, including the entries that contribute to the settlement's total.
                V1Settlement result = apiInstance.RetrieveSettlement(locationId, settlementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.RetrieveSettlement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the settlements&#39;s associated location. | 
 **settlementId** | **string**| The settlement&#39;s Square-issued ID. You obtain this value from Settlement objects returned by the List Settlements endpoint. | 

### Return type

[**V1Settlement**](V1Settlement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorder"></a>
# **UpdateOrder**
> V1Order UpdateOrder (string locationId, string orderId, V1UpdateOrderRequest body)

Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:

Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1TransactionsApi();
            var locationId = locationId_example;  // string | The ID of the order's associated location.
            var orderId = orderId_example;  // string | The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint
            var body = new V1UpdateOrderRequest(); // V1UpdateOrderRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:
                V1Order result = apiInstance.UpdateOrder(locationId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1TransactionsApi.UpdateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the order&#39;s associated location. | 
 **orderId** | **string**| The order&#39;s Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint | 
 **body** | [**V1UpdateOrderRequest**](V1UpdateOrderRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Order**](V1Order.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

