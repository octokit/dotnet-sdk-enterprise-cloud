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
namespace GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\insights\api\time-stats\{actor_type}\{actor_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithActor_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithActor_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/time-stats/{actor_type}/{actor_id}?max_timestamp={max_timestamp}&min_timestamp={min_timestamp}&timestamp_increment={timestamp_increment}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithActor_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/time-stats/{actor_type}/{actor_id}?max_timestamp={max_timestamp}&min_timestamp={min_timestamp}&timestamp_increment={timestamp_increment}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific actor within a specified time period.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/api-insights#get-time-stats-by-actor" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.ApiInsightsTimeStats&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.ApiInsightsTimeStats>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder.WithActor_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.ApiInsightsTimeStats>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder.WithActor_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.ApiInsightsTimeStats>(requestInfo, global::GitHub.Models.ApiInsightsTimeStats.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific actor within a specified time period.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder.WithActor_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder.WithActor_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Insights.Api.TimeStats.Item.Item.WithActor_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific actor within a specified time period.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithActor_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum timestamp to query for stats</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("max_timestamp")]
            public string? MaxTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("max_timestamp")]
            public string MaxTimestamp { get; set; }
#endif
            /// <summary>The minimum timestamp to query for stats</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("min_timestamp")]
            public string? MinTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("min_timestamp")]
            public string MinTimestamp { get; set; }
#endif
            /// <summary>The increment of time used to breakdown the query results (5m, 10m, 1h, etc.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("timestamp_increment")]
            public string? TimestampIncrement { get; set; }
#nullable restore
#else
            [QueryParameter("timestamp_increment")]
            public string TimestampIncrement { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
