// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Scim.V2.Organizations.Item.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Scim.V2.Organizations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\organizations\{org}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithOrgItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Users property</summary>
        public global::GitHub.Scim.V2.Organizations.Item.Users.UsersRequestBuilder Users
        {
            get => new global::GitHub.Scim.V2.Organizations.Item.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.Item.WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/organizations/{org}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.Item.WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/organizations/{org}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
