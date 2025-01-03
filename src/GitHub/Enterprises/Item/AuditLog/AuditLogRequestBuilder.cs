// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.AuditLog.StreamKey;
using GitHub.Enterprises.Item.AuditLog.Streams;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.AuditLog
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\audit-log
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AuditLogRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The streamKey property</summary>
        public global::GitHub.Enterprises.Item.AuditLog.StreamKey.StreamKeyRequestBuilder StreamKey
        {
            get => new global::GitHub.Enterprises.Item.AuditLog.StreamKey.StreamKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The streams property</summary>
        public global::GitHub.Enterprises.Item.AuditLog.Streams.StreamsRequestBuilder Streams
        {
            get => new global::GitHub.Enterprises.Item.AuditLog.Streams.StreamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/audit-log{?after*,before*,include*,order*,page*,per_page*,phrase*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/audit-log{?after*,before*,include*,order*,page*,per_page*,phrase*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the audit log for an enterprise.This endpoint has a rate limit of 1,750 queries per hour per user and IP address. If your integration receives a rate limit error (typically a 403 or 429 response), it should wait before making another request to the GitHub API. For more information, see &quot;[Rate limits for the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/rate-limits-for-the-rest-api)&quot; and &quot;[Best practices for integrators](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-integrators).&quot;The authenticated user must be an enterprise admin to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/enterprise-admin/audit-log#get-the-audit-log-for-an-enterprise" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.AuditLogEvent&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.AuditLogEvent>?> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.AuditLogEvent>> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.AuditLogEvent>(requestInfo, global::GitHub.Models.AuditLogEvent.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Gets the audit log for an enterprise.This endpoint has a rate limit of 1,750 queries per hour per user and IP address. If your integration receives a rate limit error (typically a 403 or 429 response), it should wait before making another request to the GitHub API. For more information, see &quot;[Rate limits for the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/rate-limits-for-the-rest-api)&quot; and &quot;[Best practices for integrators](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-integrators).&quot;The authenticated user must be an enterprise admin to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.AuditLog.AuditLogRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the audit log for an enterprise.This endpoint has a rate limit of 1,750 queries per hour per user and IP address. If your integration receives a rate limit error (typically a 403 or 429 response), it should wait before making another request to the GitHub API. For more information, see &quot;[Rate limits for the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/rate-limits-for-the-rest-api)&quot; and &quot;[Best practices for integrators](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-integrators).&quot;The authenticated user must be an enterprise admin to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class AuditLogRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events after this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events before this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The event types to include:- `web` - returns web (non-Git) events.- `git` - returns Git events.- `all` - returns both web and Git events.The default is `web`.</summary>
            [QueryParameter("include")]
            public global::GitHub.Enterprises.Item.AuditLog.GetIncludeQueryParameterType? Include { get; set; }
            /// <summary>The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.The default is `desc`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Enterprises.Item.AuditLog.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>A search phrase. For more information, see [Searching the audit log](https://docs.github.com/enterprise-cloud@latest//admin/monitoring-activity-in-your-enterprise/reviewing-audit-logs-for-your-enterprise/searching-the-audit-log-for-your-enterprise#searching-the-audit-log).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phrase")]
            public string? Phrase { get; set; }
#nullable restore
#else
            [QueryParameter("phrase")]
            public string Phrase { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
