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
    /// The status of a commit.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Status : IAdditionalDataHolder, IParsable
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
        /// <summary>The context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Context { get; set; }
#nullable restore
#else
        public string Context { get; set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Creator { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Creator { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
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
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The target_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl { get; set; }
#nullable restore
#else
        public string TargetUrl { get; set; }
#endif
        /// <summary>The updated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.Status"/> and sets the default values.
        /// </summary>
        public Status()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Status"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Status CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Status();
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
                { "context", n => { Context = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "creator", n => { Creator = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "target_url", n => { TargetUrl = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
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
            writer.WriteStringValue("context", Context);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("creator", Creator);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("target_url", TargetUrl);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
