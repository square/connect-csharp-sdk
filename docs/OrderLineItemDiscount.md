# Square.Connect.Model.OrderLineItemDiscount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The discount&#39;s name. | [optional] 
**Type** | **TypeEnum** | The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified. | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The amount of the discount. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of the money applied by the discount in an order. | [optional] 
**Scope** | **ScopeEnum** | The scope of the discount. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**UNKNOWN** | "UNKNOWN"
**FIXEDPERCENTAGE** | "FIXED_PERCENTAGE"
**FIXEDAMOUNT** | "FIXED_AMOUNT"
**VARIABLEPERCENTAGE** | "VARIABLE_PERCENTAGE"
**VARIABLEAMOUNT** | "VARIABLE_AMOUNT"


## ScopeEnum

Name | Value
------------ | -------------
**LINEITEM** | "LINEITEM"
**ORDER** | "ORDER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

