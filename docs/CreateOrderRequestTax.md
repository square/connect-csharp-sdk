# Square.Connect.Model.CreateOrderRequestTax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The tax&#39;s name. | [optional] 
**Type** | **TypeEnum** | Indicates the calculation method used to apply the line item tax.  Default: &#x60;ADDITIVE&#x60;; See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values. | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. This value range between 0.0 up to 100.0 | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**UNKNOWN** | "UNKNOWN"
**ADDITIVE** | "ADDITIVE"
**INCLUSIVE** | "INCLUSIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

