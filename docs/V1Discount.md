# Square.Connect.Model.V1Discount

### Description

V1Discount
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The discount&#39;s unique ID. | [optional] 
**Name** | **string** | The discount&#39;s name. | [optional] 
**Rate** | **string** | The rate of the discount, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%. This rate is 0 if discount_type is VARIABLE_PERCENTAGE. | [optional] 
**AmountMoney** | [**V1Money**](V1Money.md) | The amount of the discount. This amount is 0 if discount_type is VARIABLE_AMOUNT. This field is not included for rate-based discounts. | [optional] 
**DiscountType** | **string** | Indicates whether the discount is a FIXED value or entered at the time of sale. See [V1DiscountDiscountType](#type-v1discountdiscounttype) for possible values | [optional] 
**PinRequired** | **bool?** | Indicates whether a mobile staff member needs to enter their PIN to apply the discount to a payment. | [optional] 
**Color** | **string** | The color of the discount&#39;s display label in Square Point of Sale, if not the default color. The default color is 9da2a6. See [V1DiscountColor](#type-v1discountcolor) for possible values | [optional] 
**V2Id** | **string** | The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

