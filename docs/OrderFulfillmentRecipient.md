# Square.Connect.Model.OrderFulfillmentRecipient

### Description

The recipient of a fulfillment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | The Customer ID of the customer associated with the fulfillment.  If customer_id is provided, the corresponding recipient information fields (&#x60;display_name&#x60;, &#x60;email_address&#x60;, and &#x60;phone_number&#x60;) are automatically populated from the relevant customer profile. If the targeted profile information does not contain the necessary required information, the request will result in an error. | [optional] 
**DisplayName** | **string** | The display name of the fulfillment recipient.  If provided, overrides the value from customer profile indicated by customer_id. | [optional] 
**EmailAddress** | **string** | The email address of the fulfillment recipient.  If provided, overrides the value from customer profile indicated by customer_id. | [optional] 
**PhoneNumber** | **string** | The phone number of the fulfillment recipient.  If provided, overrides the value from customer profile indicated by customer_id. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

