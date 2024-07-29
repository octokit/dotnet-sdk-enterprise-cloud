// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// &gt; [!NOTE]&gt; `max_file_size` is in beta and subject to change.Prevent commits that exceed a specified file size limit from being pushed to the commit.
    /// </summary>
    public class Max_file_size : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Max_file_size_parameters? Parameters { get; set; }
#nullable restore
#else
        public Max_file_size_parameters Parameters { get; set; }
#endif
        /// <summary>The type property</summary>
        public Max_file_size_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Max_file_size"/> and sets the default values.
        /// </summary>
        public Max_file_size()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Max_file_size"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Max_file_size CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Max_file_size();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"parameters", n => { Parameters = n.GetObjectValue<Max_file_size_parameters>(Max_file_size_parameters.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<Max_file_size_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Max_file_size_parameters>("parameters", Parameters);
            writer.WriteEnumValue<Max_file_size_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
