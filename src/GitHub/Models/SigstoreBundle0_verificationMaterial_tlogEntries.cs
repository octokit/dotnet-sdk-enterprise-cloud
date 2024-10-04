// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class SigstoreBundle0_verificationMaterial_tlogEntries : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The canonicalizedBody property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CanonicalizedBody { get; set; }
#nullable restore
#else
        public string CanonicalizedBody { get; set; }
#endif
        /// <summary>The inclusionPromise property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_inclusionPromise? InclusionPromise { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_inclusionPromise InclusionPromise { get; set; }
#endif
        /// <summary>The inclusionProof property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InclusionProof { get; set; }
#nullable restore
#else
        public string InclusionProof { get; set; }
#endif
        /// <summary>The integratedTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegratedTime { get; set; }
#nullable restore
#else
        public string IntegratedTime { get; set; }
#endif
        /// <summary>The kindVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_kindVersion? KindVersion { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_kindVersion KindVersion { get; set; }
#endif
        /// <summary>The logId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_logId? LogId { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_logId LogId { get; set; }
#endif
        /// <summary>The logIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogIndex { get; set; }
#nullable restore
#else
        public string LogIndex { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries"/> and sets the default values.
        /// </summary>
        public SigstoreBundle0_verificationMaterial_tlogEntries()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "canonicalizedBody", n => { CanonicalizedBody = n.GetStringValue(); } },
                { "inclusionPromise", n => { InclusionPromise = n.GetObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_inclusionPromise>(global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_inclusionPromise.CreateFromDiscriminatorValue); } },
                { "inclusionProof", n => { InclusionProof = n.GetStringValue(); } },
                { "integratedTime", n => { IntegratedTime = n.GetStringValue(); } },
                { "kindVersion", n => { KindVersion = n.GetObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_kindVersion>(global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_kindVersion.CreateFromDiscriminatorValue); } },
                { "logId", n => { LogId = n.GetObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_logId>(global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_logId.CreateFromDiscriminatorValue); } },
                { "logIndex", n => { LogIndex = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("canonicalizedBody", CanonicalizedBody);
            writer.WriteObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_inclusionPromise>("inclusionPromise", InclusionPromise);
            writer.WriteStringValue("inclusionProof", InclusionProof);
            writer.WriteStringValue("integratedTime", IntegratedTime);
            writer.WriteObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_kindVersion>("kindVersion", KindVersion);
            writer.WriteObjectValue<global::GitHub.Models.SigstoreBundle0_verificationMaterial_tlogEntries_logId>("logId", LogId);
            writer.WriteStringValue("logIndex", LogIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
