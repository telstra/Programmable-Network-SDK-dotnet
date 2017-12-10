# IO.TelstraTPN - the C# library for the Telstra Programmable Network API

Telstra Programmable Network is a self-provisioning platform that allows its users to create on-demand connectivity services between multiple end-points and add various network functions to those services. Programmable Network enables to connectivity to a global ecosystem of networking services as well as public and private cloud services. Once you are connected to the platform on one or more POPs (points of presence), you can start creating those services based on the use case that you want to accomplish. The Programmable Network API is available to all customers who have registered to use the Programmable Network. To register, please contact your account representative.

- API version: 2.1.2
- SDK version: 1.0.0
- Build date: 2017-11-30T09:20:51.331+11:00

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.TelstraTPN.IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.IO.TelstraTPN.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi();
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string | 

            try
            {
                // Create an authentication token
                Model100AuthGeneratetokenResponse result = apiInstance.CreateAnAuthenticationToken(grantType, username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.CreateAnAuthenticationToken: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://penapi.pacnetconnect.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**CreateAnAuthenticationToken**](docs/AuthenticationApi.md#createanauthenticationtoken) | **POST** /1.0.0/auth/generatetoken | Create an authentication token
*AuthenticationApi* | [**ValidateAuthenticationToken**](docs/AuthenticationApi.md#validateauthenticationtoken) | **GET** /1.0.0/auth/validatetoken | Validate authentication token
*ContractsApi* | [**CreateNewContractOnSpecifiedLink**](docs/ContractsApi.md#createnewcontractonspecifiedlink) | **POST** /1.0.0/inventory/links/{linkid}/contract | Create new Contract on specified link
*ContractsApi* | [**GetActiveContractByContractID**](docs/ContractsApi.md#getactivecontractbycontractid) | **GET** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Get active Contract by ContractID
*ContractsApi* | [**UpdateActiveContractByContractID**](docs/ContractsApi.md#updateactivecontractbycontractid) | **PUT** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Update active Contract by ContractID
*CustomersApi* | [**GetAccountInformationDetails**](docs/CustomersApi.md#getaccountinformationdetails) | **GET** /1.0.0/account/{customeruuid} | Get account information details
*CustomersApi* | [**ListUsers**](docs/CustomersApi.md#listusers) | **GET** /1.0.0/account/{customeruuid}/user | List users
*DatacentresApi* | [**GetListOfAllTheDataCenters**](docs/DatacentresApi.md#getlistofallthedatacenters) | **GET** /1.0.0/inventory/datacenters | Get list of all the data centers
*EndpointsApi* | [**CreatePhysicalPortEndpoint**](docs/EndpointsApi.md#createphysicalportendpoint) | **POST** /1.0.0/inventory/regularendpoint | Create Physical (Port) Endpoint
*EndpointsApi* | [**CreateVNFEndpoint**](docs/EndpointsApi.md#createvnfendpoint) | **POST** /1.0.0/inventory/vnfendpoint | Create VNF Endpoint
*EndpointsApi* | [**GetInformationAboutTheSpecifiedEndpoint**](docs/EndpointsApi.md#getinformationaboutthespecifiedendpoint) | **GET** /1.0.0/inventory/endpoint/{endpointuuid} | Get information about the specified endpoint
*EndpointsApi* | [**GetListOfEndpointsForACustomer**](docs/EndpointsApi.md#getlistofendpointsforacustomer) | **GET** /1.0.0/inventory/endpoints/customeruuid/{customeruuid} | Get list of endpoints for a customer
*LinksApi* | [**CreateLinkAndInitialContract**](docs/LinksApi.md#createlinkandinitialcontract) | **POST** /1.0.0/inventory/link | Create Link and initial Contract
*LinksApi* | [**GetActiveLinks**](docs/LinksApi.md#getactivelinks) | **GET** /1.0.0/inventory/links/customer/{customeruuid} | Get active Links
*LinksApi* | [**GetDetailsOfSpecifiedLink**](docs/LinksApi.md#getdetailsofspecifiedlink) | **GET** /1.0.0/inventory/links/{linkid} | Get details of specified link
*LinksApi* | [**GetLinkHistory**](docs/LinksApi.md#getlinkhistory) | **GET** /1.0.0/inventory/links/history/{linkid} | Get Link history
*TopologiesApi* | [**CreateANamedTopologyTag**](docs/TopologiesApi.md#createanamedtopologytag) | **POST** /ttms/1.0.0/topology_tag | Create a named topology tag
*TopologiesApi* | [**GetInformationAboutTheSpecifiedTopologyTag**](docs/TopologiesApi.md#getinformationaboutthespecifiedtopologytag) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Get information about the specified topology tag
*TopologiesApi* | [**ListAllTopologyTags**](docs/TopologiesApi.md#listalltopologytags) | **GET** /ttms/1.0.0/topology_tag | List all topology tags
*TopologiesApi* | [**ListObjectsForTopology**](docs/TopologiesApi.md#listobjectsfortopology) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/objects/ | List objects for Topology
*VnfsApi* | [**ListImagesInTheMarketplace**](docs/VnfsApi.md#listimagesinthemarketplace) | **GET** /1.0.0/marketplace/image | List images in the Marketplace
*VportsApi* | [**CreateVNFVPort**](docs/VportsApi.md#createvnfvport) | **POST** /1.0.0/inventory/vnf/vport | Create VNF VPort
*VportsApi* | [**CreateVPortForPhysicalEndpoint**](docs/VportsApi.md#createvportforphysicalendpoint) | **POST** /1.0.0/inventory/regularvport | Create VPort for physical endpoint
*VportsApi* | [**GetInformationAboutTheSpecifiedVPort**](docs/VportsApi.md#getinformationaboutthespecifiedvport) | **GET** /1.0.0/inventory/vport/{vportuuid} | Get information about the specified VPort


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.TelstraTPN.Model.Billing](docs/Billing.md)
 - [IO.TelstraTPN.Model.Classification](docs/Classification.md)
 - [IO.TelstraTPN.Model.Contract](docs/Contract.md)
 - [IO.TelstraTPN.Model.Datacenter](docs/Datacenter.md)
 - [IO.TelstraTPN.Model.Endpoint](docs/Endpoint.md)
 - [IO.TelstraTPN.Model.EndpointPort](docs/EndpointPort.md)
 - [IO.TelstraTPN.Model.Endpointlist](docs/Endpointlist.md)
 - [IO.TelstraTPN.Model.Error](docs/Error.md)
 - [IO.TelstraTPN.Model.Error70](docs/Error70.md)
 - [IO.TelstraTPN.Model.Flavor](docs/Flavor.md)
 - [IO.TelstraTPN.Model.GlanceImage](docs/GlanceImage.md)
 - [IO.TelstraTPN.Model.Link](docs/Link.md)
 - [IO.TelstraTPN.Model.Link62](docs/Link62.md)
 - [IO.TelstraTPN.Model.Meta](docs/Meta.md)
 - [IO.TelstraTPN.Model.Model100AccountResponse](docs/Model100AccountResponse.md)
 - [IO.TelstraTPN.Model.Model100AuthGeneratetokenResponse](docs/Model100AuthGeneratetokenResponse.md)
 - [IO.TelstraTPN.Model.Model100AuthValidatetokenResponse](docs/Model100AuthValidatetokenResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryDatacenters401Error](docs/Model100InventoryDatacenters401Error.md)
 - [IO.TelstraTPN.Model.Model100InventoryDatacentersResponse](docs/Model100InventoryDatacentersResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryEndpointResponse](docs/Model100InventoryEndpointResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryEndpointsCustomeruuidResponse](docs/Model100InventoryEndpointsCustomeruuidResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinkRequest](docs/Model100InventoryLinkRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinkResponse](docs/Model100InventoryLinkResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksContractRequest](docs/Model100InventoryLinksContractRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksContractRequest35](docs/Model100InventoryLinksContractRequest35.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksContractResponse](docs/Model100InventoryLinksContractResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksContractResponse31](docs/Model100InventoryLinksContractResponse31.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksContractResponse36](docs/Model100InventoryLinksContractResponse36.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksHistoryResponse](docs/Model100InventoryLinksHistoryResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryLinksResponse](docs/Model100InventoryLinksResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryRegularendpointRequest](docs/Model100InventoryRegularendpointRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryRegularendpointResponse](docs/Model100InventoryRegularendpointResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryRegularvportRequest](docs/Model100InventoryRegularvportRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryRegularvportResponse](docs/Model100InventoryRegularvportResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryVnfVportRequest](docs/Model100InventoryVnfVportRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryVnfVportResponse](docs/Model100InventoryVnfVportResponse.md)
 - [IO.TelstraTPN.Model.Model100InventoryVnfendpointRequest](docs/Model100InventoryVnfendpointRequest.md)
 - [IO.TelstraTPN.Model.Model100InventoryVnfendpointResponse](docs/Model100InventoryVnfendpointResponse.md)
 - [IO.TelstraTPN.Model.Model100MarketplaceImageResponse](docs/Model100MarketplaceImageResponse.md)
 - [IO.TelstraTPN.Model.ModelParams](docs/ModelParams.md)
 - [IO.TelstraTPN.Model.Object50](docs/Object50.md)
 - [IO.TelstraTPN.Model.Params29](docs/Params29.md)
 - [IO.TelstraTPN.Model.Params32](docs/Params32.md)
 - [IO.TelstraTPN.Model.Params37](docs/Params37.md)
 - [IO.TelstraTPN.Model.Product](docs/Product.md)
 - [IO.TelstraTPN.Model.Role](docs/Role.md)
 - [IO.TelstraTPN.Model.SuccessFragment](docs/SuccessFragment.md)
 - [IO.TelstraTPN.Model.Topology](docs/Topology.md)
 - [IO.TelstraTPN.Model.Ttms100TopologyTagObjectsResponse](docs/Ttms100TopologyTagObjectsResponse.md)
 - [IO.TelstraTPN.Model.Ttms100TopologyTagRequest](docs/Ttms100TopologyTagRequest.md)
 - [IO.TelstraTPN.Model.User](docs/User.md)
 - [IO.TelstraTPN.Model.Vlan](docs/Vlan.md)
 - [IO.TelstraTPN.Model.VnfTag](docs/VnfTag.md)
 - [IO.TelstraTPN.Model.Vport](docs/Vport.md)
 - [IO.TelstraTPN.Model.Vportvalue](docs/Vportvalue.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="auth"></a>
### auth

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A

