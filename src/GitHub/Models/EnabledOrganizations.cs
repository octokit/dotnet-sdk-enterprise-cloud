// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The policy that controls the organizations in the enterprise that are allowed to run GitHub Actions.</summary>
    public enum EnabledOrganizations
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "selected")]
        #pragma warning disable CS1591
        Selected,
        #pragma warning restore CS1591
    }
}