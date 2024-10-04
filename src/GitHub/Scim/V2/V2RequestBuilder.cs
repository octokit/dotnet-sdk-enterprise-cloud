// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Scim.V2.Enterprises;
using GitHub.Scim.V2.Organizations;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Scim.V2
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class V2RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The enterprises property</summary>
        public global::GitHub.Scim.V2.Enterprises.EnterprisesRequestBuilder Enterprises
        {
            get => new global::GitHub.Scim.V2.Enterprises.EnterprisesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizations property</summary>
        public global::GitHub.Scim.V2.Organizations.OrganizationsRequestBuilder Organizations
        {
            get => new global::GitHub.Scim.V2.Organizations.OrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
