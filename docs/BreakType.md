# Square.Connect.Model.BreakType

### Description

A defined break template that sets an expectation for possible `Break`  instances on a `Shift`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this object. | [optional] 
**LocationId** | **string** | The ID of the business location this type of break applies to. | 
**BreakName** | **string** | A human-readable name for this type of break. Will be displayed to employees in Square products. | 
**ExpectedDuration** | **string** | Format: RFC-3339 P[n]Y[n]M[n]DT[n]H[n]M[n]S. The expected length of this break. Precision below minutes is truncated. | 
**IsPaid** | **bool?** | Whether this break counts towards time worked for compensation purposes. | 
**Version** | **int?** | Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If a value is not provided, Square&#39;s servers execute a \&quot;blind\&quot; write; potentially  overwriting another writer&#39;s data. | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 
**UpdatedAt** | **string** | A read-only timestamp in RFC 3339 format. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

