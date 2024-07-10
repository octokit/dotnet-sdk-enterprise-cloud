// <auto-generated/>
using GitHub.Enterprises.Item.Actions.Oidc.Customization.Issuer;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Actions.Oidc.Customization {
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\actions\oidc\customization
    /// </summary>
    public class CustomizationRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The issuer property</summary>
        public IssuerRequestBuilder Issuer
        {
            get => new IssuerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomizationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/oidc/customization", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomizationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/oidc/customization", rawUrl)
        {
        }
    }
}
