// <auto-generated/>
using GitHub.Teams.Item.TeamSync.GroupMappings;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Teams.Item.TeamSync {
    /// <summary>
    /// Builds and executes requests for operations under \teams\{team_id}\team-sync
    /// </summary>
    public class TeamSyncRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The groupMappings property</summary>
        public GroupMappingsRequestBuilder GroupMappings
        {
            get => new GroupMappingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="TeamSyncRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamSyncRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/team-sync", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TeamSyncRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamSyncRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/team-sync", rawUrl)
        {
        }
    }
}