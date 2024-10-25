// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class PullRequestWebhook : global::GitHub.Models.PullRequest, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Whether to allow auto-merge for pull requests.</summary>
        public bool? AllowAutoMerge { get; set; }
        /// <summary>Whether to allow updating the pull request&apos;s branch.</summary>
        public bool? AllowUpdateBranch { get; set; }
        /// <summary>Whether to delete head branches when pull requests are merged.</summary>
        public bool? DeleteBranchOnMerge { get; set; }
        /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Models.PullRequestWebhook_merge_commit_message? MergeCommitMessage { get; set; }
        /// <summary>The default value for a merge commit title.- `PR_TITLE` - default to the pull request&apos;s title.- `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., &quot;Merge pull request #123 from branch-name&quot;).</summary>
        public global::GitHub.Models.PullRequestWebhook_merge_commit_title? MergeCommitTitle { get; set; }
        /// <summary>The default value for a squash merge commit message:- `PR_BODY` - default to the pull request&apos;s body.- `COMMIT_MESSAGES` - default to the branch&apos;s commit messages.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Models.PullRequestWebhook_squash_merge_commit_message? SquashMergeCommitMessage { get; set; }
        /// <summary>The default value for a squash merge commit title:- `PR_TITLE` - default to the pull request&apos;s title.- `COMMIT_OR_PR_TITLE` - default to the commit&apos;s title (if only one commit) or the pull request&apos;s title (when more than one commit).</summary>
        public global::GitHub.Models.PullRequestWebhook_squash_merge_commit_title? SquashMergeCommitTitle { get; set; }
        /// <summary>Whether a squash merge commit can use the pull request title as default. **This property is closing down. Please use `squash_merge_commit_title` instead.**</summary>
        public bool? UseSquashPrTitleAsDefault { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PullRequestWebhook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::GitHub.Models.PullRequestWebhook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.PullRequestWebhook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allow_auto_merge", n => { AllowAutoMerge = n.GetBoolValue(); } },
                { "allow_update_branch", n => { AllowUpdateBranch = n.GetBoolValue(); } },
                { "delete_branch_on_merge", n => { DeleteBranchOnMerge = n.GetBoolValue(); } },
                { "merge_commit_message", n => { MergeCommitMessage = n.GetEnumValue<global::GitHub.Models.PullRequestWebhook_merge_commit_message>(); } },
                { "merge_commit_title", n => { MergeCommitTitle = n.GetEnumValue<global::GitHub.Models.PullRequestWebhook_merge_commit_title>(); } },
                { "squash_merge_commit_message", n => { SquashMergeCommitMessage = n.GetEnumValue<global::GitHub.Models.PullRequestWebhook_squash_merge_commit_message>(); } },
                { "squash_merge_commit_title", n => { SquashMergeCommitTitle = n.GetEnumValue<global::GitHub.Models.PullRequestWebhook_squash_merge_commit_title>(); } },
                { "use_squash_pr_title_as_default", n => { UseSquashPrTitleAsDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allow_auto_merge", AllowAutoMerge);
            writer.WriteBoolValue("allow_update_branch", AllowUpdateBranch);
            writer.WriteBoolValue("delete_branch_on_merge", DeleteBranchOnMerge);
            writer.WriteEnumValue<global::GitHub.Models.PullRequestWebhook_merge_commit_message>("merge_commit_message", MergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Models.PullRequestWebhook_merge_commit_title>("merge_commit_title", MergeCommitTitle);
            writer.WriteEnumValue<global::GitHub.Models.PullRequestWebhook_squash_merge_commit_message>("squash_merge_commit_message", SquashMergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Models.PullRequestWebhook_squash_merge_commit_title>("squash_merge_commit_title", SquashMergeCommitTitle);
            writer.WriteBoolValue("use_squash_pr_title_as_default", UseSquashPrTitleAsDefault);
        }
    }
}
#pragma warning restore CS0618
