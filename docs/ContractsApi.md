# IO.TelstraTPN..ContractsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewContractOnSpecifiedLink**](ContractsApi.md#createnewcontractonspecifiedlink) | **POST** /1.0.0/inventory/links/{linkid}/contract | Create new Contract on specified link
[**GetActiveContractByContractID**](ContractsApi.md#getactivecontractbycontractid) | **GET** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Get active Contract by ContractID
[**UpdateActiveContractByContractID**](ContractsApi.md#updateactivecontractbycontractid) | **PUT** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Update active Contract by ContractID


<a name="createnewcontractonspecifiedlink"></a>
# **CreateNewContractOnSpecifiedLink**
> Model100InventoryLinksContractResponse36 CreateNewContractOnSpecifiedLink (string linkid, Model100InventoryLinksContractRequest35 body)

Create new Contract on specified link

Create new Contract on specified link

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class CreateNewContractOnSpecifiedLinkExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var body = new Model100InventoryLinksContractRequest35(); // Model100InventoryLinksContractRequest35 |  (optional) 

            try
            {
                // Create new Contract on specified link
                Model100InventoryLinksContractResponse36 result = apiInstance.CreateNewContractOnSpecifiedLink(linkid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.CreateNewContractOnSpecifiedLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 
 **body** | [**Model100InventoryLinksContractRequest35**](Model100InventoryLinksContractRequest35.md)|  | [optional] 

### Return type

[**Model100InventoryLinksContractResponse36**](Model100InventoryLinksContractResponse36.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivecontractbycontractid"></a>
# **GetActiveContractByContractID**
> Model100InventoryLinksContractResponse GetActiveContractByContractID (string linkid, string contractid)

Get active Contract by ContractID

Get active Contract by ContractID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class GetActiveContractByContractIDExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var contractid = contractid_example;  // string | Unique identifier representing a specific contract

            try
            {
                // Get active Contract by ContractID
                Model100InventoryLinksContractResponse result = apiInstance.GetActiveContractByContractID(linkid, contractid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetActiveContractByContractID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 
 **contractid** | **string**| Unique identifier representing a specific contract | 

### Return type

[**Model100InventoryLinksContractResponse**](Model100InventoryLinksContractResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivecontractbycontractid"></a>
# **UpdateActiveContractByContractID**
> Model100InventoryLinksContractResponse31 UpdateActiveContractByContractID (string linkid, string contractid, Model100InventoryLinksContractRequest body)

Update active Contract by ContractID

Update active Contract by ContractID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class UpdateActiveContractByContractIDExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var contractid = contractid_example;  // string | Unique identifier representing a specific contract
            var body = new Model100InventoryLinksContractRequest(); // Model100InventoryLinksContractRequest |  (optional) 

            try
            {
                // Update active Contract by ContractID
                Model100InventoryLinksContractResponse31 result = apiInstance.UpdateActiveContractByContractID(linkid, contractid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.UpdateActiveContractByContractID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 
 **contractid** | **string**| Unique identifier representing a specific contract | 
 **body** | [**Model100InventoryLinksContractRequest**](Model100InventoryLinksContractRequest.md)|  | [optional] 

### Return type

[**Model100InventoryLinksContractResponse31**](Model100InventoryLinksContractResponse31.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

