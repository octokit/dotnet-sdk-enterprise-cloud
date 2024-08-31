// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Repositories associated with a code security configuration and attachment status
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CodeSecurityConfigurationRepositories : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleRepository? Repository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleRepository Repository { get; set; }
#endif
        /// <summary>The attachment status of the code security configuration on the repository.</summary>
        public global::GitHub.Models.CodeSecurityConfigurationRepositories_status? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CodeSecurityConfigurationRepositories"/> and sets the default values.
        /// </summary>
        public CodeSecurityConfigurationRepositories()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeSecurityConfigurationRepositories"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodeSecurityConfigurationRepositories CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodeSecurityConfigurationRepositories();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "repository", n => { Repository = n.GetObjectValue<global::GitHub.Models.SimpleRepository>(global::GitHub.Models.SimpleRepository.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::GitHub.Models.CodeSecurityConfigurationRepositories_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.SimpleRepository>("repository", Repository);
            writer.WriteEnumValue<global::GitHub.Models.CodeSecurityConfigurationRepositories_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
