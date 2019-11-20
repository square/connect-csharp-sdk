# Square.Connect.Model.V1Merchant

### Description

Defines the fields that are included in the response body of a request to the **RetrieveBusiness** endpoint.
**Note: This model is deprecated.**

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The merchant account&#39;s unique identifier. | [optional] 
**Name** | **string** | The name associated with the merchant account. | [optional] 
**Email** | **string** | The email address associated with the merchant account. | [optional] 
**AccountType** | **string** | Indicates whether the merchant account corresponds to a single-location account (LOCATION) or a business account (BUSINESS). This value is almost always LOCATION. See [V1MerchantAccountType](#type-v1merchantaccounttype) for possible values | [optional] 
**AccountCapabilities** | **List<string>** | Capabilities that are enabled for the merchant&#39;s Square account. Capabilities that are not listed in this array are not enabled for the account. | [optional] 
**CountryCode** | **string** | The country associated with the merchant account, in ISO 3166-1-alpha-2 format. | [optional] 
**LanguageCode** | **string** | The language associated with the merchant account, in BCP 47 format. | [optional] 
**CurrencyCode** | **string** | The currency associated with the merchant account, in ISO 4217 format. For example, the currency code for US dollars is USD. | [optional] 
**BusinessName** | **string** | The name of the merchant&#39;s business. | [optional] 
**BusinessAddress** | [**Address**](Address.md) | The address of the merchant&#39;s business. | [optional] 
**BusinessPhone** | [**V1PhoneNumber**](V1PhoneNumber.md) | The phone number of the merchant&#39;s business. | [optional] 
**BusinessType** | **string** | The type of business operated by the merchant. See [V1MerchantBusinessType](#type-v1merchantbusinesstype) for possible values | [optional] 
**ShippingAddress** | [**Address**](Address.md) | The merchant&#39;s shipping address. | [optional] 
**LocationDetails** | [**V1MerchantLocationDetails**](V1MerchantLocationDetails.md) | Additional information for a single-location account specified by its associated business account, if it has one. | [optional] 
**MarketUrl** | **string** | The URL of the merchant&#39;s online store. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

