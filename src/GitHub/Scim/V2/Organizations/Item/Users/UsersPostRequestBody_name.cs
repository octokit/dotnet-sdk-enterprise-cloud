// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Scim.V2.Organizations.Item.Users
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class UsersPostRequestBody_name : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The familyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FamilyName { get; set; }
#nullable restore
#else
        public string FamilyName { get; set; }
#endif
        /// <summary>The formatted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Formatted { get; set; }
#nullable restore
#else
        public string Formatted { get; set; }
#endif
        /// <summary>The givenName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName { get; set; }
#nullable restore
#else
        public string GivenName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name"/> and sets the default values.
        /// </summary>
        public UsersPostRequestBody_name()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "familyName", n => { FamilyName = n.GetStringValue(); } },
                { "formatted", n => { Formatted = n.GetStringValue(); } },
                { "givenName", n => { GivenName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("familyName", FamilyName);
            writer.WriteStringValue("formatted", Formatted);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
