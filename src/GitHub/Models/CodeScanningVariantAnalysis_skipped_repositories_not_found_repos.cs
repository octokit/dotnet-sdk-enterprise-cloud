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
    public partial class CodeScanningVariantAnalysis_skipped_repositories_not_found_repos : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total number of repositories that were skipped for this reason.</summary>
        public int? RepositoryCount { get; set; }
        /// <summary>A list of full repository names that were skipped. This list may not include all repositories that were skipped.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RepositoryFullNames { get; set; }
#nullable restore
#else
        public List<string> RepositoryFullNames { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos"/> and sets the default values.
        /// </summary>
        public CodeScanningVariantAnalysis_skipped_repositories_not_found_repos()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "repository_count", n => { RepositoryCount = n.GetIntValue(); } },
                { "repository_full_names", n => { RepositoryFullNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("repository_count", RepositoryCount);
            writer.WriteCollectionOfPrimitiveValues<string>("repository_full_names", RepositoryFullNames);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
