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
namespace GitHub.Search.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \search\users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/users?q={q}{&order*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/users?q={q}{&order*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Find users via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api).When searching for users, you can get text match metadata for the issue **login**, public **email**, and **name** fields when you pass the `text-match` media type. For more details about highlighting search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata). For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata).For example, if you&apos;re looking for a list of popular users, you might try this query:`q=tom+repos:%3E42+followers:%3E1000`This query searches for users with the name `tom`. The results are restricted to users with more than 42 repositories and over 1,000 followers.This endpoint does not accept authentication and will only include publicly visible users. As an alternative, you can use the GraphQL API. The GraphQL API requires authentication and will return private users, including Enterprise Managed Users (EMUs), that you are authorized to view. For more information, see &quot;[GraphQL Queries](https://docs.github.com/enterprise-cloud@latest//graphql/reference/queries#search).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/search/search#search-users" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Search.Users.UsersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.Users503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Search.Users.UsersGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Search.Users.UsersGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Users503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Search.Users.UsersGetResponse>(requestInfo, global::GitHub.Search.Users.UsersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Find users via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api).When searching for users, you can get text match metadata for the issue **login**, public **email**, and **name** fields when you pass the `text-match` media type. For more details about highlighting search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata). For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata).For example, if you&apos;re looking for a list of popular users, you might try this query:`q=tom+repos:%3E42+followers:%3E1000`This query searches for users with the name `tom`. The results are restricted to users with more than 42 repositories and over 1,000 followers.This endpoint does not accept authentication and will only include publicly visible users. As an alternative, you can use the GraphQL API. The GraphQL API requires authentication and will return private users, including Enterprise Managed Users (EMUs), that you are authorized to view. For more information, see &quot;[GraphQL Queries](https://docs.github.com/enterprise-cloud@latest//graphql/reference/queries#search).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Search.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Search.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Search.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Find users via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-cloud@latest//rest/guides/using-pagination-in-the-rest-api).When searching for users, you can get text match metadata for the issue **login**, public **email**, and **name** fields when you pass the `text-match` media type. For more details about highlighting search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata). For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-cloud@latest//rest/search/search#text-match-metadata).For example, if you&apos;re looking for a list of popular users, you might try this query:`q=tom+repos:%3E42+followers:%3E1000`This query searches for users with the name `tom`. The results are restricted to users with more than 42 repositories and over 1,000 followers.This endpoint does not accept authentication and will only include publicly visible users. As an alternative, you can use the GraphQL API. The GraphQL API requires authentication and will return private users, including Enterprise Managed Users (EMUs), that you are authorized to view. For more information, see &quot;[GraphQL Queries](https://docs.github.com/enterprise-cloud@latest//graphql/reference/queries#search).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Search.Users.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub Enterprise Cloud. The REST API supports the same qualifiers as the web interface for GitHub Enterprise Cloud. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/enterprise-cloud@latest//rest/search/search#constructing-a-search-query). See &quot;[Searching users](https://docs.github.com/enterprise-cloud@latest//search-github/searching-on-github/searching-users)&quot; for a detailed list of qualifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>Sorts the results of your query by number of `followers` or `repositories`, or when the person `joined` GitHub Enterprise Cloud. Default: [best match](https://docs.github.com/enterprise-cloud@latest//rest/search/search#ranking-search-results)</summary>
            [QueryParameter("sort")]
            public global::GitHub.Search.Users.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
