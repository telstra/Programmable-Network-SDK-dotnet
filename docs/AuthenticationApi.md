# IO.TelstraTPN..AuthenticationApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100AuthGeneratetokenPost**](AuthenticationApi.md#100authgeneratetokenpost) | **POST** /1.0.0/auth/generatetoken | Create an authentication token
[**100AuthValidatetokenGet**](AuthenticationApi.md#100authvalidatetokenget) | **GET** /1.0.0/auth/validatetoken | Validate authentication token


<a name="100authgeneratetokenpost"></a>
# **100AuthGeneratetokenPost**
> Model100AuthGeneratetokenResponse 100AuthGeneratetokenPost (string grantType, string username, string password)

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
    public class 100AuthGeneratetokenPostExample
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
                Model100AuthGeneratetokenResponse result = apiInstance.100AuthGeneratetokenPost(grantType, username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.100AuthGeneratetokenPost: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100authvalidatetokenget"></a>
# **100AuthValidatetokenGet**
> Model100AuthValidatetokenResponse 100AuthValidatetokenGet ()

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
    public class 100AuthValidatetokenGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // Validate authentication token
                Model100AuthValidatetokenResponse result = apiInstance.100AuthValidatetokenGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.100AuthValidatetokenGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

