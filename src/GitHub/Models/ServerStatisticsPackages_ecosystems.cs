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
    public partial class ServerStatisticsPackages_ecosystems : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total number of packages in an ecosystem that have been created in the 24 hours prior to `collection_date` for a GHES installation</summary>
        public int? DailyCreateCount { get; set; }
        /// <summary>The total number of packages in an ecosystem that have been deleted in the 24 hours prior to `collection_date` for a GHES installation</summary>
        public int? DailyDeleteCount { get; set; }
        /// <summary>The total number of packages in an ecosystem that have been downloaded in the 24 hours prior to `collection_date` for a GHES installation</summary>
        public int? DailyDownloadCount { get; set; }
        /// <summary>The total number of packages in an ecosystem that have been updated in the 24 hours prior to `collection_date` for a GHES installation</summary>
        public int? DailyUpdateCount { get; set; }
        /// <summary>Shows if a package system is enabled, disabled, or read-only in a GHES installation</summary>
        public global::GitHub.Models.ServerStatisticsPackages_ecosystems_enabled? Enabled { get; set; }
        /// <summary>The total number of internal packages in a package ecosystem in a GHES installation</summary>
        public int? InternalPackagesCount { get; set; }
        /// <summary>The name of the package ecosystem</summary>
        public global::GitHub.Models.ServerStatisticsPackages_ecosystems_name? Name { get; set; }
        /// <summary>The total number of organization packages in a package ecosystem in a GHES installation</summary>
        public int? OrganizationPackagesCount { get; set; }
        /// <summary>The total number of private packages in a package ecosystem in a GHES installation</summary>
        public int? PrivatePackagesCount { get; set; }
        /// <summary>The total number of public packages in a package ecosystem in a GHES installation</summary>
        public int? PublicPackagesCount { get; set; }
        /// <summary>The total number of published packages in a package ecosystem in a GHES installation</summary>
        public int? PublishedPackagesCount { get; set; }
        /// <summary>The total number of user packages in a package ecosystem in a GHES installation</summary>
        public int? UserPackagesCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatisticsPackages_ecosystems"/> and sets the default values.
        /// </summary>
        public ServerStatisticsPackages_ecosystems()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatisticsPackages_ecosystems"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatisticsPackages_ecosystems CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatisticsPackages_ecosystems();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "daily_create_count", n => { DailyCreateCount = n.GetIntValue(); } },
                { "daily_delete_count", n => { DailyDeleteCount = n.GetIntValue(); } },
                { "daily_download_count", n => { DailyDownloadCount = n.GetIntValue(); } },
                { "daily_update_count", n => { DailyUpdateCount = n.GetIntValue(); } },
                { "enabled", n => { Enabled = n.GetEnumValue<global::GitHub.Models.ServerStatisticsPackages_ecosystems_enabled>(); } },
                { "internal_packages_count", n => { InternalPackagesCount = n.GetIntValue(); } },
                { "name", n => { Name = n.GetEnumValue<global::GitHub.Models.ServerStatisticsPackages_ecosystems_name>(); } },
                { "organization_packages_count", n => { OrganizationPackagesCount = n.GetIntValue(); } },
                { "private_packages_count", n => { PrivatePackagesCount = n.GetIntValue(); } },
                { "public_packages_count", n => { PublicPackagesCount = n.GetIntValue(); } },
                { "published_packages_count", n => { PublishedPackagesCount = n.GetIntValue(); } },
                { "user_packages_count", n => { UserPackagesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("daily_create_count", DailyCreateCount);
            writer.WriteIntValue("daily_delete_count", DailyDeleteCount);
            writer.WriteIntValue("daily_download_count", DailyDownloadCount);
            writer.WriteIntValue("daily_update_count", DailyUpdateCount);
            writer.WriteEnumValue<global::GitHub.Models.ServerStatisticsPackages_ecosystems_enabled>("enabled", Enabled);
            writer.WriteIntValue("internal_packages_count", InternalPackagesCount);
            writer.WriteEnumValue<global::GitHub.Models.ServerStatisticsPackages_ecosystems_name>("name", Name);
            writer.WriteIntValue("organization_packages_count", OrganizationPackagesCount);
            writer.WriteIntValue("private_packages_count", PrivatePackagesCount);
            writer.WriteIntValue("public_packages_count", PublicPackagesCount);
            writer.WriteIntValue("published_packages_count", PublishedPackagesCount);
            writer.WriteIntValue("user_packages_count", UserPackagesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
