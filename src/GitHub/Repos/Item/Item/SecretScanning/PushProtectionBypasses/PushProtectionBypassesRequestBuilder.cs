// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\secret-scanning\push-protection-bypasses
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class PushProtectionBypassesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushProtectionBypassesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning/push-protection-bypasses", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushProtectionBypassesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning/push-protection-bypasses", rawUrl)
        {
        }
        /// <summary>
        /// Creates a bypass for a previously push protected secret.The authenticated user must be the original author of the committed secret.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/secret-scanning/secret-scanning#create-a-push-protection-bypass" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.SecretScanningPushProtectionBypass"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.SecretScanningPushProtectionBypass503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.SecretScanningPushProtectionBypass?> PostAsync(global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.SecretScanningPushProtectionBypass> PostAsync(global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "503", global::GitHub.Models.SecretScanningPushProtectionBypass503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.SecretScanningPushProtectionBypass>(requestInfo, global::GitHub.Models.SecretScanningPushProtectionBypass.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a bypass for a previously push protected secret.The authenticated user must be the original author of the committed secret.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
