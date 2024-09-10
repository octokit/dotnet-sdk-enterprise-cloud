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
namespace GitHub.Orgs.Item.RepositoryFineGrainedPermissions
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\repository-fine-grained-permissions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RepositoryFineGrainedPermissionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoryFineGrainedPermissionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/repository-fine-grained-permissions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoryFineGrainedPermissionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/repository-fine-grained-permissions", rawUrl)
        {
        }
        /// <summary>
        /// Lists the fine-grained permissions that can be used in custom repository roles for an organization. For more information, see &quot;[About custom repository roles](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/custom-roles#list-repository-fine-grained-permissions-for-an-organization" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.RepositoryFineGrainedPermission&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.RepositoryFineGrainedPermission>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.RepositoryFineGrainedPermission>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.RepositoryFineGrainedPermission>(requestInfo, global::GitHub.Models.RepositoryFineGrainedPermission.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists the fine-grained permissions that can be used in custom repository roles for an organization. For more information, see &quot;[About custom repository roles](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
