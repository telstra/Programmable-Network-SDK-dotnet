# IO.TelstraTPN.Api.AuthenticationApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthGeneratetokenPost**](AuthenticationApi.md#authgeneratetokenpost) | **POST** /1.0.0/auth/generatetoken | Create an authentication token
[**AuthValidatetokenGet**](AuthenticationApi.md#authvalidatetokenget) | **GET** /1.0.0/auth/validatetoken | Validate authentication token


<a name="authgeneratetokenpost"></a>
# **AuthGeneratetokenPost**
> AuthGeneratetokenResponse AuthGeneratetokenPost (string grantType, string username, string password)

Create an authentication token

Create an authentication token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class AuthGeneratetokenPostExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string | 

            try
            {
                // Create an authentication token
                AuthGeneratetokenResponse result = apiInstance.AuthGeneratetokenPost(grantType, username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthGeneratetokenPost: " + e.Message );
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

[**AuthGeneratetokenResponse**](AuthGeneratetokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authvalidatetokenget"></a>
# **AuthValidatetokenGet**
> AuthValidatetokenResponse AuthValidatetokenGet ()

Validate authentication token

Validate the authentication token and get information about the user (roles, permissions, etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class AuthValidatetokenGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // Validate authentication token
                AuthValidatetokenResponse result = apiInstance.AuthValidatetokenGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthValidatetokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthValidatetokenResponse**](AuthValidatetokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

