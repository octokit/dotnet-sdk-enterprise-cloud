// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Dependabot.Secrets.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class WithSecret_namePutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an organization public key](https://docs.github.com/enterprise-cloud@latest//rest/dependabot/secrets#get-an-organization-public-key) endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptedValue { get; set; }
#nullable restore
#else
        public string EncryptedValue { get; set; }
#endif
        /// <summary>ID of the key you used to encrypt the secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can manage the list of selected repositories using the [List selected repositories for an organization secret](https://docs.github.com/enterprise-cloud@latest//rest/dependabot/secrets#list-selected-repositories-for-an-organization-secret), [Set selected repositories for an organization secret](https://docs.github.com/enterprise-cloud@latest//rest/dependabot/secrets#set-selected-repositories-for-an-organization-secret), and [Remove selected repository from an organization secret](https://docs.github.com/enterprise-cloud@latest//rest/dependabot/secrets#remove-selected-repository-from-an-organization-secret) endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SelectedRepositoryIds { get; set; }
#nullable restore
#else
        public List<string> SelectedRepositoryIds { get; set; }
#endif
        /// <summary>Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.</summary>
        public global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody"/> and sets the default values.
        /// </summary>
        public WithSecret_namePutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "encrypted_value", n => { EncryptedValue = n.GetStringValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "selected_repository_ids", n => { SelectedRepositoryIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("encrypted_value", EncryptedValue);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteCollectionOfPrimitiveValues<string>("selected_repository_ids", SelectedRepositoryIds);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Dependabot.Secrets.Item.WithSecret_namePutRequestBody_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
