# Square.Connect.Model.SearchOrdersFulfillmentFilter

### Description

Filter based on [Order Fulfillment](#type-orderfulfillment) information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FulfillmentTypes** | **List<FulfillmentTypesEnum>** | List of [fulfillment types](#type-orderfulfillmenttype) to filter for. Will return orders if any of its fulfillments match any of the fulfillment types listed in this field. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values | 
**FulfillmentStates** | **List<FulfillmentStatesEnum>** | List of [fulfillment states](#type-orderfulfillmentstate) to filter for. Will return orders if any of its fulfillments match any of the fulfillment states listed in this field. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values | [optional] 


## List<FulfillmentTypesEnum>

Name | Value
------------ | -------------
**PICKUP** | "PICKUP"


## List<FulfillmentStatesEnum>

Name | Value
------------ | -------------
**PROPOSED** | "PROPOSED"
**RESERVED** | "RESERVED"
**PREPARED** | "PREPARED"
**COMPLETED** | "COMPLETED"
**CANCELED** | "CANCELED"
**FAILED** | "FAILED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

