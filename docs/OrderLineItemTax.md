# Square.Connect.Model.OrderLineItemTax

### Description

Represents a tax that applies to one or more line items in an order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the tax only within this order.  This field is read-only. | [optional] 
**CatalogObjectId** | **string** | The catalog object id referencing [CatalogTax](#type-catalogtax). | [optional] 
**Name** | **string** | The tax&#39;s name. | [optional] 
**Type** | **string** | Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of the money applied by the tax in an order. | [optional] 
**Scope** | **string** | Indicates the level at which the tax applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

