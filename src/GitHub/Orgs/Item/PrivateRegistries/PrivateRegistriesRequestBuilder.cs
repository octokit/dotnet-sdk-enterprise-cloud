// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Orgs.Item.PrivateRegistries.Item;
using GitHub.Orgs.Item.PrivateRegistries.PublicKey;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.PrivateRegistries
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\private-registries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class PrivateRegistriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The publicKey property</summary>
        public global::GitHub.Orgs.Item.PrivateRegistries.PublicKey.PublicKeyRequestBuilder PublicKey
        {
            get => new global::GitHub.Orgs.Item.PrivateRegistries.PublicKey.PublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.privateRegistries.item collection</summary>
        /// <param name="position">The name of the secret.</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PrivateRegistries.Item.WithSecret_nameItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.PrivateRegistries.Item.WithSecret_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("secret_name", position);
                return new global::GitHub.Orgs.Item.PrivateRegistries.Item.WithSecret_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivateRegistriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/private-registries{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivateRegistriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/private-registries{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Lists all private registry configurations available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/private-registries/organization-configurations#list-private-registries-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder.PrivateRegistriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder.PrivateRegistriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesGetResponse>(requestInfo, global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Creates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see &quot;[Encrypting secrets for the REST API](https://docs.github.com/enterprise-cloud@latest//rest/guides/encrypting-secrets-for-the-rest-api).&quot;OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/private-registries/organization-configurations#create-a-private-registry-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrgPrivateRegistryConfigurationWithSelectedRepositories"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.OrgPrivateRegistryConfigurationWithSelectedRepositories?> PostAsync(global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.OrgPrivateRegistryConfigurationWithSelectedRepositories> PostAsync(global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.OrgPrivateRegistryConfigurationWithSelectedRepositories>(requestInfo, global::GitHub.Models.OrgPrivateRegistryConfigurationWithSelectedRepositories.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Lists all private registry configurations available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder.PrivateRegistriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder.PrivateRegistriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Creates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see &quot;[Encrypting secrets for the REST API](https://docs.github.com/enterprise-cloud@latest//rest/guides/encrypting-secrets-for-the-rest-api).&quot;OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.PrivateRegistries.PrivateRegistriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Lists all private registry configurations available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class PrivateRegistriesRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
#pragma warning restore CS0618
