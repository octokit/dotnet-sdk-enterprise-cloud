// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The organization policy for allowing or disallowing Copilot to make suggestions that match public code.</summary>
    public enum CopilotOrganizationDetails_public_code_suggestions
    {
        [EnumMember(Value = "allow")]
        #pragma warning disable CS1591
        Allow,
        #pragma warning restore CS1591
        [EnumMember(Value = "block")]
        #pragma warning disable CS1591
        Block,
        #pragma warning restore CS1591
        [EnumMember(Value = "unconfigured")]
        #pragma warning disable CS1591
        Unconfigured,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknown")]
        #pragma warning disable CS1591
        Unknown,
        #pragma warning restore CS1591
    }
}
