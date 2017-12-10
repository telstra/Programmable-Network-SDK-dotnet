# IO.TelstraTPN..AuthenticationApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnAuthenticationToken**](AuthenticationApi.md#createanauthenticationtoken) | **POST** /1.0.0/auth/generatetoken | Create an authentication token
[**ValidateAuthenticationToken**](AuthenticationApi.md#validateauthenticationtoken) | **GET** /1.0.0/auth/validatetoken | Validate authentication token


<a name="createanauthenticationtoken"></a>
# **CreateAnAuthenticationToken**
> Model100AuthGeneratetokenResponse CreateAnAuthenticationToken (string grantType, string username, string password)

Create an authentication token

Create an authentication token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class CreateAnAuthenticationTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi();
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string | 

            try
            {
                // Create an authentication token
                Model100AuthGeneratetokenResponse result = apiInstance.CreateAnAuthenticationToken(grantType, username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.CreateAnAuthenticationToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**|  | 
 **username** | **string**|  | 
 **password** | **string**|  | 

### Return type

[**Model100AuthGeneratetokenResponse**](Model100AuthGeneratetokenResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateauthenticationtoken"></a>
# **ValidateAuthenticationToken**
> Model100AuthValidatetokenResponse ValidateAuthenticationToken ()

Validate authentication token

Validate the authentication token and get information about the user (roles, permissions, etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class ValidateAuthenticationTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi();

            try
            {
                // Validate authentication token
                Model100AuthValidatetokenResponse result = apiInstance.ValidateAuthenticationToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ValidateAuthenticationToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Model100AuthValidatetokenResponse**](Model100AuthValidatetokenResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

