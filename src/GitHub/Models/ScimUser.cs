// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// SCIM /Users provisioning endpoints
    /// </summary>
    public class ScimUser : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The active status of the User.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the user, suitable for display to end-users</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>user emails</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScimUser_emails>? Emails { get; set; }
#nullable restore
#else
        public List<ScimUser_emails> Emails { get; set; }
#endif
        /// <summary>The ID of the User.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>associated groups</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScimUser_groups>? Groups { get; set; }
#nullable restore
#else
        public List<ScimUser_groups> Groups { get; set; }
#endif
        /// <summary>Unique identifier of an external identity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ScimUser_meta? Meta { get; set; }
#nullable restore
#else
        public ScimUser_meta Meta { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ScimUser_name? Name { get; set; }
#nullable restore
#else
        public ScimUser_name Name { get; set; }
#endif
        /// <summary>Set of operations to be performed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScimUser_operations>? Operations { get; set; }
#nullable restore
#else
        public List<ScimUser_operations> Operations { get; set; }
#endif
        /// <summary>The ID of the organization.</summary>
        public int? OrganizationId { get; set; }
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScimUser_roles>? Roles { get; set; }
#nullable restore
#else
        public List<ScimUser_roles> Roles { get; set; }
#endif
        /// <summary>SCIM schema used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schemas { get; set; }
#nullable restore
#else
        public List<string> Schemas { get; set; }
#endif
        /// <summary>Configured by the admin. Could be an email, login, or username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ScimUser"/> and sets the default values.
        /// </summary>
        public ScimUser()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ScimUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScimUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScimUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"emails", n => { Emails = n.GetCollectionOfObjectValues<ScimUser_emails>(ScimUser_emails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<ScimUser_groups>(ScimUser_groups.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"meta", n => { Meta = n.GetObjectValue<ScimUser_meta>(ScimUser_meta.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetObjectValue<ScimUser_name>(ScimUser_name.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ScimUser_operations>(ScimUser_operations.CreateFromDiscriminatorValue)?.ToList(); } },
                {"organization_id", n => { OrganizationId = n.GetIntValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<ScimUser_roles>(ScimUser_roles.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schemas", n => { Schemas = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ScimUser_emails>("emails", Emails);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<ScimUser_groups>("groups", Groups);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<ScimUser_meta>("meta", Meta);
            writer.WriteObjectValue<ScimUser_name>("name", Name);
            writer.WriteCollectionOfObjectValues<ScimUser_operations>("operations", Operations);
            writer.WriteIntValue("organization_id", OrganizationId);
            writer.WriteCollectionOfObjectValues<ScimUser_roles>("roles", Roles);
            writer.WriteCollectionOfPrimitiveValues<string>("schemas", Schemas);
            writer.WriteStringValue("userName", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
