// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>Defines the level of access that workflows outside of the repository have to actions and reusable workflows within therepository.`none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization. `enterprise` level access allows sharing across the enterprise.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum ActionsWorkflowAccessToRepository_access_level
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "user")]
        #pragma warning disable CS1591
        User,
        #pragma warning restore CS1591
        [EnumMember(Value = "organization")]
        #pragma warning disable CS1591
        Organization,
        #pragma warning restore CS1591
        [EnumMember(Value = "enterprise")]
        #pragma warning disable CS1591
        Enterprise,
        #pragma warning restore CS1591
    }
}
