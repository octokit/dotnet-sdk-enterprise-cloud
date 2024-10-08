// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Breakdown of Copilot usage by editor for this language
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CopilotUsageMetrics_breakdown : IAdditionalDataHolder, IParsable
    {
        /// <summary>The number of Copilot suggestions accepted by users in the editor specified during the day specified.</summary>
        public int? AcceptancesCount { get; set; }
        /// <summary>The number of users who were shown Copilot completion suggestions in the editor specified during the day specified.</summary>
        public int? ActiveUsers { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The editor in which Copilot suggestions were shown to users for the specified language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Editor { get; set; }
#nullable restore
#else
        public string Editor { get; set; }
#endif
        /// <summary>The language in which Copilot suggestions were shown to users in the specified editor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The number of lines of code accepted by users in the editor specified during the day specified.</summary>
        public int? LinesAccepted { get; set; }
        /// <summary>The number of lines of code suggested by Copilot in the editor specified during the day specified.</summary>
        public int? LinesSuggested { get; set; }
        /// <summary>The number of Copilot suggestions shown to users in the editor specified during the day specified.</summary>
        public int? SuggestionsCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CopilotUsageMetrics_breakdown"/> and sets the default values.
        /// </summary>
        public CopilotUsageMetrics_breakdown()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CopilotUsageMetrics_breakdown"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CopilotUsageMetrics_breakdown CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CopilotUsageMetrics_breakdown();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acceptances_count", n => { AcceptancesCount = n.GetIntValue(); } },
                { "active_users", n => { ActiveUsers = n.GetIntValue(); } },
                { "editor", n => { Editor = n.GetStringValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "lines_accepted", n => { LinesAccepted = n.GetIntValue(); } },
                { "lines_suggested", n => { LinesSuggested = n.GetIntValue(); } },
                { "suggestions_count", n => { SuggestionsCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("acceptances_count", AcceptancesCount);
            writer.WriteIntValue("active_users", ActiveUsers);
            writer.WriteStringValue("editor", Editor);
            writer.WriteStringValue("language", Language);
            writer.WriteIntValue("lines_accepted", LinesAccepted);
            writer.WriteIntValue("lines_suggested", LinesSuggested);
            writer.WriteIntValue("suggestions_count", SuggestionsCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
