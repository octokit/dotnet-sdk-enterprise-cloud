// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Teams.Item
{
    /// <summary>The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  **For a non-nested team:**   * `secret` - only visible to organization owners and members of this team.   * `closed` - visible to all members of this organization.  **For a parent or child team:**   * `closed` - visible to all members of this organization.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum WithTeam_PatchRequestBody_privacy
    {
        [EnumMember(Value = "secret")]
        #pragma warning disable CS1591
        Secret,
        #pragma warning restore CS1591
        [EnumMember(Value = "closed")]
        #pragma warning disable CS1591
        Closed,
        #pragma warning restore CS1591
    }
}
