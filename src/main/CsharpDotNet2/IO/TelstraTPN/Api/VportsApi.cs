using System;
using System.Collections.Generic;
using RestSharp;
using IO.TelstraTPN.Client;
using IO.TelstraTPN.Model;

namespace IO.TelstraTPN.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVportsApi
    {
        /// <summary>
        /// Create VNF VPort Create VNF VPort
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Model100InventoryVnfVportResponse</returns>
        Model100InventoryVnfVportResponse CreateVNFVPort (Model100InventoryVnfVportRequest body);
        /// <summary>
        /// Create VPort for physical endpoint Create VPort representing a VLAN on a Physical Ethernet Port
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Model100InventoryRegularvportResponse</returns>
        Model100InventoryRegularvportResponse CreateVPortForPhysicalEndpoint (Model100InventoryRegularvportRequest body);
        /// <summary>
        /// Get information about the specified VPort Get information about the specified VPort
        /// </summary>
        /// <param name="vportuuid">Unique identifier representing a specific virtual port</param>
        /// <returns>EndpointPort</returns>
        EndpointPort GetInformationAboutTheSpecifiedVPort (string vportuuid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VportsApi : IVportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VportsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Create VNF VPort Create VNF VPort
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Model100InventoryVnfVportResponse</returns>            
        public Model100InventoryVnfVportResponse CreateVNFVPort (Model100InventoryVnfVportRequest body)
        {
            
    
            var path = "/1.0.0/inventory/vnf/vport";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVNFVPort: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVNFVPort: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryVnfVportResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryVnfVportResponse), response.Headers);
        }
    
        /// <summary>
        /// Create VPort for physical endpoint Create VPort representing a VLAN on a Physical Ethernet Port
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Model100InventoryRegularvportResponse</returns>            
        public Model100InventoryRegularvportResponse CreateVPortForPhysicalEndpoint (Model100InventoryRegularvportRequest body)
        {
            
    
            var path = "/1.0.0/inventory/regularvport";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVPortForPhysicalEndpoint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVPortForPhysicalEndpoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryRegularvportResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryRegularvportResponse), response.Headers);
        }
    
        /// <summary>
        /// Get information about the specified VPort Get information about the specified VPort
        /// </summary>
        /// <param name="vportuuid">Unique identifier representing a specific virtual port</param> 
        /// <returns>EndpointPort</returns>            
        public EndpointPort GetInformationAboutTheSpecifiedVPort (string vportuuid)
        {
            
            // verify the required parameter 'vportuuid' is set
            if (vportuuid == null) throw new ApiException(400, "Missing required parameter 'vportuuid' when calling GetInformationAboutTheSpecifiedVPort");
            
    
            var path = "/1.0.0/inventory/vport/{vportuuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "vportuuid" + "}", ApiClient.ParameterToString(vportuuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInformationAboutTheSpecifiedVPort: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInformationAboutTheSpecifiedVPort: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EndpointPort) ApiClient.Deserialize(response.Content, typeof(EndpointPort), response.Headers);
        }
    
    }
}
