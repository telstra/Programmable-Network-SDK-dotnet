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
    public interface ITopologiesApi
    {
        /// <summary>
        /// Delete a topology tag Delete a topology tag
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param>
        /// <returns></returns>
        void Ttms100TopologyTagByTopotaguuidDelete (string topotaguuid);
        /// <summary>
        /// Get information about the specified topology tag Get information about the specified topology tag
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param>
        /// <returns>Topology</returns>
        Topology Ttms100TopologyTagByTopotaguuidGet (string topotaguuid);
        /// <summary>
        /// Update a topology tag&#39;s name and/or description Update a topology tag&#39;s name and/or description
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param>
        /// <param name="body"></param>
        /// <returns>Topology</returns>
        Topology Ttms100TopologyTagByTopotaguuidPut (string topotaguuid, Ttms100TopologyTagRequest body);
        /// <summary>
        /// List all topology tags List all topology tags
        /// </summary>
        /// <returns>List&lt;Topology&gt;</returns>
        List<Topology> Ttms100TopologyTagGet ();
        /// <summary>
        /// List objects for Topology List all objects (Endpoints, Links, VPorts, etc.) associated with the topology tag.
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param>
        /// <returns>Ttms100TopologyTagObjectsResponse</returns>
        Ttms100TopologyTagObjectsResponse Ttms100TopologyTagObjectsByTopotaguuidGet (string topotaguuid);
        /// <summary>
        /// Create a named topology tag Create a named topology tag
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Topology</returns>
        Topology Ttms100TopologyTagPost (Ttms100TopologyTagRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TopologiesApi : ITopologiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TopologiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TopologiesApi(String basePath)
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
        /// Delete a topology tag Delete a topology tag
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param> 
        /// <returns></returns>            
        public void Ttms100TopologyTagByTopotaguuidDelete (string topotaguuid)
        {
            
            // verify the required parameter 'topotaguuid' is set
            if (topotaguuid == null) throw new ApiException(400, "Missing required parameter 'topotaguuid' when calling Ttms100TopologyTagByTopotaguuidDelete");
            
    
            var path = "/ttms/1.0.0/topology_tag/{topotaguuid}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "topotaguuid" + "}", ApiClient.ParameterToString(topotaguuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get information about the specified topology tag Get information about the specified topology tag
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param> 
        /// <returns>Topology</returns>            
        public Topology Ttms100TopologyTagByTopotaguuidGet (string topotaguuid)
        {
            
            // verify the required parameter 'topotaguuid' is set
            if (topotaguuid == null) throw new ApiException(400, "Missing required parameter 'topotaguuid' when calling Ttms100TopologyTagByTopotaguuidGet");
            
    
            var path = "/ttms/1.0.0/topology_tag/{topotaguuid}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "topotaguuid" + "}", ApiClient.ParameterToString(topotaguuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Topology) ApiClient.Deserialize(response.Content, typeof(Topology), response.Headers);
        }
    
        /// <summary>
        /// Update a topology tag&#39;s name and/or description Update a topology tag&#39;s name and/or description
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param> 
        /// <param name="body"></param> 
        /// <returns>Topology</returns>            
        public Topology Ttms100TopologyTagByTopotaguuidPut (string topotaguuid, Ttms100TopologyTagRequest body)
        {
            
            // verify the required parameter 'topotaguuid' is set
            if (topotaguuid == null) throw new ApiException(400, "Missing required parameter 'topotaguuid' when calling Ttms100TopologyTagByTopotaguuidPut");
            
    
            var path = "/ttms/1.0.0/topology_tag/{topotaguuid}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "topotaguuid" + "}", ApiClient.ParameterToString(topotaguuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagByTopotaguuidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Topology) ApiClient.Deserialize(response.Content, typeof(Topology), response.Headers);
        }
    
        /// <summary>
        /// List all topology tags List all topology tags
        /// </summary>
        /// <returns>List&lt;Topology&gt;</returns>            
        public List<Topology> Ttms100TopologyTagGet ()
        {
            
    
            var path = "/ttms/1.0.0/topology_tag";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Topology>) ApiClient.Deserialize(response.Content, typeof(List<Topology>), response.Headers);
        }
    
        /// <summary>
        /// List objects for Topology List all objects (Endpoints, Links, VPorts, etc.) associated with the topology tag.
        /// </summary>
        /// <param name="topotaguuid">Unique identifier representing a specific topology tag</param> 
        /// <returns>Ttms100TopologyTagObjectsResponse</returns>            
        public Ttms100TopologyTagObjectsResponse Ttms100TopologyTagObjectsByTopotaguuidGet (string topotaguuid)
        {
            
            // verify the required parameter 'topotaguuid' is set
            if (topotaguuid == null) throw new ApiException(400, "Missing required parameter 'topotaguuid' when calling Ttms100TopologyTagObjectsByTopotaguuidGet");
            
    
            var path = "/ttms/1.0.0/topology_tag/{topotaguuid}/objects/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "topotaguuid" + "}", ApiClient.ParameterToString(topotaguuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagObjectsByTopotaguuidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagObjectsByTopotaguuidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Ttms100TopologyTagObjectsResponse) ApiClient.Deserialize(response.Content, typeof(Ttms100TopologyTagObjectsResponse), response.Headers);
        }
    
        /// <summary>
        /// Create a named topology tag Create a named topology tag
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Topology</returns>            
        public Topology Ttms100TopologyTagPost (Ttms100TopologyTagRequest body)
        {
            
    
            var path = "/ttms/1.0.0/topology_tag";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ttms100TopologyTagPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Topology) ApiClient.Deserialize(response.Content, typeof(Topology), response.Headers);
        }
    
    }
}
