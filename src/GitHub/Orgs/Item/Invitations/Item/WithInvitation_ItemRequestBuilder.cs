// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Invitations.Item.Teams;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Invitations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\invitations\{invitation_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithInvitation_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The teams property</summary>
        public global::GitHub.Orgs.Item.Invitations.Item.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Orgs.Item.Invitations.Item.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Invitations.Item.WithInvitation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvitation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/invitations/{invitation_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Invitations.Item.WithInvitation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvitation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/invitations/{invitation_id}", rawUrl)
        {
        }
        /// <summary>
        /// Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).This endpoint triggers [notifications](https://docs.github.com/enterprise-cloud@latest//github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/members#cancel-an-organization-invitation" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
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
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).This endpoint triggers [notifications](https://docs.github.com/enterprise-cloud@latest//github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Invitations.Item.WithInvitation_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Invitations.Item.WithInvitation_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Invitations.Item.WithInvitation_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
