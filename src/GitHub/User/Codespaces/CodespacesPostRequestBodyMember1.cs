// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.User.Codespaces
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class CodespacesPostRequestBodyMember1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>IP for location auto-detection when proxying a request</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientIp { get; set; }
#nullable restore
#else
        public string ClientIp { get; set; }
#endif
        /// <summary>Path to devcontainer.json config to use for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevcontainerPath { get; set; }
#nullable restore
#else
        public string DevcontainerPath { get; set; }
#endif
        /// <summary>Display name for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.</summary>
        public global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1_geo? Geo { get; set; }
        /// <summary>Time in minutes before codespace stops from inactivity</summary>
        public int? IdleTimeoutMinutes { get; set; }
        /// <summary>The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>Machine type to use for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Machine { get; set; }
#nullable restore
#else
        public string Machine { get; set; }
#endif
        /// <summary>Whether to authorize requested permissions from devcontainer.json</summary>
        public bool? MultiRepoPermissionsOptOut { get; set; }
        /// <summary>Git ref (typically a branch name) for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>Repository id for this codespace</summary>
        public int? RepositoryId { get; set; }
        /// <summary>Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).</summary>
        public int? RetentionPeriodMinutes { get; set; }
        /// <summary>Working directory for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkingDirectory { get; set; }
#nullable restore
#else
        public string WorkingDirectory { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1"/> and sets the default values.
        /// </summary>
        public CodespacesPostRequestBodyMember1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "client_ip", n => { ClientIp = n.GetStringValue(); } },
                { "devcontainer_path", n => { DevcontainerPath = n.GetStringValue(); } },
                { "display_name", n => { DisplayName = n.GetStringValue(); } },
                { "geo", n => { Geo = n.GetEnumValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1_geo>(); } },
                { "idle_timeout_minutes", n => { IdleTimeoutMinutes = n.GetIntValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "machine", n => { Machine = n.GetStringValue(); } },
                { "multi_repo_permissions_opt_out", n => { MultiRepoPermissionsOptOut = n.GetBoolValue(); } },
                { "ref", n => { Ref = n.GetStringValue(); } },
                { "repository_id", n => { RepositoryId = n.GetIntValue(); } },
                { "retention_period_minutes", n => { RetentionPeriodMinutes = n.GetIntValue(); } },
                { "working_directory", n => { WorkingDirectory = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client_ip", ClientIp);
            writer.WriteStringValue("devcontainer_path", DevcontainerPath);
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteEnumValue<global::GitHub.User.Codespaces.CodespacesPostRequestBodyMember1_geo>("geo", Geo);
            writer.WriteIntValue("idle_timeout_minutes", IdleTimeoutMinutes);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("machine", Machine);
            writer.WriteBoolValue("multi_repo_permissions_opt_out", MultiRepoPermissionsOptOut);
            writer.WriteStringValue("ref", Ref);
            writer.WriteIntValue("repository_id", RepositoryId);
            writer.WriteIntValue("retention_period_minutes", RetentionPeriodMinutes);
            writer.WriteStringValue("working_directory", WorkingDirectory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
