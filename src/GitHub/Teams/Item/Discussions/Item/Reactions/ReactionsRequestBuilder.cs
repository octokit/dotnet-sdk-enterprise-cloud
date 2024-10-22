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
namespace GitHub.Teams.Item.Discussions.Item.Reactions
{
    /// <summary>
    /// Builds and executes requests for operations under \teams\{team_id}\discussions\{discussion_number}\reactions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ReactionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReactionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/discussions/{discussion_number}/reactions{?content*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReactionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/discussions/{discussion_number}/reactions{?content*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Endpoint closing down notice:** This endpoint route is closing down and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#list-reactions-for-a-team-discussion) endpoint.List the reactions to a [team discussion](https://docs.github.com/enterprise-cloud@latest//rest/teams/discussions#get-a-discussion).OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#list-reactions-for-a-team-discussion-legacy" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.Reaction&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.Reaction>?> GetAsync(Action<RequestConfiguration<global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder.ReactionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.Reaction>> GetAsync(Action<RequestConfiguration<global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder.ReactionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.Reaction>(requestInfo, global::GitHub.Models.Reaction.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Endpoint closing down notice:** This endpoint route is closing down and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create reaction for a team discussion`](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#create-reaction-for-a-team-discussion) endpoint.Create a reaction to a [team discussion](https://docs.github.com/enterprise-cloud@latest//rest/teams/discussions#get-a-discussion).A response with an HTTP `200` status means that you already added the reaction type to this team discussion.OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#create-reaction-for-a-team-discussion-legacy" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Reaction"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Reaction?> PostAsync(global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Reaction> PostAsync(global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.Reaction>(requestInfo, global::GitHub.Models.Reaction.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Endpoint closing down notice:** This endpoint route is closing down and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#list-reactions-for-a-team-discussion) endpoint.List the reactions to a [team discussion](https://docs.github.com/enterprise-cloud@latest//rest/teams/discussions#get-a-discussion).OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder.ReactionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder.ReactionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Endpoint closing down notice:** This endpoint route is closing down and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create reaction for a team discussion`](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#create-reaction-for-a-team-discussion) endpoint.Create a reaction to a [team discussion](https://docs.github.com/enterprise-cloud@latest//rest/teams/discussions#get-a-discussion).A response with an HTTP `200` status means that you already added the reaction type to this team discussion.OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Teams.Item.Discussions.Item.Reactions.ReactionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Endpoint closing down notice:** This endpoint route is closing down and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#list-reactions-for-a-team-discussion) endpoint.List the reactions to a [team discussion](https://docs.github.com/enterprise-cloud@latest//rest/teams/discussions#get-a-discussion).OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class ReactionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Returns a single [reaction type](https://docs.github.com/enterprise-cloud@latest//rest/reactions/reactions#about-reactions). Omit this parameter to list all reactions to a team discussion.</summary>
            [QueryParameter("content")]
            public global::GitHub.Teams.Item.Discussions.Item.Reactions.GetContentQueryParameterType? Content { get; set; }
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
