# IO.TelstraTPN..EndpointsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePhysicalPortEndpoint**](EndpointsApi.md#createphysicalportendpoint) | **POST** /1.0.0/inventory/regularendpoint | Create Physical (Port) Endpoint
[**CreateVNFEndpoint**](EndpointsApi.md#createvnfendpoint) | **POST** /1.0.0/inventory/vnfendpoint | Create VNF Endpoint
[**GetInformationAboutTheSpecifiedEndpoint**](EndpointsApi.md#getinformationaboutthespecifiedendpoint) | **GET** /1.0.0/inventory/endpoint/{endpointuuid} | Get information about the specified endpoint
[**GetListOfEndpointsForACustomer**](EndpointsApi.md#getlistofendpointsforacustomer) | **GET** /1.0.0/inventory/endpoints/customeruuid/{customeruuid} | Get list of endpoints for a customer


<a name="createphysicalportendpoint"></a>
# **CreatePhysicalPortEndpoint**
> Model100InventoryRegularendpointResponse CreatePhysicalPortEndpoint (Model100InventoryRegularendpointRequest body)

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
    public class CreatePhysicalPortEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var body = new Model100InventoryRegularendpointRequest(); // Model100InventoryRegularendpointRequest |  (optional) 

            try
            {
                // Create Physical (Port) Endpoint
                Model100InventoryRegularendpointResponse result = apiInstance.CreatePhysicalPortEndpoint(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.CreatePhysicalPortEndpoint: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvnfendpoint"></a>
# **CreateVNFEndpoint**
> Model100InventoryVnfendpointResponse CreateVNFEndpoint (Model100InventoryVnfendpointRequest body)

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
    public class CreateVNFEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi();
            var body = new Model100InventoryVnfendpointRequest(); // Model100InventoryVnfendpointRequest |  (optional) 

            try
            {
                // Create VNF Endpoint
                Model100InventoryVnfendpointResponse result = apiInstance.CreateVNFEndpoint(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.CreateVNFEndpoint: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinformationaboutthespecifiedendpoint"></a>
# **GetInformationAboutTheSpecifiedEndpoint**
> Model100InventoryEndpointResponse GetInformationAboutTheSpecifiedEndpoint (string endpointuuid)

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
    public class GetInformationAboutTheSpecifiedEndpointExample
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
                Model100InventoryEndpointResponse result = apiInstance.GetInformationAboutTheSpecifiedEndpoint(endpointuuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetInformationAboutTheSpecifiedEndpoint: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistofendpointsforacustomer"></a>
# **GetListOfEndpointsForACustomer**
> Model100InventoryEndpointsCustomeruuidResponse GetListOfEndpointsForACustomer (string customeruuid)

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
    public class GetListOfEndpointsForACustomerExample
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
                Model100InventoryEndpointsCustomeruuidResponse result = apiInstance.GetListOfEndpointsForACustomer(customeruuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetListOfEndpointsForACustomer: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

