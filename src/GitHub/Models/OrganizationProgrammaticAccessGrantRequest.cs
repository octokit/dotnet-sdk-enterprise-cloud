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
    /// Minimal representation of an organization programmatic access grant request for enumerations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class OrganizationProgrammaticAccessGrantRequest : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the request for access was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>Unique identifier of the request for access via fine-grained personal access token. The `pat_request_id` used to review PAT requests.</summary>
        public int? Id { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? Owner { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser Owner { get; set; }
#endif
        /// <summary>Permissions requested, categorized by type of permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_permissions? Permissions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_permissions Permissions { get; set; }
#endif
        /// <summary>Reason for requesting access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>URL to the list of repositories requested to be accessed via fine-grained personal access token. Should only be followed when `repository_selection` is `subset`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoriesUrl { get; set; }
#nullable restore
#else
        public string RepositoriesUrl { get; set; }
#endif
        /// <summary>Type of repository selection requested.</summary>
        public global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_repository_selection? RepositorySelection { get; set; }
        /// <summary>Whether the associated fine-grained personal access token has expired.</summary>
        public bool? TokenExpired { get; set; }
        /// <summary>Date and time when the associated fine-grained personal access token expires.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenExpiresAt { get; set; }
#nullable restore
#else
        public string TokenExpiresAt { get; set; }
#endif
        /// <summary>Unique identifier of the user&apos;s token. This field can also be found in audit log events and the organization&apos;s settings for their PAT grants.</summary>
        public int? TokenId { get; set; }
        /// <summary>Date and time when the associated fine-grained personal access token was last used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenLastUsedAt { get; set; }
#nullable restore
#else
        public string TokenLastUsedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest"/> and sets the default values.
        /// </summary>
        public OrganizationProgrammaticAccessGrantRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "owner", n => { Owner = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "permissions", n => { Permissions = n.GetObjectValue<global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_permissions>(global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_permissions.CreateFromDiscriminatorValue); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "repositories_url", n => { RepositoriesUrl = n.GetStringValue(); } },
                { "repository_selection", n => { RepositorySelection = n.GetEnumValue<global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_repository_selection>(); } },
                { "token_expired", n => { TokenExpired = n.GetBoolValue(); } },
                { "token_expires_at", n => { TokenExpiresAt = n.GetStringValue(); } },
                { "token_id", n => { TokenId = n.GetIntValue(); } },
                { "token_last_used_at", n => { TokenLastUsedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<global::GitHub.Models.SimpleUser>("owner", Owner);
            writer.WriteObjectValue<global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_permissions>("permissions", Permissions);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("repositories_url", RepositoriesUrl);
            writer.WriteEnumValue<global::GitHub.Models.OrganizationProgrammaticAccessGrantRequest_repository_selection>("repository_selection", RepositorySelection);
            writer.WriteBoolValue("token_expired", TokenExpired);
            writer.WriteStringValue("token_expires_at", TokenExpiresAt);
            writer.WriteIntValue("token_id", TokenId);
            writer.WriteStringValue("token_last_used_at", TokenLastUsedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
