// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Review Requested Issue Event
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ReviewRequestedIssueEvent : IAdditionalDataHolder, IParsable
    {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? Actor { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The commit_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitUrl { get; set; }
#nullable restore
#else
        public string CommitUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? RequestedReviewer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser RequestedReviewer { get; set; }
#endif
        /// <summary>Groups of organization members that gives permissions on specified repositories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Team? RequestedTeam { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Team RequestedTeam { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? ReviewRequester { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser ReviewRequester { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ReviewRequestedIssueEvent"/> and sets the default values.
        /// </summary>
        public ReviewRequestedIssueEvent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ReviewRequestedIssueEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ReviewRequestedIssueEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ReviewRequestedIssueEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actor", n => { Actor = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "commit_id", n => { CommitId = n.GetStringValue(); } },
                { "commit_url", n => { CommitUrl = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "event", n => { Event = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<global::GitHub.Models.NullableIntegration>(global::GitHub.Models.NullableIntegration.CreateFromDiscriminatorValue); } },
                { "requested_reviewer", n => { RequestedReviewer = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "requested_team", n => { RequestedTeam = n.GetObjectValue<global::GitHub.Models.Team>(global::GitHub.Models.Team.CreateFromDiscriminatorValue); } },
                { "review_requester", n => { ReviewRequester = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.SimpleUser>("actor", Actor);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteStringValue("commit_url", CommitUrl);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("event", Event);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<global::GitHub.Models.NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteObjectValue<global::GitHub.Models.SimpleUser>("requested_reviewer", RequestedReviewer);
            writer.WriteObjectValue<global::GitHub.Models.Team>("requested_team", RequestedTeam);
            writer.WriteObjectValue<global::GitHub.Models.SimpleUser>("review_requester", ReviewRequester);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
