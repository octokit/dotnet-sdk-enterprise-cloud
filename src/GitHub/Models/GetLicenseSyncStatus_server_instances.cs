// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class GetLicenseSyncStatus_server_instances : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>The last_sync property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GetLicenseSyncStatus_server_instances_last_sync? LastSync { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GetLicenseSyncStatus_server_instances_last_sync LastSync { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.GetLicenseSyncStatus_server_instances"/> and sets the default values.
        /// </summary>
        public GetLicenseSyncStatus_server_instances()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GetLicenseSyncStatus_server_instances"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GetLicenseSyncStatus_server_instances CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GetLicenseSyncStatus_server_instances();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "last_sync", n => { LastSync = n.GetObjectValue<global::GitHub.Models.GetLicenseSyncStatus_server_instances_last_sync>(global::GitHub.Models.GetLicenseSyncStatus_server_instances_last_sync.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteObjectValue<global::GitHub.Models.GetLicenseSyncStatus_server_instances_last_sync>("last_sync", LastSync);
            writer.WriteStringValue("server_id", ServerId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
