// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Scim.V2.Enterprises.Item.Groups.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Scim.V2.Enterprises.Item.Groups
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}\Groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class GroupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.scim.v2.enterprises.item.Groups.item collection</summary>
        /// <param name="position">A unique identifier of the SCIM group.</param>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Groups.Item.WithScim_group_ItemRequestBuilder"/></returns>
        public global::GitHub.Scim.V2.Enterprises.Item.Groups.Item.WithScim_group_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("scim_group_id", position);
                return new global::GitHub.Scim.V2.Enterprises.Item.Groups.Item.WithScim_group_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Groups{?count*,excludedAttributes*,filter*,startIndex*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Groups{?count*,excludedAttributes*,filter*,startIndex*}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public preview and subject to change.Lists provisioned SCIM groups in an enterprise.You can improve query search time by using the `excludedAttributes` query parameter with a value of `members` to exclude members from the response.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/enterprise-admin/scim#list-provisioned-scim-groups-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseGroupList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseGroupList?> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseGroupList> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseGroupList>(requestInfo, global::GitHub.Models.ScimEnterpriseGroupList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public preview and subject to change.Creates a SCIM group for an enterprise.When members are part of the group provisioning payload, they&apos;re designated as external group members. Providers are responsible for maintaining a mapping between the `externalId` and `id` for each user.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/enterprise-admin/scim#provision-a-scim-enterprise-group" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseGroupResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseGroupResponse?> PostAsync(global::GitHub.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseGroupResponse> PostAsync(global::GitHub.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseGroupResponse>(requestInfo, global::GitHub.Models.ScimEnterpriseGroupResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public preview and subject to change.Lists provisioned SCIM groups in an enterprise.You can improve query search time by using the `excludedAttributes` query parameter with a value of `members` to exclude members from the response.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public preview and subject to change.Creates a SCIM group for an enterprise.When members are part of the group provisioning payload, they&apos;re designated as external group members. Providers are responsible for maintaining a mapping between the `externalId` and `id` for each user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; SCIM provisioning for users and groups using the REST API is in public preview and subject to change.Lists provisioned SCIM groups in an enterprise.You can improve query search time by using the `excludedAttributes` query parameter with a value of `members` to exclude members from the response.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class GroupsRequestBuilderGetQueryParameters 
        {
            /// <summary>Used for pagination: the number of results to return per page.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Excludes the specified attribute from being returned in the results. Using this parameter can speed up response time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludedAttributes")]
            public string? ExcludedAttributes { get; set; }
#nullable restore
#else
            [QueryParameter("excludedAttributes")]
            public string ExcludedAttributes { get; set; }
#endif
            /// <summary>If specified, only results that match the specified filter will be returned. Multiple filters are not supported. Possible filters are `externalId`, `id`, and `displayName`. For example, `?filter=&quot;externalId eq &apos;9138790-10932-109120392-12321&apos;&quot;`.</summary>
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
