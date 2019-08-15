# Square.Connect.Model.SearchOrdersFilter

### Description

Filtering criteria to use for a SearchOrders request. Multiple filters will be ANDed together.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StateFilter** | [**SearchOrdersStateFilter**](SearchOrdersStateFilter.md) | Filter by [&#x60;OrderState&#x60;](#type-orderstate). | [optional] 
**DateTimeFilter** | [**SearchOrdersDateTimeFilter**](SearchOrdersDateTimeFilter.md) | Filter for results within a time range.  __Important:__ If you filter for orders by time range, you must set SearchOrdersSort to sort by the same field. [Learn more about filtering orders by time range](/orders-api/manage-orders#important-note-on-filtering-orders-by-time-range) | [optional] 
**FulfillmentFilter** | [**SearchOrdersFulfillmentFilter**](SearchOrdersFulfillmentFilter.md) | Filter by fulfillment type or state. | [optional] 
**SourceFilter** | [**SearchOrdersSourceFilter**](SearchOrdersSourceFilter.md) | Filter by source of order. | [optional] 
**CustomerFilter** | [**SearchOrdersCustomerFilter**](SearchOrdersCustomerFilter.md) | Filter by customers associated with the order. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

