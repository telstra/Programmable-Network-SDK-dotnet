# IO.TelstraTPN.Api.EndpointsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Eis100EndpointsAssignTopologyTagByEndpointuuidPost**](EndpointsApi.md#eis100endpointsassigntopologytagbyendpointuuidpost) | **POST** /eis/1.0.0/endpoints/{endpointuuid}/assign_topology_tag | Assign a Topology Tag to an Endpoint
[**InventoryEndpointByEndpointuuidGet**](EndpointsApi.md#inventoryendpointbyendpointuuidget) | **GET** /1.0.0/inventory/endpoint/{endpointuuid} | Get information about the specified endpoint
[**InventoryEndpointsCustomeruuidByCustomeruuidGet**](EndpointsApi.md#inventoryendpointscustomeruuidbycustomeruuidget) | **GET** /1.0.0/inventory/endpoints/customeruuid/{customeruuid} | Get list of endpoints for a customer
[**InventoryRegularendpointPost**](EndpointsApi.md#inventoryregularendpointpost) | **POST** /1.0.0/inventory/regularendpoint | Create Physical (Port) Endpoint
[**InventoryVnfendpointPost**](EndpointsApi.md#inventoryvnfendpointpost) | **POST** /1.0.0/inventory/vnfendpoint | Create VNF Endpoint


<a name="eis100endpointsassigntopologytagbyendpointuuidpost"></a>
# **Eis100EndpointsAssignTopologyTagByEndpointuuidPost**
> List<SuccessFragment> Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body)

Assign a Topology Tag to an Endpoint

Assign a Topology Tag to an Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Eis100EndpointsAssignTopologyTagByEndpointuuidPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var endpointuuid = endpointuuid_example;  // string | Unique identifier representing a specific endpoint
            var body = new Eis100EndpointsAssignTopologyTagRequest(); // Eis100EndpointsAssignTopologyTagRequest |  (optional) 

            try
            {
                // Assign a Topology Tag to an Endpoint
                List&lt;SuccessFragment&gt; result = apiInstance.Eis100EndpointsAssignTopologyTagByEndpointuuidPost(endpointuuid, body);
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

[**List<SuccessFragment>**](SuccessFragment.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryendpointbyendpointuuidget"></a>
# **InventoryEndpointByEndpointuuidGet**
> InventoryEndpointResponse InventoryEndpointByEndpointuuidGet (string endpointuuid)

Get information about the specified endpoint

Get information about the specified endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryEndpointByEndpointuuidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var endpointuuid = endpointuuid_example;  // string | Unique identifier representing a specific endpoint

            try
            {
                // Get information about the specified endpoint
                InventoryEndpointResponse result = apiInstance.InventoryEndpointByEndpointuuidGet(endpointuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.InventoryEndpointByEndpointuuidGet: " + e.Message );
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

[**InventoryEndpointResponse**](InventoryEndpointResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryendpointscustomeruuidbycustomeruuidget"></a>
# **InventoryEndpointsCustomeruuidByCustomeruuidGet**
> InventoryEndpointsCustomeruuidResponse InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid)

Get list of endpoints for a customer

Get list of endpoints for a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryEndpointsCustomeruuidByCustomeruuidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var customeruuid = customeruuid_example;  // string | Unique identifier representing a specific customer

            try
            {
                // Get list of endpoints for a customer
                InventoryEndpointsCustomeruuidResponse result = apiInstance.InventoryEndpointsCustomeruuidByCustomeruuidGet(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.InventoryEndpointsCustomeruuidByCustomeruuidGet: " + e.Message );
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

[**InventoryEndpointsCustomeruuidResponse**](InventoryEndpointsCustomeruuidResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryregularendpointpost"></a>
# **InventoryRegularendpointPost**
> List<InventoryRegularendpointResponse> InventoryRegularendpointPost (InventoryRegularendpointRequest body)

Create Physical (Port) Endpoint

Create Physical (Port) Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryRegularendpointPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var body = new InventoryRegularendpointRequest(); // InventoryRegularendpointRequest |  (optional) 

            try
            {
                // Create Physical (Port) Endpoint
                List&lt;InventoryRegularendpointResponse&gt; result = apiInstance.InventoryRegularendpointPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.InventoryRegularendpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryRegularendpointRequest**](InventoryRegularendpointRequest.md)|  | [optional] 

### Return type

[**List<InventoryRegularendpointResponse>**](InventoryRegularendpointResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryvnfendpointpost"></a>
# **InventoryVnfendpointPost**
> List<InventoryVnfendpointResponse> InventoryVnfendpointPost (InventoryVnfendpointRequest body)

Create VNF Endpoint

Create VNF Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryVnfendpointPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var body = new InventoryVnfendpointRequest(); // InventoryVnfendpointRequest |  (optional) 

            try
            {
                // Create VNF Endpoint
                List&lt;InventoryVnfendpointResponse&gt; result = apiInstance.InventoryVnfendpointPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.InventoryVnfendpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryVnfendpointRequest**](InventoryVnfendpointRequest.md)|  | [optional] 

### Return type

[**List<InventoryVnfendpointResponse>**](InventoryVnfendpointResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

