// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class RunsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>The workflow_runs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.WorkflowRun>? WorkflowRuns { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.WorkflowRun> WorkflowRuns { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs.RunsGetResponse"/> and sets the default values.
        /// </summary>
        public RunsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs.RunsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs.RunsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs.RunsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "total_count", n => { TotalCount = n.GetIntValue(); } },
                { "workflow_runs", n => { WorkflowRuns = n.GetCollectionOfObjectValues<global::GitHub.Models.WorkflowRun>(global::GitHub.Models.WorkflowRun.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.WorkflowRun>("workflow_runs", WorkflowRuns);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
