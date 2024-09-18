// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Repos.Item.Item.Community.Profile;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Community
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\community
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CommunityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The profile property</summary>
        public global::GitHub.Repos.Item.Item.Community.Profile.ProfileRequestBuilder Profile
        {
            get => new global::GitHub.Repos.Item.Item.Community.Profile.ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Community.CommunityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommunityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/community", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Community.CommunityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommunityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/community", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
