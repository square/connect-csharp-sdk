# Square.Connect.Model.Money

### Description

Represents an amount of money. `Money` fields can be signed or unsigned.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **long?** | The amount of money, in the smallest denomination of the currency indicated by &#x60;currency&#x60;. For example, when &#x60;currency&#x60; is &#x60;USD&#x60;, &#x60;amount&#x60; is in cents. Monetary amounts can be positive or negative. See the specific API documentation to determine the meaning of the sign in a particular case. | [optional] 
**Currency** | **string** | The type of currency, in __ISO 4217 format__. For example, the currency code for US dollars is &#x60;USD&#x60;.  See &#x60;Currency&#x60; for possible values. See [Currency](#type-currency) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

