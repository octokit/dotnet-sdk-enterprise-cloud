// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class EnterpriseSecurityAnalysisSettings : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether GitHub advanced security is automatically enabled for new repositories and repositories transferred tothis enterprise.</summary>
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }
        /// <summary>Whether GitHub Advanced Security is automatically enabled for new user namespace repositories.</summary>
        public bool? AdvancedSecurityEnabledForNewUserNamespaceRepositories { get; set; }
        /// <summary>Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to thisenterprise.</summary>
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }
        /// <summary>Whether secret scanning is automatically enabled for new repositories and repositories transferred to thisenterprise.</summary>
        public bool? SecretScanningEnabledForNewRepositories { get; set; }
        /// <summary>An optional URL string to display to contributors who are blocked from pushing a secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretScanningPushProtectionCustomLink { get; set; }
#nullable restore
#else
        public string SecretScanningPushProtectionCustomLink { get; set; }
#endif
        /// <summary>Whether secret scanning push protection is automatically enabled for new repositories and repositoriestransferred to this enterprise.</summary>
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }
        /// <summary>Whether secret scanning automatic validity checks on supported partner tokens is enabled for all repositories under this enterprise.</summary>
        public bool? SecretScanningValidityChecksEnabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="EnterpriseSecurityAnalysisSettings"/> and sets the default values.
        /// </summary>
        public EnterpriseSecurityAnalysisSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnterpriseSecurityAnalysisSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EnterpriseSecurityAnalysisSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnterpriseSecurityAnalysisSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"advanced_security_enabled_for_new_repositories", n => { AdvancedSecurityEnabledForNewRepositories = n.GetBoolValue(); } },
                {"advanced_security_enabled_for_new_user_namespace_repositories", n => { AdvancedSecurityEnabledForNewUserNamespaceRepositories = n.GetBoolValue(); } },
                {"dependabot_alerts_enabled_for_new_repositories", n => { DependabotAlertsEnabledForNewRepositories = n.GetBoolValue(); } },
                {"secret_scanning_enabled_for_new_repositories", n => { SecretScanningEnabledForNewRepositories = n.GetBoolValue(); } },
                {"secret_scanning_push_protection_custom_link", n => { SecretScanningPushProtectionCustomLink = n.GetStringValue(); } },
                {"secret_scanning_push_protection_enabled_for_new_repositories", n => { SecretScanningPushProtectionEnabledForNewRepositories = n.GetBoolValue(); } },
                {"secret_scanning_validity_checks_enabled", n => { SecretScanningValidityChecksEnabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("advanced_security_enabled_for_new_user_namespace_repositories", AdvancedSecurityEnabledForNewUserNamespaceRepositories);
            writer.WriteBoolValue("dependabot_alerts_enabled_for_new_repositories", DependabotAlertsEnabledForNewRepositories);
            writer.WriteBoolValue("secret_scanning_enabled_for_new_repositories", SecretScanningEnabledForNewRepositories);
            writer.WriteStringValue("secret_scanning_push_protection_custom_link", SecretScanningPushProtectionCustomLink);
            writer.WriteBoolValue("secret_scanning_push_protection_enabled_for_new_repositories", SecretScanningPushProtectionEnabledForNewRepositories);
            writer.WriteBoolValue("secret_scanning_validity_checks_enabled", SecretScanningValidityChecksEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
