// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Invitations
{
    /// <summary>The role for the new member.  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.   * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.   * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization.  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum InvitationsPostRequestBody_role
    {
        [EnumMember(Value = "admin")]
        #pragma warning disable CS1591
        Admin,
        #pragma warning restore CS1591
        [EnumMember(Value = "direct_member")]
        #pragma warning disable CS1591
        Direct_member,
        #pragma warning restore CS1591
        [EnumMember(Value = "billing_manager")]
        #pragma warning disable CS1591
        Billing_manager,
        #pragma warning restore CS1591
        [EnumMember(Value = "reinstate")]
        #pragma warning disable CS1591
        Reinstate,
        #pragma warning restore CS1591
    }
}
