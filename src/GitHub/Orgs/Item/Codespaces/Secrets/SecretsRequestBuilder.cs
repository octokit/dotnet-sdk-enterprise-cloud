// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Orgs.Item.Codespaces.Secrets.Item;
using GitHub.Orgs.Item.Codespaces.Secrets.PublicKey;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Codespaces.Secrets
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\codespaces\secrets
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SecretsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The publicKey property</summary>
        public global::GitHub.Orgs.Item.Codespaces.Secrets.PublicKey.PublicKeyRequestBuilder PublicKey
        {
            get => new global::GitHub.Orgs.Item.Codespaces.Secrets.PublicKey.PublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.codespaces.secrets.item collection</summary>
        /// <param name="position">The name of the secret.</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Codespaces.Secrets.Item.WithSecret_nameItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Codespaces.Secrets.Item.WithSecret_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("secret_name", position);
                return new global::GitHub.Orgs.Item.Codespaces.Secrets.Item.WithSecret_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/codespaces/secrets{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/codespaces/secrets{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all Codespaces development environment secrets available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/codespaces/organization-secrets#list-organization-secrets" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder.SecretsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder.SecretsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsGetResponse>(requestInfo, global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all Codespaces development environment secrets available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder.SecretsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder.SecretsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Codespaces.Secrets.SecretsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all Codespaces development environment secrets available at the organization-level without revealing their encryptedvalues.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SecretsRequestBuilderGetQueryParameters 
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
