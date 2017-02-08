# Square.Connect.Api.LocationApi

All endpoints are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Method | HTTP request 
------------- | ------------- 
[**ListLocations**](LocationApi.md#listlocations) | **GET** /v2/locations


# **ListLocations**
> ListLocationsResponse ListLocations (string authorization)

### Description

Provides the details for all of a business's locations.  Most other Connect API endpoints have a required `location_id` path parameter. The `id` field of the [`Location`](#type-location) objects returned by this endpoint correspond to that `location_id` parameter.

### Parameters

Name | Type | Notes
------------- | ------------- | -------------
 **authorization** | **string**| 

### Return type

[**ListLocationsResponse**](ListLocationsResponse.md)

### Authorization

Assign your **Access Token** from developer portal to the authorization parameter.

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

