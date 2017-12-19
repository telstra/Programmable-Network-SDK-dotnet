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
    public interface IContractsApi
    {
        /// <summary>
        /// Get active Contract by ContractID Get active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="contractid">Unique identifier representing a specific contract</param>
        /// <returns>Model100InventoryLinksContractResponse</returns>
        Model100InventoryLinksContractResponse 100InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid);
        /// <summary>
        /// Update active Contract by ContractID Update active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="contractid">Unique identifier representing a specific contract</param>
        /// <param name="body"></param>
        /// <returns>Model100InventoryLinksContractResponse33</returns>
        Model100InventoryLinksContractResponse33 100InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, Model100InventoryLinksContractRequest body);
        /// <summary>
        /// Create new Contract on specified link Create new Contract on specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param>
        /// <param name="body"></param>
        /// <returns>Model100InventoryLinksContractResponse38</returns>
        Model100InventoryLinksContractResponse38 100InventoryLinksContractByLinkidPost (string linkid, Model100InventoryLinksContractRequest37 body);
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
        /// <returns>Model100InventoryLinksContractResponse</returns>            
        public Model100InventoryLinksContractResponse 100InventoryLinksContractByLinkidAndContractidGet (string linkid, string contractid)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling 100InventoryLinksContractByLinkidAndContractidGet");
            
            // verify the required parameter 'contractid' is set
            if (contractid == null) throw new ApiException(400, "Missing required parameter 'contractid' when calling 100InventoryLinksContractByLinkidAndContractidGet");
            
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidAndContractidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidAndContractidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinksContractResponse) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinksContractResponse), response.Headers);
        }
    
        /// <summary>
        /// Update active Contract by ContractID Update active Contract by ContractID
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <param name="contractid">Unique identifier representing a specific contract</param> 
        /// <param name="body"></param> 
        /// <returns>Model100InventoryLinksContractResponse33</returns>            
        public Model100InventoryLinksContractResponse33 100InventoryLinksContractByLinkidAndContractidPut (string linkid, string contractid, Model100InventoryLinksContractRequest body)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling 100InventoryLinksContractByLinkidAndContractidPut");
            
            // verify the required parameter 'contractid' is set
            if (contractid == null) throw new ApiException(400, "Missing required parameter 'contractid' when calling 100InventoryLinksContractByLinkidAndContractidPut");
            
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidAndContractidPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidAndContractidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinksContractResponse33) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinksContractResponse33), response.Headers);
        }
    
        /// <summary>
        /// Create new Contract on specified link Create new Contract on specified link
        /// </summary>
        /// <param name="linkid">Unique identifier representing a specific link</param> 
        /// <param name="body"></param> 
        /// <returns>Model100InventoryLinksContractResponse38</returns>            
        public Model100InventoryLinksContractResponse38 100InventoryLinksContractByLinkidPost (string linkid, Model100InventoryLinksContractRequest37 body)
        {
            
            // verify the required parameter 'linkid' is set
            if (linkid == null) throw new ApiException(400, "Missing required parameter 'linkid' when calling 100InventoryLinksContractByLinkidPost");
            
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling 100InventoryLinksContractByLinkidPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Model100InventoryLinksContractResponse38) ApiClient.Deserialize(response.Content, typeof(Model100InventoryLinksContractResponse38), response.Headers);
        }
    
    }
}
