// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Orgs.Item.Team.Item.Copilot;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.Team.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\team\{team_slug}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithTeam_slugItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The copilot property</summary>
        public global::GitHub.Orgs.Item.Team.Item.Copilot.CopilotRequestBuilder Copilot
        {
            get => new global::GitHub.Orgs.Item.Team.Item.Copilot.CopilotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Team.Item.WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/team/{team_slug}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Team.Item.WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/team/{team_slug}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
