// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.Actions.Cache;
using GitHub.Enterprises.Item.Actions.Oidc;
using GitHub.Enterprises.Item.Actions.Permissions;
using GitHub.Enterprises.Item.Actions.RunnerGroups;
using GitHub.Enterprises.Item.Actions.Runners;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The cache property</summary>
        public global::GitHub.Enterprises.Item.Actions.Cache.CacheRequestBuilder Cache
        {
            get => new global::GitHub.Enterprises.Item.Actions.Cache.CacheRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oidc property</summary>
        public global::GitHub.Enterprises.Item.Actions.Oidc.OidcRequestBuilder Oidc
        {
            get => new global::GitHub.Enterprises.Item.Actions.Oidc.OidcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissions property</summary>
        public global::GitHub.Enterprises.Item.Actions.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new global::GitHub.Enterprises.Item.Actions.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runnerGroups property</summary>
        public global::GitHub.Enterprises.Item.Actions.RunnerGroups.RunnerGroupsRequestBuilder RunnerGroups
        {
            get => new global::GitHub.Enterprises.Item.Actions.RunnerGroups.RunnerGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runners property</summary>
        public global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder Runners
        {
            get => new global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
