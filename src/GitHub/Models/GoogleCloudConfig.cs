// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Google Cloud Config for audit log streaming configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class GoogleCloudConfig : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Google Cloud Bucket Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bucket { get; set; }
#nullable restore
#else
        public string Bucket { get; set; }
#endif
        /// <summary>The encrypted_json_credentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptedJsonCredentials { get; set; }
#nullable restore
#else
        public string EncryptedJsonCredentials { get; set; }
#endif
        /// <summary>Key ID obtained from the audit log stream key endpoint used to encrypt secrets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GoogleCloudConfig"/> and sets the default values.
        /// </summary>
        public GoogleCloudConfig()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GoogleCloudConfig"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GoogleCloudConfig CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GoogleCloudConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bucket", n => { Bucket = n.GetStringValue(); } },
                { "encrypted_json_credentials", n => { EncryptedJsonCredentials = n.GetStringValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bucket", Bucket);
            writer.WriteStringValue("encrypted_json_credentials", EncryptedJsonCredentials);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618