# Square.Connect.Api.MobileAuthorizationApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMobileAuthorizationCode**](MobileAuthorizationApi.md#createmobileauthorizationcode) | **POST** /mobile/authorization-code | CreateMobileAuthorizationCode


<a name="createmobileauthorizationcode"></a>
# **CreateMobileAuthorizationCode**
> CreateMobileAuthorizationCodeResponse CreateMobileAuthorizationCode (CreateMobileAuthorizationCodeRequest body)

CreateMobileAuthorizationCode

Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The `Authorization` header you provide to this endpoint must have the following format:  ``` Authorization: Bearer ACCESS_TOKEN ```  Replace `ACCESS_TOKEN` with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateMobileAuthorizationCodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAuthorizationApi();
            var body = new CreateMobileAuthorizationCodeRequest(); // CreateMobileAuthorizationCodeRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateMobileAuthorizationCode
                CreateMobileAuthorizationCodeResponse result = apiInstance.CreateMobileAuthorizationCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAuthorizationApi.CreateMobileAuthorizationCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateMobileAuthorizationCodeRequest**](CreateMobileAuthorizationCodeRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**CreateMobileAuthorizationCodeResponse**](CreateMobileAuthorizationCodeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

