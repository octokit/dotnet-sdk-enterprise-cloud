// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// SCIM User List
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ScimUserList : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The itemsPerPage property</summary>
        public int? ItemsPerPage { get; set; }
        /// <summary>The Resources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.ScimUser>? Resources { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.ScimUser> Resources { get; set; }
#endif
        /// <summary>SCIM schema used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schemas { get; set; }
#nullable restore
#else
        public List<string> Schemas { get; set; }
#endif
        /// <summary>The startIndex property</summary>
        public int? StartIndex { get; set; }
        /// <summary>The totalResults property</summary>
        public int? TotalResults { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ScimUserList"/> and sets the default values.
        /// </summary>
        public ScimUserList()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimUserList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ScimUserList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ScimUserList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "itemsPerPage", n => { ItemsPerPage = n.GetIntValue(); } },
                { "Resources", n => { Resources = n.GetCollectionOfObjectValues<global::GitHub.Models.ScimUser>(global::GitHub.Models.ScimUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schemas", n => { Schemas = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "startIndex", n => { StartIndex = n.GetIntValue(); } },
                { "totalResults", n => { TotalResults = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("itemsPerPage", ItemsPerPage);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.ScimUser>("Resources", Resources);
            writer.WriteCollectionOfPrimitiveValues<string>("schemas", Schemas);
            writer.WriteIntValue("startIndex", StartIndex);
            writer.WriteIntValue("totalResults", TotalResults);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
