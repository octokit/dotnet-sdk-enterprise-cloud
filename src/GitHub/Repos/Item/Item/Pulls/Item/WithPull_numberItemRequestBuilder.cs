// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.Pulls.Item.Codespaces;
using GitHub.Repos.Item.Item.Pulls.Item.Comments;
using GitHub.Repos.Item.Item.Pulls.Item.Commits;
using GitHub.Repos.Item.Item.Pulls.Item.Files;
using GitHub.Repos.Item.Item.Pulls.Item.Merge;
using GitHub.Repos.Item.Item.Pulls.Item.Requested_reviewers;
using GitHub.Repos.Item.Item.Pulls.Item.Reviews;
using GitHub.Repos.Item.Item.Pulls.Item.UpdateBranch;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\pulls\{pull_number}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithPull_numberItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The codespaces property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Codespaces.CodespacesRequestBuilder Codespaces
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Codespaces.CodespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsRequestBuilder Comments
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commits property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Commits.CommitsRequestBuilder Commits
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Commits.CommitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The files property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Files.FilesRequestBuilder Files
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Files.FilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The merge property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergeRequestBuilder Merge
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The requested_reviewers property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Requested_reviewers.Requested_reviewersRequestBuilder Requested_reviewers
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Requested_reviewers.Requested_reviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reviews property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsRequestBuilder Reviews
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updateBranch property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.UpdateBranch.UpdateBranchRequestBuilder UpdateBranch
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.Item.UpdateBranch.UpdateBranchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPull_numberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/pulls/{pull_number}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPull_numberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/pulls/{pull_number}", rawUrl)
        {
        }
        /// <summary>
        /// Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists details of a pull request by providing its number.When you get, [create](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls/#create-a-pull-request), or [edit](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#update-a-pull-request) a pull request, GitHub Enterprise Cloud creates a merge commit to test whether the pull request can be automatically merged into the base branch. This test commit is not added to the base branch or the head branch. You can review the status of the test commit using the `mergeable` key. For more information, see &quot;[Checking mergeability of pull requests](https://docs.github.com/enterprise-cloud@latest//rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)&quot;.The value of the `mergeable` attribute can be `true`, `false`, or `null`. If the value is `null`, then GitHub Enterprise Cloud has started a background job to compute the mergeability. After giving the job time to complete, resubmit the request. When the job finishes, you will see a non-`null` value for the `mergeable` attribute in the response. If `mergeable` is `true`, then `merge_commit_sha` will be the SHA of the _test_ merge commit.The value of the `merge_commit_sha` attribute changes depending on the state of the pull request. Before merging a pull request, the `merge_commit_sha` attribute holds the SHA of the _test_ merge commit. After merging a pull request, the `merge_commit_sha` attribute changes depending on how you merged the pull request:*   If merged as a [merge commit](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/), `merge_commit_sha` represents the SHA of the merge commit.*   If merged via a [squash](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/#squashing-your-merge-commits), `merge_commit_sha` represents the SHA of the squashed commit on the base branch.*   If [rebased](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/#rebasing-and-merging-your-commits), `merge_commit_sha` represents the commit that the base branch was updated to.Pass the appropriate [media type](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types) to fetch diff and patch formats.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.- **`application/vnd.github.diff`**: For more information, see &quot;[git-diff](https://git-scm.com/docs/git-diff)&quot; in the Git documentation. If a diff is corrupt, contact us through the [GitHub Support portal](https://support.github.com/). Include the repository name and pull request ID in your message.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#get-a-pull-request" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PullRequest"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 406 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
        /// <exception cref="global::GitHub.Models.PullRequest503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PullRequest?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PullRequest> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "406", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.PullRequest503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.PullRequest>(requestInfo, global::GitHub.Models.PullRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#update-a-pull-request" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PullRequest"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PullRequest?> PatchAsync(global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PullRequest> PatchAsync(global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.PullRequest>(requestInfo, global::GitHub.Models.PullRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists details of a pull request by providing its number.When you get, [create](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls/#create-a-pull-request), or [edit](https://docs.github.com/enterprise-cloud@latest//rest/pulls/pulls#update-a-pull-request) a pull request, GitHub Enterprise Cloud creates a merge commit to test whether the pull request can be automatically merged into the base branch. This test commit is not added to the base branch or the head branch. You can review the status of the test commit using the `mergeable` key. For more information, see &quot;[Checking mergeability of pull requests](https://docs.github.com/enterprise-cloud@latest//rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)&quot;.The value of the `mergeable` attribute can be `true`, `false`, or `null`. If the value is `null`, then GitHub Enterprise Cloud has started a background job to compute the mergeability. After giving the job time to complete, resubmit the request. When the job finishes, you will see a non-`null` value for the `mergeable` attribute in the response. If `mergeable` is `true`, then `merge_commit_sha` will be the SHA of the _test_ merge commit.The value of the `merge_commit_sha` attribute changes depending on the state of the pull request. Before merging a pull request, the `merge_commit_sha` attribute holds the SHA of the _test_ merge commit. After merging a pull request, the `merge_commit_sha` attribute changes depending on how you merged the pull request:*   If merged as a [merge commit](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/), `merge_commit_sha` represents the SHA of the merge commit.*   If merged via a [squash](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/#squashing-your-merge-commits), `merge_commit_sha` represents the SHA of the squashed commit on the base branch.*   If [rebased](https://docs.github.com/enterprise-cloud@latest//articles/about-merge-methods-on-github/#rebasing-and-merging-your-commits), `merge_commit_sha` represents the commit that the base branch was updated to.Pass the appropriate [media type](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types) to fetch diff and patch formats.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.- **`application/vnd.github.diff`**: For more information, see &quot;[git-diff](https://git-scm.com/docs/git-diff)&quot; in the Git documentation. If a diff is corrupt, contact us through the [GitHub Support portal](https://support.github.com/). Include the repository name and pull request ID in your message.
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
        /// Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
