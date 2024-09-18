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
    /// A GitHub organization.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class OrganizationSimple : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatar_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarUrl { get; set; }
#nullable restore
#else
        public string AvatarUrl { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The hooks_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HooksUrl { get; set; }
#nullable restore
#else
        public string HooksUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The issues_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuesUrl { get; set; }
#nullable restore
#else
        public string IssuesUrl { get; set; }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login { get; set; }
#nullable restore
#else
        public string Login { get; set; }
#endif
        /// <summary>The members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembersUrl { get; set; }
#nullable restore
#else
        public string MembersUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The public_members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicMembersUrl { get; set; }
#nullable restore
#else
        public string PublicMembersUrl { get; set; }
#endif
        /// <summary>The repos_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReposUrl { get; set; }
#nullable restore
#else
        public string ReposUrl { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.OrganizationSimple"/> and sets the default values.
        /// </summary>
        public OrganizationSimple()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrganizationSimple"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.OrganizationSimple CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.OrganizationSimple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avatar_url", n => { AvatarUrl = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "events_url", n => { EventsUrl = n.GetStringValue(); } },
                { "hooks_url", n => { HooksUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "issues_url", n => { IssuesUrl = n.GetStringValue(); } },
                { "login", n => { Login = n.GetStringValue(); } },
                { "members_url", n => { MembersUrl = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "public_members_url", n => { PublicMembersUrl = n.GetStringValue(); } },
                { "repos_url", n => { ReposUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("avatar_url", AvatarUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteStringValue("hooks_url", HooksUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issues_url", IssuesUrl);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("members_url", MembersUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("public_members_url", PublicMembersUrl);
            writer.WriteStringValue("repos_url", ReposUrl);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
