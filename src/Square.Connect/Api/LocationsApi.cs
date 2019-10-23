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
    public interface ILocationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListLocationsResponse</returns>        ListLocationsResponse ListLocations ();

        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListLocationsResponse</returns>
        ApiResponse<ListLocationsResponse> ListLocationsWithHttpInfo ();
        /// <summary>
        /// RetrieveLocation
        /// </summary>
        /// <remarks>
        /// Retrieves details of a location.
        /// Note: This endpoint is in beta.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>RetrieveLocationResponse</returns>        RetrieveLocationResponse RetrieveLocation (string locationId);

        /// <summary>
        /// RetrieveLocation
        /// </summary>
        /// <remarks>
        /// Retrieves details of a location.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>ApiResponse of RetrieveLocationResponse</returns>
        ApiResponse<RetrieveLocationResponse> RetrieveLocationWithHttpInfo (string locationId);
        /// <summary>
        /// UpdateLocation
        /// </summary>
        /// <remarks>
        /// Updates the &#x60;Location&#x60; specified by the given ID.
        /// Note: This endpoint is in beta.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>UpdateLocationResponse</returns>        UpdateLocationResponse UpdateLocation (string locationId, UpdateLocationRequest body);

        /// <summary>
        /// UpdateLocation
        /// </summary>
        /// <remarks>
        /// Updates the &#x60;Location&#x60; specified by the given ID.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of UpdateLocationResponse</returns>
        ApiResponse<UpdateLocationResponse> UpdateLocationWithHttpInfo (string locationId, UpdateLocationRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ListLocationsResponse</returns>
        System.Threading.Tasks.Task<ListLocationsResponse> ListLocationsAsync ();

        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ListLocationsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListLocationsResponse>> ListLocationsAsyncWithHttpInfo ();
        /// <summary>
        /// RetrieveLocation
        /// </summary>
        /// <remarks>
        /// Retrieves details of a location.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>Task of RetrieveLocationResponse</returns>
        System.Threading.Tasks.Task<RetrieveLocationResponse> RetrieveLocationAsync (string locationId);

        /// <summary>
        /// RetrieveLocation
        /// </summary>
        /// <remarks>
        /// Retrieves details of a location.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>Task of ApiResponse (RetrieveLocationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RetrieveLocationResponse>> RetrieveLocationAsyncWithHttpInfo (string locationId);
        /// <summary>
        /// UpdateLocation
        /// </summary>
        /// <remarks>
        /// Updates the &#x60;Location&#x60; specified by the given ID.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of UpdateLocationResponse</returns>
        System.Threading.Tasks.Task<UpdateLocationResponse> UpdateLocationAsync (string locationId, UpdateLocationRequest body);

        /// <summary>
        /// UpdateLocation
        /// </summary>
        /// <remarks>
        /// Updates the &#x60;Location&#x60; specified by the given ID.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (UpdateLocationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateLocationResponse>> UpdateLocationAsyncWithHttpInfo (string locationId, UpdateLocationRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationsApi : ILocationsApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LocationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationsApi(Configuration configuration = null)
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
        /// ListLocations Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListLocationsResponse</returns>
        public ListLocationsResponse ListLocations ()
        {
             ApiResponse<ListLocationsResponse> localVarResponse = ListLocationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListLocations Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListLocationsResponse</returns>
        public ApiResponse< ListLocationsResponse > ListLocationsWithHttpInfo ()
        {

            var localVarPath = "/v2/locations";
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
                Exception exception = ExceptionFactory("ListLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListLocationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (ListLocationsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListLocationsResponse)));
            
        }

        /// <summary>
        /// ListLocations Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ListLocationsResponse</returns>
        public async System.Threading.Tasks.Task<ListLocationsResponse> ListLocationsAsync ()
        {
             ApiResponse<ListLocationsResponse> localVarResponse = await ListLocationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListLocations Provides the details for all of a business&#39;s locations.  Most other Connect API endpoints have a required &#x60;location_id&#x60; path parameter. The &#x60;id&#x60; field of the [&#x60;Location&#x60;](#type-location) objects returned by this endpoint correspond to that &#x60;location_id&#x60; parameter.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ListLocationsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListLocationsResponse>> ListLocationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/v2/locations";
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
                Exception exception = ExceptionFactory("ListLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListLocationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (ListLocationsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListLocationsResponse)));
            
        }

        /// <summary>
        /// RetrieveLocation Retrieves details of a location.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>RetrieveLocationResponse</returns>
        public RetrieveLocationResponse RetrieveLocation (string locationId)
        {
             ApiResponse<RetrieveLocationResponse> localVarResponse = RetrieveLocationWithHttpInfo(locationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// RetrieveLocation Retrieves details of a location.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>ApiResponse of RetrieveLocationResponse</returns>
        public ApiResponse< RetrieveLocationResponse > RetrieveLocationWithHttpInfo (string locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->RetrieveLocation");

            var localVarPath = "/v2/locations/{location_id}";
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter

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
                Exception exception = ExceptionFactory("RetrieveLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RetrieveLocationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (RetrieveLocationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveLocationResponse)));
            
        }

        /// <summary>
        /// RetrieveLocation Retrieves details of a location.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>Task of RetrieveLocationResponse</returns>
        public async System.Threading.Tasks.Task<RetrieveLocationResponse> RetrieveLocationAsync (string locationId)
        {
             ApiResponse<RetrieveLocationResponse> localVarResponse = await RetrieveLocationAsyncWithHttpInfo(locationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// RetrieveLocation Retrieves details of a location.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to retrieve.</param>
        /// <returns>Task of ApiResponse (RetrieveLocationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RetrieveLocationResponse>> RetrieveLocationAsyncWithHttpInfo (string locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->RetrieveLocation");

            var localVarPath = "/v2/locations/{location_id}";
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter

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
                Exception exception = ExceptionFactory("RetrieveLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RetrieveLocationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (RetrieveLocationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveLocationResponse)));
            
        }

        /// <summary>
        /// UpdateLocation Updates the &#x60;Location&#x60; specified by the given ID.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>UpdateLocationResponse</returns>
        public UpdateLocationResponse UpdateLocation (string locationId, UpdateLocationRequest body)
        {
             ApiResponse<UpdateLocationResponse> localVarResponse = UpdateLocationWithHttpInfo(locationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// UpdateLocation Updates the &#x60;Location&#x60; specified by the given ID.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of UpdateLocationResponse</returns>
        public ApiResponse< UpdateLocationResponse > UpdateLocationWithHttpInfo (string locationId, UpdateLocationRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->UpdateLocation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->UpdateLocation");

            var localVarPath = "/v2/locations/{location_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateLocationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (UpdateLocationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateLocationResponse)));
            
        }

        /// <summary>
        /// UpdateLocation Updates the &#x60;Location&#x60; specified by the given ID.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of UpdateLocationResponse</returns>
        public async System.Threading.Tasks.Task<UpdateLocationResponse> UpdateLocationAsync (string locationId, UpdateLocationRequest body)
        {
             ApiResponse<UpdateLocationResponse> localVarResponse = await UpdateLocationAsyncWithHttpInfo(locationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// UpdateLocation Updates the &#x60;Location&#x60; specified by the given ID.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the location to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (UpdateLocationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateLocationResponse>> UpdateLocationAsyncWithHttpInfo (string locationId, UpdateLocationRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->UpdateLocation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->UpdateLocation");

            var localVarPath = "/v2/locations/{location_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateLocationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString(), StringComparer.OrdinalIgnoreCase),
                (UpdateLocationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateLocationResponse)));
            
        }

    }
}
