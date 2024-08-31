// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Hooks.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Hooks
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\hooks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class HooksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.hooks.item collection</summary>
        /// <param name="position">The unique identifier of the hook. You can find this value in the `X-GitHub-Hook-ID` header of a webhook delivery.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("hook_id", position);
                return new global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HooksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/hooks{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HooksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/hooks{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists webhooks for a repository. `last response` may return null if there have not been any deliveries within 30 days.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/repos/webhooks#list-repository-webhooks" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.Hook&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.Hook>?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder.HooksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.Hook>> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder.HooksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.Hook>(requestInfo, global::GitHub.Models.Hook.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks canshare the same `config` as long as those webhooks do not have any `events` that overlap.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/repos/webhooks#create-a-repository-webhook" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Hook"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Hook?> PostAsync(global::GitHub.Repos.Item.Item.Hooks.HooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Hook> PostAsync(global::GitHub.Repos.Item.Item.Hooks.HooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.Hook>(requestInfo, global::GitHub.Models.Hook.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists webhooks for a repository. `last response` may return null if there have not been any deliveries within 30 days.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder.HooksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder.HooksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks canshare the same `config` as long as those webhooks do not have any `events` that overlap.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.Hooks.HooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.Hooks.HooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists webhooks for a repository. `last response` may return null if there have not been any deliveries within 30 days.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class HooksRequestBuilderGetQueryParameters 
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
