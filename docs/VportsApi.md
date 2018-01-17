# IO.TelstraTPN.Api.VportsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryRegularvportPost**](VportsApi.md#inventoryregularvportpost) | **POST** /1.0.0/inventory/regularvport | Create VPort for physical endpoint
[**InventoryVnfVportPost**](VportsApi.md#inventoryvnfvportpost) | **POST** /1.0.0/inventory/vnf/vport | Create VNF VPort
[**InventoryVportByVportuuidGet**](VportsApi.md#inventoryvportbyvportuuidget) | **GET** /1.0.0/inventory/vport/{vportuuid} | Get information about the specified VPort


<a name="inventoryregularvportpost"></a>
# **InventoryRegularvportPost**
> InventoryRegularvportResponse InventoryRegularvportPost (InventoryRegularvportRequest body)

Create VPort for physical endpoint

Create VPort representing a VLAN on a Physical Ethernet Port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryRegularvportPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VportsApi();
            var body = new InventoryRegularvportRequest(); // InventoryRegularvportRequest |  (optional) 

            try
            {
                // Create VPort for physical endpoint
                InventoryRegularvportResponse result = apiInstance.InventoryRegularvportPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.InventoryRegularvportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryRegularvportRequest**](InventoryRegularvportRequest.md)|  | [optional] 

### Return type

[**InventoryRegularvportResponse**](InventoryRegularvportResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryvnfvportpost"></a>
# **InventoryVnfVportPost**
> InventoryVnfVportResponse InventoryVnfVportPost (InventoryVnfVportRequest body)

Create VNF VPort

Create VNF VPort

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryVnfVportPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VportsApi();
            var body = new InventoryVnfVportRequest(); // InventoryVnfVportRequest |  (optional) 

            try
            {
                // Create VNF VPort
                InventoryVnfVportResponse result = apiInstance.InventoryVnfVportPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.InventoryVnfVportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryVnfVportRequest**](InventoryVnfVportRequest.md)|  | [optional] 

### Return type

[**InventoryVnfVportResponse**](InventoryVnfVportResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryvportbyvportuuidget"></a>
# **InventoryVportByVportuuidGet**
> List<EndpointPort> InventoryVportByVportuuidGet (string vportuuid)

Get information about the specified VPort

Get information about the specified VPort

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryVportByVportuuidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VportsApi();
            var vportuuid = vportuuid_example;  // string | Unique identifier representing a specific virtual port

            try
            {
                // Get information about the specified VPort
                List&lt;EndpointPort&gt; result = apiInstance.InventoryVportByVportuuidGet(vportuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.InventoryVportByVportuuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vportuuid** | **string**| Unique identifier representing a specific virtual port | 

### Return type

[**List<EndpointPort>**](EndpointPort.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

