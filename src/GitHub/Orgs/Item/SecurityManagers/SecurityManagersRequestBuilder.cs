// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.SecurityManagers.Teams;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.SecurityManagers
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\security-managers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class SecurityManagersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The teams property</summary>
        public global::GitHub.Orgs.Item.SecurityManagers.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Orgs.Item.SecurityManagers.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityManagersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/security-managers", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityManagersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/security-managers", rawUrl)
        {
        }
        /// <summary>
        /// Lists teams that are security managers for an organization. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;The authenticated user must be an administrator or security manager for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/security-managers#list-security-manager-teams" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.TeamSimple&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.TeamSimple>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.TeamSimple>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.TeamSimple>(requestInfo, global::GitHub.Models.TeamSimple.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists teams that are security managers for an organization. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;The authenticated user must be an administrator or security manager for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
