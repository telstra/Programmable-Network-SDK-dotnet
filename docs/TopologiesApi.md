# IO.TelstraTPN.Api.TopologiesApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Ttms100TopologyTagByTopotaguuidDelete**](TopologiesApi.md#ttms100topologytagbytopotaguuiddelete) | **DELETE** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Delete a topology tag
[**Ttms100TopologyTagByTopotaguuidGet**](TopologiesApi.md#ttms100topologytagbytopotaguuidget) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Get information about the specified topology tag
[**Ttms100TopologyTagByTopotaguuidPut**](TopologiesApi.md#ttms100topologytagbytopotaguuidput) | **PUT** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Update a topology tag&#39;s name and/or description
[**Ttms100TopologyTagGet**](TopologiesApi.md#ttms100topologytagget) | **GET** /ttms/1.0.0/topology_tag | List all topology tags
[**Ttms100TopologyTagObjectsByTopotaguuidGet**](TopologiesApi.md#ttms100topologytagobjectsbytopotaguuidget) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/objects/ | List objects for Topology
[**Ttms100TopologyTagPost**](TopologiesApi.md#ttms100topologytagpost) | **POST** /ttms/1.0.0/topology_tag | Create a named topology tag


<a name="ttms100topologytagbytopotaguuiddelete"></a>
# **Ttms100TopologyTagByTopotaguuidDelete**
> void Ttms100TopologyTagByTopotaguuidDelete (string topotaguuid)

Delete a topology tag

Delete a topology tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagByTopotaguuidDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag

            try
            {
                // Delete a topology tag
                apiInstance.Ttms100TopologyTagByTopotaguuidDelete(topotaguuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagByTopotaguuidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topotaguuid** | **string**| Unique identifier representing a specific topology tag | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ttms100topologytagbytopotaguuidget"></a>
# **Ttms100TopologyTagByTopotaguuidGet**
> Topology Ttms100TopologyTagByTopotaguuidGet (string topotaguuid)

Get information about the specified topology tag

Get information about the specified topology tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagByTopotaguuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag

            try
            {
                // Get information about the specified topology tag
                Topology result = apiInstance.Ttms100TopologyTagByTopotaguuidGet(topotaguuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagByTopotaguuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topotaguuid** | **string**| Unique identifier representing a specific topology tag | 

### Return type

[**Topology**](Topology.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ttms100topologytagbytopotaguuidput"></a>
# **Ttms100TopologyTagByTopotaguuidPut**
> Topology Ttms100TopologyTagByTopotaguuidPut (string topotaguuid, Ttms100TopologyTagRequest body)

Update a topology tag's name and/or description

Update a topology tag's name and/or description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagByTopotaguuidPutExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag
            var body = new Ttms100TopologyTagRequest(); // Ttms100TopologyTagRequest |  (optional) 

            try
            {
                // Update a topology tag's name and/or description
                Topology result = apiInstance.Ttms100TopologyTagByTopotaguuidPut(topotaguuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagByTopotaguuidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topotaguuid** | **string**| Unique identifier representing a specific topology tag | 
 **body** | [**Ttms100TopologyTagRequest**](Ttms100TopologyTagRequest.md)|  | [optional] 

### Return type

[**Topology**](Topology.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ttms100topologytagget"></a>
# **Ttms100TopologyTagGet**
> List<Topology> Ttms100TopologyTagGet ()

List all topology tags

List all topology tags

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagGetExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();

            try
            {
                // List all topology tags
                List&lt;Topology&gt; result = apiInstance.Ttms100TopologyTagGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Topology>**](Topology.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ttms100topologytagobjectsbytopotaguuidget"></a>
# **Ttms100TopologyTagObjectsByTopotaguuidGet**
> Ttms100TopologyTagObjectsResponse Ttms100TopologyTagObjectsByTopotaguuidGet (string topotaguuid)

List objects for Topology

List all objects (Endpoints, Links, VPorts, etc.) associated with the topology tag.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagObjectsByTopotaguuidGetExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag

            try
            {
                // List objects for Topology
                Ttms100TopologyTagObjectsResponse result = apiInstance.Ttms100TopologyTagObjectsByTopotaguuidGet(topotaguuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagObjectsByTopotaguuidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topotaguuid** | **string**| Unique identifier representing a specific topology tag | 

### Return type

[**Ttms100TopologyTagObjectsResponse**](Ttms100TopologyTagObjectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ttms100topologytagpost"></a>
# **Ttms100TopologyTagPost**
> Topology Ttms100TopologyTagPost (Ttms100TopologyTagRequest body)

Create a named topology tag

Create a named topology tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Ttms100TopologyTagPostExample
    {
        public void main()
        {
            
            var apiInstance = new TopologiesApi();
            var body = new Ttms100TopologyTagRequest(); // Ttms100TopologyTagRequest |  (optional) 

            try
            {
                // Create a named topology tag
                Topology result = apiInstance.Ttms100TopologyTagPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.Ttms100TopologyTagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Ttms100TopologyTagRequest**](Ttms100TopologyTagRequest.md)|  | [optional] 

### Return type

[**Topology**](Topology.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

