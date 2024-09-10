// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ServerStatistics_ghe_stats_orgs : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The disabled_orgs property</summary>
        public int? DisabledOrgs { get; set; }
        /// <summary>The total_orgs property</summary>
        public int? TotalOrgs { get; set; }
        /// <summary>The total_team_members property</summary>
        public int? TotalTeamMembers { get; set; }
        /// <summary>The total_teams property</summary>
        public int? TotalTeams { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_orgs"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_orgs()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_orgs"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics_ghe_stats_orgs CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics_ghe_stats_orgs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "disabled_orgs", n => { DisabledOrgs = n.GetIntValue(); } },
                { "total_orgs", n => { TotalOrgs = n.GetIntValue(); } },
                { "total_team_members", n => { TotalTeamMembers = n.GetIntValue(); } },
                { "total_teams", n => { TotalTeams = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("disabled_orgs", DisabledOrgs);
            writer.WriteIntValue("total_orgs", TotalOrgs);
            writer.WriteIntValue("total_team_members", TotalTeamMembers);
            writer.WriteIntValue("total_teams", TotalTeams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
