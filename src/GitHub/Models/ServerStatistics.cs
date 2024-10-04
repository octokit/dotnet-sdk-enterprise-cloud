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
    public partial class ServerStatistics : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Actions metrics that are included in the Server Statistics payload/export from GHES</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ServerStatisticsActions? ActionsStats { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ServerStatisticsActions ActionsStats { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The collection_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CollectionDate { get; set; }
#nullable restore
#else
        public string CollectionDate { get; set; }
#endif
        /// <summary>The dormant_users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ServerStatistics_dormant_users? DormantUsers { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ServerStatistics_dormant_users DormantUsers { get; set; }
#endif
        /// <summary>The ghe_stats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ServerStatistics_ghe_stats? GheStats { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ServerStatistics_ghe_stats GheStats { get; set; }
#endif
        /// <summary>The ghes_version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GhesVersion { get; set; }
#nullable restore
#else
        public string GhesVersion { get; set; }
#endif
        /// <summary>The github_connect property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ServerStatistics_github_connect? GithubConnect { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ServerStatistics_github_connect GithubConnect { get; set; }
#endif
        /// <summary>The host_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName { get; set; }
#nullable restore
#else
        public string HostName { get; set; }
#endif
        /// <summary>Packages metrics that are included in the Server Statistics payload/export from GHES</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ServerStatisticsPackages? PackagesStats { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ServerStatisticsPackages PackagesStats { get; set; }
#endif
        /// <summary>The schema_version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchemaVersion { get; set; }
#nullable restore
#else
        public string SchemaVersion { get; set; }
#endif
        /// <summary>The server_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerId { get; set; }
#nullable restore
#else
        public string ServerId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics"/> and sets the default values.
        /// </summary>
        public ServerStatistics()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actions_stats", n => { ActionsStats = n.GetObjectValue<global::GitHub.Models.ServerStatisticsActions>(global::GitHub.Models.ServerStatisticsActions.CreateFromDiscriminatorValue); } },
                { "collection_date", n => { CollectionDate = n.GetStringValue(); } },
                { "dormant_users", n => { DormantUsers = n.GetObjectValue<global::GitHub.Models.ServerStatistics_dormant_users>(global::GitHub.Models.ServerStatistics_dormant_users.CreateFromDiscriminatorValue); } },
                { "ghe_stats", n => { GheStats = n.GetObjectValue<global::GitHub.Models.ServerStatistics_ghe_stats>(global::GitHub.Models.ServerStatistics_ghe_stats.CreateFromDiscriminatorValue); } },
                { "ghes_version", n => { GhesVersion = n.GetStringValue(); } },
                { "github_connect", n => { GithubConnect = n.GetObjectValue<global::GitHub.Models.ServerStatistics_github_connect>(global::GitHub.Models.ServerStatistics_github_connect.CreateFromDiscriminatorValue); } },
                { "host_name", n => { HostName = n.GetStringValue(); } },
                { "packages_stats", n => { PackagesStats = n.GetObjectValue<global::GitHub.Models.ServerStatisticsPackages>(global::GitHub.Models.ServerStatisticsPackages.CreateFromDiscriminatorValue); } },
                { "schema_version", n => { SchemaVersion = n.GetStringValue(); } },
                { "server_id", n => { ServerId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.ServerStatisticsActions>("actions_stats", ActionsStats);
            writer.WriteStringValue("collection_date", CollectionDate);
            writer.WriteObjectValue<global::GitHub.Models.ServerStatistics_dormant_users>("dormant_users", DormantUsers);
            writer.WriteObjectValue<global::GitHub.Models.ServerStatistics_ghe_stats>("ghe_stats", GheStats);
            writer.WriteStringValue("ghes_version", GhesVersion);
            writer.WriteObjectValue<global::GitHub.Models.ServerStatistics_github_connect>("github_connect", GithubConnect);
            writer.WriteStringValue("host_name", HostName);
            writer.WriteObjectValue<global::GitHub.Models.ServerStatisticsPackages>("packages_stats", PackagesStats);
            writer.WriteStringValue("schema_version", SchemaVersion);
            writer.WriteStringValue("server_id", ServerId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
