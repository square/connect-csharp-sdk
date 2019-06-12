# Square.Connect.Model.MeasurementUnit

### Description

Represents a unit of measurement to use with a quantity, such as ounces or inches. Exactly one of the following fields are required: `custom_unit`, `area_unit`, `length_unit`, `volume_unit`, and `weight_unit`.  The `family` field describes the type of measurement. For example, ounces are in the weight family.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUnit** | [**MeasurementUnitCustom**](MeasurementUnitCustom.md) | A custom unit of measurement defined by the seller using the Point of Sale app or ad-hoc as an order line item. | [optional] 
**AreaUnit** | **AreaUnitEnum** | Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values | [optional] 
**LengthUnit** | **LengthUnitEnum** | Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values | [optional] 
**VolumeUnit** | **VolumeUnitEnum** | Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values | [optional] 
**WeightUnit** | **WeightUnitEnum** | Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values | [optional] 
**GenericUnit** | **GenericUnitEnum** | Reserved for API integrations that lack the ability to specify a real measurement unit See [MeasurementUnitGeneric](#type-measurementunitgeneric) for possible values | [optional] 


## AreaUnitEnum

Name | Value
------------ | -------------
**IMPERIALACRE** | "IMPERIAL_ACRE"
**IMPERIALSQUAREINCH** | "IMPERIAL_SQUARE_INCH"
**IMPERIALSQUAREFOOT** | "IMPERIAL_SQUARE_FOOT"
**IMPERIALSQUAREYARD** | "IMPERIAL_SQUARE_YARD"
**IMPERIALSQUAREMILE** | "IMPERIAL_SQUARE_MILE"
**METRICSQUARECENTIMETER** | "METRIC_SQUARE_CENTIMETER"
**METRICSQUAREMETER** | "METRIC_SQUARE_METER"
**METRICSQUAREKILOMETER** | "METRIC_SQUARE_KILOMETER"


## LengthUnitEnum

Name | Value
------------ | -------------
**IMPERIALINCH** | "IMPERIAL_INCH"
**IMPERIALFOOT** | "IMPERIAL_FOOT"
**IMPERIALYARD** | "IMPERIAL_YARD"
**IMPERIALMILE** | "IMPERIAL_MILE"
**METRICMILLIMETER** | "METRIC_MILLIMETER"
**METRICCENTIMETER** | "METRIC_CENTIMETER"
**METRICMETER** | "METRIC_METER"
**METRICKILOMETER** | "METRIC_KILOMETER"


## VolumeUnitEnum

Name | Value
------------ | -------------
**GENERICFLUIDOUNCE** | "GENERIC_FLUID_OUNCE"
**GENERICSHOT** | "GENERIC_SHOT"
**GENERICCUP** | "GENERIC_CUP"
**GENERICPINT** | "GENERIC_PINT"
**GENERICQUART** | "GENERIC_QUART"
**GENERICGALLON** | "GENERIC_GALLON"
**IMPERIALCUBICINCH** | "IMPERIAL_CUBIC_INCH"
**IMPERIALCUBICFOOT** | "IMPERIAL_CUBIC_FOOT"
**IMPERIALCUBICYARD** | "IMPERIAL_CUBIC_YARD"
**METRICMILLILITER** | "METRIC_MILLILITER"
**METRICLITER** | "METRIC_LITER"


## WeightUnitEnum

Name | Value
------------ | -------------
**IMPERIALWEIGHTOUNCE** | "IMPERIAL_WEIGHT_OUNCE"
**IMPERIALPOUND** | "IMPERIAL_POUND"
**IMPERIALSTONE** | "IMPERIAL_STONE"
**METRICMILLIGRAM** | "METRIC_MILLIGRAM"
**METRICGRAM** | "METRIC_GRAM"
**METRICKILOGRAM** | "METRIC_KILOGRAM"


## GenericUnitEnum

Name | Value
------------ | -------------
**INVALIDGENERICUNIT** | "INVALID_GENERIC_UNIT"
**UNIT** | "UNIT"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

