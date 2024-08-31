// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CodeScanningDefaultSetupUpdate : IParsable
    {
        /// <summary>CodeQL languages to be analyzed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.CodeScanningDefaultSetupUpdate_languages?>? Languages { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.CodeScanningDefaultSetupUpdate_languages?> Languages { get; set; }
#endif
        /// <summary>CodeQL query suite to be used.</summary>
        public global::GitHub.Models.CodeScanningDefaultSetupUpdate_query_suite? QuerySuite { get; set; }
        /// <summary>The desired state of code scanning default setup.</summary>
        public global::GitHub.Models.CodeScanningDefaultSetupUpdate_state? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeScanningDefaultSetupUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodeScanningDefaultSetupUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodeScanningDefaultSetupUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "languages", n => { Languages = n.GetCollectionOfEnumValues<global::GitHub.Models.CodeScanningDefaultSetupUpdate_languages>()?.AsList(); } },
                { "query_suite", n => { QuerySuite = n.GetEnumValue<global::GitHub.Models.CodeScanningDefaultSetupUpdate_query_suite>(); } },
                { "state", n => { State = n.GetEnumValue<global::GitHub.Models.CodeScanningDefaultSetupUpdate_state>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::GitHub.Models.CodeScanningDefaultSetupUpdate_languages>("languages", Languages);
            writer.WriteEnumValue<global::GitHub.Models.CodeScanningDefaultSetupUpdate_query_suite>("query_suite", QuerySuite);
            writer.WriteEnumValue<global::GitHub.Models.CodeScanningDefaultSetupUpdate_state>("state", State);
        }
    }
}
