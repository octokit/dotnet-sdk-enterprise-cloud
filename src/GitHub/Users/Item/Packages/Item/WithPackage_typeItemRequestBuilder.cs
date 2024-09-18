// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Users.Item.Packages.Item.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Users.Item.Packages.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}\packages\{package_type}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithPackage_typeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.users.item.packages.item.item collection</summary>
        /// <param name="position">The name of the package.</param>
        /// <returns>A <see cref="global::GitHub.Users.Item.Packages.Item.Item.WithPackage_nameItemRequestBuilder"/></returns>
        public global::GitHub.Users.Item.Packages.Item.Item.WithPackage_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("package_name", position);
                return new global::GitHub.Users.Item.Packages.Item.Item.WithPackage_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.Packages.Item.WithPackage_typeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPackage_typeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/packages/{package_type}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.Packages.Item.WithPackage_typeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPackage_typeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/packages/{package_type}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
