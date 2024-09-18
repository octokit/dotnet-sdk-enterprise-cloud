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
namespace GitHub.Enterprises.Item.Actions.Runners.RegistrationToken
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\actions\runners\registration-token
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RegistrationTokenRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RegistrationTokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/runners/registration-token", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RegistrationTokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/runners/registration-token", rawUrl)
        {
        }
        /// <summary>
        /// Returns a token that you can pass to the `config` script. The token expires after one hour.Example using registration token:Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.```./config.sh --url https://github.com/enterprises/octo-enterprise --token TOKEN```OAuth app tokens and personal access tokens (classic) need the `manage_runners:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/actions/self-hosted-runners#create-a-registration-token-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.AuthenticationToken"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.AuthenticationToken?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.AuthenticationToken> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.AuthenticationToken>(requestInfo, global::GitHub.Models.AuthenticationToken.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a token that you can pass to the `config` script. The token expires after one hour.Example using registration token:Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.```./config.sh --url https://github.com/enterprises/octo-enterprise --token TOKEN```OAuth app tokens and personal access tokens (classic) need the `manage_runners:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
