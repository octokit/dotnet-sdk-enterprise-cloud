// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Invitations.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Invitations {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\invitations
    /// </summary>
    public class InvitationsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.orgs.item.invitations.item collection</summary>
        /// <param name="position">The unique identifier of the invitation.</param>
        /// <returns>A <see cref="WithInvitation_ItemRequestBuilder"/></returns>
        public WithInvitation_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("invitation_id", position);
                return new WithInvitation_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="InvitationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvitationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/invitations{?invitation_source*,page*,per_page*,role*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="InvitationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvitationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/invitations{?invitation_source*,page*,per_page*,role*}", rawUrl)
        {
        }
        /// <summary>
        /// The return hash contains a `role` field which refers to the OrganizationInvitation role and will be one of the following values: `direct_member`, `admin`,`billing_manager`, or `hiring_manager`. If the invitee is not a GitHub Enterprise Cloudmember, the `login` field in the return hash will be `null`.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/members#list-pending-organization-invitations" />
        /// </summary>
        /// <returns>A List&lt;OrganizationInvitation&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<OrganizationInvitation>?> GetAsync(Action<RequestConfiguration<InvitationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<OrganizationInvitation>> GetAsync(Action<RequestConfiguration<InvitationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<OrganizationInvitation>(requestInfo, OrganizationInvitation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).This endpoint triggers [notifications](https://docs.github.com/enterprise-cloud@latest//github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See &quot;[Secondary rate limits](https://docs.github.com/enterprise-cloud@latest//rest/overview/resources-in-the-rest-api#secondary-rate-limits)&quot; and &quot;[Dealing with secondary rate limits](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)&quot; for details.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/members#create-an-organization-invitation" />
        /// </summary>
        /// <returns>A <see cref="OrganizationInvitation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationInvitation?> PostAsync(InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OrganizationInvitation> PostAsync(InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationInvitation>(requestInfo, OrganizationInvitation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The return hash contains a `role` field which refers to the OrganizationInvitation role and will be one of the following values: `direct_member`, `admin`,`billing_manager`, or `hiring_manager`. If the invitee is not a GitHub Enterprise Cloudmember, the `login` field in the return hash will be `null`.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InvitationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InvitationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).This endpoint triggers [notifications](https://docs.github.com/enterprise-cloud@latest//github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See &quot;[Secondary rate limits](https://docs.github.com/enterprise-cloud@latest//rest/overview/resources-in-the-rest-api#secondary-rate-limits)&quot; and &quot;[Dealing with secondary rate limits](https://docs.github.com/enterprise-cloud@latest//rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)&quot; for details.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="InvitationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public InvitationsRequestBuilder WithUrl(string rawUrl)
        {
            return new InvitationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The return hash contains a `role` field which refers to the OrganizationInvitation role and will be one of the following values: `direct_member`, `admin`,`billing_manager`, or `hiring_manager`. If the invitee is not a GitHub Enterprise Cloudmember, the `login` field in the return hash will be `null`.This endpoint is not available for [Enterprise Managed User (EMU) organizations](https://docs.github.com/enterprise-cloud@latest//admin/identity-and-access-management/using-enterprise-managed-users-for-iam/about-enterprise-managed-users).
        /// </summary>
        public class InvitationsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter invitations by their invitation source.</summary>
            [QueryParameter("invitation_source")]
            public GetInvitation_sourceQueryParameterType? InvitationSource { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Filter invitations by their member role.</summary>
            [QueryParameter("role")]
            public GetRoleQueryParameterType? Role { get; set; }
        }
    }
}
