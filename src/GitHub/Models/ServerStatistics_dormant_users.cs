// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class ServerStatistics_dormant_users : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The dormancy_threshold property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DormancyThreshold { get; set; }
#nullable restore
#else
        public string DormancyThreshold { get; set; }
#endif
        /// <summary>The total_dormant_users property</summary>
        public int? TotalDormantUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ServerStatistics_dormant_users"/> and sets the default values.
        /// </summary>
        public ServerStatistics_dormant_users()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServerStatistics_dormant_users"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServerStatistics_dormant_users CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServerStatistics_dormant_users();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"dormancy_threshold", n => { DormancyThreshold = n.GetStringValue(); } },
                {"total_dormant_users", n => { TotalDormantUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dormancy_threshold", DormancyThreshold);
            writer.WriteIntValue("total_dormant_users", TotalDormantUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
