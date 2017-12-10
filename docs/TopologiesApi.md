# IO.TelstraTPN..TopologiesApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateANamedTopologyTag**](TopologiesApi.md#createanamedtopologytag) | **POST** /ttms/1.0.0/topology_tag | Create a named topology tag
[**GetInformationAboutTheSpecifiedTopologyTag**](TopologiesApi.md#getinformationaboutthespecifiedtopologytag) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Get information about the specified topology tag
[**ListAllTopologyTags**](TopologiesApi.md#listalltopologytags) | **GET** /ttms/1.0.0/topology_tag | List all topology tags
[**ListObjectsForTopology**](TopologiesApi.md#listobjectsfortopology) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/objects/ | List objects for Topology


<a name="createanamedtopologytag"></a>
# **CreateANamedTopologyTag**
> Topology CreateANamedTopologyTag (Ttms100TopologyTagRequest body)

Create a named topology tag

Create a named topology tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class CreateANamedTopologyTagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopologiesApi();
            var body = new Ttms100TopologyTagRequest(); // Ttms100TopologyTagRequest |  (optional) 

            try
            {
                // Create a named topology tag
                Topology result = apiInstance.CreateANamedTopologyTag(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.CreateANamedTopologyTag: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinformationaboutthespecifiedtopologytag"></a>
# **GetInformationAboutTheSpecifiedTopologyTag**
> Topology GetInformationAboutTheSpecifiedTopologyTag (string topotaguuid)

Get information about the specified topology tag

Get information about the specified topology tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class GetInformationAboutTheSpecifiedTopologyTagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag

            try
            {
                // Get information about the specified topology tag
                Topology result = apiInstance.GetInformationAboutTheSpecifiedTopologyTag(topotaguuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.GetInformationAboutTheSpecifiedTopologyTag: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalltopologytags"></a>
# **ListAllTopologyTags**
> List<Topology> ListAllTopologyTags ()

List all topology tags

List all topology tags

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class ListAllTopologyTagsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopologiesApi();

            try
            {
                // List all topology tags
                List&lt;Topology&gt; result = apiInstance.ListAllTopologyTags();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.ListAllTopologyTags: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listobjectsfortopology"></a>
# **ListObjectsForTopology**
> Ttms100TopologyTagObjectsResponse ListObjectsForTopology (string topotaguuid)

List objects for Topology

List all objects (Endpoints, Links, VPorts, etc.) associated with the topology tag.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class ListObjectsForTopologyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopologiesApi();
            var topotaguuid = topotaguuid_example;  // string | Unique identifier representing a specific topology tag

            try
            {
                // List objects for Topology
                Ttms100TopologyTagObjectsResponse result = apiInstance.ListObjectsForTopology(topotaguuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TopologiesApi.ListObjectsForTopology: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

