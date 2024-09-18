// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Scim.V2.Enterprises.Item.Users.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Scim.V2.Enterprises.Item.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}\Users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.scim.v2.enterprises.item.Users.item collection</summary>
        /// <param name="position">The unique identifier of the SCIM user.</param>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder"/></returns>
        public global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("scim_user_id", position);
                return new global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users{?count*,filter*,startIndex*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users{?count*,filter*,startIndex*}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public beta and subject to change.Lists provisioned SCIM enterprise members.When you remove a user with a SCIM-provisioned external identity from an enterprise using a `patch` with `active` flag to `false`, the user&apos;s metadata remains intact. This means they can potentially re-join the enterprise later. Although, while suspended, the user can&apos;t sign in. If you want to ensure the user can&apos;t re-join in the future, use the delete request. Only users who weren&apos;t permanently deleted will appear in the result list.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/enterprise-admin/scim#list-scim-provisioned-identities-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseUserList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseUserList?> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseUserList> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseUserList>(requestInfo, global::GitHub.Models.ScimEnterpriseUserList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public beta and subject to change.Creates an external identity for a new SCIM enterprise user.SCIM is responsible for user provisioning, not authentication. The actual user authentication is handled by SAML. However, with SCIM enabled, users must first be provisioned via SCIM before they can sign in through SAML.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/enterprise-admin/scim#provision-a-scim-enterprise-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseUserResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseUserResponse?> PostAsync(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseUserResponse> PostAsync(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseUserResponse>(requestInfo, global::GitHub.Models.ScimEnterpriseUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public beta and subject to change.Lists provisioned SCIM enterprise members.When you remove a user with a SCIM-provisioned external identity from an enterprise using a `patch` with `active` flag to `false`, the user&apos;s metadata remains intact. This means they can potentially re-join the enterprise later. Although, while suspended, the user can&apos;t sign in. If you want to ensure the user can&apos;t re-join in the future, use the delete request. Only users who weren&apos;t permanently deleted will appear in the result list.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public beta and subject to change.Creates an external identity for a new SCIM enterprise user.SCIM is responsible for user provisioning, not authentication. The actual user authentication is handled by SAML. However, with SCIM enabled, users must first be provisioned via SCIM before they can sign in through SAML.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public beta and subject to change.Lists provisioned SCIM enterprise members.When you remove a user with a SCIM-provisioned external identity from an enterprise using a `patch` with `active` flag to `false`, the user&apos;s metadata remains intact. This means they can potentially re-join the enterprise later. Although, while suspended, the user can&apos;t sign in. If you want to ensure the user can&apos;t re-join in the future, use the delete request. Only users who weren&apos;t permanently deleted will appear in the result list.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Used for pagination: the number of results to return per page.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>If specified, only results that match the specified filter will be returned. Multiple filters are not supported. Possible filters are `userName`, `externalId`, `id`, and `displayName`. For example, `?filter=&quot;externalId eq &apos;9138790-10932-109120392-12321&apos;&quot;`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Used for pagination: the starting index of the first result to return when paginating through values.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
        }
    }
}
#pragma warning restore CS0618
