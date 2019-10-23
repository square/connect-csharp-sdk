/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Square.Connect.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMerchantsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ListMerchants
        /// </summary>
        /// <remarks>
        /// Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>ListMerchantsResponse</returns>        ListMerchantsResponse ListMerchants (int? cursor = null);

        /// <summary>
        /// ListMerchants
        /// </summary>
        /// <remarks>
        /// Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>ApiResponse of ListMerchantsResponse</returns>
        ApiResponse<ListMerchantsResponse> ListMerchantsWithHttpInfo (int? cursor = null);
        /// <summary>
        /// RetrieveMerchant
        /// </summary>
        /// <remarks>
        /// Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>RetrieveMerchantResponse</returns>        RetrieveMerchantResponse RetrieveMerchant (string merchantId);

        /// <summary>
        /// RetrieveMerchant
        /// </summary>
        /// <remarks>
        /// Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>ApiResponse of RetrieveMerchantResponse</returns>
        ApiResponse<RetrieveMerchantResponse> RetrieveMerchantWithHttpInfo (string merchantId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// ListMerchants
        /// </summary>
        /// <remarks>
        /// Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>Task of ListMerchantsResponse</returns>
        System.Threading.Tasks.Task<ListMerchantsResponse> ListMerchantsAsync (int? cursor = null);

        /// <summary>
        /// ListMerchants
        /// </summary>
        /// <remarks>
        /// Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>Task of ApiResponse (ListMerchantsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListMerchantsResponse>> ListMerchantsAsyncWithHttpInfo (int? cursor = null);
        /// <summary>
        /// RetrieveMerchant
        /// </summary>
        /// <remarks>
        /// Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>Task of RetrieveMerchantResponse</returns>
        System.Threading.Tasks.Task<RetrieveMerchantResponse> RetrieveMerchantAsync (string merchantId);

        /// <summary>
        /// RetrieveMerchant
        /// </summary>
        /// <remarks>
        /// Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>Task of ApiResponse (RetrieveMerchantResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RetrieveMerchantResponse>> RetrieveMerchantAsyncWithHttpInfo (string merchantId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerchantsApi : IMerchantsApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MerchantsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerchantsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Square.Connect.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// ListMerchants Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>ListMerchantsResponse</returns>
        public ListMerchantsResponse ListMerchants (int? cursor = null)
        {
             ApiResponse<ListMerchantsResponse> localVarResponse = ListMerchantsWithHttpInfo(cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListMerchants Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>ApiResponse of ListMerchantsResponse</returns>
        public ApiResponse< ListMerchantsResponse > ListMerchantsWithHttpInfo (int? cursor = null)
        {

            var localVarPath = "/v2/merchants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2019-10-23");
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListMerchants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListMerchantsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (ListMerchantsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListMerchantsResponse)));
            
        }

        /// <summary>
        /// ListMerchants Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>Task of ListMerchantsResponse</returns>
        public async System.Threading.Tasks.Task<ListMerchantsResponse> ListMerchantsAsync (int? cursor = null)
        {
             ApiResponse<ListMerchantsResponse> localVarResponse = await ListMerchantsAsyncWithHttpInfo(cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListMerchants Returns &#x60;Merchant&#x60; information for a given access token.  If you don&#39;t know a &#x60;Merchant&#x60; ID, you can use this endpoint to retrieve the merchant ID for an access token. You can specify your personal access token to get your own merchant information or specify an OAuth token to get the information for the  merchant that granted you access.  If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)  endpoint to get the merchant information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cursor">The cursor generated by the previous response. (optional)</param>
        /// <returns>Task of ApiResponse (ListMerchantsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListMerchantsResponse>> ListMerchantsAsyncWithHttpInfo (int? cursor = null)
        {

            var localVarPath = "/v2/merchants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2019-10-23");
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListMerchants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListMerchantsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (ListMerchantsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListMerchantsResponse)));
            
        }

        /// <summary>
        /// RetrieveMerchant Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>RetrieveMerchantResponse</returns>
        public RetrieveMerchantResponse RetrieveMerchant (string merchantId)
        {
             ApiResponse<RetrieveMerchantResponse> localVarResponse = RetrieveMerchantWithHttpInfo(merchantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// RetrieveMerchant Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>ApiResponse of RetrieveMerchantResponse</returns>
        public ApiResponse< RetrieveMerchantResponse > RetrieveMerchantWithHttpInfo (string merchantId)
        {
            // verify the required parameter 'merchantId' is set
            if (merchantId == null)
                throw new ApiException(400, "Missing required parameter 'merchantId' when calling MerchantsApi->RetrieveMerchant");

            var localVarPath = "/v2/merchants/{merchant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2019-10-23");
            if (merchantId != null) localVarPathParams.Add("merchant_id", Configuration.ApiClient.ParameterToString(merchantId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RetrieveMerchantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (RetrieveMerchantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveMerchantResponse)));
            
        }

        /// <summary>
        /// RetrieveMerchant Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>Task of RetrieveMerchantResponse</returns>
        public async System.Threading.Tasks.Task<RetrieveMerchantResponse> RetrieveMerchantAsync (string merchantId)
        {
             ApiResponse<RetrieveMerchantResponse> localVarResponse = await RetrieveMerchantAsyncWithHttpInfo(merchantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// RetrieveMerchant Retrieve a &#x60;Merchant&#x60; object for the given &#x60;merchant_id&#x60;.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The ID of the merchant to retrieve.</param>
        /// <returns>Task of ApiResponse (RetrieveMerchantResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RetrieveMerchantResponse>> RetrieveMerchantAsyncWithHttpInfo (string merchantId)
        {
            // verify the required parameter 'merchantId' is set
            if (merchantId == null)
                throw new ApiException(400, "Missing required parameter 'merchantId' when calling MerchantsApi->RetrieveMerchant");

            var localVarPath = "/v2/merchants/{merchant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2019-10-23");
            if (merchantId != null) localVarPathParams.Add("merchant_id", Configuration.ApiClient.ParameterToString(merchantId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RetrieveMerchantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (RetrieveMerchantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveMerchantResponse)));
            
        }

    }
}
