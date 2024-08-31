// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Environments.Item.DeploymentBranchPolicies;
using GitHub.Repos.Item.Item.Environments.Item.Deployment_protection_rules;
using GitHub.Repos.Item.Item.Environments.Item.Secrets;
using GitHub.Repos.Item.Item.Environments.Item.Variables;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Environments.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\environments\{environment_name}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithEnvironment_nameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The deployment_protection_rules property</summary>
        public global::GitHub.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Deployment_protection_rulesRequestBuilder Deployment_protection_rules
        {
            get => new global::GitHub.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Deployment_protection_rulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deploymentBranchPolicies property</summary>
        public global::GitHub.Repos.Item.Item.Environments.Item.DeploymentBranchPolicies.DeploymentBranchPoliciesRequestBuilder DeploymentBranchPolicies
        {
            get => new global::GitHub.Repos.Item.Item.Environments.Item.DeploymentBranchPolicies.DeploymentBranchPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secrets property</summary>
        public global::GitHub.Repos.Item.Item.Environments.Item.Secrets.SecretsRequestBuilder Secrets
        {
            get => new global::GitHub.Repos.Item.Item.Environments.Item.Secrets.SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The variables property</summary>
        public global::GitHub.Repos.Item.Item.Environments.Item.Variables.VariablesRequestBuilder Variables
        {
            get => new global::GitHub.Repos.Item.Item.Environments.Item.Variables.VariablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnvironment_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/environments/{environment_name}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnvironment_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/environments/{environment_name}", rawUrl)
        {
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/deployments/environments#delete-an-environment" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
        /// &gt; [!NOTE]&gt; To get information about name patterns that branches must match in order to deploy to this environment, see &quot;[Get a deployment branch policy](/rest/deployments/branch-policies#get-a-deployment-branch-policy).&quot;Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/deployments/environments#get-an-environment" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnvironmentObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.EnvironmentObject?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.EnvironmentObject> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.EnvironmentObject>(requestInfo, global::GitHub.Models.EnvironmentObject.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see &quot;[Environments](/actions/reference/environments#environment-protection-rules).&quot;&gt; [!NOTE]&gt; To create or update name patterns that branches must match in order to deploy to this environment, see &quot;[Deployment branch policies](/rest/deployments/branch-policies).&quot;&gt; [!NOTE]&gt; To create or update secrets for an environment, see &quot;[GitHub Actions secrets](/rest/actions/secrets).&quot;OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/deployments/environments#create-or-update-an-environment" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnvironmentObject"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.EnvironmentObject?> PutAsync(global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.EnvironmentObject> PutAsync(global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.EnvironmentObject>(requestInfo, global::GitHub.Models.EnvironmentObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
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
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; To get information about name patterns that branches must match in order to deploy to this environment, see &quot;[Get a deployment branch policy](/rest/deployments/branch-policies#get-a-deployment-branch-policy).&quot;Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
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
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see &quot;[Environments](/actions/reference/environments#environment-protection-rules).&quot;&gt; [!NOTE]&gt; To create or update name patterns that branches must match in order to deploy to this environment, see &quot;[Deployment branch policies](/rest/deployments/branch-policies).&quot;&gt; [!NOTE]&gt; To create or update secrets for an environment, see &quot;[GitHub Actions secrets](/rest/actions/secrets).&quot;OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_nameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_nameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_nameItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
