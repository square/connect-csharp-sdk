# Square.Connect.Model.OrderLineItemTax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The tax&#39;s name. | [optional] 
**Type** | **TypeEnum** | The type of a tax is either INCLUSIVE or ADDITIVE. | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of the money applied by the tax in an order. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**UNKNOWN** | "UNKNOWN"
**ADDITIVE** | "ADDITIVE"
**INCLUSIVE** | "INCLUSIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

