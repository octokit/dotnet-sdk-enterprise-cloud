// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.User.Blocks;
using GitHub.User.Codespaces;
using GitHub.User.Docker;
using GitHub.User.Email;
using GitHub.User.Emails;
using GitHub.User.Followers;
using GitHub.User.Following;
using GitHub.User.Gpg_keys;
using GitHub.User.Installations;
using GitHub.User.InteractionLimits;
using GitHub.User.Issues;
using GitHub.User.Item;
using GitHub.User.Keys;
using GitHub.User.Marketplace_purchases;
using GitHub.User.Memberships;
using GitHub.User.Migrations;
using GitHub.User.Orgs;
using GitHub.User.Packages;
using GitHub.User.Projects;
using GitHub.User.Public_emails;
using GitHub.User.Repos;
using GitHub.User.Repository_invitations;
using GitHub.User.Social_accounts;
using GitHub.User.Ssh_signing_keys;
using GitHub.User.Starred;
using GitHub.User.Subscriptions;
using GitHub.User.Teams;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.User
{
    /// <summary>
    /// Builds and executes requests for operations under \user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The blocks property</summary>
        public global::GitHub.User.Blocks.BlocksRequestBuilder Blocks
        {
            get => new global::GitHub.User.Blocks.BlocksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codespaces property</summary>
        public global::GitHub.User.Codespaces.CodespacesRequestBuilder Codespaces
        {
            get => new global::GitHub.User.Codespaces.CodespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public global::GitHub.User.Docker.DockerRequestBuilder Docker
        {
            get => new global::GitHub.User.Docker.DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The email property</summary>
        public global::GitHub.User.Email.EmailRequestBuilder Email
        {
            get => new global::GitHub.User.Email.EmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emails property</summary>
        public global::GitHub.User.Emails.EmailsRequestBuilder Emails
        {
            get => new global::GitHub.User.Emails.EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The followers property</summary>
        public global::GitHub.User.Followers.FollowersRequestBuilder Followers
        {
            get => new global::GitHub.User.Followers.FollowersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The following property</summary>
        public global::GitHub.User.Following.FollowingRequestBuilder Following
        {
            get => new global::GitHub.User.Following.FollowingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gpg_keys property</summary>
        public global::GitHub.User.Gpg_keys.Gpg_keysRequestBuilder Gpg_keys
        {
            get => new global::GitHub.User.Gpg_keys.Gpg_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installations property</summary>
        public global::GitHub.User.Installations.InstallationsRequestBuilder Installations
        {
            get => new global::GitHub.User.Installations.InstallationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The interactionLimits property</summary>
        public global::GitHub.User.InteractionLimits.InteractionLimitsRequestBuilder InteractionLimits
        {
            get => new global::GitHub.User.InteractionLimits.InteractionLimitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public global::GitHub.User.Issues.IssuesRequestBuilder Issues
        {
            get => new global::GitHub.User.Issues.IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public global::GitHub.User.Keys.KeysRequestBuilder Keys
        {
            get => new global::GitHub.User.Keys.KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The marketplace_purchases property</summary>
        public global::GitHub.User.Marketplace_purchases.Marketplace_purchasesRequestBuilder Marketplace_purchases
        {
            get => new global::GitHub.User.Marketplace_purchases.Marketplace_purchasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        public global::GitHub.User.Memberships.MembershipsRequestBuilder Memberships
        {
            get => new global::GitHub.User.Memberships.MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrations property</summary>
        public global::GitHub.User.Migrations.MigrationsRequestBuilder Migrations
        {
            get => new global::GitHub.User.Migrations.MigrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orgs property</summary>
        public global::GitHub.User.Orgs.OrgsRequestBuilder Orgs
        {
            get => new global::GitHub.User.Orgs.OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public global::GitHub.User.Packages.PackagesRequestBuilder Packages
        {
            get => new global::GitHub.User.Packages.PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public global::GitHub.User.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.User.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public_emails property</summary>
        public global::GitHub.User.Public_emails.Public_emailsRequestBuilder Public_emails
        {
            get => new global::GitHub.User.Public_emails.Public_emailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public global::GitHub.User.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.User.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repository_invitations property</summary>
        public global::GitHub.User.Repository_invitations.Repository_invitationsRequestBuilder Repository_invitations
        {
            get => new global::GitHub.User.Repository_invitations.Repository_invitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The social_accounts property</summary>
        public global::GitHub.User.Social_accounts.Social_accountsRequestBuilder Social_accounts
        {
            get => new global::GitHub.User.Social_accounts.Social_accountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssh_signing_keys property</summary>
        public global::GitHub.User.Ssh_signing_keys.Ssh_signing_keysRequestBuilder Ssh_signing_keys
        {
            get => new global::GitHub.User.Ssh_signing_keys.Ssh_signing_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The starred property</summary>
        public global::GitHub.User.Starred.StarredRequestBuilder Starred
        {
            get => new global::GitHub.User.Starred.StarredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public global::GitHub.User.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new global::GitHub.User.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::GitHub.User.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.User.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.user.item collection</summary>
        /// <param name="position">account_id parameter</param>
        /// <returns>A <see cref="global::GitHub.User.Item.WithAccount_ItemRequestBuilder"/></returns>
        public global::GitHub.User.Item.WithAccount_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("account_id", position);
                return new global::GitHub.User.Item.WithAccount_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", rawUrl)
        {
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope in order for the response to include private profile information.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/users#get-the-authenticated-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.User.UserRequestBuilder.UserGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.User.UserRequestBuilder.UserGetResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.User.UserRequestBuilder.UserGetResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.User.UserRequestBuilder.UserGetResponse>(requestInfo, global::GitHub.User.UserRequestBuilder.UserGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/users#update-the-authenticated-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PrivateUser"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PrivateUser?> PatchAsync(global::GitHub.User.UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PrivateUser> PatchAsync(global::GitHub.User.UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.PrivateUser>(requestInfo, global::GitHub.Models.PrivateUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope in order for the response to include private profile information.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.User.UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.User.UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.User.UserRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.User.UserRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.User.UserRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.PrivateUser"/>, <see cref="global::GitHub.Models.PublicUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class UserGetResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.PrivateUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.PublicUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.User.UserRequestBuilder.UserGetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.User.UserRequestBuilder.UserGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("user_view_type")?.GetStringValue();
                var result = new global::GitHub.User.UserRequestBuilder.UserGetResponse();
                if("private".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PrivateUser = new global::GitHub.Models.PrivateUser();
                }
                else if("public".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PublicUser = new global::GitHub.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PrivateUser != null)
                {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null)
                {
                    return PublicUser.GetFieldDeserializers();
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
                if(PrivateUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.PublicUser>(null, PublicUser);
                }
            }
        }
    }
}
#pragma warning restore CS0618
