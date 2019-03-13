# Square.Connect.Model.ListBreakTypesResponse

### Description

The response to a request for a set of `BreakTypes`. Contains the requested `BreakType` objects. May contain a set of `Error` objects if the request resulted in errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BreakTypes** | [**List&lt;BreakType&gt;**](BreakType.md) |  A page of &#x60;BreakType&#x60; results. | [optional] 
**Cursor** | **string** | Value supplied in the subsequent request to fetch the next next page of Break Type results. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

