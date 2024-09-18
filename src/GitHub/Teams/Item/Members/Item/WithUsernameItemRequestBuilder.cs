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
namespace GitHub.Teams.Item.Members.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \teams\{team_id}\members\{username}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithUsernameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Members.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/members/{username}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Members.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/members/{username}", rawUrl)
        {
        }
        /// <summary>
        /// The &quot;Remove team member&quot; endpoint (described below) is deprecated.We recommend using the [Remove team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#remove-team-membership-for-a-user) endpoint instead. It allows you to remove both active and pending memberships.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To remove a team member, the authenticated user must have &apos;admin&apos; permissions to the team or be an owner of the org that the team is associated with. Removing a team member does not delete the user, it just removes them from the team.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Cloud team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Cloud](https://docs.github.com/enterprise-cloud@latest//articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/teams/members#remove-team-member-legacy" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The &quot;Get team member&quot; endpoint (described below) is deprecated.We recommend using the [Get team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.To list members in a team, the team must be visible to the authenticated user.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/teams/members#get-team-member-legacy" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The &quot;Add team member&quot; endpoint (described below) is deprecated.We recommend using the [Add or update team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#add-or-update-team-membership-for-a-user) endpoint instead. It allows you to invite new organization members to your teams.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To add someone to a team, the authenticated user must be an organization owner or a team maintainer in the team they&apos;re changing. The person being added to the team must be a member of the team&apos;s organization.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Cloud team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Cloud](https://docs.github.com/enterprise-cloud@latest//articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;Note that you&apos;ll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/enterprise-cloud@latest//rest/guides/getting-started-with-the-rest-api#http-method).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/teams/members#add-team-member-legacy" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The &quot;Remove team member&quot; endpoint (described below) is deprecated.We recommend using the [Remove team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#remove-team-membership-for-a-user) endpoint instead. It allows you to remove both active and pending memberships.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To remove a team member, the authenticated user must have &apos;admin&apos; permissions to the team or be an owner of the org that the team is associated with. Removing a team member does not delete the user, it just removes them from the team.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Cloud team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Cloud](https://docs.github.com/enterprise-cloud@latest//articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// The &quot;Get team member&quot; endpoint (described below) is deprecated.We recommend using the [Get team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
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
            return requestInfo;
        }
        /// <summary>
        /// The &quot;Add team member&quot; endpoint (described below) is deprecated.We recommend using the [Add or update team membership for a user](https://docs.github.com/enterprise-cloud@latest//rest/teams/members#add-or-update-team-membership-for-a-user) endpoint instead. It allows you to invite new organization members to your teams.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-cloud@latest//github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To add someone to a team, the authenticated user must be an organization owner or a team maintainer in the team they&apos;re changing. The person being added to the team must be a member of the team&apos;s organization.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Cloud team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Cloud](https://docs.github.com/enterprise-cloud@latest//articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;Note that you&apos;ll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/enterprise-cloud@latest//rest/guides/getting-started-with-the-rest-api#http-method).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Teams.Item.Members.Item.WithUsernameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Members.Item.WithUsernameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Teams.Item.Members.Item.WithUsernameItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
