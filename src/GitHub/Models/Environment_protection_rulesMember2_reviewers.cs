// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class Environment_protection_rulesMember2_reviewers : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The reviewer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Environment_protection_rulesMember2_reviewers_reviewer? Reviewer { get; set; }
#nullable restore
#else
        public Environment_protection_rulesMember2_reviewers_reviewer Reviewer { get; set; }
#endif
        /// <summary>The type of reviewer.</summary>
        public DeploymentReviewerType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Environment_protection_rulesMember2_reviewers"/> and sets the default values.
        /// </summary>
        public Environment_protection_rulesMember2_reviewers()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Environment_protection_rulesMember2_reviewers"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Environment_protection_rulesMember2_reviewers CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Environment_protection_rulesMember2_reviewers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"reviewer", n => { Reviewer = n.GetObjectValue<Environment_protection_rulesMember2_reviewers_reviewer>(Environment_protection_rulesMember2_reviewers_reviewer.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<DeploymentReviewerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Environment_protection_rulesMember2_reviewers_reviewer>("reviewer", Reviewer);
            writer.WriteEnumValue<DeploymentReviewerType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="SimpleUser"/>, <see cref="Team"/>
        /// </summary>
        public class Environment_protection_rulesMember2_reviewers_reviewer : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SimpleUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SimpleUser? SimpleUser { get; set; }
#nullable restore
#else
            public GitHub.Models.SimpleUser SimpleUser { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.Team"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.Team? Team { get; set; }
#nullable restore
#else
            public GitHub.Models.Team Team { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="Environment_protection_rulesMember2_reviewers_reviewer"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static Environment_protection_rulesMember2_reviewers_reviewer CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new Environment_protection_rulesMember2_reviewers_reviewer();
                result.SimpleUser = new GitHub.Models.SimpleUser();
                result.Team = new GitHub.Models.Team();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(SimpleUser != null || Team != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(SimpleUser, Team);
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
                writer.WriteObjectValue<GitHub.Models.SimpleUser>(null, SimpleUser, Team);
            }
        }
    }
}