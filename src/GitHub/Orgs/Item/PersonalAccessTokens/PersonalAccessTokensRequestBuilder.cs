// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Orgs.Item.PersonalAccessTokens.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.PersonalAccessTokens
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\personal-access-tokens
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class PersonalAccessTokensRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.orgs.item.personalAccessTokens.item collection</summary>
        /// <param name="position">The unique identifier of the fine-grained personal access token.</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PersonalAccessTokens.Item.WithPat_ItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.PersonalAccessTokens.Item.WithPat_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pat_id", position);
                return new global::GitHub.Orgs.Item.PersonalAccessTokens.Item.WithPat_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonalAccessTokensRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-tokens{?direction*,last_used_after*,last_used_before*,owner*,page*,per_page*,permission*,repository*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonalAccessTokensRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-tokens{?direction*,last_used_after*,last_used_before*,owner*,page*,per_page*,permission*,repository*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.Only GitHub Apps can use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/personal-access-tokens#list-fine-grained-personal-access-tokens-with-access-to-organization-resources" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.OrganizationProgrammaticAccessGrant&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.OrganizationProgrammaticAccessGrant>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder.PersonalAccessTokensRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.OrganizationProgrammaticAccessGrant>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder.PersonalAccessTokensRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.OrganizationProgrammaticAccessGrant>(requestInfo, global::GitHub.Models.OrganizationProgrammaticAccessGrant.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token&apos;s existing access.Only GitHub Apps can use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/personal-access-tokens#update-the-access-to-organization-resources-via-fine-grained-personal-access-tokens" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostResponse?> PostAsync(global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostResponse> PostAsync(global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostResponse>(requestInfo, global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder.PersonalAccessTokensRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder.PersonalAccessTokensRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token&apos;s existing access.Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.Only GitHub Apps can use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class PersonalAccessTokensRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Orgs.Item.PersonalAccessTokens.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>Only show fine-grained personal access tokens used after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("last_used_after")]
            public DateTimeOffset? LastUsedAfter { get; set; }
            /// <summary>Only show fine-grained personal access tokens used before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("last_used_before")]
            public DateTimeOffset? LastUsedBefore { get; set; }
            /// <summary>A list of owner usernames to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("owner")]
            public string[]? Owner { get; set; }
#nullable restore
#else
            [QueryParameter("owner")]
            public string[] Owner { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The permission to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("permission")]
            public string? Permission { get; set; }
#nullable restore
#else
            [QueryParameter("permission")]
            public string Permission { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The name of the repository to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("repository")]
            public string? Repository { get; set; }
#nullable restore
#else
            [QueryParameter("repository")]
            public string Repository { get; set; }
#endif
            /// <summary>The property by which to sort the results.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Orgs.Item.PersonalAccessTokens.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
