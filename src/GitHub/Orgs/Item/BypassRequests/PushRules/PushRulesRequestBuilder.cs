// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.BypassRequests.PushRules
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\bypass-requests\push-rules
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class PushRulesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushRulesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/bypass-requests/push-rules{?page*,per_page*,repository_name*,request_status*,requester*,reviewer*,time_period*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushRulesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/bypass-requests/push-rules{?page*,per_page*,repository_name*,request_status*,requester*,reviewer*,time_period*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the requests made by users of a repository to bypass push protection rules within an organization.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/bypass-requests#list-push-rule-bypass-requests-within-an-organization" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.PushRuleBypassRequest&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.PushRuleBypassRequest>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder.PushRulesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.PushRuleBypassRequest>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder.PushRulesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.PushRuleBypassRequest>(requestInfo, global::GitHub.Models.PushRuleBypassRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists the requests made by users of a repository to bypass push protection rules within an organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder.PushRulesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder.PushRulesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.BypassRequests.PushRules.PushRulesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the requests made by users of a repository to bypass push protection rules within an organization.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class PushRulesRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The name of the repository to filter on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("repository_name")]
            public string? RepositoryName { get; set; }
#nullable restore
#else
            [QueryParameter("repository_name")]
            public string RepositoryName { get; set; }
#endif
            /// <summary>Filter bypass requests by the handle of the GitHub user who requested the bypass.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("requester")]
            public string? Requester { get; set; }
#nullable restore
#else
            [QueryParameter("requester")]
            public string Requester { get; set; }
#endif
            /// <summary>The status of the bypass request to filter on. When specified, only requests with this status will be returned.</summary>
            [QueryParameter("request_status")]
            public global::GitHub.Orgs.Item.BypassRequests.PushRules.GetRequest_statusQueryParameterType? RequestStatus { get; set; }
            /// <summary>Filter bypass requests by the handle of the GitHub user who reviewed the bypass request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("reviewer")]
            public string? Reviewer { get; set; }
#nullable restore
#else
            [QueryParameter("reviewer")]
            public string Reviewer { get; set; }
#endif
            /// <summary>The time period to filter by.For example, `day` will filter for rule suites that occurred in the past 24 hours, and `week` will filter for insights that occurred in the past 7 days (168 hours).</summary>
            [QueryParameter("time_period")]
            public global::GitHub.Orgs.Item.BypassRequests.PushRules.GetTime_periodQueryParameterType? TimePeriod { get; set; }
        }
    }
}
#pragma warning restore CS0618
