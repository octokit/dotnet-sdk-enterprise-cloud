// <auto-generated/>
using GitHub.Applications.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Applications {
    /// <summary>
    /// Builds and executes requests for operations under \applications
    /// </summary>
    public class ApplicationsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.applications.item collection</summary>
        /// <param name="position">The client ID of the GitHub app.</param>
        /// <returns>A <see cref="WithClient_ItemRequestBuilder"/></returns>
        public WithClient_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("client_id", position);
                return new WithClient_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="ApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplicationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplicationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications", rawUrl)
        {
        }
    }
}
