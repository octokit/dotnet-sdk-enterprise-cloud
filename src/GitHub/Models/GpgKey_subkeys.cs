// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class GpgKey_subkeys : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The can_certify property</summary>
        public bool? CanCertify { get; set; }
        /// <summary>The can_encrypt_comms property</summary>
        public bool? CanEncryptComms { get; set; }
        /// <summary>The can_encrypt_storage property</summary>
        public bool? CanEncryptStorage { get; set; }
        /// <summary>The can_sign property</summary>
        public bool? CanSign { get; set; }
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.GpgKey_subkeys_emails>? Emails { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.GpgKey_subkeys_emails> Emails { get; set; }
#endif
        /// <summary>The expires_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpiresAt { get; set; }
#nullable restore
#else
        public string ExpiresAt { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The key_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>The primary_key_id property</summary>
        public int? PrimaryKeyId { get; set; }
        /// <summary>The public_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicKey { get; set; }
#nullable restore
#else
        public string PublicKey { get; set; }
#endif
        /// <summary>The raw_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawKey { get; set; }
#nullable restore
#else
        public string RawKey { get; set; }
#endif
        /// <summary>The revoked property</summary>
        public bool? Revoked { get; set; }
        /// <summary>The subkeys property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Subkeys { get; set; }
#nullable restore
#else
        public UntypedNode Subkeys { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GpgKey_subkeys"/> and sets the default values.
        /// </summary>
        public GpgKey_subkeys()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GpgKey_subkeys"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GpgKey_subkeys CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GpgKey_subkeys();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_certify", n => { CanCertify = n.GetBoolValue(); } },
                { "can_encrypt_comms", n => { CanEncryptComms = n.GetBoolValue(); } },
                { "can_encrypt_storage", n => { CanEncryptStorage = n.GetBoolValue(); } },
                { "can_sign", n => { CanSign = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "emails", n => { Emails = n.GetCollectionOfObjectValues<global::GitHub.Models.GpgKey_subkeys_emails>(global::GitHub.Models.GpgKey_subkeys_emails.CreateFromDiscriminatorValue)?.AsList(); } },
                { "expires_at", n => { ExpiresAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "primary_key_id", n => { PrimaryKeyId = n.GetIntValue(); } },
                { "public_key", n => { PublicKey = n.GetStringValue(); } },
                { "raw_key", n => { RawKey = n.GetStringValue(); } },
                { "revoked", n => { Revoked = n.GetBoolValue(); } },
                { "subkeys", n => { Subkeys = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("can_certify", CanCertify);
            writer.WriteBoolValue("can_encrypt_comms", CanEncryptComms);
            writer.WriteBoolValue("can_encrypt_storage", CanEncryptStorage);
            writer.WriteBoolValue("can_sign", CanSign);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.GpgKey_subkeys_emails>("emails", Emails);
            writer.WriteStringValue("expires_at", ExpiresAt);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteIntValue("primary_key_id", PrimaryKeyId);
            writer.WriteStringValue("public_key", PublicKey);
            writer.WriteStringValue("raw_key", RawKey);
            writer.WriteBoolValue("revoked", Revoked);
            writer.WriteObjectValue<UntypedNode>("subkeys", Subkeys);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
