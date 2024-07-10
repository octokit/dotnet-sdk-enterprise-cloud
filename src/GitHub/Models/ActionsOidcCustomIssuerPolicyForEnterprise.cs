// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class ActionsOidcCustomIssuerPolicyForEnterprise : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the enterprise customer requested a custom issuer URL.</summary>
        public bool? IncludeEnterpriseSlug { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ActionsOidcCustomIssuerPolicyForEnterprise"/> and sets the default values.
        /// </summary>
        public ActionsOidcCustomIssuerPolicyForEnterprise()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionsOidcCustomIssuerPolicyForEnterprise"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionsOidcCustomIssuerPolicyForEnterprise CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionsOidcCustomIssuerPolicyForEnterprise();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"include_enterprise_slug", n => { IncludeEnterpriseSlug = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("include_enterprise_slug", IncludeEnterpriseSlug);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}