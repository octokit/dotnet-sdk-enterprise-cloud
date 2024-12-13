// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Organizations.Item.Custom_roles;
using GitHub.Organizations.Item.Settings;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Organizations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \organizations\{organization_-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Organization_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The custom_roles property</summary>
        public global::GitHub.Organizations.Item.Custom_roles.Custom_rolesRequestBuilder Custom_roles
        {
            get => new global::GitHub.Organizations.Item.Custom_roles.Custom_rolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::GitHub.Organizations.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::GitHub.Organizations.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Organizations.Item.Organization_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Organization_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Organizations.Item.Organization_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Organization_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618