# IO.TelstraTPN..VnfsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100MarketplaceImageGet**](VnfsApi.md#100marketplaceimageget) | **GET** /1.0.0/marketplace/image | List images in the Marketplace


<a name="100marketplaceimageget"></a>
# **100MarketplaceImageGet**
> Model100MarketplaceImageResponse 100MarketplaceImageGet ()

List images in the Marketplace

List images in the Marketplace

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class 100MarketplaceImageGetExample
    {
        public void main()
        {
            
            var apiInstance = new VnfsApi();

            try
            {
                // List images in the Marketplace
                Model100MarketplaceImageResponse result = apiInstance.100MarketplaceImageGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VnfsApi.100MarketplaceImageGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Model100MarketplaceImageResponse**](Model100MarketplaceImageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

