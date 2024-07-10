// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Copilot.Billing.Selected_users {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing\selected_users
    /// </summary>
    public class Selected_usersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="Selected_usersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_usersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_users", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Selected_usersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_usersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_users", rawUrl)
        {
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Cancels the Copilot seat assignment for each user specified.This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.For more information about Copilot pricing, see &quot;[Pricing for GitHub Copilot](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)&quot;.For more information about disabling access to Copilot Business or Enterprise, see &quot;[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/enterprise-cloud@latest//copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)&quot;.Only organization owners can cancel Copilot seats for their organization members.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/copilot/copilot-user-management#remove-users-from-the-copilot-subscription-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="Selected_usersDeleteResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_usersDeleteResponse?> DeleteAsync(Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Selected_usersDeleteResponse> DeleteAsync(Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_usersDeleteResponse>(requestInfo, Selected_usersDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Purchases a GitHub Copilot seat for each user specified.The organization will be billed accordingly. For more information about Copilot pricing, see &quot;[Pricing for GitHub Copilot](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)&quot;.Only organization owners can add Copilot seats for their organization members.In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.For more information about setting up a Copilot subscription, see &quot;[Setting up a Copilot subscription for your organization](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise)&quot;.For more information about setting a suggestion matching policy, see &quot;[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/enterprise-cloud@latest//copilot/managing-copilot/managing-policies-for-github-copilot-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)&quot;.The response will contain the total number of new seats that were created and existing seats that were refreshed.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/copilot/copilot-user-management#add-users-to-the-copilot-subscription-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="Selected_usersPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_usersPostResponse?> PostAsync(Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Selected_usersPostResponse> PostAsync(Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_usersPostResponse>(requestInfo, Selected_usersPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Cancels the Copilot seat assignment for each user specified.This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.For more information about Copilot pricing, see &quot;[Pricing for GitHub Copilot](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)&quot;.For more information about disabling access to Copilot Business or Enterprise, see &quot;[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/enterprise-cloud@latest//copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)&quot;.Only organization owners can cancel Copilot seats for their organization members.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Selected_usersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Purchases a GitHub Copilot seat for each user specified.The organization will be billed accordingly. For more information about Copilot pricing, see &quot;[Pricing for GitHub Copilot](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)&quot;.Only organization owners can add Copilot seats for their organization members.In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.For more information about setting up a Copilot subscription, see &quot;[Setting up a Copilot subscription for your organization](https://docs.github.com/enterprise-cloud@latest//billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise)&quot;.For more information about setting a suggestion matching policy, see &quot;[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/enterprise-cloud@latest//copilot/managing-copilot/managing-policies-for-github-copilot-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)&quot;.The response will contain the total number of new seats that were created and existing seats that were refreshed.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Selected_usersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Selected_usersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Selected_usersRequestBuilder WithUrl(string rawUrl)
        {
            return new Selected_usersRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}