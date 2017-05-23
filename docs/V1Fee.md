# Square.Connect.Model.V1Fee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The fee&#39;s unique ID. | [optional] 
**Name** | **string** | The fee&#39;s name. | [optional] 
**Rate** | **string** | The rate of the fee, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%. | [optional] 
**CalculationPhase** | **CalculationPhaseEnum** | Forthcoming | [optional] 
**AdjustmentType** | **AdjustmentTypeEnum** | The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees. | [optional] 
**AppliesToCustomAmounts** | **bool?** | If true, the fee applies to custom amounts entered into Square Register that are not associated with a particular item. | [optional] 
**Enabled** | **bool?** | If true, the fee is applied to all appropriate items. If false, the fee is not applied at all. | [optional] 
**InclusionType** | **InclusionTypeEnum** | Whether the fee is ADDITIVE or INCLUSIVE. | [optional] 
**Type** | **TypeEnum** | In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants. | [optional] 


## CalculationPhaseEnum

Name | Value
------------ | -------------
**FEESUBTOTALPHASE** | "FEE_SUBTOTAL_PHASE"
**OTHER** | "OTHER"
**FEETOTALPHASE** | "FEE_TOTAL_PHASE"


## AdjustmentTypeEnum

Name | Value
------------ | -------------
**TAX** | "TAX"


## InclusionTypeEnum

Name | Value
------------ | -------------
**ADDITIVE** | "ADDITIVE"
**INCLUSIVE** | "INCLUSIVE"


## TypeEnum

Name | Value
------------ | -------------
**CAGST** | "CA_GST"
**CAHST** | "CA_HST"
**CAPST** | "CA_PST"
**CAQST** | "CA_QST"
**JPCONSUMPTIONTAX** | "JP_CONSUMPTION_TAX"
**CAPEIPST** | "CA_PEI_PST"
**USSALESTAX** | "US_SALES_TAX"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

