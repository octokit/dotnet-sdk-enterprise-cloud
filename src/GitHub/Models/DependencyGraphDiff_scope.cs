// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum DependencyGraphDiff_scope
    {
        [EnumMember(Value = "unknown")]
        #pragma warning disable CS1591
        Unknown,
        #pragma warning restore CS1591
        [EnumMember(Value = "runtime")]
        #pragma warning disable CS1591
        Runtime,
        #pragma warning restore CS1591
        [EnumMember(Value = "development")]
        #pragma warning disable CS1591
        Development,
        #pragma warning restore CS1591
    }
}
