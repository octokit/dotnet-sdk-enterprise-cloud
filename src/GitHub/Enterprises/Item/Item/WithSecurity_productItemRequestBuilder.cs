// <auto-generated/>
using GitHub.Enterprises.Item.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\{security_product}
    /// </summary>
    public class WithSecurity_productItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.enterprises.item.item.item collection</summary>
        /// <param name="position">The action to take.`enable_all` means to enable the specified security feature for all repositories in the enterprise.`disable_all` means to disable the specified security feature for all repositories in the enterprise.</param>
        /// <returns>A <see cref="WithEnablementItemRequestBuilder"/></returns>
        public WithEnablementItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("enablement", position);
                return new WithEnablementItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSecurity_productItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSecurity_productItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/{security_product}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSecurity_productItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSecurity_productItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/{security_product}", rawUrl)
        {
        }
    }
}