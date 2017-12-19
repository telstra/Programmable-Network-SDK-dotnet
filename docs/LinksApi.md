# IO.TelstraTPN..LinksApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100InventoryLinkPost**](LinksApi.md#100inventorylinkpost) | **POST** /1.0.0/inventory/link | Create Link and initial Contract
[**100InventoryLinksByLinkidGet**](LinksApi.md#100inventorylinksbylinkidget) | **GET** /1.0.0/inventory/links/{linkid} | Get details of specified link
[**100InventoryLinksCustomerByCustomeruuidGet**](LinksApi.md#100inventorylinkscustomerbycustomeruuidget) | **GET** /1.0.0/inventory/links/customer/{customeruuid} | Get active Links
[**100InventoryLinksHistoryByLinkidGet**](LinksApi.md#100inventorylinkshistorybylinkidget) | **GET** /1.0.0/inventory/links/history/{linkid} | Get Link history


<a name="100inventorylinkpost"></a>
# **100InventoryLinkPost**
> Model100InventoryLinkResponse 100InventoryLinkPost (Model100InventoryLinkRequest body)

Create Link and initial Contract

Create Link and initial Contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryLinkPostExample
    {
        public void main()
        {
            
            var apiInstance = new LinksApi();
            var body = new Model100InventoryLinkRequest(); // Model100InventoryLinkRequest |  (optional) 

            try
            {
                // Create Link and initial Contract
                Model100InventoryLinkResponse result = apiInstance.100InventoryLinkPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.100InventoryLinkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model100InventoryLinkRequest**](Model100InventoryLinkRequest.md)|  | [optional] 

### Return type

[**Model100InventoryLinkResponse**](Model100InventoryLinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventorylinksbylinkidget"></a>
# **100InventoryLinksByLinkidGet**
> Model100InventoryLinksResponse 100InventoryLinksByLinkidGet (string linkid)

Get details of specified link

Get details of specified link

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryLinksByLinkidGetExample
    {
        public void main()
        {
            
            var apiInstance = new LinksApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link

            try
            {
                // Get details of specified link
                Model100InventoryLinksResponse result = apiInstance.100InventoryLinksByLinkidGet(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.100InventoryLinksByLinkidGet: " + e.Message );
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

[**Model100InventoryLinksResponse**](Model100InventoryLinksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventorylinkscustomerbycustomeruuidget"></a>
# **100InventoryLinksCustomerByCustomeruuidGet**
> List<Link> 100InventoryLinksCustomerByCustomeruuidGet (string customeruuid)

Get active Links

Get active Links

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryLinksCustomerByCustomeruuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new LinksApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // Get active Links
                List&lt;Link&gt; result = apiInstance.100InventoryLinksCustomerByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.100InventoryLinksCustomerByCustomeruuidGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventorylinkshistorybylinkidget"></a>
# **100InventoryLinksHistoryByLinkidGet**
> Model100InventoryLinksHistoryResponse 100InventoryLinksHistoryByLinkidGet (string linkid)

Get Link history

Get Link history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryLinksHistoryByLinkidGetExample
    {
        public void main()
        {
            
            var apiInstance = new LinksApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link

            try
            {
                // Get Link history
                Model100InventoryLinksHistoryResponse result = apiInstance.100InventoryLinksHistoryByLinkidGet(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.100InventoryLinksHistoryByLinkidGet: " + e.Message );
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

[**Model100InventoryLinksHistoryResponse**](Model100InventoryLinksHistoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

