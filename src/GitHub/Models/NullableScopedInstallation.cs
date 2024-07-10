// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class NullableScopedInstallation : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Account { get; set; }
#nullable restore
#else
        public SimpleUser Account { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The has_multiple_single_files property</summary>
        public bool? HasMultipleSingleFiles { get; set; }
        /// <summary>The permissions granted to the user access token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppPermissions? Permissions { get; set; }
#nullable restore
#else
        public AppPermissions Permissions { get; set; }
#endif
        /// <summary>The repositories_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoriesUrl { get; set; }
#nullable restore
#else
        public string RepositoriesUrl { get; set; }
#endif
        /// <summary>Describe whether all repositories have been selected or there&apos;s a selection involved</summary>
        public NullableScopedInstallation_repository_selection? RepositorySelection { get; set; }
        /// <summary>The single_file_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SingleFileName { get; set; }
#nullable restore
#else
        public string SingleFileName { get; set; }
#endif
        /// <summary>The single_file_paths property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SingleFilePaths { get; set; }
#nullable restore
#else
        public List<string> SingleFilePaths { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="NullableScopedInstallation"/> and sets the default values.
        /// </summary>
        public NullableScopedInstallation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NullableScopedInstallation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NullableScopedInstallation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NullableScopedInstallation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"account", n => { Account = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"has_multiple_single_files", n => { HasMultipleSingleFiles = n.GetBoolValue(); } },
                {"permissions", n => { Permissions = n.GetObjectValue<AppPermissions>(AppPermissions.CreateFromDiscriminatorValue); } },
                {"repositories_url", n => { RepositoriesUrl = n.GetStringValue(); } },
                {"repository_selection", n => { RepositorySelection = n.GetEnumValue<NullableScopedInstallation_repository_selection>(); } },
                {"single_file_name", n => { SingleFileName = n.GetStringValue(); } },
                {"single_file_paths", n => { SingleFilePaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SimpleUser>("account", Account);
            writer.WriteBoolValue("has_multiple_single_files", HasMultipleSingleFiles);
            writer.WriteObjectValue<AppPermissions>("permissions", Permissions);
            writer.WriteStringValue("repositories_url", RepositoriesUrl);
            writer.WriteEnumValue<NullableScopedInstallation_repository_selection>("repository_selection", RepositorySelection);
            writer.WriteStringValue("single_file_name", SingleFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("single_file_paths", SingleFilePaths);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}