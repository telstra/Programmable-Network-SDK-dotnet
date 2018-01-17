# IO.TelstraTPN.Api.VnfsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarketplaceImageGet**](VnfsApi.md#marketplaceimageget) | **GET** /1.0.0/marketplace/image | List images in the Marketplace


<a name="marketplaceimageget"></a>
# **MarketplaceImageGet**
> MarketplaceImageResponse MarketplaceImageGet ()

List images in the Marketplace

List images in the Marketplace

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class MarketplaceImageGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VnfsApi();

            try
            {
                // List images in the Marketplace
                MarketplaceImageResponse result = apiInstance.MarketplaceImageGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VnfsApi.MarketplaceImageGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MarketplaceImageResponse**](MarketplaceImageResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

