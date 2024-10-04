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
    public partial class ServerStatistics_ghe_stats_issues : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The closed_issues property</summary>
        public int? ClosedIssues { get; set; }
        /// <summary>The open_issues property</summary>
        public int? OpenIssues { get; set; }
        /// <summary>The total_issues property</summary>
        public int? TotalIssues { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_issues"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_issues()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_issues"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics_ghe_stats_issues CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics_ghe_stats_issues();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "closed_issues", n => { ClosedIssues = n.GetIntValue(); } },
                { "open_issues", n => { OpenIssues = n.GetIntValue(); } },
                { "total_issues", n => { TotalIssues = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("closed_issues", ClosedIssues);
            writer.WriteIntValue("open_issues", OpenIssues);
            writer.WriteIntValue("total_issues", TotalIssues);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
