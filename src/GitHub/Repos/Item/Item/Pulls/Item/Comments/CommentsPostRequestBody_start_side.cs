// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Comments {
    /// <summary>**Required when using multi-line comments unless using `in_reply_to`**. The `start_side` is the starting side of the diff that the comment applies to. Can be `LEFT` or `RIGHT`. To learn more about multi-line comments, see &quot;[Commenting on a pull request](https://docs.github.com/enterprise-cloud@latest//articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)&quot; in the GitHub Help documentation. See `side` in this table for additional context.</summary>
    public enum CommentsPostRequestBody_start_side
    {
        [EnumMember(Value = "LEFT")]
        #pragma warning disable CS1591
        LEFT,
        #pragma warning restore CS1591
        [EnumMember(Value = "RIGHT")]
        #pragma warning disable CS1591
        RIGHT,
        #pragma warning restore CS1591
        [EnumMember(Value = "side")]
        #pragma warning disable CS1591
        Side,
        #pragma warning restore CS1591
    }
}