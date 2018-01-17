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
    public interface IContractsApi
    {
        /// <summary>
        /// Get active Contract by ContractID Get active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="contractid">Unique identifier representing a specific contract</param>
        /// <returns>InventoryLinksContractResponse</returns>
        InventoryLinksContractResponse InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid);
        /// <summary>
        /// Update active Contract by ContractID Update active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="contractid">Unique identifier representing a specific contract</param>
        /// <param name="body"></param>
        /// <returns>InventoryLinksContractResponse33</returns>
        InventoryLinksContractResponse33 InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, InventoryLinksContractRequest body);
        /// <summary>
        /// Create new Contract on specified link Create new Contract on specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="body"></param>
        /// <returns>List&lt;InventoryLinksContractResponse38&gt;</returns>
        List<InventoryLinksContractResponse38> InventoryLinksContractByLinkidPost (string linkid, InventoryLinksContractRequest37 body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContractsApi : IContractsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContractsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContractsApi(String basePath)
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
        /// Get active Contract by ContractID Get active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <param name="contractid">Unique identifier representing a specific contract</param> 
        /// <returns>InventoryLinksContractResponse</returns>            
        public InventoryLinksContractResponse InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling InventoryLinksContractByLinkidAndContractidGet");
            
            // verify the required parameter 'contractid' is set
            if (contractid == null) throw new ApiException(400, "Missing required parameter 'contractid' when calling InventoryLinksContractByLinkidAndContractidGet");
            
    
            var path = "/1.0.0/inventory/links/{linkid}/contract/{contractid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "linkid" + "}", ApiClient.ParameterToString(linkid));
path = path.Replace("{" + "contractid" + "}", ApiClient.ParameterToString(contractid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidAndContractidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidAndContractidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InventoryLinksContractResponse) ApiClient.Deserialize(response.Content, typeof(InventoryLinksContractResponse), response.Headers);
        }
    
        /// <summary>
        /// Update active Contract by ContractID Update active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <param name="contractid">Unique identifier representing a specific contract</param> 
        /// <param name="body"></param> 
        /// <returns>InventoryLinksContractResponse33</returns>            
        public InventoryLinksContractResponse33 InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, InventoryLinksContractRequest body)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling InventoryLinksContractByLinkidAndContractidPut");
            
            // verify the required parameter 'contractid' is set
            if (contractid == null) throw new ApiException(400, "Missing required parameter 'contractid' when calling InventoryLinksContractByLinkidAndContractidPut");
            
    
            var path = "/1.0.0/inventory/links/{linkid}/contract/{contractid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "linkid" + "}", ApiClient.ParameterToString(linkid));
path = path.Replace("{" + "contractid" + "}", ApiClient.ParameterToString(contractid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidAndContractidPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidAndContractidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InventoryLinksContractResponse33) ApiClient.Deserialize(response.Content, typeof(InventoryLinksContractResponse33), response.Headers);
        }
    
        /// <summary>
        /// Create new Contract on specified link Create new Contract on specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;InventoryLinksContractResponse38&gt;</returns>            
        public List<InventoryLinksContractResponse38> InventoryLinksContractByLinkidPost (string linkid, InventoryLinksContractRequest37 body)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling InventoryLinksContractByLinkidPost");
            
    
            var path = "/1.0.0/inventory/links/{linkid}/contract";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "linkid" + "}", ApiClient.ParameterToString(linkid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InventoryLinksContractByLinkidPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InventoryLinksContractResponse38>) ApiClient.Deserialize(response.Content, typeof(List<InventoryLinksContractResponse38>), response.Headers);
        }
    
    }
}
