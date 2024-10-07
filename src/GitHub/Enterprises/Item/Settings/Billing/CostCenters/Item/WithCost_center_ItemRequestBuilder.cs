// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item.Resource;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\settings\billing\cost-centers\{cost_center_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithCost_center_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The resource property</summary>
        public global::GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item.Resource.ResourceRequestBuilder Resource
        {
            get => new global::GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item.Resource.ResourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item.WithCost_center_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCost_center_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/settings/billing/cost-centers/{cost_center_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Settings.Billing.CostCenters.Item.WithCost_center_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCost_center_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/settings/billing/cost-centers/{cost_center_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
