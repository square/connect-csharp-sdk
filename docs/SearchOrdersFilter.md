# Square.Connect.Model.SearchOrdersFilter

### Description

Filter options to use for a query. Multiple filters will be ANDed together.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StateFilter** | [**SearchOrdersStateFilter**](SearchOrdersStateFilter.md) | Filter by [&#x60;OrderState&#x60;](#type-orderstate). | [optional] 
**DateTimeFilter** | [**SearchOrdersDateTimeFilter**](SearchOrdersDateTimeFilter.md) | Filter for results within a time range. | [optional] 
**FulfillmentFilter** | [**SearchOrdersFulfillmentFilter**](SearchOrdersFulfillmentFilter.md) | Filter by fulfillment type or state. | [optional] 
**SourceFilter** | [**SearchOrdersSourceFilter**](SearchOrdersSourceFilter.md) | Filter by source of order. | [optional] 
**CustomerFilter** | [**SearchOrdersCustomerFilter**](SearchOrdersCustomerFilter.md) | Filter by customers associated with the order. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

