# IO.TelstraTPN..LinksApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLinkAndInitialContract**](LinksApi.md#createlinkandinitialcontract) | **POST** /1.0.0/inventory/link | Create Link and initial Contract
[**GetActiveLinks**](LinksApi.md#getactivelinks) | **GET** /1.0.0/inventory/links/customer/{customeruuid} | Get active Links
[**GetDetailsOfSpecifiedLink**](LinksApi.md#getdetailsofspecifiedlink) | **GET** /1.0.0/inventory/links/{linkid} | Get details of specified link
[**GetLinkHistory**](LinksApi.md#getlinkhistory) | **GET** /1.0.0/inventory/links/history/{linkid} | Get Link history


<a name="createlinkandinitialcontract"></a>
# **CreateLinkAndInitialContract**
> Model100InventoryLinkResponse CreateLinkAndInitialContract (Model100InventoryLinkRequest body)

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
    public class CreateLinkAndInitialContractExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi();
            var body = new Model100InventoryLinkRequest(); // Model100InventoryLinkRequest |  (optional) 

            try
            {
                // Create Link and initial Contract
                Model100InventoryLinkResponse result = apiInstance.CreateLinkAndInitialContract(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.CreateLinkAndInitialContract: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivelinks"></a>
# **GetActiveLinks**
> List<Link> GetActiveLinks (string customeruuid)

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
    public class GetActiveLinksExample
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
                List&lt;Link&gt; result = apiInstance.GetActiveLinks(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.GetActiveLinks: " + e.Message );
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

<a name="getdetailsofspecifiedlink"></a>
# **GetDetailsOfSpecifiedLink**
> Model100InventoryLinksResponse GetDetailsOfSpecifiedLink (string linkid)

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
    public class GetDetailsOfSpecifiedLinkExample
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
                Model100InventoryLinksResponse result = apiInstance.GetDetailsOfSpecifiedLink(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.GetDetailsOfSpecifiedLink: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkhistory"></a>
# **GetLinkHistory**
> Model100InventoryLinksHistoryResponse GetLinkHistory (string linkid)

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
    public class GetLinkHistoryExample
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
                Model100InventoryLinksHistoryResponse result = apiInstance.GetLinkHistory(linkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinksApi.GetLinkHistory: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

