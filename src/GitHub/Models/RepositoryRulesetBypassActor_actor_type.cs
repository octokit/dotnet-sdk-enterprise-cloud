// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The type of actor that can bypass a ruleset.</summary>
    public enum RepositoryRulesetBypassActor_actor_type
    {
        [EnumMember(Value = "Integration")]
        #pragma warning disable CS1591
        Integration,
        #pragma warning restore CS1591
        [EnumMember(Value = "OrganizationAdmin")]
        #pragma warning disable CS1591
        OrganizationAdmin,
        #pragma warning restore CS1591
        [EnumMember(Value = "RepositoryRole")]
        #pragma warning disable CS1591
        RepositoryRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "Team")]
        #pragma warning disable CS1591
        Team,
        #pragma warning restore CS1591
        [EnumMember(Value = "DeployKey")]
        #pragma warning disable CS1591
        DeployKey,
        #pragma warning restore CS1591
    }
}