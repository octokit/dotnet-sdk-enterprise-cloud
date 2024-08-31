// <auto-generated/>
using GitHub.Licenses.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Licenses
{
    /// <summary>
    /// Builds and executes requests for operations under \licenses
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class LicensesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.licenses.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::GitHub.Licenses.Item.WithLicenseItemRequestBuilder"/></returns>
        public global::GitHub.Licenses.Item.WithLicenseItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("license", position);
                return new global::GitHub.Licenses.Item.WithLicenseItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Licenses.LicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicensesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/licenses{?featured*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Licenses.LicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicensesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/licenses{?featured*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-cloud@latest//repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/licenses/licenses#get-all-commonly-used-licenses" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.LicenseSimple&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.LicenseSimple>?> GetAsync(Action<RequestConfiguration<global::GitHub.Licenses.LicensesRequestBuilder.LicensesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.LicenseSimple>> GetAsync(Action<RequestConfiguration<global::GitHub.Licenses.LicensesRequestBuilder.LicensesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.LicenseSimple>(requestInfo, global::GitHub.Models.LicenseSimple.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-cloud@latest//repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Licenses.LicensesRequestBuilder.LicensesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Licenses.LicensesRequestBuilder.LicensesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Licenses.LicensesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Licenses.LicensesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Licenses.LicensesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-cloud@latest//repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class LicensesRequestBuilderGetQueryParameters 
        {
            [QueryParameter("featured")]
            public bool? Featured { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
