// <auto-generated/>
using GitHub.User.Installations.Item.Repositories;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.User.Installations.Item {
    /// <summary>
    /// Builds and executes requests for operations under \user\installations\{installation_id}
    /// </summary>
    public class WithInstallation_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The repositories property</summary>
        public RepositoriesRequestBuilder Repositories
        {
            get => new RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithInstallation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInstallation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/installations/{installation_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithInstallation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInstallation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/installations/{installation_id}", rawUrl)
        {
        }
    }
}
