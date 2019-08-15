# Square.Connect.Model.MeasurementUnit

### Description

Represents a unit of measurement to use with a quantity, such as ounces or inches. Exactly one of the following fields are required: `custom_unit`, `area_unit`, `length_unit`, `volume_unit`, and `weight_unit`.  The `family` field describes the type of measurement. For example, ounces are in the weight family.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUnit** | [**MeasurementUnitCustom**](MeasurementUnitCustom.md) | A custom unit of measurement defined by the seller using the Point of Sale app or ad-hoc as an order line item. | [optional] 
**AreaUnit** | **string** | Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values | [optional] 
**LengthUnit** | **string** | Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values | [optional] 
**VolumeUnit** | **string** | Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values | [optional] 
**WeightUnit** | **string** | Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values | [optional] 
**GenericUnit** | **string** | Reserved for API integrations that lack the ability to specify a real measurement unit See [MeasurementUnitGeneric](#type-measurementunitgeneric) for possible values | [optional] 
**TimeUnit** | **string** | Represents a standard unit of time. See [MeasurementUnitTime](#type-measurementunittime) for possible values | [optional] 
**Type** | **string** | Represents the type of the measurement unit. See [MeasurementUnitUnitType](#type-measurementunitunittype) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

