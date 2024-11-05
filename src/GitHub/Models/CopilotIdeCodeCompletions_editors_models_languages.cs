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
    /// Usage metrics for a given language for the given editor for Copilot code completions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CopilotIdeCodeCompletions_editors_models_languages : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the language used for Copilot code completion suggestions, for the given editor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The number of Copilot code suggestions accepted for the given editor, for the given language. Includes both full and partial acceptances.</summary>
        public int? TotalCodeAcceptances { get; set; }
        /// <summary>The number of lines of code accepted from Copilot code suggestions for the given editor, for the given language.</summary>
        public int? TotalCodeLinesAccepted { get; set; }
        /// <summary>The number of lines of code suggested by Copilot code completions for the given editor, for the given language.</summary>
        public int? TotalCodeLinesSuggested { get; set; }
        /// <summary>The number of Copilot code suggestions generated for the given editor, for the given language.</summary>
        public int? TotalCodeSuggestions { get; set; }
        /// <summary>Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language. Includes both full and partial acceptances.</summary>
        public int? TotalEngagedUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CopilotIdeCodeCompletions_editors_models_languages"/> and sets the default values.
        /// </summary>
        public CopilotIdeCodeCompletions_editors_models_languages()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CopilotIdeCodeCompletions_editors_models_languages"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CopilotIdeCodeCompletions_editors_models_languages CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CopilotIdeCodeCompletions_editors_models_languages();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "total_code_acceptances", n => { TotalCodeAcceptances = n.GetIntValue(); } },
                { "total_code_lines_accepted", n => { TotalCodeLinesAccepted = n.GetIntValue(); } },
                { "total_code_lines_suggested", n => { TotalCodeLinesSuggested = n.GetIntValue(); } },
                { "total_code_suggestions", n => { TotalCodeSuggestions = n.GetIntValue(); } },
                { "total_engaged_users", n => { TotalEngagedUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("total_code_acceptances", TotalCodeAcceptances);
            writer.WriteIntValue("total_code_lines_accepted", TotalCodeLinesAccepted);
            writer.WriteIntValue("total_code_lines_suggested", TotalCodeLinesSuggested);
            writer.WriteIntValue("total_code_suggestions", TotalCodeSuggestions);
            writer.WriteIntValue("total_engaged_users", TotalEngagedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
