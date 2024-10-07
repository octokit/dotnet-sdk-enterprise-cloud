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
    public partial class ServerStatistics_ghe_stats_comments : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total_commit_comments property</summary>
        public int? TotalCommitComments { get; set; }
        /// <summary>The total_gist_comments property</summary>
        public int? TotalGistComments { get; set; }
        /// <summary>The total_issue_comments property</summary>
        public int? TotalIssueComments { get; set; }
        /// <summary>The total_pull_request_comments property</summary>
        public int? TotalPullRequestComments { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_comments"/> and sets the default values.
        /// </summary>
        public ServerStatistics_ghe_stats_comments()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ServerStatistics_ghe_stats_comments"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ServerStatistics_ghe_stats_comments CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ServerStatistics_ghe_stats_comments();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "total_commit_comments", n => { TotalCommitComments = n.GetIntValue(); } },
                { "total_gist_comments", n => { TotalGistComments = n.GetIntValue(); } },
                { "total_issue_comments", n => { TotalIssueComments = n.GetIntValue(); } },
                { "total_pull_request_comments", n => { TotalPullRequestComments = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total_commit_comments", TotalCommitComments);
            writer.WriteIntValue("total_gist_comments", TotalGistComments);
            writer.WriteIntValue("total_issue_comments", TotalIssueComments);
            writer.WriteIntValue("total_pull_request_comments", TotalPullRequestComments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
