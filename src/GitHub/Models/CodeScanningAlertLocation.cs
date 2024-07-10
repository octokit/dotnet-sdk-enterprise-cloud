// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Describe a region within a file for the alert.
    /// </summary>
    public class CodeScanningAlertLocation : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The end_column property</summary>
        public int? EndColumn { get; set; }
        /// <summary>The end_line property</summary>
        public int? EndLine { get; set; }
        /// <summary>The path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The start_column property</summary>
        public int? StartColumn { get; set; }
        /// <summary>The start_line property</summary>
        public int? StartLine { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CodeScanningAlertLocation"/> and sets the default values.
        /// </summary>
        public CodeScanningAlertLocation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CodeScanningAlertLocation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningAlertLocation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningAlertLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"end_column", n => { EndColumn = n.GetIntValue(); } },
                {"end_line", n => { EndLine = n.GetIntValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"start_column", n => { StartColumn = n.GetIntValue(); } },
                {"start_line", n => { StartLine = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("end_column", EndColumn);
            writer.WriteIntValue("end_line", EndLine);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("start_column", StartColumn);
            writer.WriteIntValue("start_line", StartLine);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}