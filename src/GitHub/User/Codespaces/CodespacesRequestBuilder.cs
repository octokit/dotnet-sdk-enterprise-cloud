// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.User.Codespaces.Item;
using GitHub.User.Codespaces.Secrets;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.User.Codespaces
{
    /// <summary>
    /// Builds and executes requests for operations under \user\codespaces
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CodespacesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The secrets property</summary>
        public global::GitHub.User.Codespaces.Secrets.SecretsRequestBuilder Secrets
        {
            get => new global::GitHub.User.Codespaces.Secrets.SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.user.codespaces.item collection</summary>
        /// <param name="position">The name of the codespace.</param>
        /// <returns>A <see cref="global::GitHub.User.Codespaces.Item.WithCodespace_nameItemRequestBuilder"/></returns>
        public global::GitHub.User.Codespaces.Item.WithCodespace_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("codespace_name", position);
                return new global::GitHub.User.Codespaces.Item.WithCodespace_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Codespaces.CodespacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodespacesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/codespaces{?page*,per_page*,repository_id*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Codespaces.CodespacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodespacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/codespaces{?page*,per_page*,repository_id*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the authenticated user&apos;s codespaces.OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/codespaces/codespaces#list-codespaces-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.User.Codespaces.CodespacesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.User.Codespaces.CodespacesGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.User.Codespaces.CodespacesGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.User.Codespaces.CodespacesGetResponse>(requestInfo, global::GitHub.User.Codespaces.CodespacesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new codespace, owned by the authenticated user.This endpoint requires either a `repository_id` OR a `pull_request` but not both.OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/codespaces/codespaces#create-a-codespace-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Codespace"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.Codespace503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Codespace?> PostAsync(global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Codespace> PostAsync(global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Codespace503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.Codespace>(requestInfo, global::GitHub.Models.Codespace.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the authenticated user&apos;s codespaces.OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new codespace, owned by the authenticated user.This endpoint requires either a `repository_id` OR a `pull_request` but not both.OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.User.Codespaces.CodespacesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.User.Codespaces.CodespacesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.User.Codespaces.CodespacesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1"/>, <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CodespacesPostRequestBody : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1? CodespacesPostRequestBodyCodespacesPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1 CodespacesPostRequestBodyCodespacesPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2? CodespacesPostRequestBodyCodespacesPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2 CodespacesPostRequestBodyCodespacesPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1? CodespacesPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1 CodespacesPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2? CodespacesPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2 CodespacesPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.User.Codespaces.CodespacesRequestBuilder.CodespacesPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CodespacesPostRequestBodyCodespacesPostRequestBodyMember1 = new global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CodespacesPostRequestBodyCodespacesPostRequestBodyMember2 = new global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CodespacesPostRequestBodyMember1 = new global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CodespacesPostRequestBodyMember2 = new global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CodespacesPostRequestBodyCodespacesPostRequestBodyMember1 != null)
                {
                    return CodespacesPostRequestBodyCodespacesPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CodespacesPostRequestBodyCodespacesPostRequestBodyMember2 != null)
                {
                    return CodespacesPostRequestBodyCodespacesPostRequestBodyMember2.GetFieldDeserializers();
                }
                else if(CodespacesPostRequestBodyMember1 != null)
                {
                    return CodespacesPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CodespacesPostRequestBodyMember2 != null)
                {
                    return CodespacesPostRequestBodyMember2.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(CodespacesPostRequestBodyCodespacesPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1>(null, CodespacesPostRequestBodyCodespacesPostRequestBodyMember1);
                }
                else if(CodespacesPostRequestBodyCodespacesPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2>(null, CodespacesPostRequestBodyCodespacesPostRequestBodyMember2);
                }
                else if(CodespacesPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1>(null, CodespacesPostRequestBodyMember1);
                }
                else if(CodespacesPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember2>(null, CodespacesPostRequestBodyMember2);
                }
            }
        }
        /// <summary>
        /// Lists the authenticated user&apos;s codespaces.OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CodespacesRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>ID of the Repository to filter on</summary>
            [QueryParameter("repository_id")]
            public int? RepositoryId { get; set; }
        }
    }
}
#pragma warning restore CS0618
