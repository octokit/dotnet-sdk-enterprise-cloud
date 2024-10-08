// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Orgs.Item.Dependabot.Alerts;
using GitHub.Orgs.Item.Dependabot.Secrets;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.Dependabot
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\dependabot
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class DependabotRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The alerts property</summary>
        public global::GitHub.Orgs.Item.Dependabot.Alerts.AlertsRequestBuilder Alerts
        {
            get => new global::GitHub.Orgs.Item.Dependabot.Alerts.AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secrets property</summary>
        public global::GitHub.Orgs.Item.Dependabot.Secrets.SecretsRequestBuilder Secrets
        {
            get => new global::GitHub.Orgs.Item.Dependabot.Secrets.SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Dependabot.DependabotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DependabotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/dependabot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Dependabot.DependabotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DependabotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/dependabot", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
