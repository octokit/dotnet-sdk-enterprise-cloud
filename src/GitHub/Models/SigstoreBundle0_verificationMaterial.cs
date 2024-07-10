// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class SigstoreBundle0_verificationMaterial : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The timestampVerificationData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimestampVerificationData { get; set; }
#nullable restore
#else
        public string TimestampVerificationData { get; set; }
#endif
        /// <summary>The tlogEntries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SigstoreBundle0_verificationMaterial_tlogEntries>? TlogEntries { get; set; }
#nullable restore
#else
        public List<SigstoreBundle0_verificationMaterial_tlogEntries> TlogEntries { get; set; }
#endif
        /// <summary>The x509CertificateChain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SigstoreBundle0_verificationMaterial_x509CertificateChain? X509CertificateChain { get; set; }
#nullable restore
#else
        public SigstoreBundle0_verificationMaterial_x509CertificateChain X509CertificateChain { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SigstoreBundle0_verificationMaterial"/> and sets the default values.
        /// </summary>
        public SigstoreBundle0_verificationMaterial()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SigstoreBundle0_verificationMaterial"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SigstoreBundle0_verificationMaterial CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SigstoreBundle0_verificationMaterial();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"timestampVerificationData", n => { TimestampVerificationData = n.GetStringValue(); } },
                {"tlogEntries", n => { TlogEntries = n.GetCollectionOfObjectValues<SigstoreBundle0_verificationMaterial_tlogEntries>(SigstoreBundle0_verificationMaterial_tlogEntries.CreateFromDiscriminatorValue)?.ToList(); } },
                {"x509CertificateChain", n => { X509CertificateChain = n.GetObjectValue<SigstoreBundle0_verificationMaterial_x509CertificateChain>(SigstoreBundle0_verificationMaterial_x509CertificateChain.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("timestampVerificationData", TimestampVerificationData);
            writer.WriteCollectionOfObjectValues<SigstoreBundle0_verificationMaterial_tlogEntries>("tlogEntries", TlogEntries);
            writer.WriteObjectValue<SigstoreBundle0_verificationMaterial_x509CertificateChain>("x509CertificateChain", X509CertificateChain);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
