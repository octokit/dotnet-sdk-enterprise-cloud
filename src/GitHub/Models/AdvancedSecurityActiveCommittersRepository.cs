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
    public partial class AdvancedSecurityActiveCommittersRepository : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The advanced_security_committers property</summary>
        public int? AdvancedSecurityCommitters { get; set; }
        /// <summary>The advanced_security_committers_breakdown property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.AdvancedSecurityActiveCommittersUser>? AdvancedSecurityCommittersBreakdown { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.AdvancedSecurityActiveCommittersUser> AdvancedSecurityCommittersBreakdown { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.AdvancedSecurityActiveCommittersRepository"/> and sets the default values.
        /// </summary>
        public AdvancedSecurityActiveCommittersRepository()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.AdvancedSecurityActiveCommittersRepository"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.AdvancedSecurityActiveCommittersRepository CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.AdvancedSecurityActiveCommittersRepository();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security_committers", n => { AdvancedSecurityCommitters = n.GetIntValue(); } },
                { "advanced_security_committers_breakdown", n => { AdvancedSecurityCommittersBreakdown = n.GetCollectionOfObjectValues<global::GitHub.Models.AdvancedSecurityActiveCommittersUser>(global::GitHub.Models.AdvancedSecurityActiveCommittersUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("advanced_security_committers", AdvancedSecurityCommitters);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.AdvancedSecurityActiveCommittersUser>("advanced_security_committers_breakdown", AdvancedSecurityCommittersBreakdown);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
