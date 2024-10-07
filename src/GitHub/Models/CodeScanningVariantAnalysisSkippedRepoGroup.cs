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
    public partial class CodeScanningVariantAnalysisSkippedRepoGroup : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of repositories that were skipped. This list may not include all repositories that were skipped. This is only available when the repository was found and the user has access to it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.CodeScanningVariantAnalysisRepository>? Repositories { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.CodeScanningVariantAnalysisRepository> Repositories { get; set; }
#endif
        /// <summary>The total number of repositories that were skipped for this reason.</summary>
        public int? RepositoryCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup"/> and sets the default values.
        /// </summary>
        public CodeScanningVariantAnalysisSkippedRepoGroup()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "repositories", n => { Repositories = n.GetCollectionOfObjectValues<global::GitHub.Models.CodeScanningVariantAnalysisRepository>(global::GitHub.Models.CodeScanningVariantAnalysisRepository.CreateFromDiscriminatorValue)?.AsList(); } },
                { "repository_count", n => { RepositoryCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.CodeScanningVariantAnalysisRepository>("repositories", Repositories);
            writer.WriteIntValue("repository_count", RepositoryCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
