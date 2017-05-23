# Square.Connect.Model.V1Merchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The merchant account&#39;s unique identifier. | [optional] 
**Name** | **string** | The name associated with the merchant account. | [optional] 
**Email** | **string** | The email address associated with the merchant account. | [optional] 
**AccountType** | **AccountTypeEnum** | Indicates whether the merchant account corresponds to a single-location account (LOCATION) or a business account (BUSINESS). This value is almost always LOCATION. | [optional] 
**AccountCapabilities** | **List<string>** | Capabilities that are enabled for the merchant&#39;s Square account. Capabilities that are not listed in this array are not enabled for the account. | [optional] 
**CountryCode** | **string** | The country associated with the merchant account, in ISO 3166-1-alpha-2 format. | [optional] 
**LanguageCode** | **string** | The language associated with the merchant account, in BCP 47 format. | [optional] 
**CurrencyCode** | **string** | The currency associated with the merchant account, in ISO 4217 format. For example, the currency code for US dollars is USD. | [optional] 
**BusinessName** | **string** | The name of the merchant&#39;s business. | [optional] 
**BusinessAddress** | [**Address**](Address.md) | The address of the merchant&#39;s business. | [optional] 
**BusinessPhone** | [**V1PhoneNumber**](V1PhoneNumber.md) | The phone number of the merchant&#39;s business. | [optional] 
**BusinessType** | **BusinessTypeEnum** | The type of business operated by the merchant. | [optional] 
**ShippingAddress_** | [**Address**](Address.md) | The merchant&#39;s shipping address. | [optional] 
**LocationDetails** | [**V1MerchantLocationDetails**](V1MerchantLocationDetails.md) |  | [optional] 
**MarketUrl** | **string** | The URL of the merchant&#39;s online store. | [optional] 


## AccountTypeEnum

Name | Value
------------ | -------------
**LOCATION** | "LOCATION"
**BUSINESS** | "BUSINESS"


## BusinessTypeEnum

Name | Value
------------ | -------------
**ACCOUNTING** | "ACCOUNTING"
**APPARELANDACCESSORYSHOPS** | "APPAREL_AND_ACCESSORY_SHOPS"
**ARTDEALERSGALLERIES** | "ART_DEALERS_GALLERIES"
**ARTDESIGNANDPHOTOGRAPHY** | "ART_DESIGN_AND_PHOTOGRAPHY"
**BARCLUBLOUNGE** | "BAR_CLUB_LOUNGE"
**BEAUTYANDBARBERSHOPS** | "BEAUTY_AND_BARBER_SHOPS"
**BOOKSTORES** | "BOOK_STORES"
**BUSINESSSERVICES** | "BUSINESS_SERVICES"
**CATERING** | "CATERING"
**CHARITABLESOCIALSERVICEORGANIZATIONS** | "CHARITABLE_SOCIAL_SERVICE_ORGANIZATIONS"
**CHARITIBLEORGS** | "CHARITIBLE_ORGS"
**CLEANINGSERVICES** | "CLEANING_SERVICES"
**COMPUTEREQUIPMENTSOFTWAREMAINTENANCEREPAIRSERVICES** | "COMPUTER_EQUIPMENT_SOFTWARE_MAINTENANCE_REPAIR_SERVICES"
**CONSULTANT** | "CONSULTANT"
**CONTRACTORS** | "CONTRACTORS"
**DELIVERYSERVICES** | "DELIVERY_SERVICES"
**DENTISTRY** | "DENTISTRY"
**EDUCATION** | "EDUCATION"
**FOODSTORESCONVENIENCESTORESANDSPECIALTYMARKETS** | "FOOD_STORES_CONVENIENCE_STORES_AND_SPECIALTY_MARKETS"
**FOODTRUCKCART** | "FOOD_TRUCK_CART"
**FURNITUREHOMEANDOFFICEEQUIPMENT** | "FURNITURE_HOME_AND_OFFICE_EQUIPMENT"
**FURNITUREHOMEGOODS** | "FURNITURE_HOME_GOODS"
**HOTELSANDLODGING** | "HOTELS_AND_LODGING"
**INDIVIDUALUSE** | "INDIVIDUAL_USE"
**JEWELRYANDWATCHES** | "JEWELRY_AND_WATCHES"
**LANDSCAPINGANDHORTICULTURALSERVICES** | "LANDSCAPING_AND_HORTICULTURAL_SERVICES"
**LANGUAGESCHOOLS** | "LANGUAGE_SCHOOLS"
**LEGALSERVICES** | "LEGAL_SERVICES"
**MEDICALPRACTITIONERS** | "MEDICAL_PRACTITIONERS"
**MEDICALSERVICESANDHEALTHPRACTITIONERS** | "MEDICAL_SERVICES_AND_HEALTH_PRACTITIONERS"
**MEMBERSHIPORGANIZATIONS** | "MEMBERSHIP_ORGANIZATIONS"
**MUSICANDENTERTAINMENT** | "MUSIC_AND_ENTERTAINMENT"
**OTHER** | "OTHER"
**OUTDOORMARKETS** | "OUTDOOR_MARKETS"
**PERSONALSERVICES** | "PERSONAL_SERVICES"
**POLITICALORGANIZATIONS** | "POLITICAL_ORGANIZATIONS"
**PROFESSIONALSERVICES** | "PROFESSIONAL_SERVICES"
**REALESTATE** | "REAL_ESTATE"
**RECREATIONSERVICES** | "RECREATION_SERVICES"
**REPAIRSHOPSANDRELATEDSERVICES** | "REPAIR_SHOPS_AND_RELATED_SERVICES"
**RESTAURANTS** | "RESTAURANTS"
**RETAILSHOPS** | "RETAIL_SHOPS"
**SCHOOLSANDEDUCATIONALSERVICES** | "SCHOOLS_AND_EDUCATIONAL_SERVICES"
**SPORTINGGOODS** | "SPORTING_GOODS"
**TAXICABSANDLIMOUSINES** | "TAXICABS_AND_LIMOUSINES"
**TICKETSALES** | "TICKET_SALES"
**TOURISM** | "TOURISM"
**TRAVELTOURISM** | "TRAVEL_TOURISM"
**VETERINARYSERVICES** | "VETERINARY_SERVICES"
**WEBDEVDESIGN** | "WEB_DEV_DESIGN"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

