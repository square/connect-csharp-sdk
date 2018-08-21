# Square.Connect.Model.RenewTokenResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The renewed access token. This value might be different from the &#x60;access_token&#x60; you provided in your request. You provide this token in a header with every request to Connect API endpoints. See [Request and response headers](https://docs.connect.squareup.com/api/connect/v2/#requestandresponseheaders) for the format of this header. | [optional] 
**TokenType** | **string** | This value is always _bearer_. | [optional] 
**ExpiresAt** | **string** | The date when access_token expires, in [ISO 8601](http://www.iso.org/iso/home/standards/iso8601.htm) format. | [optional] 
**MerchantId** | **string** | The ID of the authorizing merchant&#39;s business. | [optional] 
**SubscriptionId** | **string** | The ID of the merchant [subscription](https://docs.connect.squareup.com/api/connect/v1/#navsection-subscriptionmanagement) associated with the authorization. Only present if the merchant signed up for a subscription during authorization. | [optional] 
**PlanId** | **string** | The ID of the [subscription](https://docs.connect.squareup.com/api/connect/v1/#navsection-subscriptionmanagement) plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

