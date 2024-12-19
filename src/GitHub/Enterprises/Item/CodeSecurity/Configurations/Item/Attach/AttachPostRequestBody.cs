// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class AttachPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`</summary>
        public global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody_scope? Scope { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "scope", n => { Scope = n.GetEnumValue<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody_scope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Enterprises.Item.CodeSecurity.Configurations.Item.Attach.AttachPostRequestBody_scope>("scope", Scope);
        }
    }
}
#pragma warning restore CS0618
