# IO.TelstraTPN..DatacentresApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListOfAllTheDataCenters**](DatacentresApi.md#getlistofallthedatacenters) | **GET** /1.0.0/inventory/datacenters | Get list of all the data centers


<a name="getlistofallthedatacenters"></a>
# **GetListOfAllTheDataCenters**
> List<Model100InventoryDatacentersResponse> GetListOfAllTheDataCenters ()

Get list of all the data centers

Get list of all the data centers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class GetListOfAllTheDataCentersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatacentresApi();

            try
            {
                // Get list of all the data centers
                List&lt;Model100InventoryDatacentersResponse&gt; result = apiInstance.GetListOfAllTheDataCenters();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatacentresApi.GetListOfAllTheDataCenters: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Model100InventoryDatacentersResponse>**](Model100InventoryDatacentersResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

