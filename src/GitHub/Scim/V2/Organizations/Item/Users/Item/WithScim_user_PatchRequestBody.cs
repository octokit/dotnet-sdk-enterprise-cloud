// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Scim.V2.Organizations.Item.Users.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class WithScim_user_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Set of operations to be performed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody_Operations>? Operations { get; set; }
#nullable restore
#else
        public List<global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody_Operations> Operations { get; set; }
#endif
        /// <summary>The schemas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schemas { get; set; }
#nullable restore
#else
        public List<string> Schemas { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithScim_user_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Operations", n => { Operations = n.GetCollectionOfObjectValues<global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody_Operations>(global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody_Operations.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schemas", n => { Schemas = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Scim.V2.Organizations.Item.Users.Item.WithScim_user_PatchRequestBody_Operations>("Operations", Operations);
            writer.WriteCollectionOfPrimitiveValues<string>("schemas", Schemas);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
