# Square.Connect.Api.CustomersApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /v2/customers | CreateCustomer
[**CreateCustomerCard**](CustomersApi.md#createcustomercard) | **POST** /v2/customers/{customer_id}/cards | CreateCustomerCard
[**DeleteCustomer**](CustomersApi.md#deletecustomer) | **DELETE** /v2/customers/{customer_id} | DeleteCustomer
[**DeleteCustomerCard**](CustomersApi.md#deletecustomercard) | **DELETE** /v2/customers/{customer_id}/cards/{card_id} | DeleteCustomerCard
[**ListCustomers**](CustomersApi.md#listcustomers) | **GET** /v2/customers | ListCustomers
[**RetrieveCustomer**](CustomersApi.md#retrievecustomer) | **GET** /v2/customers/{customer_id} | RetrieveCustomer
[**SearchCustomers**](CustomersApi.md#searchcustomers) | **POST** /v2/customers/search | SearchCustomers
[**UpdateCustomer**](CustomersApi.md#updatecustomer) | **PUT** /v2/customers/{customer_id} | UpdateCustomer


<a name="createcustomer"></a>
# **CreateCustomer**
> CreateCustomerResponse CreateCustomer (CreateCustomerRequest body)

CreateCustomer

Creates a new customer for a business, which can have associated cards on file.  You must provide __at least one__ of the following values in your request to this endpoint:  - `given_name` - `family_name` - `company_name` - `email_address` - `phone_number`  This endpoint does not accept an idempotency key. If you accidentally create a duplicate customer, you can delete it with the [DeleteCustomer](#endpoint-deletecustomer) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateCustomerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var body = new CreateCustomerRequest(); // CreateCustomerRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateCustomer
                CreateCustomerResponse result = apiInstance.CreateCustomer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCustomerRequest**](CreateCustomerRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateCustomerResponse**](CreateCustomerResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomercard"></a>
# **CreateCustomerCard**
> CreateCustomerCardResponse CreateCustomerCard (string customerId, CreateCustomerCardRequest body)

CreateCustomerCard

Adds a card on file to an existing customer. In the United States Square takes care of automatically updating any cards on file that might have expired since you first attached them to a customer.  As with charges, calls to `CreateCustomerCard` are idempotent. Multiple calls with the same card nonce return the same card record that was created with the provided nonce during the _first_ call.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateCustomerCardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | The ID of the customer to link the card on file to.
            var body = new CreateCustomerCardRequest(); // CreateCustomerCardRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateCustomerCard
                CreateCustomerCardResponse result = apiInstance.CreateCustomerCard(customerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The ID of the customer to link the card on file to. | 
 **body** | [**CreateCustomerCardRequest**](CreateCustomerCardRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateCustomerCardResponse**](CreateCustomerCardResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomer"></a>
# **DeleteCustomer**
> DeleteCustomerResponse DeleteCustomer (string customerId)

DeleteCustomer

Deletes a customer from a business, along with any linked cards on file.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | The ID of the customer to delete.

            try
            {
                // DeleteCustomer
                DeleteCustomerResponse result = apiInstance.DeleteCustomer(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The ID of the customer to delete. | 

### Return type

[**DeleteCustomerResponse**](DeleteCustomerResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomercard"></a>
# **DeleteCustomerCard**
> DeleteCustomerCardResponse DeleteCustomerCard (string customerId, string cardId)

DeleteCustomerCard

Removes a card on file from a customer.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteCustomerCardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | The ID of the customer that the card on file belongs to.
            var cardId = cardId_example;  // string | The ID of the card on file to delete.

            try
            {
                // DeleteCustomerCard
                DeleteCustomerCardResponse result = apiInstance.DeleteCustomerCard(customerId, cardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomerCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The ID of the customer that the card on file belongs to. | 
 **cardId** | **string**| The ID of the card on file to delete. | 

### Return type

[**DeleteCustomerCardResponse**](DeleteCustomerCardResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomers"></a>
# **ListCustomers**
> ListCustomersResponse ListCustomers (string cursor = null, string sortField = null, string sortOrder = null)

ListCustomers

Lists a business's customers.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListCustomersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var cursor = cursor_example;  // string | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. (optional) 
            var sortField = sortField_example;  // string | Indicates how Customers should be sorted. Default: `DEFAULT`. See [CustomerSortField](#type-customersortfield) for possible values. (optional) 
            var sortOrder = sortOrder_example;  // string | Indicates whether Customers should be sorted in ascending (`ASC`) or descending (`DESC`) order. Default: `ASC`. See [SortOrder](#type-sortorder) for possible values. (optional) 

            try
            {
                // ListCustomers
                ListCustomersResponse result = apiInstance.ListCustomers(cursor, sortField, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cursor** | **string**| A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Paginating results](#paginatingresults) for more information. | [optional] 
 **sortField** | **string**| Indicates how Customers should be sorted. Default: &#x60;DEFAULT&#x60;. See [CustomerSortField](#type-customersortfield) for possible values. | [optional] 
 **sortOrder** | **string**| Indicates whether Customers should be sorted in ascending (&#x60;ASC&#x60;) or descending (&#x60;DESC&#x60;) order. Default: &#x60;ASC&#x60;. See [SortOrder](#type-sortorder) for possible values. | [optional] 

### Return type

[**ListCustomersResponse**](ListCustomersResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievecustomer"></a>
# **RetrieveCustomer**
> RetrieveCustomerResponse RetrieveCustomer (string customerId)

RetrieveCustomer

Returns details for a single customer.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveCustomerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | The ID of the customer to retrieve.

            try
            {
                // RetrieveCustomer
                RetrieveCustomerResponse result = apiInstance.RetrieveCustomer(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.RetrieveCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The ID of the customer to retrieve. | 

### Return type

[**RetrieveCustomerResponse**](RetrieveCustomerResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcustomers"></a>
# **SearchCustomers**
> SearchCustomersResponse SearchCustomers (SearchCustomersRequest body)

SearchCustomers

Searches the customer profiles associated with a Square account. Calling SearchCustomers without an explicit query parameter returns all customer profiles ordered alphabetically based on `given_name` and `family_name`.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class SearchCustomersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var body = new SearchCustomersRequest(); // SearchCustomersRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // SearchCustomers
                SearchCustomersResponse result = apiInstance.SearchCustomers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.SearchCustomers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SearchCustomersRequest**](SearchCustomersRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**SearchCustomersResponse**](SearchCustomersResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomer"></a>
# **UpdateCustomer**
> UpdateCustomerResponse UpdateCustomer (string customerId, UpdateCustomerRequest body)

UpdateCustomer

Updates the details of an existing customer. The ID of the customer may change if the customer has been merged into another customer.  You cannot edit a customer's cards on file with this endpoint. To make changes to a card on file, you must delete the existing card on file with the [DeleteCustomerCard](#endpoint-deletecustomercard) endpoint, then create a new one with the [CreateCustomerCard](#endpoint-createcustomercard) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateCustomerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | The ID of the customer to update.
            var body = new UpdateCustomerRequest(); // UpdateCustomerRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateCustomer
                UpdateCustomerResponse result = apiInstance.UpdateCustomer(customerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The ID of the customer to update. | 
 **body** | [**UpdateCustomerRequest**](UpdateCustomerRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**UpdateCustomerResponse**](UpdateCustomerResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

