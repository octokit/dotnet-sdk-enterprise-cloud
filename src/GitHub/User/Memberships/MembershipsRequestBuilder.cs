// <auto-generated/>
using GitHub.User.Memberships.Orgs;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.User.Memberships {
    /// <summary>
    /// Builds and executes requests for operations under \user\memberships
    /// </summary>
    public class MembershipsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The orgs property</summary>
        public OrgsRequestBuilder Orgs
        {
            get => new OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="MembershipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembershipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/memberships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MembershipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembershipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/memberships", rawUrl)
        {
        }
    }
}