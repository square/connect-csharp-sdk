# Square.Connect.Model.Location

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Square-issued ID of the location. | [optional] 
**Name** | **string** | The name of the location. This information appears in the dashboard as the nickname. | [optional] 
**Address** | [**Address**](Address.md) | The physical address of the location. | [optional] 
**Timezone** | **string** | The [IANA Timezone](https://www.iana.org/time-zones) identifier for the timezone of the location. | [optional] 
**Capabilities** | **List<string>** | The Square features that are enabled for the location. See &#x60;LocationCapability&#x60; for possible values. See [LocationCapability](#type-locationcapability) for possible values | [optional] 
**Status** | **string** | The status of the location, either active or inactive. See [LocationStatus](#type-locationstatus) for possible values | [optional] 
**CreatedAt** | **string** | The time when the location was created, in RFC 3339 format. | [optional] 
**MerchantId** | **string** | The ID of the merchant that owns the location. | [optional] 
**Country** | **string** | The country of the location, in ISO 3166-1-alpha-2 format.  See &#x60;Country&#x60; for possible values. See [Country](#type-country) for possible values | [optional] 
**LanguageCode** | **string** | The language associated with the location, in [BCP 47 format](https://tools.ietf.org/html/bcp47#appendix-A). | [optional] 
**Currency** | **string** | The currency used for all transactions at this location, in ISO 4217 format. See &#x60;Currency&#x60; for possible values. See [Currency](#type-currency) for possible values | [optional] 
**PhoneNumber** | **string** | The phone number of the location in human readable format. | [optional] 
**BusinessName** | **string** | The business name of the location This is the name visible to the customers of the location. For example, this name appears on customer receipts. | [optional] 
**Type** | **string** | The type of the location, either physical or mobile. See [LocationType](#type-locationtype) for possible values | [optional] 
**WebsiteUrl** | **string** | The website URL of the location. | [optional] 
**BusinessHours** | [**BusinessHours**](BusinessHours.md) |  Represents the hours of operation for the location. | [optional] 
**BusinessEmail** | **string** | The email of the location. This email is visible to the customers of the location. For example, the email appears on customer receipts. | [optional] 
**Description** | **string** | The description of the location. | [optional] 
**TwitterUsername** | **string** | The Twitter username of the location without the &#39;&amp;#64;&#39; symbol. | [optional] 
**InstagramUsername** | **string** | The Instagram username of the location without the &#39;&amp;#64;&#39; symbol. | [optional] 
**FacebookUrl** | **string** | The Facebook profile URL of the location. The URL should begin with &#39;facebook.com/&#39;. | [optional] 
**Coordinates** | [**Coordinates**](Coordinates.md) | The physical coordinates (latitude and longitude) of the location. | [optional] 
**LogoUrl** | **string** | The URL of the logo image for the location. | [optional] 
**PosBackgroundUrl** | **string** | The URL of the Point of Sale background image for the location. | [optional] 
**Mcc** | **string** | The merchant category code (MCC) of the location, as standardized by ISO 18245. The MCC describes the kind of goods or services sold at the location. | [optional] [beta]



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

