using System;
using System.Collections.Generic;
using RestSharp;
using IO.TelstraTPN;
using IO.TelstraTPN.Model;

namespace IO.TelstraTPN.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEndpointsApi
    {
        /// <summary>
        /// Assign a Topology Tag to an Endpoint Assign a Topology Tag to an Endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param>
        /// <param name="body"></param>
        /// <returns>List&lt;SuccessFragment&gt;</returns>
        List<SuccessFragment> Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body);
        /// <summary>
        /// Get information about the specified endpoint Get information about the specified endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param>
        /// <returns>InventoryEndpointResponse</returns>
        InventoryEndpointResponse InventoryEndpointByEndpointuuidGet (string endpointuuid);
        /// <summary>
        /// Get list of endpoints for a customer Get list of endpoints for a customer
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param>
        /// <returns>InventoryEndpointsCustomeruuidResponse</returns>
        InventoryEndpointsCustomeruuidResponse InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid);
        /// <summary>
        /// Create Physical (Port) Endpoint Create Physical (Port) Endpoint
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;InventoryRegularendpointResponse&gt;</returns>
        List<InventoryRegularendpointResponse> InventoryRegularendpointPost (InventoryRegularendpointRequest body);
        /// <summary>
        /// Create VNF Endpoint Create VNF Endpoint
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;InventoryVnfendpointResponse&gt;</returns>
        List<InventoryVnfendpointResponse> InventoryVnfendpointPost (InventoryVnfendpointRequest body);
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
        /// Assign a Topology Tag to an Endpoint Assign a Topology Tag to an Endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;SuccessFragment&gt;</returns>            
        public List<SuccessFragment> Eis100EndpointsAssignTopologyTagByEndpointuuidPost (string endpointuuid, Eis100EndpointsAssignTopologyTagRequest body)
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
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eis100EndpointsAssignTopologyTagByEndpointuuidPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eis100EndpointsAssignTopologyTagByEndpointuuidPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SuccessFragment>) ApiClient.Deserialize(response.Content, typeof(List<SuccessFragment>), response.Headers);
        }
    
        /// <summary>
        /// Get information about the specified endpoint Get information about the specified endpoint
        /// </summary>
        /// <param name="endpointuuid">Unique identifier representing a specific endpoint</param> 
        /// <returns>InventoryEndpointResponse</returns>            
        public InventoryEndpointResponse InventoryEndpointByEndpointuuidGet (string endpointuuid)
        {
            
            // verify the required parameter 'endpointuuid' is set
            if (endpointuuid == null) throw new ApiException(400, "Missing required parameter 'endpointuuid' when calling InventoryEndpointByEndpointuuidGet");
            
    
            var path = "/1.0.0/inventory/endpoint/{endpointuuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "endpointuuid" + "}", ApiClient.ParameterToString(endpointuuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryEndpointByEndpointuuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryEndpointByEndpointuuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InventoryEndpointResponse) ApiClient.Deserialize(response.Content, typeof(InventoryEndpointResponse), response.Headers);
        }
    
        /// <summary>
        /// Get list of endpoints for a customer Get list of endpoints for a customer
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param> 
        /// <returns>InventoryEndpointsCustomeruuidResponse</returns>            
        public InventoryEndpointsCustomeruuidResponse InventoryEndpointsCustomeruuidByCustomeruuidGet (string customeruuid)
        {
            
            // verify the required parameter 'customeruuid' is set
            if (customeruuid == null) throw new ApiException(400, "Missing required parameter 'customeruuid' when calling InventoryEndpointsCustomeruuidByCustomeruuidGet");
            
    
            var path = "/1.0.0/inventory/endpoints/customeruuid/{customeruuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customeruuid" + "}", ApiClient.ParameterToString(customeruuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryEndpointsCustomeruuidByCustomeruuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryEndpointsCustomeruuidByCustomeruuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InventoryEndpointsCustomeruuidResponse) ApiClient.Deserialize(response.Content, typeof(InventoryEndpointsCustomeruuidResponse), response.Headers);
        }
    
        /// <summary>
        /// Create Physical (Port) Endpoint Create Physical (Port) Endpoint
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>List&lt;InventoryRegularendpointResponse&gt;</returns>            
        public List<InventoryRegularendpointResponse> InventoryRegularendpointPost (InventoryRegularendpointRequest body)
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
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryRegularendpointPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryRegularendpointPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InventoryRegularendpointResponse>) ApiClient.Deserialize(response.Content, typeof(List<InventoryRegularendpointResponse>), response.Headers);
        }
    
        /// <summary>
        /// Create VNF Endpoint Create VNF Endpoint
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>List&lt;InventoryVnfendpointResponse&gt;</returns>            
        public List<InventoryVnfendpointResponse> InventoryVnfendpointPost (InventoryVnfendpointRequest body)
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
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryVnfendpointPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryVnfendpointPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InventoryVnfendpointResponse>) ApiClient.Deserialize(response.Content, typeof(List<InventoryVnfendpointResponse>), response.Headers);
        }
    
    }
}
