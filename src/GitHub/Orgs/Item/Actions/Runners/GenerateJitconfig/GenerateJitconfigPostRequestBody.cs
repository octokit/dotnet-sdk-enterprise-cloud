// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Actions.Runners.GenerateJitconfig
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class GenerateJitconfigPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Labels { get; set; }
#nullable restore
#else
        public List<string> Labels { get; set; }
#endif
        /// <summary>The name of the new runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ID of the runner group to register the runner to.</summary>
        public int? RunnerGroupId { get; set; }
        /// <summary>The working directory to be used for job execution, relative to the runner install directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkFolder { get; set; }
#nullable restore
#else
        public string WorkFolder { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigPostRequestBody"/> and sets the default values.
        /// </summary>
        public GenerateJitconfigPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            WorkFolder = "_work";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "runner_group_id", n => { RunnerGroupId = n.GetIntValue(); } },
                { "work_folder", n => { WorkFolder = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("runner_group_id", RunnerGroupId);
            writer.WriteStringValue("work_folder", WorkFolder);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
