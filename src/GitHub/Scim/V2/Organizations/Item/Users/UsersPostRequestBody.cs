// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Scim.V2.Organizations.Item.Users
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class UsersPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active property</summary>
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
        public List<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_emails>? Emails { get; set; }
#nullable restore
#else
        public List<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_emails> Emails { get; set; }
#endif
        /// <summary>The externalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups { get; set; }
#nullable restore
#else
        public List<string> Groups { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name? Name { get; set; }
#nullable restore
#else
        public global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name Name { get; set; }
#endif
        /// <summary>The schemas property</summary>
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
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody"/> and sets the default values.
        /// </summary>
        public UsersPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "emails", n => { Emails = n.GetCollectionOfObjectValues<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_emails>(global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_emails.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetObjectValue<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name>(global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name.CreateFromDiscriminatorValue); } },
                { "schemas", n => { Schemas = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_emails>("emails", Emails);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteObjectValue<global::GitHub.Scim.V2.Organizations.Item.Users.UsersPostRequestBody_name>("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("schemas", Schemas);
            writer.WriteStringValue("userName", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
