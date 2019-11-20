# Square.Connect.Model.Error

### Description

Represents an error encountered during a request to the Connect API.  See [Handling errors](#handlingerrors) for more information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | The high-level category for the error. See &#x60;ErrorCategory&#x60; for possible values. See [ErrorCategory](#type-errorcategory) for possible values | 
**Code** | **string** | The specific code of the error. See &#x60;ErrorCode&#x60; for possible values See [ErrorCode](#type-errorcode) for possible values | 
**Detail** | **string** | A human-readable description of the error for debugging purposes. | [optional] 
**Field** | **string** | The name of the field provided in the original request (if any) that the error pertains to. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

