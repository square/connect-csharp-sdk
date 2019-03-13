# Square.Connect.Model.ListWorkweekConfigsResponse

### Description

The response to a request for a set of `WorkweekConfig` objects. Contains the requested `WorkweekConfig` objects. May contain a set of `Error` objects if the request resulted in errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkweekConfigs** | [**List&lt;WorkweekConfig&gt;**](WorkweekConfig.md) | A page of Employee Wage results. | [optional] 
**Cursor** | **string** | Value supplied in the subsequent request to fetch the next page of Employee Wage results. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

