// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.Actions.Cache.Usage;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Actions.Cache
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\actions\cache
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CacheRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The usage property</summary>
        public global::GitHub.Enterprises.Item.Actions.Cache.Usage.UsageRequestBuilder Usage
        {
            get => new global::GitHub.Enterprises.Item.Actions.Cache.Usage.UsageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Cache.CacheRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CacheRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/cache", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Cache.CacheRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CacheRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/cache", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
