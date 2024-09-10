// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Advisories;
using GitHub.App;
using GitHub.AppManifests;
using GitHub.Applications;
using GitHub.Apps;
using GitHub.Assignments;
using GitHub.Classrooms;
using GitHub.Codes_of_conduct;
using GitHub.Emojis;
using GitHub.EnterpriseInstallation;
using GitHub.Enterprises;
using GitHub.Events;
using GitHub.Feeds;
using GitHub.Gists;
using GitHub.Gitignore;
using GitHub.Installation;
using GitHub.Issues;
using GitHub.Licenses;
using GitHub.Markdown;
using GitHub.Marketplace_listing;
using GitHub.Meta;
using GitHub.Models;
using GitHub.Networks;
using GitHub.Notifications;
using GitHub.Octocat;
using GitHub.Organizations;
using GitHub.Orgs;
using GitHub.Projects;
using GitHub.Rate_limit;
using GitHub.Repos;
using GitHub.Repositories;
using GitHub.Scim;
using GitHub.Search;
using GitHub.Teams;
using GitHub.User;
using GitHub.Users;
using GitHub.Versions;
using GitHub.Zen;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class GitHubClient : BaseRequestBuilder
    {
        /// <summary>The advisories property</summary>
        public global::GitHub.Advisories.AdvisoriesRequestBuilder Advisories
        {
            get => new global::GitHub.Advisories.AdvisoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The app property</summary>
        public global::GitHub.App.AppRequestBuilder App
        {
            get => new global::GitHub.App.AppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applications property</summary>
        public global::GitHub.Applications.ApplicationsRequestBuilder Applications
        {
            get => new global::GitHub.Applications.ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appManifests property</summary>
        public global::GitHub.AppManifests.AppManifestsRequestBuilder AppManifests
        {
            get => new global::GitHub.AppManifests.AppManifestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The apps property</summary>
        public global::GitHub.Apps.AppsRequestBuilder Apps
        {
            get => new global::GitHub.Apps.AppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignments property</summary>
        public global::GitHub.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new global::GitHub.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The classrooms property</summary>
        public global::GitHub.Classrooms.ClassroomsRequestBuilder Classrooms
        {
            get => new global::GitHub.Classrooms.ClassroomsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codes_of_conduct property</summary>
        public global::GitHub.Codes_of_conduct.Codes_of_conductRequestBuilder Codes_of_conduct
        {
            get => new global::GitHub.Codes_of_conduct.Codes_of_conductRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emojis property</summary>
        public global::GitHub.Emojis.EmojisRequestBuilder Emojis
        {
            get => new global::GitHub.Emojis.EmojisRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enterpriseInstallation property</summary>
        public global::GitHub.EnterpriseInstallation.EnterpriseInstallationRequestBuilder EnterpriseInstallation
        {
            get => new global::GitHub.EnterpriseInstallation.EnterpriseInstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enterprises property</summary>
        public global::GitHub.Enterprises.EnterprisesRequestBuilder Enterprises
        {
            get => new global::GitHub.Enterprises.EnterprisesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::GitHub.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The feeds property</summary>
        public global::GitHub.Feeds.FeedsRequestBuilder Feeds
        {
            get => new global::GitHub.Feeds.FeedsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gists property</summary>
        public global::GitHub.Gists.GistsRequestBuilder Gists
        {
            get => new global::GitHub.Gists.GistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gitignore property</summary>
        public global::GitHub.Gitignore.GitignoreRequestBuilder Gitignore
        {
            get => new global::GitHub.Gitignore.GitignoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public global::GitHub.Installation.InstallationRequestBuilder Installation
        {
            get => new global::GitHub.Installation.InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public global::GitHub.Issues.IssuesRequestBuilder Issues
        {
            get => new global::GitHub.Issues.IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The licenses property</summary>
        public global::GitHub.Licenses.LicensesRequestBuilder Licenses
        {
            get => new global::GitHub.Licenses.LicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The markdown property</summary>
        public global::GitHub.Markdown.MarkdownRequestBuilder Markdown
        {
            get => new global::GitHub.Markdown.MarkdownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The marketplace_listing property</summary>
        public global::GitHub.Marketplace_listing.Marketplace_listingRequestBuilder Marketplace_listing
        {
            get => new global::GitHub.Marketplace_listing.Marketplace_listingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The meta property</summary>
        public global::GitHub.Meta.MetaRequestBuilder Meta
        {
            get => new global::GitHub.Meta.MetaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The networks property</summary>
        public global::GitHub.Networks.NetworksRequestBuilder Networks
        {
            get => new global::GitHub.Networks.NetworksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notifications property</summary>
        public global::GitHub.Notifications.NotificationsRequestBuilder Notifications
        {
            get => new global::GitHub.Notifications.NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The octocat property</summary>
        public global::GitHub.Octocat.OctocatRequestBuilder Octocat
        {
            get => new global::GitHub.Octocat.OctocatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizations property</summary>
        public global::GitHub.Organizations.OrganizationsRequestBuilder Organizations
        {
            get => new global::GitHub.Organizations.OrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orgs property</summary>
        public global::GitHub.Orgs.OrgsRequestBuilder Orgs
        {
            get => new global::GitHub.Orgs.OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public global::GitHub.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rate_limit property</summary>
        public global::GitHub.Rate_limit.Rate_limitRequestBuilder Rate_limit
        {
            get => new global::GitHub.Rate_limit.Rate_limitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public global::GitHub.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repositories property</summary>
        public global::GitHub.Repositories.RepositoriesRequestBuilder Repositories
        {
            get => new global::GitHub.Repositories.RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scim property</summary>
        public global::GitHub.Scim.ScimRequestBuilder Scim
        {
            get => new global::GitHub.Scim.ScimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public global::GitHub.Search.SearchRequestBuilder Search
        {
            get => new global::GitHub.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::GitHub.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::GitHub.User.UserRequestBuilder User
        {
            get => new global::GitHub.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::GitHub.Users.UsersRequestBuilder Users
        {
            get => new global::GitHub.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The versions property</summary>
        public global::GitHub.Versions.VersionsRequestBuilder Versions
        {
            get => new global::GitHub.Versions.VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The zen property</summary>
        public global::GitHub.Zen.ZenRequestBuilder Zen
        {
            get => new global::GitHub.Zen.ZenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.GitHubClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitHubClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.github.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
        /// <summary>
        /// Get Hypermedia links to resources accessible in GitHub&apos;s REST API
        /// API method documentation <see href="https://docs.github.com/enterprise-cloud@latest//rest/meta/meta#github-api-root" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Root"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Root?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Root> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.Root>(requestInfo, global::GitHub.Models.Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Hypermedia links to resources accessible in GitHub&apos;s REST API
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
    }
}
#pragma warning restore CS0618
