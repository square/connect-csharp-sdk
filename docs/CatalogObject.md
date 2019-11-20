# Square.Connect.Model.CatalogObject

### Description

The wrapper object for object types in the Catalog data model. The type of a particular `CatalogObject` is determined by the value of `type` and only the corresponding data field may be set.  - if type = `ITEM`, only `item_data` will be populated and it will contain a valid `CatalogItem` object. - if type = `ITEM_VARIATION`, only `item_variation_data` will be populated and it will contain a valid `CatalogItemVariation` object. - if type = `MODIFIER`, only `modifier_data` will be populated and it will contain a valid `CatalogModifier` object. - if type = `MODIFIER_LIST`, only `modifier_list_data` will be populated and it will contain a valid `CatalogModifierList` object. - if type = `CATEGORY`, only `category_data` will be populated and it will contain a valid `CatalogCategory` object. - if type = `DISCOUNT`, only `discount_data` will be populated and it will contain a valid `CatalogDiscount` object. - if type = `TAX`, only `tax_data` will be populated and it will contain a valid `CatalogTax` object. - if type = `IMAGE`, only `image_data` will be populated and it will contain a valid `CatalogImage` object.  For a more detailed discussion of the Catalog data model, please see the [Design a Catalog](/catalog-api/design-a-catalog) guide.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of this object. Each object type has expected properties expressed in a structured format within its corresponding &#x60;*_data&#x60; field below. See [CatalogObjectType](#type-catalogobjecttype) for possible values | 
**Id** | **string** | An identifier to reference this object in the catalog. When a new &#x60;CatalogObject&#x60; is inserted, the client should set the id to a temporary identifier starting with a \&quot;&#x60;#&#x60;\&quot; character. Other objects being inserted or updated within the same request may use this identifier to refer to the new object.  When the server receives the new object, it will supply a unique identifier that replaces the temporary identifier for all future references. | 
**UpdatedAt** | **string** | Last modification [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates) in RFC 3339 format, e.g., &#x60;\&quot;2016-08-15T23:59:33.123Z\&quot;&#x60; would indicate the UTC time (denoted by &#x60;Z&#x60;) of August 15, 2016 at 23:59:33 and 123 milliseconds. | [optional] 
**Version** | **long?** | The version of the object. When updating an object, the version supplied must match the version in the database, otherwise the write will be rejected as conflicting. | [optional] 
**IsDeleted** | **bool?** | If &#x60;true&#x60;, the object has been deleted from the database. Must be &#x60;false&#x60; for new objects being inserted. When deleted, the &#x60;updated_at&#x60; field will equal the deletion time. | [optional] 
**CatalogV1Ids** | [**List&lt;CatalogV1Id&gt;**](CatalogV1Id.md) | The Connect v1 IDs for this object at each location where it is present, where they differ from the object&#39;s Connect V2 ID. The field will only be present for objects that have been created or modified by legacy APIs. | [optional] 
**PresentAtAllLocations** | **bool?** | If &#x60;true&#x60;, this object is present at all locations (including future locations), except where specified in the &#x60;absent_at_location_ids&#x60; field. If &#x60;false&#x60;, this object is not present at any locations (including future locations), except where specified in the &#x60;present_at_location_ids&#x60; field. If not specified, defaults to &#x60;true&#x60;. | [optional] 
**PresentAtLocationIds** | **List<string>** | A list of locations where the object is present, even if &#x60;present_at_all_locations&#x60; is &#x60;false&#x60;. | [optional] 
**AbsentAtLocationIds** | **List<string>** | A list of locations where the object is not present, even if &#x60;present_at_all_locations&#x60; is &#x60;true&#x60;. | [optional] 
**ImageId** | **string** | Identifies the &#x60;CatalogImage&#x60; attached to this &#x60;CatalogObject&#x60;. | [optional] 
**ItemData** | [**CatalogItem**](CatalogItem.md) | Structured data for a &#x60;CatalogItem&#x60;, set for CatalogObjects of type &#x60;ITEM&#x60;. | [optional] 
**CategoryData** | [**CatalogCategory**](CatalogCategory.md) | Structured data for a &#x60;CatalogCategory&#x60;, set for CatalogObjects of type &#x60;CATEGORY&#x60;. | [optional] 
**ItemVariationData** | [**CatalogItemVariation**](CatalogItemVariation.md) | Structured data for a &#x60;CatalogItemVariation&#x60;, set for CatalogObjects of type &#x60;ITEM_VARIATION&#x60;. | [optional] 
**TaxData** | [**CatalogTax**](CatalogTax.md) | Structured data for a &#x60;CatalogTax&#x60;, set for CatalogObjects of type &#x60;TAX&#x60;. | [optional] 
**DiscountData** | [**CatalogDiscount**](CatalogDiscount.md) | Structured data for a &#x60;CatalogDiscount&#x60;, set for CatalogObjects of type &#x60;DISCOUNT&#x60;. | [optional] 
**ModifierListData** | [**CatalogModifierList**](CatalogModifierList.md) | Structured data for a &#x60;CatalogModifierList&#x60;, set for CatalogObjects of type &#x60;MODIFIER_LIST&#x60;. | [optional] 
**ModifierData** | [**CatalogModifier**](CatalogModifier.md) | Structured data for a &#x60;CatalogModifier&#x60;, set for CatalogObjects of type &#x60;MODIFIER&#x60;. | [optional] 
**TimePeriodData** | [**CatalogTimePeriod**](CatalogTimePeriod.md) | Structured data for a &#x60;CatalogTimePeriod&#x60;, set for CatalogObjects of type &#x60;TIME_PERIOD&#x60;. | [optional] 
**ProductSetData** | [**CatalogProductSet**](CatalogProductSet.md) | Structured data for a &#x60;CatalogProductSet&#x60;, set for CatalogObjects of type &#x60;PRODUCT_SET&#x60;. | [optional] 
**PricingRuleData** | [**CatalogPricingRule**](CatalogPricingRule.md) | Structured data for a &#x60;CatalogPricingRule&#x60;, set for CatalogObjects of type &#x60;PRICING_RULE&#x60;. | [optional] 
**ImageData** | [**CatalogImage**](CatalogImage.md) | Structured data for a &#x60;CatalogImage&#x60;, set for CatalogObjects of type &#x60;IMAGE&#x60;. | [optional] 
**MeasurementUnitData** | [**CatalogMeasurementUnit**](CatalogMeasurementUnit.md) | Structured data for a &#x60;CatalogMeasurementUnit&#x60;, set for CatalogObjects of type &#x60;MEASUREMENT_UNIT&#x60;. | [optional] 
**ItemOptionData** | [**CatalogItemOption**](CatalogItemOption.md) | Structured data for a &#x60;CatalogItemOption&#x60;, set for CatalogObjects of type &#x60;ITEM_OPTION&#x60;. | [optional] 
**ItemOptionValueData** | [**CatalogItemOptionValue**](CatalogItemOptionValue.md) | Structured data for a &#x60;CatalogItemOptionValue&#x60;, set for CatalogObjects of type &#x60;ITEM_OPTION_VAL&#x60;. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

