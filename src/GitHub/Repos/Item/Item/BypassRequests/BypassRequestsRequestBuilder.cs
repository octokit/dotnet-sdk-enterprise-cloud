// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Repos.Item.Item.BypassRequests.PushRules;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.BypassRequests
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\bypass-requests
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class BypassRequestsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The pushRules property</summary>
        public global::GitHub.Repos.Item.Item.BypassRequests.PushRules.PushRulesRequestBuilder PushRules
        {
            get => new global::GitHub.Repos.Item.Item.BypassRequests.PushRules.PushRulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.BypassRequests.BypassRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BypassRequestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/bypass-requests", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.BypassRequests.BypassRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BypassRequestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/bypass-requests", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
