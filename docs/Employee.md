# Square.Connect.Model.Employee

### Description

An employee created in the **Square Dashboard** account of a business.  Used by the Labor API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this &#x60;Employee&#x60;. | [optional] 
**FirstName** | **string** | Given (first) name of the employee. | [optional] 
**LastName** | **string** | Family (last) name of the employee | [optional] 
**Email** | **string** | Email of the employee | [optional] 
**PhoneNumber** | **string** | Phone number of the employee in E.164 format, i.e. \&quot;+12125554250\&quot; | [optional] 
**LocationIds** | **List<string>** | A list of location IDs where this employee has access. | [optional] 
**Status** | **string** | Specifies the status of the employee being fetched. See [EmployeeStatus](#type-employeestatus) for possible values | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 
**UpdatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

