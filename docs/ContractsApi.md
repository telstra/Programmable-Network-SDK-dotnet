# IO.TelstraTPN..ContractsApi

All URIs are relative to *https://penapi.pacnetconnect.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**100InventoryLinksContractByLinkidAndContractidGet**](ContractsApi.md#100inventorylinkscontractbylinkidandcontractidget) | **GET** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Get active Contract by ContractID
[**100InventoryLinksContractByLinkidAndContractidPut**](ContractsApi.md#100inventorylinkscontractbylinkidandcontractidput) | **PUT** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Update active Contract by ContractID
[**100InventoryLinksContractByLinkidPost**](ContractsApi.md#100inventorylinkscontractbylinkidpost) | **POST** /1.0.0/inventory/links/{linkid}/contract | Create new Contract on specified link


<a name="100inventorylinkscontractbylinkidandcontractidget"></a>
# **100InventoryLinksContractByLinkidAndContractidGet**
> Model100InventoryLinksContractResponse 100InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid)

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
    public class 100InventoryLinksContractByLinkidAndContractidGetExample
    {
        public void main()
        {
            
            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var contractid = contractid_example;  // string | Unique identifier representing a specific contract

            try
            {
                // Get active Contract by ContractID
                Model100InventoryLinksContractResponse result = apiInstance.100InventoryLinksContractByLinkidAndContractidGet(linkid, contractid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.100InventoryLinksContractByLinkidAndContractidGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventorylinkscontractbylinkidandcontractidput"></a>
# **100InventoryLinksContractByLinkidAndContractidPut**
> Model100InventoryLinksContractResponse33 100InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, Model100InventoryLinksContractRequest body)

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
    public class 100InventoryLinksContractByLinkidAndContractidPutExample
    {
        public void main()
        {
            
            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var contractid = contractid_example;  // string | Unique identifier representing a specific contract
            var body = new Model100InventoryLinksContractRequest(); // Model100InventoryLinksContractRequest |  (optional) 

            try
            {
                // Update active Contract by ContractID
                Model100InventoryLinksContractResponse33 result = apiInstance.100InventoryLinksContractByLinkidAndContractidPut(linkid, contractid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.100InventoryLinksContractByLinkidAndContractidPut: " + e.Message );
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

[**Model100InventoryLinksContractResponse33**](Model100InventoryLinksContractResponse33.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="100inventorylinkscontractbylinkidpost"></a>
# **100InventoryLinksContractByLinkidPost**
> Model100InventoryLinksContractResponse38 100InventoryLinksContractByLinkidPost (string linkid, Model100InventoryLinksContractRequest37 body)

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
    public class 100InventoryLinksContractByLinkidPostExample
    {
        public void main()
        {
            
            var apiInstance = new ContractsApi();
            var linkid = linkid_example;  // string | Unique identifier representing a specific link
            var body = new Model100InventoryLinksContractRequest37(); // Model100InventoryLinksContractRequest37 |  (optional) 

            try
            {
                // Create new Contract on specified link
                Model100InventoryLinksContractResponse38 result = apiInstance.100InventoryLinksContractByLinkidPost(linkid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.100InventoryLinksContractByLinkidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkid** | **string**| Unique identifier representing a specific link | 
 **body** | [**Model100InventoryLinksContractRequest37**](Model100InventoryLinksContractRequest37.md)|  | [optional] 

### Return type

[**Model100InventoryLinksContractResponse38**](Model100InventoryLinksContractResponse38.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

