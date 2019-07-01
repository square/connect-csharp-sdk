# Square.Connect.Model.Address

### Description

Represents a physical address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first line of the address.  Fields that start with &#x60;address_line&#x60; provide the address&#39;s most specific details, like street number, street name, and building name. They do *not* provide less specific details like city, state/province, or country (these details are provided in other fields). | [optional] 
**AddressLine2** | **string** | The second line of the address, if any. | [optional] 
**AddressLine3** | **string** | The third line of the address, if any. | [optional] 
**Locality** | **string** | The city or town of the address. | [optional] 
**Sublocality** | **string** | A civil region within the address&#39;s &#x60;locality&#x60;, if any. | [optional] 
**Sublocality2** | **string** | A civil region within the address&#39;s &#x60;sublocality&#x60;, if any. | [optional] 
**Sublocality3** | **string** | A civil region within the address&#39;s &#x60;sublocality_2&#x60;, if any. | [optional] 
**AdministrativeDistrictLevel1** | **string** | A civil entity within the address&#39;s country. In the US, this is the state. | [optional] 
**AdministrativeDistrictLevel2** | **string** | A civil entity within the address&#39;s &#x60;administrative_district_level_1&#x60;. In the US, this is the county. | [optional] 
**AdministrativeDistrictLevel3** | **string** | A civil entity within the address&#39;s &#x60;administrative_district_level_2&#x60;, if any. | [optional] 
**PostalCode** | **string** | The address&#39;s postal code. | [optional] 
**Country** | **string** | The address&#39;s country, in ISO 3166-1-alpha-2 format. See [Country](#type-country) for possible values | [optional] 
**FirstName** | **string** | Optional first name when it&#39;s representing recipient. | [optional] 
**LastName** | **string** | Optional last name when it&#39;s representing recipient. | [optional] 
**Organization** | **string** | Optional organization name when it&#39;s representing recipient. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

