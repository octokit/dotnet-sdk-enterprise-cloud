// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.CodeSecurity.Configurations.Defaults;
using GitHub.Enterprises.Item.CodeSecurity.Configurations.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.CodeSecurity.Configurations
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\code-security\configurations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ConfigurationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The defaults property</summary>
        public global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Defaults.DefaultsRequestBuilder Defaults
        {
            get => new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Defaults.DefaultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.enterprises.item.codeSecurity.configurations.item collection</summary>
        /// <param name="position">The unique identifier of the code security configuration.</param>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.WithConfiguration_ItemRequestBuilder"/></returns>
        public global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.WithConfiguration_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("configuration_id", position);
                return new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.WithConfiguration_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code-security/configurations{?after*,before*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code-security/configurations{?after*,before*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all code security configurations available in an enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations#get-code-security-configurations-for-an-enterprise" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.CodeSecurityConfiguration&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.CodeSecurityConfiguration>?> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder.ConfigurationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.CodeSecurityConfiguration>> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder.ConfigurationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.CodeSecurityConfiguration>(requestInfo, global::GitHub.Models.CodeSecurityConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Creates a code security configuration in an enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations#create-a-code-security-configuration-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeSecurityConfiguration"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.CodeSecurityConfiguration?> PostAsync(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.CodeSecurityConfiguration> PostAsync(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.CodeSecurityConfiguration>(requestInfo, global::GitHub.Models.CodeSecurityConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all code security configurations available in an enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder.ConfigurationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder.ConfigurationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a code security configuration in an enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.ConfigurationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all code security configurations available in an enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class ConfigurationsRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
#pragma warning restore CS0618
