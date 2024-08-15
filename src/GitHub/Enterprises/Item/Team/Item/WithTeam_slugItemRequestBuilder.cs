// <auto-generated/>
using GitHub.Enterprises.Item.Team.Item.Copilot;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Team.Item {
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\team\{team_slug}
    /// </summary>
    public class WithTeam_slugItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The copilot property</summary>
        public CopilotRequestBuilder Copilot
        {
            get => new CopilotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/team/{team_slug}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/team/{team_slug}", rawUrl)
        {
        }
    }
}
