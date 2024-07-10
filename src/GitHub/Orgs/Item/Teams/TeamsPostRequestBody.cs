// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Teams {
    #pragma warning disable CS1591
    public class TeamsPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>List GitHub IDs for organization members who will become team maintainers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Maintainers { get; set; }
#nullable restore
#else
        public List<string> Maintainers { get; set; }
#endif
        /// <summary>The name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The notification setting the team has chosen. The options are:   * `notifications_enabled` - team members receive notifications when the team is @mentioned.   * `notifications_disabled` - no one receives notifications.  Default: `notifications_enabled`</summary>
        public TeamsPostRequestBody_notification_setting? NotificationSetting { get; set; }
        /// <summary>The ID of a team to set as the parent team.</summary>
        public int? ParentTeamId { get; set; }
        /// <summary>**Deprecated**. The permission that new repositories will be added to the team with when none is specified.</summary>
        public TeamsPostRequestBody_permission? Permission { get; set; }
        /// <summary>The level of privacy this team should have. The options are:  **For a non-nested team:**   * `secret` - only visible to organization owners and members of this team.   * `closed` - visible to all members of this organization.  Default: `secret`  **For a parent or child team:**   * `closed` - visible to all members of this organization.  Default for child team: `closed`</summary>
        public TeamsPostRequestBody_privacy? Privacy { get; set; }
        /// <summary>The full name (e.g., &quot;organization-name/repository-name&quot;) of repositories to add the team to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RepoNames { get; set; }
#nullable restore
#else
        public List<string> RepoNames { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TeamsPostRequestBody"/> and sets the default values.
        /// </summary>
        public TeamsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Permission = TeamsPostRequestBody_permission.Pull;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"description", n => { Description = n.GetStringValue(); } },
                {"maintainers", n => { Maintainers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notification_setting", n => { NotificationSetting = n.GetEnumValue<TeamsPostRequestBody_notification_setting>(); } },
                {"parent_team_id", n => { ParentTeamId = n.GetIntValue(); } },
                {"permission", n => { Permission = n.GetEnumValue<TeamsPostRequestBody_permission>(); } },
                {"privacy", n => { Privacy = n.GetEnumValue<TeamsPostRequestBody_privacy>(); } },
                {"repo_names", n => { RepoNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("maintainers", Maintainers);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<TeamsPostRequestBody_notification_setting>("notification_setting", NotificationSetting);
            writer.WriteIntValue("parent_team_id", ParentTeamId);
            writer.WriteEnumValue<TeamsPostRequestBody_permission>("permission", Permission);
            writer.WriteEnumValue<TeamsPostRequestBody_privacy>("privacy", Privacy);
            writer.WriteCollectionOfPrimitiveValues<string>("repo_names", RepoNames);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
