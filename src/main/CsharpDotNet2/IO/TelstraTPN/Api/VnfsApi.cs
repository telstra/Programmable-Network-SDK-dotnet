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
    public interface IVnfsApi
    {
        /// <summary>
        /// List images in the Marketplace List images in the Marketplace
        /// </summary>
        /// <returns>Model100MarketplaceImageResponse</returns>
        Model100MarketplaceImageResponse 100MarketplaceImageGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VnfsApi : IVnfsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VnfsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VnfsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VnfsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VnfsApi(String basePath)
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
        /// List images in the Marketplace List images in the Marketplace
        /// </summary>
        /// <returns>Model100MarketplaceImageResponse</returns>            
        public Model100MarketplaceImageResponse 100MarketplaceImageGet ()
        {
            
    
            var path = "/1.0.0/marketplace/image";
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
                throw new ApiException ((int)response.StatusCode, "Error calling 100MarketplaceImageGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100MarketplaceImageGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100MarketplaceImageResponse) ApiClient.Deserialize(response.Content, typeof(Model100MarketplaceImageResponse), response.Headers);
        }
    
    }
}
