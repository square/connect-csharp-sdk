# Square.Connect.Model.CatalogTax

### Description

A tax in the Catalog object model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The tax&#39;s name. Searchable. This field has max length of 255 Unicode code points. | [optional] 
**CalculationPhase** | **string** | Whether the tax is calculated based on a payment&#39;s subtotal or total. See [TaxCalculationPhase](#type-taxcalculationphase) for possible values | [optional] 
**InclusionType** | **string** | Whether the tax is &#x60;ADDITIVE&#x60; or &#x60;INCLUSIVE&#x60;. See [TaxInclusionType](#type-taxinclusiontype) for possible values | [optional] 
**Percentage** | **string** | The percentage of the tax in decimal form, using a &#x60;&#39;.&#39;&#x60; as the decimal separator and without a &#x60;&#39;%&#39;&#x60; sign. A value of &#x60;7.5&#x60; corresponds to 7.5%. | [optional] 
**AppliesToCustomAmounts** | **bool?** | If &#x60;true&#x60;, the fee applies to custom amounts entered into the Square Point of Sale app that are not associated with a particular &#x60;CatalogItem&#x60;. | [optional] 
**Enabled** | **bool?** | If &#x60;true&#x60;, the tax will be shown as enabled in the Square Point of Sale app. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

