// <auto-generated/>
using GitHub.Models;
using GitHub.Users.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Users {
    /// <summary>
    /// Builds and executes requests for operations under \users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.users.item collection</summary>
        /// <param name="position">The handle for the GitHub user account.</param>
        /// <returns>A <see cref="WithUsernameItemRequestBuilder"/></returns>
        public WithUsernameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("username", position);
                return new WithUsernameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?per_page*,since*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?per_page*,since*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Cloud. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/users/users#list-users" />
        /// </summary>
        /// <returns>A List&lt;SimpleUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> GetAsync(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<SimpleUser>> GetAsync(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Cloud. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Cloud. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// </summary>
        public class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>A user ID. Only return users with an ID greater than this ID.</summary>
            [QueryParameter("since")]
            public int? Since { get; set; }
        }
    }
}