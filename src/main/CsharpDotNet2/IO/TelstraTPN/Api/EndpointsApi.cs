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
    public interface IEndpointsApi
    {
        /// <summary>
        /// Get information about the specified endpoint Get information about the specified endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param>
        /// <returns>Model100InventoryEndpointResponse</returns>
        Model100InventoryEndpointResponse 100InventoryEndpointByEndpointuuidGet (string endpointuuid);
        /// <summary>
        /// Get list of endpoints for a customer Get list of endpoints for a customer
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param>
        /// <returns>Model100InventoryEndpointsCustomeruuidResponse</returns>
        Model100InventoryEndpointsCustomeruuidResponse 100InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid);
        /// <summary>
        /// Create Physical (Port) Endpoint Create Physical (Port) Endpoint
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Model100InventoryRegularendpointResponse</returns>
        Model100InventoryRegularendpointResponse 100InventoryRegularendpointPost (Model100InventoryRegularendpointRequest body);
        /// <summary>
        /// Create VNF Endpoint Create VNF Endpoint
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Model100InventoryVnfendpointResponse</returns>
        Model100InventoryVnfendpointResponse 100InventoryVnfendpointPost (Model100InventoryVnfendpointRequest body);
        /// <summary>
        /// Assign a Topology Tag to an Endpoint Assign a Topology Tag to an Endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param>
        /// <param name="body"></param>
        /// <returns>SuccessFragment</returns>
        SuccessFragment Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EndpointsApi : IEndpointsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EndpointsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EndpointsApi(String basePath)
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
        /// Get information about the specified endpoint Get information about the specified endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param> 
        /// <returns>Model100InventoryEndpointResponse</returns>            
        public Model100InventoryEndpointResponse 100InventoryEndpointByEndpointuuidGet (string endpointuuid)
        {
            
            // verify the required parameter 'endpointuuid' is set
            if (endpointuuid == null) throw new ApiException(400, "Missing required parameter 'endpointuuid' when calling 100InventoryEndpointByEndpointuuidGet");
            
    
            var path = "/1.0.0/inventory/endpoint/{endpointuuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "endpointuuid" + "}", ApiClient.ParameterToString(endpointuuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryEndpointByEndpointuuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryEndpointByEndpointuuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryEndpointResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryEndpointResponse), response.Headers);
        }
    
        /// <summary>
        /// Get list of endpoints for a customer Get list of endpoints for a customer
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param> 
        /// <returns>Model100InventoryEndpointsCustomeruuidResponse</returns>            
        public Model100InventoryEndpointsCustomeruuidResponse 100InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid)
        {
            
            // verify the required parameter 'customeruuid' is set
            if (customeruuid == null) throw new ApiException(400, "Missing required parameter 'customeruuid' when calling 100InventoryEndpointsCustomeruuidByCustomeruuidGet");
            
    
            var path = "/1.0.0/inventory/endpoints/customeruuid/{customeruuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customeruuid" + "}", ApiClient.ParameterToString(customeruuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryEndpointsCustomeruuidByCustomeruuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryEndpointsCustomeruuidByCustomeruuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryEndpointsCustomeruuidResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryEndpointsCustomeruuidResponse), response.Headers);
        }
    
        /// <summary>
        /// Create Physical (Port) Endpoint Create Physical (Port) Endpoint
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Model100InventoryRegularendpointResponse</returns>            
        public Model100InventoryRegularendpointResponse 100InventoryRegularendpointPost (Model100InventoryRegularendpointRequest body)
        {
            
    
            var path = "/1.0.0/inventory/regularendpoint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryRegularendpointPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryRegularendpointPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryRegularendpointResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryRegularendpointResponse), response.Headers);
        }
    
        /// <summary>
        /// Create VNF Endpoint Create VNF Endpoint
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Model100InventoryVnfendpointResponse</returns>            
        public Model100InventoryVnfendpointResponse 100InventoryVnfendpointPost (Model100InventoryVnfendpointRequest body)
        {
            
    
            var path = "/1.0.0/inventory/vnfendpoint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryVnfendpointPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryVnfendpointPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryVnfendpointResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryVnfendpointResponse), response.Headers);
        }
    
        /// <summary>
        /// Assign a Topology Tag to an Endpoint Assign a Topology Tag to an Endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param> 
        /// <param name="body"></param> 
        /// <returns>SuccessFragment</returns>            
        public SuccessFragment Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body)
        {
            
            // verify the required parameter 'endpointuuid' is set
            if (endpointuuid == null) throw new ApiException(400, "Missing required parameter 'endpointuuid' when calling Eis100EndpointsAssignTopologyTagByEndpointuuidPost");
            
    
            var path = "/eis/1.0.0/endpoints/{endpointuuid}/assign_topology_tag";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "endpointuuid" + "}", ApiClient.ParameterToString(endpointuuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eis100EndpointsAssignTopologyTagByEndpointuuidPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eis100EndpointsAssignTopologyTagByEndpointuuidPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SuccessFragment) ApiClient.Deserialize(response.Content, typeof(SuccessFragment), response.Headers);
        }
    
    }
}
