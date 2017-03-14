# Square.Connect.Model.V1PaymentTax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Name** | **string** | The merchant-defined name of the tax. | [optional] 
**AppliedMoney** | [**V1Money**](V1Money.md) | The amount of money that this tax adds to the payment. | [optional] 
**Rate** | **string** | The rate of the tax, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%. | [optional] 
**InclusionType** | **InclusionTypeEnum** | Whether the tax is an ADDITIVE tax or an INCLUSIVE tax. | [optional] 
**FeeId** | **string** | The ID of the tax, if available. Taxes applied in older versions of Square Register might not have an ID. | [optional] 


## InclusionTypeEnum

Name | Value
------------ | -------------
**ADDITIVE** | "ADDITIVE"
**INCLUSIVE** | "INCLUSIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

