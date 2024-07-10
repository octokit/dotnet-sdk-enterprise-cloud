// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class GroupResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable name for a security group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>A unique identifier for the resource as defined by the provisioning client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The group members.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupResponse_members>? Members { get; set; }
#nullable restore
#else
        public List<GroupResponse_members> Members { get; set; }
#endif
        /// <summary>The URIs that are used to indicate the namespaces of the SCIM schemas.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupResponse_schemas?>? Schemas { get; set; }
#nullable restore
#else
        public List<GroupResponse_schemas?> Schemas { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GroupResponse"/> and sets the default values.
        /// </summary>
        public GroupResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GroupResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GroupResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<GroupResponse_members>(GroupResponse_members.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schemas", n => { Schemas = n.GetCollectionOfEnumValues<GroupResponse_schemas>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<GroupResponse_members>("members", Members);
            writer.WriteCollectionOfEnumValues<GroupResponse_schemas>("schemas", Schemas);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}