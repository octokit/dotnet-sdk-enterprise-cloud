// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ScimEnterpriseGroupList : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of objects per page</summary>
        public int? ItemsPerPage { get; set; }
        /// <summary>Information about each provisioned group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.ScimEnterpriseGroupResponse>? Resources { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.ScimEnterpriseGroupResponse> Resources { get; set; }
#endif
        /// <summary>The URIs that are used to indicate the namespaces of the list SCIM schemas.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.ScimEnterpriseGroupList_schemas?>? Schemas { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.ScimEnterpriseGroupList_schemas?> Schemas { get; set; }
#endif
        /// <summary>A starting index for the returned page</summary>
        public int? StartIndex { get; set; }
        /// <summary>Number of results found</summary>
        public int? TotalResults { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ScimEnterpriseGroupList"/> and sets the default values.
        /// </summary>
        public ScimEnterpriseGroupList()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseGroupList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ScimEnterpriseGroupList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ScimEnterpriseGroupList();
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
                { "Resources", n => { Resources = n.GetCollectionOfObjectValues<global::GitHub.Models.ScimEnterpriseGroupResponse>(global::GitHub.Models.ScimEnterpriseGroupResponse.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schemas", n => { Schemas = n.GetCollectionOfEnumValues<global::GitHub.Models.ScimEnterpriseGroupList_schemas>()?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.ScimEnterpriseGroupResponse>("Resources", Resources);
            writer.WriteCollectionOfEnumValues<global::GitHub.Models.ScimEnterpriseGroupList_schemas>("schemas", Schemas);
            writer.WriteIntValue("startIndex", StartIndex);
            writer.WriteIntValue("totalResults", TotalResults);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
