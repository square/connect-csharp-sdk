# Square.Connect.Model.Location

### Description

Represents one of a business's locations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The location&#39;s unique ID. | [optional] 
**Name** | **string** | The location&#39;s name. Location names are set by the account owner and displayed in the dashboard as the location&#39;s nickname | [optional] 
**Address** | [**Address**](Address.md) | The location&#39;s physical address. | [optional] 
**Timezone** | **string** | The [IANA Timezone Database](https://www.iana.org/time-zones) identifier for the location&#39;s timezone. | [optional] 
**Capabilities** | **List<string>** | Indicates which Square features are enabled for the location. See [LocationCapability](#type-locationcapability) for possible values | [optional] 
**Status** | **string** | The location&#39;s status See [LocationStatus](#type-locationstatus) for possible values | [optional] 
**CreatedAt** | **string** | The time when the location was created, in RFC 3339 format. | [optional] 
**MerchantId** | **string** | The identifier of the merchant that owns the location. | [optional] 
**Country** | **string** | The location&#39;s country, in ISO 3166-1-alpha-2 format. See [Country](#type-country) for possible values | [optional] 
**LanguageCode** | **string** | The language associated with the location in [BCP 47 format](https://tools.ietf.org/html/bcp47#appendix-A). | [optional] 
**Currency** | **string** | The currency used for all transactions at this location, specified in __ISO 4217 format__. For example, the currency for a location processing transactions in the United States is &#39;USD&#39;. See [Currency](#type-currency) for possible values | [optional] 
**PhoneNumber** | **string** | The location&#39;s phone_number. | [optional] 
**BusinessName** | **string** | The location&#39;s business_name which is shown to its customers. For example, this is the name printed on its customer&#39;s receipts. | [optional] 
**Type** | **string** | The location&#39;s type, as set by the account owner in the Square dashboard. Typically used to indicate whether or not the location object represents a physical space like a building or mall space. See [LocationType](#type-locationtype) for possible values | [optional] 
**WebsiteUrl** | **string** | The location&#39;s website, as set by the account owner in the Square dashboard.  Default: none; only exists if explicitly set. | [optional] 
**BusinessHours** | [**BusinessHours**](BusinessHours.md) |   The hours of operation for a business location.  Default: none; only exists if explicitly set. | [optional] 
**BusinessEmail** | **string** | The email of the location. | [optional] 
**Description** | **string** | The business description of the location. | [optional] 
**TwitterUsername** | **string** | The Twitter username of the location without the &#39;&amp;#64;&#39; symbol. | [optional] 
**InstagramUsername** | **string** | The Instagram username of the location without the &#39;&amp;#64;&#39; symbol. | [optional] 
**FacebookUrl** | **string** | The Facebook profile URL of the location. The URL should begin with &#39;facebook.com/&#39;. | [optional] 
**Coordinates** | [**Coordinates**](Coordinates.md) | The physical coordinates (latitude and longitude) of the location. | [optional] 
**LogoUrl** | **string** | The logo image URL of the location. | [optional] 
**PosBackgroundUrl** | **string** | The Point of Sale background image URL of the location. | [optional] 
**Mcc** | **string** | The merchant category code (MCC) of the location, as standardized by ISO 18245. The MCC describes the kind of goods or services sold at the location. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

