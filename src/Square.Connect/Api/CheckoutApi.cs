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
    public interface ICheckoutApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// CreateCheckout
        /// </summary>
        /// <remarks>
        /// Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateCheckoutResponse</returns>        CreateCheckoutResponse CreateCheckout (string locationId, CreateCheckoutRequest body);

        /// <summary>
        /// CreateCheckout
        /// </summary>
        /// <remarks>
        /// Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateCheckoutResponse</returns>
        ApiResponse<CreateCheckoutResponse> CreateCheckoutWithHttpInfo (string locationId, CreateCheckoutRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// CreateCheckout
        /// </summary>
        /// <remarks>
        /// Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCheckoutResponse</returns>
        System.Threading.Tasks.Task<CreateCheckoutResponse> CreateCheckoutAsync (string locationId, CreateCheckoutRequest body);

        /// <summary>
        /// CreateCheckout
        /// </summary>
        /// <remarks>
        /// Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCheckoutResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCheckoutResponse>> CreateCheckoutAsyncWithHttpInfo (string locationId, CreateCheckoutRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CheckoutApi : ICheckoutApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CheckoutApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CheckoutApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CheckoutApi(Configuration configuration = null)
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
        /// CreateCheckout Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateCheckoutResponse</returns>
        public CreateCheckoutResponse CreateCheckout (string locationId, CreateCheckoutRequest body)
        {
             ApiResponse<CreateCheckoutResponse> localVarResponse = CreateCheckoutWithHttpInfo(locationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateCheckout Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateCheckoutResponse</returns>
        public ApiResponse< CreateCheckoutResponse > CreateCheckoutWithHttpInfo (string locationId, CreateCheckoutRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling CheckoutApi->CreateCheckout");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CheckoutApi->CreateCheckout");

            var localVarPath = "/v2/locations/{location_id}/checkouts";
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
            localVarHeaderParams.Add("Square-Version", "2019-09-25");
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCheckout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateCheckoutResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCheckoutResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCheckoutResponse)));
            
        }

        /// <summary>
        /// CreateCheckout Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCheckoutResponse</returns>
        public async System.Threading.Tasks.Task<CreateCheckoutResponse> CreateCheckoutAsync (string locationId, CreateCheckoutRequest body)
        {
             ApiResponse<CreateCheckoutResponse> localVarResponse = await CreateCheckoutAsyncWithHttpInfo(locationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateCheckout Links a &#x60;checkoutId&#x60; to a &#x60;checkout_page_url&#x60; that customers will be directed to in order to provide their payment information using a payment processing workflow hosted on connect.squareup.com.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCheckoutResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCheckoutResponse>> CreateCheckoutAsyncWithHttpInfo (string locationId, CreateCheckoutRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling CheckoutApi->CreateCheckout");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CheckoutApi->CreateCheckout");

            var localVarPath = "/v2/locations/{location_id}/checkouts";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCheckout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateCheckoutResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCheckoutResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCheckoutResponse)));
            
        }

    }
}
