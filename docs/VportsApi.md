# IO.TelstraTPN..VportsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVNFVPort**](VportsApi.md#createvnfvport) | **POST** /1.0.0/inventory/vnf/vport | Create VNF VPort
[**CreateVPortForPhysicalEndpoint**](VportsApi.md#createvportforphysicalendpoint) | **POST** /1.0.0/inventory/regularvport | Create VPort for physical endpoint
[**GetInformationAboutTheSpecifiedVPort**](VportsApi.md#getinformationaboutthespecifiedvport) | **GET** /1.0.0/inventory/vport/{vportuuid} | Get information about the specified VPort


<a name="createvnfvport"></a>
# **CreateVNFVPort**
> Model100InventoryVnfVportResponse CreateVNFVPort (Model100InventoryVnfVportRequest body)

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
    public class CreateVNFVPortExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VportsApi();
            var body = new Model100InventoryVnfVportRequest(); // Model100InventoryVnfVportRequest |  (optional) 

            try
            {
                // Create VNF VPort
                Model100InventoryVnfVportResponse result = apiInstance.CreateVNFVPort(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.CreateVNFVPort: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvportforphysicalendpoint"></a>
# **CreateVPortForPhysicalEndpoint**
> Model100InventoryRegularvportResponse CreateVPortForPhysicalEndpoint (Model100InventoryRegularvportRequest body)

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
    public class CreateVPortForPhysicalEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VportsApi();
            var body = new Model100InventoryRegularvportRequest(); // Model100InventoryRegularvportRequest |  (optional) 

            try
            {
                // Create VPort for physical endpoint
                Model100InventoryRegularvportResponse result = apiInstance.CreateVPortForPhysicalEndpoint(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.CreateVPortForPhysicalEndpoint: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinformationaboutthespecifiedvport"></a>
# **GetInformationAboutTheSpecifiedVPort**
> EndpointPort GetInformationAboutTheSpecifiedVPort (string vportuuid)

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
    public class GetInformationAboutTheSpecifiedVPortExample
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
                EndpointPort result = apiInstance.GetInformationAboutTheSpecifiedVPort(vportuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VportsApi.GetInformationAboutTheSpecifiedVPort: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

