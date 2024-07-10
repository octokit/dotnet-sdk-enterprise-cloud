// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class ServerStatistics_ghe_stats_gists : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The private_gists property</summary>
        public int? PrivateGists { get; set; }
        /// <summary>The public_gists property</summary>
        public int? PublicGists { get; set; }
        /// <summary>The total_gists property</summary>
        public int? TotalGists { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ServerStatistics_ghe_stats_gists"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_gists()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServerStatistics_ghe_stats_gists"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServerStatistics_ghe_stats_gists CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServerStatistics_ghe_stats_gists();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"private_gists", n => { PrivateGists = n.GetIntValue(); } },
                {"public_gists", n => { PublicGists = n.GetIntValue(); } },
                {"total_gists", n => { TotalGists = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("private_gists", PrivateGists);
            writer.WriteIntValue("public_gists", PublicGists);
            writer.WriteIntValue("total_gists", TotalGists);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
