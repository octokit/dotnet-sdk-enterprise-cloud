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
    /// Thread
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ThreadObject : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The last_read_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastReadAt { get; set; }
#nullable restore
#else
        public string LastReadAt { get; set; }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.MinimalRepository Repository { get; set; }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Thread_subject? Subject { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Thread_subject Subject { get; set; }
#endif
        /// <summary>The subscription_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionUrl { get; set; }
#nullable restore
#else
        public string SubscriptionUrl { get; set; }
#endif
        /// <summary>The unread property</summary>
        public bool? Unread { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.ThreadObject"/> and sets the default values.
        /// </summary>
        public ThreadObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ThreadObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ThreadObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ThreadObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetStringValue(); } },
                { "last_read_at", n => { LastReadAt = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "repository", n => { Repository = n.GetObjectValue<global::GitHub.Models.MinimalRepository>(global::GitHub.Models.MinimalRepository.CreateFromDiscriminatorValue); } },
                { "subject", n => { Subject = n.GetObjectValue<global::GitHub.Models.Thread_subject>(global::GitHub.Models.Thread_subject.CreateFromDiscriminatorValue); } },
                { "subscription_url", n => { SubscriptionUrl = n.GetStringValue(); } },
                { "unread", n => { Unread = n.GetBoolValue(); } },
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
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("last_read_at", LastReadAt);
            writer.WriteStringValue("reason", Reason);
            writer.WriteObjectValue<global::GitHub.Models.MinimalRepository>("repository", Repository);
            writer.WriteObjectValue<global::GitHub.Models.Thread_subject>("subject", Subject);
            writer.WriteStringValue("subscription_url", SubscriptionUrl);
            writer.WriteBoolValue("unread", Unread);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
