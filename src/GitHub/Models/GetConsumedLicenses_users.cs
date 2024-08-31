// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class GetConsumedLicenses_users : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enterprise_server_emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnterpriseServerEmails { get; set; }
#nullable restore
#else
        public List<string> EnterpriseServerEmails { get; set; }
#endif
        /// <summary>The enterprise_server_user property</summary>
        public bool? EnterpriseServerUser { get; set; }
        /// <summary>The enterprise_server_user_ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnterpriseServerUserIds { get; set; }
#nullable restore
#else
        public List<string> EnterpriseServerUserIds { get; set; }
#endif
        /// <summary>All enterprise roles for a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GithubComEnterpriseRoles { get; set; }
#nullable restore
#else
        public List<string> GithubComEnterpriseRoles { get; set; }
#endif
        /// <summary>The github_com_login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GithubComLogin { get; set; }
#nullable restore
#else
        public string GithubComLogin { get; set; }
#endif
        /// <summary>The github_com_member_roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GithubComMemberRoles { get; set; }
#nullable restore
#else
        public List<string> GithubComMemberRoles { get; set; }
#endif
        /// <summary>The github_com_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GithubComName { get; set; }
#nullable restore
#else
        public string GithubComName { get; set; }
#endif
        /// <summary>The github_com_orgs_with_pending_invites property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GithubComOrgsWithPendingInvites { get; set; }
#nullable restore
#else
        public List<string> GithubComOrgsWithPendingInvites { get; set; }
#endif
        /// <summary>The github_com_profile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GithubComProfile { get; set; }
#nullable restore
#else
        public string GithubComProfile { get; set; }
#endif
        /// <summary>The github_com_saml_name_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GithubComSamlNameId { get; set; }
#nullable restore
#else
        public string GithubComSamlNameId { get; set; }
#endif
        /// <summary>The github_com_two_factor_auth property</summary>
        public bool? GithubComTwoFactorAuth { get; set; }
        /// <summary>The github_com_user property</summary>
        public bool? GithubComUser { get; set; }
        /// <summary>The github_com_verified_domain_emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GithubComVerifiedDomainEmails { get; set; }
#nullable restore
#else
        public List<string> GithubComVerifiedDomainEmails { get; set; }
#endif
        /// <summary>The license_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseType { get; set; }
#nullable restore
#else
        public string LicenseType { get; set; }
#endif
        /// <summary>The total_user_accounts property</summary>
        public int? TotalUserAccounts { get; set; }
        /// <summary>The visual_studio_license_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VisualStudioLicenseStatus { get; set; }
#nullable restore
#else
        public string VisualStudioLicenseStatus { get; set; }
#endif
        /// <summary>The visual_studio_subscription_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VisualStudioSubscriptionEmail { get; set; }
#nullable restore
#else
        public string VisualStudioSubscriptionEmail { get; set; }
#endif
        /// <summary>The visual_studio_subscription_user property</summary>
        public bool? VisualStudioSubscriptionUser { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GetConsumedLicenses_users"/> and sets the default values.
        /// </summary>
        public GetConsumedLicenses_users()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GetConsumedLicenses_users"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GetConsumedLicenses_users CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GetConsumedLicenses_users();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enterprise_server_emails", n => { EnterpriseServerEmails = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "enterprise_server_user", n => { EnterpriseServerUser = n.GetBoolValue(); } },
                { "enterprise_server_user_ids", n => { EnterpriseServerUserIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "github_com_enterprise_roles", n => { GithubComEnterpriseRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "github_com_login", n => { GithubComLogin = n.GetStringValue(); } },
                { "github_com_member_roles", n => { GithubComMemberRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "github_com_name", n => { GithubComName = n.GetStringValue(); } },
                { "github_com_orgs_with_pending_invites", n => { GithubComOrgsWithPendingInvites = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "github_com_profile", n => { GithubComProfile = n.GetStringValue(); } },
                { "github_com_saml_name_id", n => { GithubComSamlNameId = n.GetStringValue(); } },
                { "github_com_two_factor_auth", n => { GithubComTwoFactorAuth = n.GetBoolValue(); } },
                { "github_com_user", n => { GithubComUser = n.GetBoolValue(); } },
                { "github_com_verified_domain_emails", n => { GithubComVerifiedDomainEmails = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "license_type", n => { LicenseType = n.GetStringValue(); } },
                { "total_user_accounts", n => { TotalUserAccounts = n.GetIntValue(); } },
                { "visual_studio_license_status", n => { VisualStudioLicenseStatus = n.GetStringValue(); } },
                { "visual_studio_subscription_email", n => { VisualStudioSubscriptionEmail = n.GetStringValue(); } },
                { "visual_studio_subscription_user", n => { VisualStudioSubscriptionUser = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("enterprise_server_emails", EnterpriseServerEmails);
            writer.WriteBoolValue("enterprise_server_user", EnterpriseServerUser);
            writer.WriteCollectionOfPrimitiveValues<string>("enterprise_server_user_ids", EnterpriseServerUserIds);
            writer.WriteCollectionOfPrimitiveValues<string>("github_com_enterprise_roles", GithubComEnterpriseRoles);
            writer.WriteStringValue("github_com_login", GithubComLogin);
            writer.WriteCollectionOfPrimitiveValues<string>("github_com_member_roles", GithubComMemberRoles);
            writer.WriteStringValue("github_com_name", GithubComName);
            writer.WriteCollectionOfPrimitiveValues<string>("github_com_orgs_with_pending_invites", GithubComOrgsWithPendingInvites);
            writer.WriteStringValue("github_com_profile", GithubComProfile);
            writer.WriteStringValue("github_com_saml_name_id", GithubComSamlNameId);
            writer.WriteBoolValue("github_com_two_factor_auth", GithubComTwoFactorAuth);
            writer.WriteBoolValue("github_com_user", GithubComUser);
            writer.WriteCollectionOfPrimitiveValues<string>("github_com_verified_domain_emails", GithubComVerifiedDomainEmails);
            writer.WriteStringValue("license_type", LicenseType);
            writer.WriteIntValue("total_user_accounts", TotalUserAccounts);
            writer.WriteStringValue("visual_studio_license_status", VisualStudioLicenseStatus);
            writer.WriteStringValue("visual_studio_subscription_email", VisualStudioSubscriptionEmail);
            writer.WriteBoolValue("visual_studio_subscription_user", VisualStudioSubscriptionUser);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
