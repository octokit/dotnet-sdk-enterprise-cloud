// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Hooks.Item.Deliveries.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Hooks.Item.Deliveries
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\hooks\{hook_id}\deliveries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class DeliveriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.orgs.item.hooks.item.deliveries.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Hooks.Item.Deliveries.Item.WithDelivery_ItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Hooks.Item.Deliveries.Item.WithDelivery_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("delivery_id", position);
                return new global::GitHub.Orgs.Item.Hooks.Item.Deliveries.Item.WithDelivery_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/deliveries{?cursor*,per_page*,redelivery*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/deliveries{?cursor*,per_page*,redelivery*}", rawUrl)
        {
        }
        /// <summary>
        /// You must be an organization owner or have the &quot;Manage organization webhooks&quot; permission to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit webhooksthat they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/orgs/webhooks#list-deliveries-for-an-organization-webhook" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.HookDeliveryItem&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.HookDeliveryItem>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder.DeliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.HookDeliveryItem>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder.DeliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.HookDeliveryItem>(requestInfo, global::GitHub.Models.HookDeliveryItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// You must be an organization owner or have the &quot;Manage organization webhooks&quot; permission to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit webhooksthat they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder.DeliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder.DeliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Hooks.Item.Deliveries.DeliveriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// You must be an organization owner or have the &quot;Manage organization webhooks&quot; permission to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit webhooksthat they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class DeliveriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cursor")]
            public string? Cursor { get; set; }
#nullable restore
#else
            [QueryParameter("cursor")]
            public string Cursor { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-cloud@latest//rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("redelivery")]
            public bool? Redelivery { get; set; }
        }
    }
}
