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
    public partial class ServerStatistics_ghe_stats_milestones : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The closed_milestones property</summary>
        public int? ClosedMilestones { get; set; }
        /// <summary>The open_milestones property</summary>
        public int? OpenMilestones { get; set; }
        /// <summary>The total_milestones property</summary>
        public int? TotalMilestones { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_milestones"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_milestones()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_milestones"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics_ghe_stats_milestones CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics_ghe_stats_milestones();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "closed_milestones", n => { ClosedMilestones = n.GetIntValue(); } },
                { "open_milestones", n => { OpenMilestones = n.GetIntValue(); } },
                { "total_milestones", n => { TotalMilestones = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("closed_milestones", ClosedMilestones);
            writer.WriteIntValue("open_milestones", OpenMilestones);
            writer.WriteIntValue("total_milestones", TotalMilestones);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
