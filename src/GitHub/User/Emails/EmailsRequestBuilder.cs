// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.User.Emails {
    /// <summary>
    /// Builds and executes requests for operations under \user\emails
    /// </summary>
    public class EmailsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="EmailsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/emails{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EmailsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/emails{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/emails#delete-an-email-address-for-the-authenticated-user" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(EmailsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(EmailsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all of your email addresses, and specifies which one is visibleto the public.OAuth app tokens and personal access tokens (classic) need the `user:email` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/emails#list-email-addresses-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A List&lt;GitHub.Models.Email&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<GitHub.Models.Email>?> GetAsync(Action<RequestConfiguration<EmailsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<GitHub.Models.Email>> GetAsync(Action<RequestConfiguration<EmailsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<GitHub.Models.Email>(requestInfo, GitHub.Models.Email.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/emails#add-an-email-address-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A List&lt;GitHub.Models.Email&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<GitHub.Models.Email>?> PostAsync(EmailsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<GitHub.Models.Email>> PostAsync(EmailsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<GitHub.Models.Email>(requestInfo, GitHub.Models.Email.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(EmailsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(EmailsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Lists all of your email addresses, and specifies which one is visibleto the public.OAuth app tokens and personal access tokens (classic) need the `user:email` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EmailsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EmailsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(EmailsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(EmailsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="EmailsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EmailsRequestBuilder WithUrl(string rawUrl)
        {
            return new EmailsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="EmailsDeleteRequestBodyMember1"/>, <see cref="string"/>
        /// </summary>
        public class EmailsDeleteRequestBody : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.User.Emails.EmailsDeleteRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.User.Emails.EmailsDeleteRequestBodyMember1? EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.User.Emails.EmailsDeleteRequestBodyMember1 EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.User.Emails.EmailsDeleteRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.User.Emails.EmailsDeleteRequestBodyMember1? EmailsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.User.Emails.EmailsDeleteRequestBodyMember1 EmailsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EmailsDeleteRequestBodyString { get; set; }
#nullable restore
#else
            public string EmailsDeleteRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="EmailsDeleteRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static EmailsDeleteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new EmailsDeleteRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1 = new GitHub.User.Emails.EmailsDeleteRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailsDeleteRequestBodyMember1 = new GitHub.User.Emails.EmailsDeleteRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string emailsDeleteRequestBodyStringValue)
                {
                    result.EmailsDeleteRequestBodyString = emailsDeleteRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1 != null)
                {
                    return EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                else if(EmailsDeleteRequestBodyMember1 != null)
                {
                    return EmailsDeleteRequestBodyMember1.GetFieldDeserializers();
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
                if(EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.User.Emails.EmailsDeleteRequestBodyMember1>(null, EmailsDeleteRequestBodyEmailsDeleteRequestBodyMember1);
                }
                else if(EmailsDeleteRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.User.Emails.EmailsDeleteRequestBodyMember1>(null, EmailsDeleteRequestBodyMember1);
                }
                else if(EmailsDeleteRequestBodyString != null)
                {
                    writer.WriteStringValue(null, EmailsDeleteRequestBodyString);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="EmailsPostRequestBodyMember1"/>, <see cref="string"/>
        /// </summary>
        public class EmailsPostRequestBody : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.User.Emails.EmailsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.User.Emails.EmailsPostRequestBodyMember1? EmailsPostRequestBodyEmailsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.User.Emails.EmailsPostRequestBodyMember1 EmailsPostRequestBodyEmailsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.User.Emails.EmailsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.User.Emails.EmailsPostRequestBodyMember1? EmailsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.User.Emails.EmailsPostRequestBodyMember1 EmailsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EmailsPostRequestBodyString { get; set; }
#nullable restore
#else
            public string EmailsPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="EmailsPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static EmailsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new EmailsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailsPostRequestBodyEmailsPostRequestBodyMember1 = new GitHub.User.Emails.EmailsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailsPostRequestBodyMember1 = new GitHub.User.Emails.EmailsPostRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string emailsPostRequestBodyStringValue)
                {
                    result.EmailsPostRequestBodyString = emailsPostRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmailsPostRequestBodyEmailsPostRequestBodyMember1 != null)
                {
                    return EmailsPostRequestBodyEmailsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(EmailsPostRequestBodyMember1 != null)
                {
                    return EmailsPostRequestBodyMember1.GetFieldDeserializers();
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
                if(EmailsPostRequestBodyEmailsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.User.Emails.EmailsPostRequestBodyMember1>(null, EmailsPostRequestBodyEmailsPostRequestBodyMember1);
                }
                else if(EmailsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.User.Emails.EmailsPostRequestBodyMember1>(null, EmailsPostRequestBodyMember1);
                }
                else if(EmailsPostRequestBodyString != null)
                {
                    writer.WriteStringValue(null, EmailsPostRequestBodyString);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Lists all of your email addresses, and specifies which one is visibleto the public.OAuth app tokens and personal access tokens (classic) need the `user:email` scope to use this endpoint.
        /// </summary>
        public class EmailsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
