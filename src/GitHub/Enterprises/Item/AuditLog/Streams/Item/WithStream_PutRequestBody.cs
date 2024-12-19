// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Enterprises.Item.AuditLog.Streams.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class WithStream_PutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>This setting pauses or resumes a stream.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The audit log streaming provider. The name is case sensitive.</summary>
        public global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody_stream_type? StreamType { get; set; }
        /// <summary>The vendor_specific property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific? VendorSpecific { get; set; }
#nullable restore
#else
        public global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific VendorSpecific { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody"/> and sets the default values.
        /// </summary>
        public WithStream_PutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "stream_type", n => { StreamType = n.GetEnumValue<global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody_stream_type>(); } },
                { "vendor_specific", n => { VendorSpecific = n.GetObjectValue<global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific>(global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody_stream_type>("stream_type", StreamType);
            writer.WriteObjectValue<global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific>("vendor_specific", VendorSpecific);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.AmazonS3AccessKeysConfig"/>, <see cref="global::GitHub.Models.AmazonS3OidcConfig"/>, <see cref="global::GitHub.Models.AzureBlobConfig"/>, <see cref="global::GitHub.Models.AzureHubConfig"/>, <see cref="global::GitHub.Models.DatadogConfig"/>, <see cref="global::GitHub.Models.GoogleCloudConfig"/>, <see cref="global::GitHub.Models.SplunkConfig"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithStream_PutRequestBody_vendor_specific : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.AmazonS3AccessKeysConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.AmazonS3AccessKeysConfig? AmazonS3AccessKeysConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.AmazonS3AccessKeysConfig AmazonS3AccessKeysConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.AmazonS3OidcConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.AmazonS3OidcConfig? AmazonS3OidcConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.AmazonS3OidcConfig AmazonS3OidcConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.AzureBlobConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.AzureBlobConfig? AzureBlobConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.AzureBlobConfig AzureBlobConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.AzureHubConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.AzureHubConfig? AzureHubConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.AzureHubConfig AzureHubConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.DatadogConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.DatadogConfig? DatadogConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.DatadogConfig DatadogConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.GoogleCloudConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.GoogleCloudConfig? GoogleCloudConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.GoogleCloudConfig GoogleCloudConfig { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.SplunkConfig"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.SplunkConfig? SplunkConfig { get; set; }
#nullable restore
#else
            public global::GitHub.Models.SplunkConfig SplunkConfig { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.Enterprises.Item.AuditLog.Streams.Item.WithStream_PutRequestBody.WithStream_PutRequestBody_vendor_specific();
                if("amazon-s3-access-keys-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AmazonS3AccessKeysConfig = new global::GitHub.Models.AmazonS3AccessKeysConfig();
                }
                else if("amazon-s3-oidc-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AmazonS3OidcConfig = new global::GitHub.Models.AmazonS3OidcConfig();
                }
                else if("azure-blob-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AzureBlobConfig = new global::GitHub.Models.AzureBlobConfig();
                }
                else if("azure-hub-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AzureHubConfig = new global::GitHub.Models.AzureHubConfig();
                }
                else if("datadog-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.DatadogConfig = new global::GitHub.Models.DatadogConfig();
                }
                else if("google-cloud-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.GoogleCloudConfig = new global::GitHub.Models.GoogleCloudConfig();
                }
                else if("splunk-config".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SplunkConfig = new global::GitHub.Models.SplunkConfig();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(AmazonS3AccessKeysConfig != null)
                {
                    return AmazonS3AccessKeysConfig.GetFieldDeserializers();
                }
                else if(AmazonS3OidcConfig != null)
                {
                    return AmazonS3OidcConfig.GetFieldDeserializers();
                }
                else if(AzureBlobConfig != null)
                {
                    return AzureBlobConfig.GetFieldDeserializers();
                }
                else if(AzureHubConfig != null)
                {
                    return AzureHubConfig.GetFieldDeserializers();
                }
                else if(DatadogConfig != null)
                {
                    return DatadogConfig.GetFieldDeserializers();
                }
                else if(GoogleCloudConfig != null)
                {
                    return GoogleCloudConfig.GetFieldDeserializers();
                }
                else if(SplunkConfig != null)
                {
                    return SplunkConfig.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(AmazonS3AccessKeysConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.AmazonS3AccessKeysConfig>(null, AmazonS3AccessKeysConfig);
                }
                else if(AmazonS3OidcConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.AmazonS3OidcConfig>(null, AmazonS3OidcConfig);
                }
                else if(AzureBlobConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.AzureBlobConfig>(null, AzureBlobConfig);
                }
                else if(AzureHubConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.AzureHubConfig>(null, AzureHubConfig);
                }
                else if(DatadogConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.DatadogConfig>(null, DatadogConfig);
                }
                else if(GoogleCloudConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.GoogleCloudConfig>(null, GoogleCloudConfig);
                }
                else if(SplunkConfig != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.SplunkConfig>(null, SplunkConfig);
                }
            }
        }
    }
}
#pragma warning restore CS0618
