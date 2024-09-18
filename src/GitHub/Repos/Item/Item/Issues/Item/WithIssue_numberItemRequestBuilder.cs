// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.Issues.Item.Assignees;
using GitHub.Repos.Item.Item.Issues.Item.Comments;
using GitHub.Repos.Item.Item.Issues.Item.Events;
using GitHub.Repos.Item.Item.Issues.Item.Labels;
using GitHub.Repos.Item.Item.Issues.Item.Lock;
using GitHub.Repos.Item.Item.Issues.Item.Reactions;
using GitHub.Repos.Item.Item.Issues.Item.Timeline;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Issues.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\issues\{issue_number}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithIssue_numberItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The assignees property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Assignees.AssigneesRequestBuilder Assignees
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Assignees.AssigneesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Comments.CommentsRequestBuilder Comments
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Comments.CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsRequestBuilder Labels
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lock property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Lock.LockRequestBuilder Lock
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Lock.LockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reactions property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsRequestBuilder Reactions
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeline property</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Timeline.TimelineRequestBuilder Timeline
        {
            get => new global::GitHub.Repos.Item.Item.Issues.Item.Timeline.TimelineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithIssue_numberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/{issue_number}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithIssue_numberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/{issue_number}", rawUrl)
        {
        }
        /// <summary>
        /// The API returns a [`301 Moved Permanently` status](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-using-the-rest-api#follow-redirects) if the issue was[transferred](https://docs.github.com/enterprise-cloud@latest//articles/transferring-an-issue-to-another-repository/) to another repository. Ifthe issue was transferred to or deleted from a repository where the authenticated user lacks read access, the APIreturns a `404 Not Found` status. If the issue was deleted from a repository where the authenticated user has readaccess, the API returns a `410 Gone` status. To receive webhook events for transferred and deleted issues, subscribeto the [`issues`](https://docs.github.com/enterprise-cloud@latest//webhooks/event-payloads/#issues) webhook.&gt; [!NOTE]&gt; GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For this reason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pull request id, use the &quot;[List pull requests](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/issues/issues#get-an-issue" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Issue"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 410 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Issue?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Issue> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "410", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.Issue>(requestInfo, global::GitHub.Models.Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Issue owners and users with push access can edit an issue.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/issues/issues#update-an-issue" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Issue"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 410 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.Issue503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Issue?> PatchAsync(global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Issue> PatchAsync(global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "410", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Issue503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.Issue>(requestInfo, global::GitHub.Models.Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The API returns a [`301 Moved Permanently` status](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-using-the-rest-api#follow-redirects) if the issue was[transferred](https://docs.github.com/enterprise-cloud@latest//articles/transferring-an-issue-to-another-repository/) to another repository. Ifthe issue was transferred to or deleted from a repository where the authenticated user lacks read access, the APIreturns a `404 Not Found` status. If the issue was deleted from a repository where the authenticated user has readaccess, the API returns a `410 Gone` status. To receive webhook events for transferred and deleted issues, subscribeto the [`issues`](https://docs.github.com/enterprise-cloud@latest//webhooks/event-payloads/#issues) webhook.&gt; [!NOTE]&gt; GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For this reason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pull request id, use the &quot;[List pull requests](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Issue owners and users with push access can edit an issue.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Issues.Item.WithIssue_numberItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
