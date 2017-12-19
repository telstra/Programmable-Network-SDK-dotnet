# IO.TelstraTPN..VportsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100InventoryRegularvportPost**](VportsApi.md#100inventoryregularvportpost) | **POST** /1.0.0/inventory/regularvport | Create VPort for physical endpoint
[**100InventoryVnfVportPost**](VportsApi.md#100inventoryvnfvportpost) | **POST** /1.0.0/inventory/vnf/vport | Create VNF VPort
[**100InventoryVportByVportuuidGet**](VportsApi.md#100inventoryvportbyvportuuidget) | **GET** /1.0.0/inventory/vport/{vportuuid} | Get information about the specified VPort


<a name="100inventoryregularvportpost"></a>
# **100InventoryRegularvportPost**
> Model100InventoryRegularvportResponse 100InventoryRegularvportPost (Model100InventoryRegularvportRequest body)

Create VPort for physical endpoint

Create VPort representing a VLAN on a Physical Ethernet Port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryRegularvportPostExample
    {
        public void main()
        {
            
            var apiInstance = new VportsApi();
            var body = new Model100InventoryRegularvportRequest(); // Model100InventoryRegularvportRequest |  (optional) 

            try
            {
                // Create VPort for physical endpoint
                Model100InventoryRegularvportResponse result = apiInstance.100InventoryRegularvportPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.100InventoryRegularvportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model100InventoryRegularvportRequest**](Model100InventoryRegularvportRequest.md)|  | [optional] 

### Return type

[**Model100InventoryRegularvportResponse**](Model100InventoryRegularvportResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventoryvnfvportpost"></a>
# **100InventoryVnfVportPost**
> Model100InventoryVnfVportResponse 100InventoryVnfVportPost (Model100InventoryVnfVportRequest body)

Create VNF VPort

Create VNF VPort

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryVnfVportPostExample
    {
        public void main()
        {
            
            var apiInstance = new VportsApi();
            var body = new Model100InventoryVnfVportRequest(); // Model100InventoryVnfVportRequest |  (optional) 

            try
            {
                // Create VNF VPort
                Model100InventoryVnfVportResponse result = apiInstance.100InventoryVnfVportPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.100InventoryVnfVportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model100InventoryVnfVportRequest**](Model100InventoryVnfVportRequest.md)|  | [optional] 

### Return type

[**Model100InventoryVnfVportResponse**](Model100InventoryVnfVportResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventoryvportbyvportuuidget"></a>
# **100InventoryVportByVportuuidGet**
> EndpointPort 100InventoryVportByVportuuidGet (string vportuuid)

Get information about the specified VPort

Get information about the specified VPort

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryVportByVportuuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new VportsApi();
            var vportuuid = vportuuid_example;  // string | Unique identifier representing a specific virtual port

            try
            {
                // Get information about the specified VPort
                EndpointPort result = apiInstance.100InventoryVportByVportuuidGet(vportuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.100InventoryVportByVportuuidGet: " + e.Message );
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

[**EndpointPort**](EndpointPort.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

