# IO.TelstraTPN..DatacentresApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100InventoryDatacentersGet**](DatacentresApi.md#100inventorydatacentersget) | **GET** /1.0.0/inventory/datacenters | Get list of all the data centers


<a name="100inventorydatacentersget"></a>
# **100InventoryDatacentersGet**
> List<Model100InventoryDatacentersResponse> 100InventoryDatacentersGet ()

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
    public class 100InventoryDatacentersGetExample
    {
        public void main()
        {
            
            var apiInstance = new DatacentresApi();

            try
            {
                // Get list of all the data centers
                List&lt;Model100InventoryDatacentersResponse&gt; result = apiInstance.100InventoryDatacentersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatacentresApi.100InventoryDatacentersGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

