# IO.TelstraTPN..EndpointsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100InventoryEndpointByEndpointuuidGet**](EndpointsApi.md#100inventoryendpointbyendpointuuidget) | **GET** /1.0.0/inventory/endpoint/{endpointuuid} | Get information about the specified endpoint
[**100InventoryEndpointsCustomeruuidByCustomeruuidGet**](EndpointsApi.md#100inventoryendpointscustomeruuidbycustomeruuidget) | **GET** /1.0.0/inventory/endpoints/customeruuid/{customeruuid} | Get list of endpoints for a customer
[**100InventoryRegularendpointPost**](EndpointsApi.md#100inventoryregularendpointpost) | **POST** /1.0.0/inventory/regularendpoint | Create Physical (Port) Endpoint
[**100InventoryVnfendpointPost**](EndpointsApi.md#100inventoryvnfendpointpost) | **POST** /1.0.0/inventory/vnfendpoint | Create VNF Endpoint
[**Eis100EndpointsAssignTopologyTagByEndpointuuidPost**](EndpointsApi.md#eis100endpointsassigntopologytagbyendpointuuidpost) | **POST** /eis/1.0.0/endpoints/{endpointuuid}/assign_topology_tag | Assign a Topology Tag to an Endpoint


<a name="100inventoryendpointbyendpointuuidget"></a>
# **100InventoryEndpointByEndpointuuidGet**
> Model100InventoryEndpointResponse 100InventoryEndpointByEndpointuuidGet (string endpointuuid)

Get information about the specified endpoint

Get information about the specified endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryEndpointByEndpointuuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new EndpointsApi();
            var endpointuuid = endpointuuid_example;  // string | Unique identifier representing a specific endpoint

            try
            {
                // Get information about the specified endpoint
                Model100InventoryEndpointResponse result = apiInstance.100InventoryEndpointByEndpointuuidGet(endpointuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.100InventoryEndpointByEndpointuuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endpointuuid** | **string**| Unique identifier representing a specific endpoint | 

### Return type

[**Model100InventoryEndpointResponse**](Model100InventoryEndpointResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventoryendpointscustomeruuidbycustomeruuidget"></a>
# **100InventoryEndpointsCustomeruuidByCustomeruuidGet**
> Model100InventoryEndpointsCustomeruuidResponse 100InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid)

Get list of endpoints for a customer

Get list of endpoints for a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryEndpointsCustomeruuidByCustomeruuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new EndpointsApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // Get list of endpoints for a customer
                Model100InventoryEndpointsCustomeruuidResponse result = apiInstance.100InventoryEndpointsCustomeruuidByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.100InventoryEndpointsCustomeruuidByCustomeruuidGet: " + e.Message );
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

[**Model100InventoryEndpointsCustomeruuidResponse**](Model100InventoryEndpointsCustomeruuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventoryregularendpointpost"></a>
# **100InventoryRegularendpointPost**
> Model100InventoryRegularendpointResponse 100InventoryRegularendpointPost (Model100InventoryRegularendpointRequest body)

Create Physical (Port) Endpoint

Create Physical (Port) Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryRegularendpointPostExample
    {
        public void main()
        {
            
            var apiInstance = new EndpointsApi();
            var body = new Model100InventoryRegularendpointRequest(); // Model100InventoryRegularendpointRequest |  (optional) 

            try
            {
                // Create Physical (Port) Endpoint
                Model100InventoryRegularendpointResponse result = apiInstance.100InventoryRegularendpointPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.100InventoryRegularendpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model100InventoryRegularendpointRequest**](Model100InventoryRegularendpointRequest.md)|  | [optional] 

### Return type

[**Model100InventoryRegularendpointResponse**](Model100InventoryRegularendpointResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventoryvnfendpointpost"></a>
# **100InventoryVnfendpointPost**
> Model100InventoryVnfendpointResponse 100InventoryVnfendpointPost (Model100InventoryVnfendpointRequest body)

Create VNF Endpoint

Create VNF Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100InventoryVnfendpointPostExample
    {
        public void main()
        {
            
            var apiInstance = new EndpointsApi();
            var body = new Model100InventoryVnfendpointRequest(); // Model100InventoryVnfendpointRequest |  (optional) 

            try
            {
                // Create VNF Endpoint
                Model100InventoryVnfendpointResponse result = apiInstance.100InventoryVnfendpointPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.100InventoryVnfendpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model100InventoryVnfendpointRequest**](Model100InventoryVnfendpointRequest.md)|  | [optional] 

### Return type

[**Model100InventoryVnfendpointResponse**](Model100InventoryVnfendpointResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eis100endpointsassigntopologytagbyendpointuuidpost"></a>
# **Eis100EndpointsAssignTopologyTagByEndpointuuidPost**
> SuccessFragment Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body)

Assign a Topology Tag to an Endpoint

Assign a Topology Tag to an Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Eis100EndpointsAssignTopologyTagByEndpointuuidPostExample
    {
        public void main()
        {
            
            var apiInstance = new EndpointsApi();
            var endpointuuid = endpointuuid_example;  // string | Unique identifier representing a specific endpoint
            var body = new Eis100EndpointsAssignTopologyTagRequest(); // Eis100EndpointsAssignTopologyTagRequest |  (optional) 

            try
            {
                // Assign a Topology Tag to an Endpoint
                SuccessFragment result = apiInstance.Eis100EndpointsAssignTopologyTagByEndpointuuidPost(endpointuuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.Eis100EndpointsAssignTopologyTagByEndpointuuidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endpointuuid** | **string**| Unique identifier representing a specific endpoint | 
 **body** | [**Eis100EndpointsAssignTopologyTagRequest**](Eis100EndpointsAssignTopologyTagRequest.md)|  | [optional] 

### Return type

[**SuccessFragment**](SuccessFragment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

