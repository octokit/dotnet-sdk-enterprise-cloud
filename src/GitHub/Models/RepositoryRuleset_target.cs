// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The target of the ruleset**Note**: The `push` target is in beta and is subject to change.</summary>
    public enum RepositoryRuleset_target
    {
        [EnumMember(Value = "branch")]
        #pragma warning disable CS1591
        Branch,
        #pragma warning restore CS1591
        [EnumMember(Value = "tag")]
        #pragma warning disable CS1591
        Tag,
        #pragma warning restore CS1591
        [EnumMember(Value = "push")]
        #pragma warning disable CS1591
        Push,
        #pragma warning restore CS1591
    }
}