// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class Feed__links : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? CurrentUser { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType CurrentUser { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? CurrentUserActor { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType CurrentUserActor { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? CurrentUserOrganization { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType CurrentUserOrganization { get; set; }
#endif
        /// <summary>The current_user_organizations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.LinkWithType>? CurrentUserOrganizations { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.LinkWithType> CurrentUserOrganizations { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? CurrentUserPublic { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType CurrentUserPublic { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? RepositoryDiscussions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType RepositoryDiscussions { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? RepositoryDiscussionsCategory { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType RepositoryDiscussionsCategory { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? SecurityAdvisories { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType SecurityAdvisories { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? Timeline { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType Timeline { get; set; }
#endif
        /// <summary>Hypermedia Link with Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LinkWithType? User { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LinkWithType User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Feed__links"/> and sets the default values.
        /// </summary>
        public Feed__links()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Feed__links"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Feed__links CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Feed__links();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "current_user", n => { CurrentUser = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "current_user_actor", n => { CurrentUserActor = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "current_user_organization", n => { CurrentUserOrganization = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "current_user_organizations", n => { CurrentUserOrganizations = n.GetCollectionOfObjectValues<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue)?.AsList(); } },
                { "current_user_public", n => { CurrentUserPublic = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "repository_discussions", n => { RepositoryDiscussions = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "repository_discussions_category", n => { RepositoryDiscussionsCategory = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "security_advisories", n => { SecurityAdvisories = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "timeline", n => { Timeline = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
                { "user", n => { User = n.GetObjectValue<global::GitHub.Models.LinkWithType>(global::GitHub.Models.LinkWithType.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("current_user", CurrentUser);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("current_user_actor", CurrentUserActor);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("current_user_organization", CurrentUserOrganization);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.LinkWithType>("current_user_organizations", CurrentUserOrganizations);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("current_user_public", CurrentUserPublic);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("repository_discussions", RepositoryDiscussions);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("repository_discussions_category", RepositoryDiscussionsCategory);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("security_advisories", SecurityAdvisories);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("timeline", Timeline);
            writer.WriteObjectValue<global::GitHub.Models.LinkWithType>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
