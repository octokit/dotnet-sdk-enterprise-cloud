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
    /// Usage metrics for Copilot Chat in github.com
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CopilotDotcomChat : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of model metrics for a custom models and the default model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.CopilotDotcomChat_models>? Models { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.CopilotDotcomChat_models> Models { get; set; }
#endif
        /// <summary>Total number of users who prompted Copilot Chat on github.com at least once.</summary>
        public int? TotalEngagedUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CopilotDotcomChat"/> and sets the default values.
        /// </summary>
        public CopilotDotcomChat()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CopilotDotcomChat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CopilotDotcomChat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CopilotDotcomChat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "models", n => { Models = n.GetCollectionOfObjectValues<global::GitHub.Models.CopilotDotcomChat_models>(global::GitHub.Models.CopilotDotcomChat_models.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.CopilotDotcomChat_models>("models", Models);
            writer.WriteIntValue("total_engaged_users", TotalEngagedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618