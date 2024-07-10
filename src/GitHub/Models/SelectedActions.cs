// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class SelectedActions : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.</summary>
        public bool? GithubOwnedAllowed { get; set; }
        /// <summary>Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PatternsAllowed { get; set; }
#nullable restore
#else
        public List<string> PatternsAllowed { get; set; }
#endif
        /// <summary>Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.</summary>
        public bool? VerifiedAllowed { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SelectedActions"/> and sets the default values.
        /// </summary>
        public SelectedActions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SelectedActions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SelectedActions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SelectedActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"github_owned_allowed", n => { GithubOwnedAllowed = n.GetBoolValue(); } },
                {"patterns_allowed", n => { PatternsAllowed = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"verified_allowed", n => { VerifiedAllowed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("github_owned_allowed", GithubOwnedAllowed);
            writer.WriteCollectionOfPrimitiveValues<string>("patterns_allowed", PatternsAllowed);
            writer.WriteBoolValue("verified_allowed", VerifiedAllowed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
