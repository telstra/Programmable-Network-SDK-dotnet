# IO.TelstraTPN..VnfsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListImagesInTheMarketplace**](VnfsApi.md#listimagesinthemarketplace) | **GET** /1.0.0/marketplace/image | List images in the Marketplace


<a name="listimagesinthemarketplace"></a>
# **ListImagesInTheMarketplace**
> Model100MarketplaceImageResponse ListImagesInTheMarketplace ()

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
    public class ListImagesInTheMarketplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VnfsApi();

            try
            {
                // List images in the Marketplace
                Model100MarketplaceImageResponse result = apiInstance.ListImagesInTheMarketplace();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VnfsApi.ListImagesInTheMarketplace: " + e.Message );
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

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

