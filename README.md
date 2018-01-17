# Telstra Programmable Network

Telstra Programmable Network is a self-provisioning platform that allows its users to create on-demand connectivity services between multiple end-points and add various network functions to those services. Programmable Network enables to connectivity to a global ecosystem of networking services as well as public and private cloud services. Once you are connected to the platform on one or more POPs (points of presence), you can start creating those services based on the use case that you want to accomplish. The Programmable Network API is available to all customers who have registered to use the Programmable Network. To register, please contact your account representative.

- API version: 2.1.3
- SDK version: 1.0.0
- Build date: 2018-01-17T21:50:14.739+11:00

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
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.TelstraTPN.Api;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string | 

            try
            {
                // Create an authentication token
                AuthGeneratetokenResponse result = apiInstance.AuthGeneratetokenPost(grantType, username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthGeneratetokenPost: " + e.Message );
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
*AuthenticationApi* | [**AuthGeneratetokenPost**](docs/AuthenticationApi.md#authgeneratetokenpost) | **POST** /1.0.0/auth/generatetoken | Create an authentication token
*AuthenticationApi* | [**AuthValidatetokenGet**](docs/AuthenticationApi.md#authvalidatetokenget) | **GET** /1.0.0/auth/validatetoken | Validate authentication token
*ContractsApi* | [**InventoryLinksContractByLinkidAndContractidGet**](docs/ContractsApi.md#inventorylinkscontractbylinkidandcontractidget) | **GET** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Get active Contract by ContractID
*ContractsApi* | [**InventoryLinksContractByLinkidAndContractidPut**](docs/ContractsApi.md#inventorylinkscontractbylinkidandcontractidput) | **PUT** /1.0.0/inventory/links/{linkid}/contract/{contractid} | Update active Contract by ContractID
*ContractsApi* | [**InventoryLinksContractByLinkidPost**](docs/ContractsApi.md#inventorylinkscontractbylinkidpost) | **POST** /1.0.0/inventory/links/{linkid}/contract | Create new Contract on specified link
*CustomersApi* | [**AccountByCustomeruuidGet**](docs/CustomersApi.md#accountbycustomeruuidget) | **GET** /1.0.0/account/{customeruuid} | Get account information details
*CustomersApi* | [**AccountUserByCustomeruuidGet**](docs/CustomersApi.md#accountuserbycustomeruuidget) | **GET** /1.0.0/account/{customeruuid}/user | List users
*DatacentresApi* | [**InventoryDatacentersGet**](docs/DatacentresApi.md#inventorydatacentersget) | **GET** /1.0.0/inventory/datacenters | Get list of all the data centers
*EndpointsApi* | [**Eis100EndpointsAssignTopologyTagByEndpointuuidPost**](docs/EndpointsApi.md#eis100endpointsassigntopologytagbyendpointuuidpost) | **POST** /eis/1.0.0/endpoints/{endpointuuid}/assign_topology_tag | Assign a Topology Tag to an Endpoint
*EndpointsApi* | [**InventoryEndpointByEndpointuuidGet**](docs/EndpointsApi.md#inventoryendpointbyendpointuuidget) | **GET** /1.0.0/inventory/endpoint/{endpointuuid} | Get information about the specified endpoint
*EndpointsApi* | [**InventoryEndpointsCustomeruuidByCustomeruuidGet**](docs/EndpointsApi.md#inventoryendpointscustomeruuidbycustomeruuidget) | **GET** /1.0.0/inventory/endpoints/customeruuid/{customeruuid} | Get list of endpoints for a customer
*EndpointsApi* | [**InventoryRegularendpointPost**](docs/EndpointsApi.md#inventoryregularendpointpost) | **POST** /1.0.0/inventory/regularendpoint | Create Physical (Port) Endpoint
*EndpointsApi* | [**InventoryVnfendpointPost**](docs/EndpointsApi.md#inventoryvnfendpointpost) | **POST** /1.0.0/inventory/vnfendpoint | Create VNF Endpoint
*LinksApi* | [**InventoryLinkPost**](docs/LinksApi.md#inventorylinkpost) | **POST** /1.0.0/inventory/link | Create Link and initial Contract
*LinksApi* | [**InventoryLinksByLinkidGet**](docs/LinksApi.md#inventorylinksbylinkidget) | **GET** /1.0.0/inventory/links/{linkid} | Get details of specified link
*LinksApi* | [**InventoryLinksCustomerByCustomeruuidGet**](docs/LinksApi.md#inventorylinkscustomerbycustomeruuidget) | **GET** /1.0.0/inventory/links/customer/{customeruuid} | Get active Links
*LinksApi* | [**InventoryLinksHistoryByLinkidGet**](docs/LinksApi.md#inventorylinkshistorybylinkidget) | **GET** /1.0.0/inventory/links/history/{linkid} | Get Link history
*TopologiesApi* | [**Ttms100TopologyTagByTopotaguuidDelete**](docs/TopologiesApi.md#ttms100topologytagbytopotaguuiddelete) | **DELETE** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Delete a topology tag
*TopologiesApi* | [**Ttms100TopologyTagByTopotaguuidGet**](docs/TopologiesApi.md#ttms100topologytagbytopotaguuidget) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Get information about the specified topology tag
*TopologiesApi* | [**Ttms100TopologyTagByTopotaguuidPut**](docs/TopologiesApi.md#ttms100topologytagbytopotaguuidput) | **PUT** /ttms/1.0.0/topology_tag/{topotaguuid}/ | Update a topology tag's name and/or description
*TopologiesApi* | [**Ttms100TopologyTagGet**](docs/TopologiesApi.md#ttms100topologytagget) | **GET** /ttms/1.0.0/topology_tag | List all topology tags
*TopologiesApi* | [**Ttms100TopologyTagObjectsByTopotaguuidGet**](docs/TopologiesApi.md#ttms100topologytagobjectsbytopotaguuidget) | **GET** /ttms/1.0.0/topology_tag/{topotaguuid}/objects/ | List objects for Topology
*TopologiesApi* | [**Ttms100TopologyTagPost**](docs/TopologiesApi.md#ttms100topologytagpost) | **POST** /ttms/1.0.0/topology_tag | Create a named topology tag
*VnfsApi* | [**MarketplaceImageGet**](docs/VnfsApi.md#marketplaceimageget) | **GET** /1.0.0/marketplace/image | List images in the Marketplace
*VportsApi* | [**InventoryRegularvportPost**](docs/VportsApi.md#inventoryregularvportpost) | **POST** /1.0.0/inventory/regularvport | Create VPort for physical endpoint
*VportsApi* | [**InventoryVnfVportPost**](docs/VportsApi.md#inventoryvnfvportpost) | **POST** /1.0.0/inventory/vnf/vport | Create VNF VPort
*VportsApi* | [**InventoryVportByVportuuidGet**](docs/VportsApi.md#inventoryvportbyvportuuidget) | **GET** /1.0.0/inventory/vport/{vportuuid} | Get information about the specified VPort


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.TelstraTPN.Model.AccountResponse](docs/AccountResponse.md)
 - [IO.TelstraTPN.Model.AuthGeneratetokenResponse](docs/AuthGeneratetokenResponse.md)
 - [IO.TelstraTPN.Model.AuthValidatetokenResponse](docs/AuthValidatetokenResponse.md)
 - [IO.TelstraTPN.Model.Billing](docs/Billing.md)
 - [IO.TelstraTPN.Model.Classification](docs/Classification.md)
 - [IO.TelstraTPN.Model.Contract](docs/Contract.md)
 - [IO.TelstraTPN.Model.Datacenter](docs/Datacenter.md)
 - [IO.TelstraTPN.Model.Eis100EndpointsAssignTopologyTagRequest](docs/Eis100EndpointsAssignTopologyTagRequest.md)
 - [IO.TelstraTPN.Model.Endpoint](docs/Endpoint.md)
 - [IO.TelstraTPN.Model.EndpointPort](docs/EndpointPort.md)
 - [IO.TelstraTPN.Model.Endpointlist](docs/Endpointlist.md)
 - [IO.TelstraTPN.Model.Error](docs/Error.md)
 - [IO.TelstraTPN.Model.Error74](docs/Error74.md)
 - [IO.TelstraTPN.Model.Flavor](docs/Flavor.md)
 - [IO.TelstraTPN.Model.GlanceImage](docs/GlanceImage.md)
 - [IO.TelstraTPN.Model.InventoryDatacenters401Error](docs/InventoryDatacenters401Error.md)
 - [IO.TelstraTPN.Model.InventoryDatacentersResponse](docs/InventoryDatacentersResponse.md)
 - [IO.TelstraTPN.Model.InventoryEndpointResponse](docs/InventoryEndpointResponse.md)
 - [IO.TelstraTPN.Model.InventoryEndpointsCustomeruuidResponse](docs/InventoryEndpointsCustomeruuidResponse.md)
 - [IO.TelstraTPN.Model.InventoryLinkRequest](docs/InventoryLinkRequest.md)
 - [IO.TelstraTPN.Model.InventoryLinkResponse](docs/InventoryLinkResponse.md)
 - [IO.TelstraTPN.Model.InventoryLinksContractRequest](docs/InventoryLinksContractRequest.md)
 - [IO.TelstraTPN.Model.InventoryLinksContractRequest37](docs/InventoryLinksContractRequest37.md)
 - [IO.TelstraTPN.Model.InventoryLinksContractResponse](docs/InventoryLinksContractResponse.md)
 - [IO.TelstraTPN.Model.InventoryLinksContractResponse33](docs/InventoryLinksContractResponse33.md)
 - [IO.TelstraTPN.Model.InventoryLinksContractResponse38](docs/InventoryLinksContractResponse38.md)
 - [IO.TelstraTPN.Model.InventoryLinksHistoryResponse](docs/InventoryLinksHistoryResponse.md)
 - [IO.TelstraTPN.Model.InventoryLinksResponse](docs/InventoryLinksResponse.md)
 - [IO.TelstraTPN.Model.InventoryRegularendpointRequest](docs/InventoryRegularendpointRequest.md)
 - [IO.TelstraTPN.Model.InventoryRegularendpointResponse](docs/InventoryRegularendpointResponse.md)
 - [IO.TelstraTPN.Model.InventoryRegularvportRequest](docs/InventoryRegularvportRequest.md)
 - [IO.TelstraTPN.Model.InventoryRegularvportResponse](docs/InventoryRegularvportResponse.md)
 - [IO.TelstraTPN.Model.InventoryVnfVportRequest](docs/InventoryVnfVportRequest.md)
 - [IO.TelstraTPN.Model.InventoryVnfVportResponse](docs/InventoryVnfVportResponse.md)
 - [IO.TelstraTPN.Model.InventoryVnfendpointRequest](docs/InventoryVnfendpointRequest.md)
 - [IO.TelstraTPN.Model.InventoryVnfendpointResponse](docs/InventoryVnfendpointResponse.md)
 - [IO.TelstraTPN.Model.Link](docs/Link.md)
 - [IO.TelstraTPN.Model.Link66](docs/Link66.md)
 - [IO.TelstraTPN.Model.MarketplaceImageResponse](docs/MarketplaceImageResponse.md)
 - [IO.TelstraTPN.Model.Meta](docs/Meta.md)
 - [IO.TelstraTPN.Model.ModelParams](docs/ModelParams.md)
 - [IO.TelstraTPN.Model.Object52](docs/Object52.md)
 - [IO.TelstraTPN.Model.Params31](docs/Params31.md)
 - [IO.TelstraTPN.Model.Params34](docs/Params34.md)
 - [IO.TelstraTPN.Model.Params39](docs/Params39.md)
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
- **Scopes**: 
  - Oauth2: Oauth2

