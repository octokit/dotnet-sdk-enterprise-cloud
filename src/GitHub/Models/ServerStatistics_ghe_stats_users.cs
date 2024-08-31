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
    public partial class ServerStatistics_ghe_stats_users : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin_users property</summary>
        public int? AdminUsers { get; set; }
        /// <summary>The suspended_users property</summary>
        public int? SuspendedUsers { get; set; }
        /// <summary>The total_users property</summary>
        public int? TotalUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_users"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_users()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_users"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics_ghe_stats_users CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics_ghe_stats_users();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "admin_users", n => { AdminUsers = n.GetIntValue(); } },
                { "suspended_users", n => { SuspendedUsers = n.GetIntValue(); } },
                { "total_users", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("admin_users", AdminUsers);
            writer.WriteIntValue("suspended_users", SuspendedUsers);
            writer.WriteIntValue("total_users", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
