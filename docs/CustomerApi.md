# Square.Connect.Api.CustomerApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**CreateCustomer**](CustomerApi.md#createcustomer) | **POST** /v2/customers
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /v2/customers/{customer_id}
[**ListCustomers**](CustomerApi.md#listcustomers) | **GET** /v2/customers
[**RetrieveCustomer**](CustomerApi.md#retrievecustomer) | **GET** /v2/customers/{customer_id}
[**UpdateCustomer**](CustomerApi.md#updatecustomer) | **PUT** /v2/customers/{customer_id}


# **CreateCustomer**
> CreateCustomerResponse CreateCustomer (string authorization, CreateCustomerRequest body)

### Description

Creates a new customer for a business, which can have associated cards on file.  You must provide __at least one__ of the following values in your request to this endpoint:  - `given_name` - `family_name` - `company_name` - `email_address` - `phone_number`  This endpoint does not accept an idempotency key. If you accidentally create a duplicate customer, you can delete it with the [DeleteCustomer](#endpoint-deletecustomer) endpoint.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **body** | [**CreateCustomerRequest**](CreateCustomerRequest.md)| 

### Return type

[**CreateCustomerResponse**](CreateCustomerResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteCustomer**
> DeleteCustomerResponse DeleteCustomer (string authorization, string customerId)

### Description

Deletes a customer from a business, along with any linked cards on file.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **customerId** | **string**| 

### Return type

[**DeleteCustomerResponse**](DeleteCustomerResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListCustomers**
> ListCustomersResponse ListCustomers (string authorization, string cursor = null)

### Description

Lists a business's customers.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **cursor** | **string**| [optional] 

### Return type

[**ListCustomersResponse**](ListCustomersResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **RetrieveCustomer**
> RetrieveCustomerResponse RetrieveCustomer (string authorization, string customerId)

### Description

Returns details for a single customer.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **customerId** | **string**| 

### Return type

[**RetrieveCustomerResponse**](RetrieveCustomerResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateCustomer**
> UpdateCustomerResponse UpdateCustomer (string authorization, string customerId, UpdateCustomerRequest body)

### Description

Updates the details of an existing customer.  You cannot edit a customer's cards on file with this endpoint. To make changes to a card on file, you must delete the existing card on file with the [DeleteCustomerCard](#endpoint-deletecustomercard) endpoint, then create a new one with the [CreateCustomerCard](#endpoint-createcustomercard) endpoint.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 
 **customerId** | **string**| 
 **body** | [**UpdateCustomerRequest**](UpdateCustomerRequest.md)| 

### Return type

[**UpdateCustomerResponse**](UpdateCustomerResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

