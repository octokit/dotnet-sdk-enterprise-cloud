// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class ScimUser_operations : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The op property</summary>
        public ScimUser_operations_op? Op { get; set; }
        /// <summary>The path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ScimUser_operations_value? Value { get; set; }
#nullable restore
#else
        public ScimUser_operations_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ScimUser_operations"/> and sets the default values.
        /// </summary>
        public ScimUser_operations()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ScimUser_operations"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScimUser_operations CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScimUser_operations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"op", n => { Op = n.GetEnumValue<ScimUser_operations_op>(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"value", n => { Value = n.GetObjectValue<ScimUser_operations_value>(ScimUser_operations_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ScimUser_operations_op>("op", Op);
            writer.WriteStringValue("path", Path);
            writer.WriteObjectValue<ScimUser_operations_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="ScimUser_operations_valueMember1"/>, <see cref="ScimUser_operations_valueMember2"/>, <see cref="string"/>
        /// </summary>
        public class ScimUser_operations_value : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="ScimUser_operations_valueMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public ScimUser_operations_valueMember1? ScimUserOperationsValueMember1 { get; set; }
#nullable restore
#else
            public ScimUser_operations_valueMember1 ScimUserOperationsValueMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="ScimUser_operations_valueMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public ScimUser_operations_valueMember2? ScimUserOperationsValueMember2 { get; set; }
#nullable restore
#else
            public ScimUser_operations_valueMember2 ScimUserOperationsValueMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="ScimUser_operations_value"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static ScimUser_operations_value CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new ScimUser_operations_value();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ScimUserOperationsValueMember1 = new ScimUser_operations_valueMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ScimUserOperationsValueMember2 = new ScimUser_operations_valueMember2();
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ScimUserOperationsValueMember1 != null)
                {
                    return ScimUserOperationsValueMember1.GetFieldDeserializers();
                }
                else if(ScimUserOperationsValueMember2 != null)
                {
                    return ScimUserOperationsValueMember2.GetFieldDeserializers();
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
                if(ScimUserOperationsValueMember1 != null)
                {
                    writer.WriteObjectValue<ScimUser_operations_valueMember1>(null, ScimUserOperationsValueMember1);
                }
                else if(ScimUserOperationsValueMember2 != null)
                {
                    writer.WriteObjectValue<ScimUser_operations_valueMember2>(null, ScimUserOperationsValueMember2);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
