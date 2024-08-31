// <auto-generated/>
using GitHub.Enterprises.Item.Team.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Team
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\team
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class TeamRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.enterprises.item.team.item collection</summary>
        /// <param name="position">The slug of the team name.</param>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Team.Item.WithTeam_slugItemRequestBuilder"/></returns>
        public global::GitHub.Enterprises.Item.Team.Item.WithTeam_slugItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("team_slug", position);
                return new global::GitHub.Enterprises.Item.Team.Item.WithTeam_slugItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Team.TeamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/team", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Team.TeamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/team", rawUrl)
        {
        }
    }
}
