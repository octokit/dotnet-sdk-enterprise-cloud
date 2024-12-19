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
    /// Amazon S3 OIDC Config for audit log streaming configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AmazonS3OidcConfig : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The arn_role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArnRole { get; set; }
#nullable restore
#else
        public string ArnRole { get; set; }
#endif
        /// <summary>Authentication Type for Amazon S3.</summary>
        public global::GitHub.Models.AmazonS3OidcConfig_authentication_type? AuthenticationType { get; set; }
        /// <summary>Amazon S3 Bucket Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bucket { get; set; }
#nullable restore
#else
        public string Bucket { get; set; }
#endif
        /// <summary>Key ID obtained from the audit log stream key endpoint used to encrypt secrets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>AWS S3 Bucket Region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.AmazonS3OidcConfig"/> and sets the default values.
        /// </summary>
        public AmazonS3OidcConfig()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.AmazonS3OidcConfig"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.AmazonS3OidcConfig CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.AmazonS3OidcConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "arn_role", n => { ArnRole = n.GetStringValue(); } },
                { "authentication_type", n => { AuthenticationType = n.GetEnumValue<global::GitHub.Models.AmazonS3OidcConfig_authentication_type>(); } },
                { "bucket", n => { Bucket = n.GetStringValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("arn_role", ArnRole);
            writer.WriteEnumValue<global::GitHub.Models.AmazonS3OidcConfig_authentication_type>("authentication_type", AuthenticationType);
            writer.WriteStringValue("bucket", Bucket);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteStringValue("region", Region);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
