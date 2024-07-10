// <auto-generated/>
using GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\runs\{run_id}\attempts
    /// </summary>
    public class AttemptsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.actions.runs.item.attempts.item collection</summary>
        /// <param name="position">The attempt number of the workflow run.</param>
        /// <returns>A <see cref="WithAttempt_numberItemRequestBuilder"/></returns>
        public WithAttempt_numberItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("attempt_number", position);
                return new WithAttempt_numberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="AttemptsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttemptsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/attempts", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AttemptsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttemptsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/attempts", rawUrl)
        {
        }
    }
}