// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Repos.Item.Item.Codeowners.Errors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Codeowners
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\codeowners
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CodeownersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The errors property</summary>
        public global::GitHub.Repos.Item.Item.Codeowners.Errors.ErrorsRequestBuilder Errors
        {
            get => new global::GitHub.Repos.Item.Item.Codeowners.Errors.ErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Codeowners.CodeownersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeownersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/codeowners", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Codeowners.CodeownersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeownersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/codeowners", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
