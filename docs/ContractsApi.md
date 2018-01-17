# IO.TelstraTPN.Api.ContractsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryLinksContractByLinkidAndContractidGet**](ContractsApi.md#inventorylinkscontractbylinkidandcontractidget) | **GET** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Get active Contract by ContractID
[**InventoryLinksContractByLinkidAndContractidPut**](ContractsApi.md#inventorylinkscontractbylinkidandcontractidput) | **PUT** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Update active Contract by ContractID
[**InventoryLinksContractByLinkidPost**](ContractsApi.md#inventorylinkscontractbylinkidpost) | **POST** /1.0.0/inventory/links/{linkid}/contract | Create new Contract on specified link


<a name="inventorylinkscontractbylinkidandcontractidget"></a>
# **InventoryLinksContractByLinkidAndContractidGet**
> InventoryLinksContractResponse InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid)

Get active Contract by ContractID

Get active Contract by ContractID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksContractByLinkidAndContractidGetExample
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
                InventoryLinksContractResponse result = apiInstance.InventoryLinksContractByLinkidAndContractidGet(linkid, contractid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.InventoryLinksContractByLinkidAndContractidGet: " + e.Message );
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

[**InventoryLinksContractResponse**](InventoryLinksContractResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkscontractbylinkidandcontractidput"></a>
# **InventoryLinksContractByLinkidAndContractidPut**
> InventoryLinksContractResponse33 InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, InventoryLinksContractRequest body)

Update active Contract by ContractID

Update active Contract by ContractID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksContractByLinkidAndContractidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var contractid = contractid_example;  // string | Unique identifier representing a specific contract
            var body = new InventoryLinksContractRequest(); // InventoryLinksContractRequest |  (optional) 

            try
            {
                // Update active Contract by ContractID
                InventoryLinksContractResponse33 result = apiInstance.InventoryLinksContractByLinkidAndContractidPut(linkid, contractid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.InventoryLinksContractByLinkidAndContractidPut: " + e.Message );
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
 **body** | [**InventoryLinksContractRequest**](InventoryLinksContractRequest.md)|  | [optional] 

### Return type

[**InventoryLinksContractResponse33**](InventoryLinksContractResponse33.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkscontractbylinkidpost"></a>
# **InventoryLinksContractByLinkidPost**
> List<InventoryLinksContractResponse38> InventoryLinksContractByLinkidPost (string linkid, InventoryLinksContractRequest37 body)

Create new Contract on specified link

Create new Contract on specified link

### Example
```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class InventoryLinksContractByLinkidPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var body = new InventoryLinksContractRequest37(); // InventoryLinksContractRequest37 |  (optional) 

            try
            {
                // Create new Contract on specified link
                List&lt;InventoryLinksContractResponse38&gt; result = apiInstance.InventoryLinksContractByLinkidPost(linkid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.InventoryLinksContractByLinkidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 
 **body** | [**InventoryLinksContractRequest37**](InventoryLinksContractRequest37.md)|  | [optional] 

### Return type

[**List<InventoryLinksContractResponse38>**](InventoryLinksContractResponse38.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

