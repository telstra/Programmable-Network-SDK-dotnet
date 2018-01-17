# IO.TelstraTPN.Api.LinksApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryLinkPost**](LinksApi.md#inventorylinkpost) | **POST** /1.0.0/inventory/link | Create Link and initial Contract
[**InventoryLinksByLinkidGet**](LinksApi.md#inventorylinksbylinkidget) | **GET** /1.0.0/inventory/links/{linkid} | Get details of specified link
[**InventoryLinksCustomerByCustomeruuidGet**](LinksApi.md#inventorylinkscustomerbycustomeruuidget) | **GET** /1.0.0/inventory/links/customer/{customeruuid} | Get active Links
[**InventoryLinksHistoryByLinkidGet**](LinksApi.md#inventorylinkshistorybylinkidget) | **GET** /1.0.0/inventory/links/history/{linkid} | Get Link history


<a name="inventorylinkpost"></a>
# **InventoryLinkPost**
> InventoryLinkResponse InventoryLinkPost (InventoryLinkRequest body)

Create Link and initial Contract

Create Link and initial Contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinkPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi();
            var body = new InventoryLinkRequest(); // InventoryLinkRequest |  (optional) 

            try
            {
                // Create Link and initial Contract
                InventoryLinkResponse result = apiInstance.InventoryLinkPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.InventoryLinkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryLinkRequest**](InventoryLinkRequest.md)|  | [optional] 

### Return type

[**InventoryLinkResponse**](InventoryLinkResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinksbylinkidget"></a>
# **InventoryLinksByLinkidGet**
> InventoryLinksResponse InventoryLinksByLinkidGet (string linkid)

Get details of specified link

Get details of specified link

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksByLinkidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link

            try
            {
                // Get details of specified link
                InventoryLinksResponse result = apiInstance.InventoryLinksByLinkidGet(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.InventoryLinksByLinkidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 

### Return type

[**InventoryLinksResponse**](InventoryLinksResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkscustomerbycustomeruuidget"></a>
# **InventoryLinksCustomerByCustomeruuidGet**
> List<Link> InventoryLinksCustomerByCustomeruuidGet (string customeruuid)

Get active Links

Get active Links

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksCustomerByCustomeruuidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // Get active Links
                List&lt;Link&gt; result = apiInstance.InventoryLinksCustomerByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.InventoryLinksCustomerByCustomeruuidGet: " + e.Message );
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

[**List<Link>**](Link.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkshistorybylinkidget"></a>
# **InventoryLinksHistoryByLinkidGet**
> InventoryLinksHistoryResponse InventoryLinksHistoryByLinkidGet (string linkid)

Get Link history

Get Link history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksHistoryByLinkidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link

            try
            {
                // Get Link history
                InventoryLinksHistoryResponse result = apiInstance.InventoryLinksHistoryByLinkidGet(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.InventoryLinksHistoryByLinkidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 

### Return type

[**InventoryLinksHistoryResponse**](InventoryLinksHistoryResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

