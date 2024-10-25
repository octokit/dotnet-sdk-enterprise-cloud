// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class WithOrgPatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether GitHub Advanced Security is automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }
        /// <summary>Billing email address. This address is not publicized.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingEmail { get; set; }
#nullable restore
#else
        public string BillingEmail { get; set; }
#endif
        /// <summary>The blog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blog { get; set; }
#nullable restore
#else
        public string Blog { get; set; }
#endif
        /// <summary>The company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>Default permission level members have for organization repositories.</summary>
        public global::GitHub.Orgs.Item.WithOrgPatchRequestBody_default_repository_permission? DefaultRepositoryPermission { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }
        /// <summary>The description of the company. The maximum size is 160 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The publicly visible email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Whether an organization can use organization projects.</summary>
        public bool? HasOrganizationProjects { get; set; }
        /// <summary>Whether repositories that belong to the organization can use repository projects.</summary>
        public bool? HasRepositoryProjects { get; set; }
        /// <summary>The location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. **Note:** This parameter is closing down and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.</summary>
        public global::GitHub.Orgs.Item.WithOrgPatchRequestBody_members_allowed_repository_creation_type? MembersAllowedRepositoryCreationType { get; set; }
        /// <summary>Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see &quot;[Restricting repository creation in your organization](https://docs.github.com/enterprise-cloud@latest//github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)&quot; in the GitHub Help documentation.</summary>
        public bool? MembersCanCreateInternalRepositories { get; set; }
        /// <summary>Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.</summary>
        public bool? MembersCanCreatePages { get; set; }
        /// <summary>Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.</summary>
        public bool? MembersCanCreatePrivatePages { get; set; }
        /// <summary>Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see &quot;[Restricting repository creation in your organization](https://docs.github.com/enterprise-cloud@latest//github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)&quot; in the GitHub Help documentation.</summary>
        public bool? MembersCanCreatePrivateRepositories { get; set; }
        /// <summary>Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.</summary>
        public bool? MembersCanCreatePublicPages { get; set; }
        /// <summary>Whether organization members can create public repositories, which are visible to anyone. For more information, see &quot;[Restricting repository creation in your organization](https://docs.github.com/enterprise-cloud@latest//github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)&quot; in the GitHub Help documentation.</summary>
        public bool? MembersCanCreatePublicRepositories { get; set; }
        /// <summary>Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.</summary>
        public bool? MembersCanCreateRepositories { get; set; }
        /// <summary>Whether organization members can fork private organization repositories.</summary>
        public bool? MembersCanForkPrivateRepositories { get; set; }
        /// <summary>The shorthand name of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }
        /// <summary>If `secret_scanning_push_protection_custom_link_enabled` is true, the URL that will be displayed to contributors who are blocked from pushing a secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretScanningPushProtectionCustomLink { get; set; }
#nullable restore
#else
        public string SecretScanningPushProtectionCustomLink { get; set; }
#endif
        /// <summary>Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.</summary>
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-cloud@latest//organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.</summary>
        [Obsolete("")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }
        /// <summary>**Endpoint closing down notice.** Please use [code security configurations](https://docs.github.com/enterprise-cloud@latest//rest/code-security/configurations) instead.Whether secret scanning automatic validity checks on supported partner tokens is enabled for all repositories under this organization.</summary>
        [Obsolete("")]
        public bool? SecretScanningValidityChecksEnabled { get; set; }
        /// <summary>The Twitter username of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwitterUsername { get; set; }
#nullable restore
#else
        public string TwitterUsername { get; set; }
#endif
        /// <summary>Whether contributors to organization repositories are required to sign off on commits they make through GitHub&apos;s web interface.</summary>
        public bool? WebCommitSignoffRequired { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.WithOrgPatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithOrgPatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            DefaultRepositoryPermission = global::GitHub.Orgs.Item.WithOrgPatchRequestBody_default_repository_permission.Read;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.WithOrgPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.WithOrgPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.WithOrgPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security_enabled_for_new_repositories", n => { AdvancedSecurityEnabledForNewRepositories = n.GetBoolValue(); } },
                { "billing_email", n => { BillingEmail = n.GetStringValue(); } },
                { "blog", n => { Blog = n.GetStringValue(); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "default_repository_permission", n => { DefaultRepositoryPermission = n.GetEnumValue<global::GitHub.Orgs.Item.WithOrgPatchRequestBody_default_repository_permission>(); } },
                { "dependabot_alerts_enabled_for_new_repositories", n => { DependabotAlertsEnabledForNewRepositories = n.GetBoolValue(); } },
                { "dependabot_security_updates_enabled_for_new_repositories", n => { DependabotSecurityUpdatesEnabledForNewRepositories = n.GetBoolValue(); } },
                { "dependency_graph_enabled_for_new_repositories", n => { DependencyGraphEnabledForNewRepositories = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "has_organization_projects", n => { HasOrganizationProjects = n.GetBoolValue(); } },
                { "has_repository_projects", n => { HasRepositoryProjects = n.GetBoolValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "members_allowed_repository_creation_type", n => { MembersAllowedRepositoryCreationType = n.GetEnumValue<global::GitHub.Orgs.Item.WithOrgPatchRequestBody_members_allowed_repository_creation_type>(); } },
                { "members_can_create_internal_repositories", n => { MembersCanCreateInternalRepositories = n.GetBoolValue(); } },
                { "members_can_create_pages", n => { MembersCanCreatePages = n.GetBoolValue(); } },
                { "members_can_create_private_pages", n => { MembersCanCreatePrivatePages = n.GetBoolValue(); } },
                { "members_can_create_private_repositories", n => { MembersCanCreatePrivateRepositories = n.GetBoolValue(); } },
                { "members_can_create_public_pages", n => { MembersCanCreatePublicPages = n.GetBoolValue(); } },
                { "members_can_create_public_repositories", n => { MembersCanCreatePublicRepositories = n.GetBoolValue(); } },
                { "members_can_create_repositories", n => { MembersCanCreateRepositories = n.GetBoolValue(); } },
                { "members_can_fork_private_repositories", n => { MembersCanForkPrivateRepositories = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "secret_scanning_enabled_for_new_repositories", n => { SecretScanningEnabledForNewRepositories = n.GetBoolValue(); } },
                { "secret_scanning_push_protection_custom_link", n => { SecretScanningPushProtectionCustomLink = n.GetStringValue(); } },
                { "secret_scanning_push_protection_custom_link_enabled", n => { SecretScanningPushProtectionCustomLinkEnabled = n.GetBoolValue(); } },
                { "secret_scanning_push_protection_enabled_for_new_repositories", n => { SecretScanningPushProtectionEnabledForNewRepositories = n.GetBoolValue(); } },
                { "secret_scanning_validity_checks_enabled", n => { SecretScanningValidityChecksEnabled = n.GetBoolValue(); } },
                { "twitter_username", n => { TwitterUsername = n.GetStringValue(); } },
                { "web_commit_signoff_required", n => { WebCommitSignoffRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("advanced_security_enabled_for_new_repositories", AdvancedSecurityEnabledForNewRepositories);
            writer.WriteStringValue("billing_email", BillingEmail);
            writer.WriteStringValue("blog", Blog);
            writer.WriteStringValue("company", Company);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.WithOrgPatchRequestBody_default_repository_permission>("default_repository_permission", DefaultRepositoryPermission);
            writer.WriteBoolValue("dependabot_alerts_enabled_for_new_repositories", DependabotAlertsEnabledForNewRepositories);
            writer.WriteBoolValue("dependabot_security_updates_enabled_for_new_repositories", DependabotSecurityUpdatesEnabledForNewRepositories);
            writer.WriteBoolValue("dependency_graph_enabled_for_new_repositories", DependencyGraphEnabledForNewRepositories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("email", Email);
            writer.WriteBoolValue("has_organization_projects", HasOrganizationProjects);
            writer.WriteBoolValue("has_repository_projects", HasRepositoryProjects);
            writer.WriteStringValue("location", Location);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.WithOrgPatchRequestBody_members_allowed_repository_creation_type>("members_allowed_repository_creation_type", MembersAllowedRepositoryCreationType);
            writer.WriteBoolValue("members_can_create_internal_repositories", MembersCanCreateInternalRepositories);
            writer.WriteBoolValue("members_can_create_pages", MembersCanCreatePages);
            writer.WriteBoolValue("members_can_create_private_pages", MembersCanCreatePrivatePages);
            writer.WriteBoolValue("members_can_create_private_repositories", MembersCanCreatePrivateRepositories);
            writer.WriteBoolValue("members_can_create_public_pages", MembersCanCreatePublicPages);
            writer.WriteBoolValue("members_can_create_public_repositories", MembersCanCreatePublicRepositories);
            writer.WriteBoolValue("members_can_create_repositories", MembersCanCreateRepositories);
            writer.WriteBoolValue("members_can_fork_private_repositories", MembersCanForkPrivateRepositories);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("secret_scanning_enabled_for_new_repositories", SecretScanningEnabledForNewRepositories);
            writer.WriteStringValue("secret_scanning_push_protection_custom_link", SecretScanningPushProtectionCustomLink);
            writer.WriteBoolValue("secret_scanning_push_protection_custom_link_enabled", SecretScanningPushProtectionCustomLinkEnabled);
            writer.WriteBoolValue("secret_scanning_push_protection_enabled_for_new_repositories", SecretScanningPushProtectionEnabledForNewRepositories);
            writer.WriteBoolValue("secret_scanning_validity_checks_enabled", SecretScanningValidityChecksEnabled);
            writer.WriteStringValue("twitter_username", TwitterUsername);
            writer.WriteBoolValue("web_commit_signoff_required", WebCommitSignoffRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
