// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Git.Trees {
    /// <summary>Either `blob`, `tree`, or `commit`.</summary>
    public enum TreesPostRequestBody_tree_type
    {
        [EnumMember(Value = "blob")]
        #pragma warning disable CS1591
        Blob,
        #pragma warning restore CS1591
        [EnumMember(Value = "tree")]
        #pragma warning disable CS1591
        Tree,
        #pragma warning restore CS1591
        [EnumMember(Value = "commit")]
        #pragma warning disable CS1591
        Commit,
        #pragma warning restore CS1591
    }
}