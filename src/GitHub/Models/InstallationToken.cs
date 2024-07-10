// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Authentication token for a GitHub App installed on a user or org.
    /// </summary>
    public class InstallationToken : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expires_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpiresAt { get; set; }
#nullable restore
#else
        public string ExpiresAt { get; set; }
#endif
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
        /// <summary>The repositories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Repository>? Repositories { get; set; }
#nullable restore
#else
        public List<Repository> Repositories { get; set; }
#endif
        /// <summary>The repository_selection property</summary>
        public InstallationToken_repository_selection? RepositorySelection { get; set; }
        /// <summary>The single_file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SingleFile { get; set; }
#nullable restore
#else
        public string SingleFile { get; set; }
#endif
        /// <summary>The single_file_paths property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SingleFilePaths { get; set; }
#nullable restore
#else
        public List<string> SingleFilePaths { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="InstallationToken"/> and sets the default values.
        /// </summary>
        public InstallationToken()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InstallationToken"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InstallationToken CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InstallationToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"expires_at", n => { ExpiresAt = n.GetStringValue(); } },
                {"has_multiple_single_files", n => { HasMultipleSingleFiles = n.GetBoolValue(); } },
                {"permissions", n => { Permissions = n.GetObjectValue<AppPermissions>(AppPermissions.CreateFromDiscriminatorValue); } },
                {"repositories", n => { Repositories = n.GetCollectionOfObjectValues<Repository>(Repository.CreateFromDiscriminatorValue)?.ToList(); } },
                {"repository_selection", n => { RepositorySelection = n.GetEnumValue<InstallationToken_repository_selection>(); } },
                {"single_file", n => { SingleFile = n.GetStringValue(); } },
                {"single_file_paths", n => { SingleFilePaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expires_at", ExpiresAt);
            writer.WriteBoolValue("has_multiple_single_files", HasMultipleSingleFiles);
            writer.WriteObjectValue<AppPermissions>("permissions", Permissions);
            writer.WriteCollectionOfObjectValues<Repository>("repositories", Repositories);
            writer.WriteEnumValue<InstallationToken_repository_selection>("repository_selection", RepositorySelection);
            writer.WriteStringValue("single_file", SingleFile);
            writer.WriteCollectionOfPrimitiveValues<string>("single_file_paths", SingleFilePaths);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}