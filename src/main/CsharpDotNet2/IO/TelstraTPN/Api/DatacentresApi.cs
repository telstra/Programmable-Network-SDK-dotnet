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
    public interface IDatacentresApi
    {
        /// <summary>
        /// Get list of all the data centers Get list of all the data centers
        /// </summary>
        /// <returns>List&lt;Model100InventoryDatacentersResponse&gt;</returns>
        List<Model100InventoryDatacentersResponse> GetListOfAllTheDataCenters ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DatacentresApi : IDatacentresApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacentresApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DatacentresApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacentresApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatacentresApi(String basePath)
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
        /// Get list of all the data centers Get list of all the data centers
        /// </summary>
        /// <returns>List&lt;Model100InventoryDatacentersResponse&gt;</returns>            
        public List<Model100InventoryDatacentersResponse> GetListOfAllTheDataCenters ()
        {
            
    
            var path = "/1.0.0/inventory/datacenters";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListOfAllTheDataCenters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListOfAllTheDataCenters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Model100InventoryDatacentersResponse>) ApiClient.Deserialize(response.Content, typeof(List<Model100InventoryDatacentersResponse>), response.Headers);
        }
    
    }
}
