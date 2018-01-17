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
    public interface IAuthenticationApi
    {
        /// <summary>
        /// Create an authentication token Create an authentication token
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>AuthGeneratetokenResponse</returns>
        AuthGeneratetokenResponse AuthGeneratetokenPost (string grantType, string username, string password);
        /// <summary>
        /// Validate authentication token Validate the authentication token and get information about the user (roles, permissions, etc.)
        /// </summary>
        /// <returns>AuthValidatetokenResponse</returns>
        AuthValidatetokenResponse AuthValidatetokenGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IAuthenticationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
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
        /// Create an authentication token Create an authentication token
        /// </summary>
        /// <param name="grantType"></param> 
        /// <param name="username"></param> 
        /// <param name="password"></param> 
        /// <returns>AuthGeneratetokenResponse</returns>            
        public AuthGeneratetokenResponse AuthGeneratetokenPost (string grantType, string username, string password)
        {
            
            // verify the required parameter 'grantType' is set
            if (grantType == null) throw new ApiException(400, "Missing required parameter 'grantType' when calling AuthGeneratetokenPost");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling AuthGeneratetokenPost");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling AuthGeneratetokenPost");
            
    
            var path = "/1.0.0/auth/generatetoken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (grantType != null) formParams.Add("grant_type", ApiClient.ParameterToString(grantType)); // form parameter
if (username != null) formParams.Add("username", ApiClient.ParameterToString(username)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthGeneratetokenPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthGeneratetokenPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthGeneratetokenResponse) ApiClient.Deserialize(response.Content, typeof(AuthGeneratetokenResponse), response.Headers);
        }
    
        /// <summary>
        /// Validate authentication token Validate the authentication token and get information about the user (roles, permissions, etc.)
        /// </summary>
        /// <returns>AuthValidatetokenResponse</returns>            
        public AuthValidatetokenResponse AuthValidatetokenGet ()
        {
            
    
            var path = "/1.0.0/auth/validatetoken";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuthValidatetokenGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthValidatetokenGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthValidatetokenResponse) ApiClient.Deserialize(response.Content, typeof(AuthValidatetokenResponse), response.Headers);
        }
    
    }
}
