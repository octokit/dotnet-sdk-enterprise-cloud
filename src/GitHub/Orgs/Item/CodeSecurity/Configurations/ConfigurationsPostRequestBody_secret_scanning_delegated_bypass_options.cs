// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.CodeSecurity.Configurations
{
    /// <summary>
    /// Feature options for secret scanning delegated bypass
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bypass reviewers for secret scanning delegated bypass</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options_reviewers>? Reviewers { get; set; }
#nullable restore
#else
        public List<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options_reviewers> Reviewers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options"/> and sets the default values.
        /// </summary>
        public ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options_reviewers>(global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options_reviewers.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_delegated_bypass_options_reviewers>("reviewers", Reviewers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618