// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Scim.V2.Organizations.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Scim.V2.Organizations
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\organizations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class OrganizationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.scim.v2.organizations.item collection</summary>
        /// <param name="position">The organization name. The name is not case sensitive.</param>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Organizations.Item.WithOrgItemRequestBuilder"/></returns>
        public global::GitHub.Scim.V2.Organizations.Item.WithOrgItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("org", position);
                return new global::GitHub.Scim.V2.Organizations.Item.WithOrgItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/organizations", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/organizations", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
