# IO.TelstraTPN..CustomersApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100AccountByCustomeruuidGet**](CustomersApi.md#100accountbycustomeruuidget) | **GET** /1.0.0/account/{customeruuid} | Get account information details
[**100AccountUserByCustomeruuidGet**](CustomersApi.md#100accountuserbycustomeruuidget) | **GET** /1.0.0/account/{customeruuid}/user | List users


<a name="100accountbycustomeruuidget"></a>
# **100AccountByCustomeruuidGet**
> Model100AccountResponse 100AccountByCustomeruuidGet (string customeruuid)

Get account information details

Get the account information for the specified customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100AccountByCustomeruuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // Get account information details
                Model100AccountResponse result = apiInstance.100AccountByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.100AccountByCustomeruuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customeruuid** | **string**| Unique identifier representing a specific customer | 

### Return type

[**Model100AccountResponse**](Model100AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100accountuserbycustomeruuidget"></a>
# **100AccountUserByCustomeruuidGet**
> List<User> 100AccountUserByCustomeruuidGet (string customeruuid)

List users

List all users associated with the specified customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100AccountUserByCustomeruuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // List users
                List&lt;User&gt; result = apiInstance.100AccountUserByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.100AccountUserByCustomeruuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customeruuid** | **string**| Unique identifier representing a specific customer | 

### Return type

[**List<User>**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

