// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Attestations.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class WithSubject_digestGetResponse_attestations : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attestation&apos;s Sigstore Bundle.Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations_bundle? Bundle { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations_bundle Bundle { get; set; }
#endif
        /// <summary>The repository_id property</summary>
        public int? RepositoryId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations"/> and sets the default values.
        /// </summary>
        public WithSubject_digestGetResponse_attestations()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bundle", n => { Bundle = n.GetObjectValue<global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations_bundle>(global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations_bundle.CreateFromDiscriminatorValue); } },
                { "repository_id", n => { RepositoryId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.Attestations.Item.WithSubject_digestGetResponse_attestations_bundle>("bundle", Bundle);
            writer.WriteIntValue("repository_id", RepositoryId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
