// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Teams.Item.Projects.Item {
    #pragma warning disable CS1591
    public class WithProject_PutRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The permission to grant to the team for this project. Default: the team&apos;s `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you&apos;ll need to set `Content-Length` to zero when calling this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/enterprise-cloud@latest//rest/guides/getting-started-with-the-rest-api#http-method).&quot;</summary>
        public WithProject_PutRequestBody_permission? Permission { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WithProject_PutRequestBody"/> and sets the default values.
        /// </summary>
        public WithProject_PutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithProject_PutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithProject_PutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithProject_PutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"permission", n => { Permission = n.GetEnumValue<WithProject_PutRequestBody_permission>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WithProject_PutRequestBody_permission>("permission", Permission);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
