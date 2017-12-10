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
    public interface ILinksApi
    {
        /// <summary>
        /// Create Link and initial Contract Create Link and initial Contract
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Model100InventoryLinkResponse</returns>
        Model100InventoryLinkResponse CreateLinkAndInitialContract (Model100InventoryLinkRequest body);
        /// <summary>
        /// Get active Links Get active Links
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param>
        /// <returns>List&lt;Link&gt;</returns>
        List<Link> GetActiveLinks (string customeruuid);
        /// <summary>
        /// Get details of specified link Get details of specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <returns>Model100InventoryLinksResponse</returns>
        Model100InventoryLinksResponse GetDetailsOfSpecifiedLink (string linkid);
        /// <summary>
        /// Get Link history Get Link history
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <returns>Model100InventoryLinksHistoryResponse</returns>
        Model100InventoryLinksHistoryResponse GetLinkHistory (string linkid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LinksApi : ILinksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LinksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinksApi(String basePath)
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
        /// Create Link and initial Contract Create Link and initial Contract
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Model100InventoryLinkResponse</returns>            
        public Model100InventoryLinkResponse CreateLinkAndInitialContract (Model100InventoryLinkRequest body)
        {
            
    
            var path = "/1.0.0/inventory/link";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLinkAndInitialContract: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLinkAndInitialContract: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinkResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinkResponse), response.Headers);
        }
    
        /// <summary>
        /// Get active Links Get active Links
        /// </summary>
        /// <param name="customeruuid">Unique identifier representing a specific customer</param> 
        /// <returns>List&lt;Link&gt;</returns>            
        public List<Link> GetActiveLinks (string customeruuid)
        {
            
            // verify the required parameter 'customeruuid' is set
            if (customeruuid == null) throw new ApiException(400, "Missing required parameter 'customeruuid' when calling GetActiveLinks");
            
    
            var path = "/1.0.0/inventory/links/customer/{customeruuid}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActiveLinks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActiveLinks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Link>) ApiClient.Deserialize(response.Content, typeof(List<Link>), response.Headers);
        }
    
        /// <summary>
        /// Get details of specified link Get details of specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <returns>Model100InventoryLinksResponse</returns>            
        public Model100InventoryLinksResponse GetDetailsOfSpecifiedLink (string linkid)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling GetDetailsOfSpecifiedLink");
            
    
            var path = "/1.0.0/inventory/links/{linkid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "linkid" + "}", ApiClient.ParameterToString(linkid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDetailsOfSpecifiedLink: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDetailsOfSpecifiedLink: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinksResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinksResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Link history Get Link history
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <returns>Model100InventoryLinksHistoryResponse</returns>            
        public Model100InventoryLinksHistoryResponse GetLinkHistory (string linkid)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling GetLinkHistory");
            
    
            var path = "/1.0.0/inventory/links/history/{linkid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "linkid" + "}", ApiClient.ParameterToString(linkid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLinkHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLinkHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinksHistoryResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinksHistoryResponse), response.Headers);
        }
    
    }
}
