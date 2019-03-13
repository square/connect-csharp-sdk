# Square.Connect.Api.OAuthApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ObtainToken**](OAuthApi.md#obtaintoken) | **POST** /oauth2/token | ObtainToken
[**RenewToken**](OAuthApi.md#renewtoken) | **POST** /oauth2/clients/{client_id}/access-token/renew | RenewToken
[**RevokeToken**](OAuthApi.md#revoketoken) | **POST** /oauth2/revoke | RevokeToken


<a name="obtaintoken"></a>
# **ObtainToken**
> ObtainTokenResponse ObtainToken (ObtainTokenRequest body)

ObtainToken

Returns an OAuth access token.   The endpoint supports distinct methods of obtaining OAuth access tokens.  Applications specify a method by adding the `grant_type` parameter  in the request and also provide relevant information.  For more information, see [OAuth access token management](/authz/oauth/how-it-works#oauth-access-token-management).   __Note:__ Regardless of the method application specified, the endpoint always returns two items; an OAuth access token and  a refresh token in the response.   By default, the OAuth API lets up to 500 Square accounts authorize your application. Please [contact support](https://squareup.com/help/us/en/contact?prefill=developer_api) if you are developing an application for a larger audience.  __OAuth tokens should only live on secure servers. Application clients should never interact directly with OAuth tokens__.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ObtainTokenExample
    {
        public void main()
        {
            
            var apiInstance = new OAuthApi();
            var body = new ObtainTokenRequest(); // ObtainTokenRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // ObtainToken
                ObtainTokenResponse result = apiInstance.ObtainToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.ObtainToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ObtainTokenRequest**](ObtainTokenRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**ObtainTokenResponse**](ObtainTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renewtoken"></a>
# **RenewToken**
> RenewTokenResponse RenewToken (string clientId, RenewTokenRequest body)

RenewToken

`RenewToken` is deprecated. For information about refreshing OAuth access tokens, see  [Renew OAuth Token](/authz/oauth/cookbook/oauth-renew).   Renews an OAuth access token before it expires.  OAuth access tokens besides your application's personal access token expire after __30 days__. You can also renew expired tokens within __15 days__ of their expiration. You cannot renew an access token that has been expired for more than 15 days. Instead, the associated user must re-complete the OAuth flow from the beginning.  __Important:__ The `Authorization` header for this endpoint must have the following format:  ``` Authorization: Client APPLICATION_SECRET ```  Replace `APPLICATION_SECRET` with the application secret on the Credentials page in the [application dashboard](https://connect.squareup.com/apps).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RenewTokenExample
    {
        public void main()
        {
            
            // Configure API key authorization: oauth2ClientSecret
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_APPLICATION_SECRET");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Your application's ID, available from the [application dashboard](https://connect.squareup.com/apps).
            var body = new RenewTokenRequest(); // RenewTokenRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // RenewToken
                RenewTokenResponse result = apiInstance.RenewToken(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.RenewToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Your application&#39;s ID, available from the [application dashboard](https://connect.squareup.com/apps). | 
 **body** | [**RenewTokenRequest**](RenewTokenRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**RenewTokenResponse**](RenewTokenResponse.md)

### Authorization

[oauth2ClientSecret](../README.md#oauth2ClientSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revoketoken"></a>
# **RevokeToken**
> RevokeTokenResponse RevokeToken (RevokeTokenRequest body)

RevokeToken

Revokes an access token generated with the OAuth flow.  If an account has more than one OAuth access token for your application, this endpoint revokes all of them, regardless of which token you specify. When an OAuth access token is revoked, all of the active subscriptions associated with that OAuth token are canceled immediately.  __Important:__ The `Authorization` header for this endpoint must have the following format:  ``` Authorization: Client APPLICATION_SECRET ```  Replace `APPLICATION_SECRET` with the application secret on the Credentials page in the [application dashboard](https://connect.squareup.com/apps).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RevokeTokenExample
    {
        public void main()
        {
            
            // Configure API key authorization: oauth2ClientSecret
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_APPLICATION_SECRET");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OAuthApi();
            var body = new RevokeTokenRequest(); // RevokeTokenRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // RevokeToken
                RevokeTokenResponse result = apiInstance.RevokeToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.RevokeToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RevokeTokenRequest**](RevokeTokenRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**RevokeTokenResponse**](RevokeTokenResponse.md)

### Authorization

[oauth2ClientSecret](../README.md#oauth2ClientSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

