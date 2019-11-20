# Square.Connect.Model.Employee

### Description

An employee object that is used by the external API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this object. | [optional] 
**FirstName** | **string** | The employee&#39;s first name. | [optional] 
**LastName** | **string** | The employee&#39;s last name. | [optional] 
**Email** | **string** | The employee&#39;s email address | [optional] 
**PhoneNumber** | **string** | The employee&#39;s phone number in E.164 format, i.e. \&quot;+12125554250\&quot; | [optional] 
**LocationIds** | **List<string>** | A list of location IDs where this employee has access to. | [optional] 
**Status** | **string** | Specifies the status of the employees being fetched. See [EmployeeStatus](#type-employeestatus) for possible values | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 
**UpdatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

