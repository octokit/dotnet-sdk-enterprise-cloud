// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Repos
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ReposPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.</summary>
        public bool? AllowAutoMerge { get; set; }
        /// <summary>Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.</summary>
        public bool? AllowMergeCommit { get; set; }
        /// <summary>Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.</summary>
        public bool? AllowRebaseMerge { get; set; }
        /// <summary>Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.</summary>
        public bool? AllowSquashMerge { get; set; }
        /// <summary>Pass `true` to create an initial commit with empty README.</summary>
        public bool? AutoInit { get; set; }
        /// <summary>The custom properties for the new repository. The keys are the custom property names, and the values are the corresponding custom property values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_custom_properties? CustomProperties { get; set; }
#nullable restore
#else
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_custom_properties CustomProperties { get; set; }
#endif
        /// <summary>Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion. **The authenticated user must be an organization owner to set this property to `true`.**</summary>
        public bool? DeleteBranchOnMerge { get; set; }
        /// <summary>A short description of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, &quot;Haskell&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitignoreTemplate { get; set; }
#nullable restore
#else
        public string GitignoreTemplate { get; set; }
#endif
        /// <summary>Whether downloads are enabled.</summary>
        public bool? HasDownloads { get; set; }
        /// <summary>Either `true` to enable issues for this repository or `false` to disable them.</summary>
        public bool? HasIssues { get; set; }
        /// <summary>Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you&apos;re creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.</summary>
        public bool? HasProjects { get; set; }
        /// <summary>Either `true` to enable the wiki for this repository or `false` to disable it.</summary>
        public bool? HasWiki { get; set; }
        /// <summary>A URL with more information about the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Homepage { get; set; }
#nullable restore
#else
        public string Homepage { get; set; }
#endif
        /// <summary>Either `true` to make this repo available as a template repository or `false` to prevent it.</summary>
        public bool? IsTemplate { get; set; }
        /// <summary>Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/enterprise-cloud@latest//articles/licensing-a-repository/#searching-github-by-license-type) as the `license_template` string. For example, &quot;mit&quot; or &quot;mpl-2.0&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseTemplate { get; set; }
#nullable restore
#else
        public string LicenseTemplate { get; set; }
#endif
        /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_message? MergeCommitMessage { get; set; }
        /// <summary>Required when using `merge_commit_message`.The default value for a merge commit title.- `PR_TITLE` - default to the pull request&apos;s title.- `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).</summary>
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_title? MergeCommitTitle { get; set; }
        /// <summary>The name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Whether the repository is private.</summary>
        public bool? Private { get; set; }
        /// <summary>The default value for a squash merge commit message:- `PR_BODY` - default to the pull request&apos;s body.- `COMMIT_MESSAGES` - default to the branch&apos;s commit messages.- `BLANK` - default to a blank commit message.</summary>
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_message? SquashMergeCommitMessage { get; set; }
        /// <summary>Required when using `squash_merge_commit_message`.The default value for a squash merge commit title:- `PR_TITLE` - default to the pull request&apos;s title.- `COMMIT_OR_PR_TITLE` - default to the commit&apos;s title (if only one commit) or the pull request&apos;s title (when more than one commit).</summary>
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_title? SquashMergeCommitTitle { get; set; }
        /// <summary>The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.</summary>
        public int? TeamId { get; set; }
        /// <summary>Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message. **This property has been deprecated. Please use `squash_merge_commit_title` instead.</summary>
        [Obsolete("")]
        public bool? UseSquashPrTitleAsDefault { get; set; }
        /// <summary>The visibility of the repository.</summary>
        public global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Repos.ReposPostRequestBody"/> and sets the default values.
        /// </summary>
        public ReposPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Repos.ReposPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Repos.ReposPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Repos.ReposPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_auto_merge", n => { AllowAutoMerge = n.GetBoolValue(); } },
                { "allow_merge_commit", n => { AllowMergeCommit = n.GetBoolValue(); } },
                { "allow_rebase_merge", n => { AllowRebaseMerge = n.GetBoolValue(); } },
                { "allow_squash_merge", n => { AllowSquashMerge = n.GetBoolValue(); } },
                { "auto_init", n => { AutoInit = n.GetBoolValue(); } },
                { "custom_properties", n => { CustomProperties = n.GetObjectValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_custom_properties>(global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_custom_properties.CreateFromDiscriminatorValue); } },
                { "delete_branch_on_merge", n => { DeleteBranchOnMerge = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "gitignore_template", n => { GitignoreTemplate = n.GetStringValue(); } },
                { "has_downloads", n => { HasDownloads = n.GetBoolValue(); } },
                { "has_issues", n => { HasIssues = n.GetBoolValue(); } },
                { "has_projects", n => { HasProjects = n.GetBoolValue(); } },
                { "has_wiki", n => { HasWiki = n.GetBoolValue(); } },
                { "homepage", n => { Homepage = n.GetStringValue(); } },
                { "is_template", n => { IsTemplate = n.GetBoolValue(); } },
                { "license_template", n => { LicenseTemplate = n.GetStringValue(); } },
                { "merge_commit_message", n => { MergeCommitMessage = n.GetEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_message>(); } },
                { "merge_commit_title", n => { MergeCommitTitle = n.GetEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_title>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private", n => { Private = n.GetBoolValue(); } },
                { "squash_merge_commit_message", n => { SquashMergeCommitMessage = n.GetEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_message>(); } },
                { "squash_merge_commit_title", n => { SquashMergeCommitTitle = n.GetEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_title>(); } },
                { "team_id", n => { TeamId = n.GetIntValue(); } },
                { "use_squash_pr_title_as_default", n => { UseSquashPrTitleAsDefault = n.GetBoolValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_auto_merge", AllowAutoMerge);
            writer.WriteBoolValue("allow_merge_commit", AllowMergeCommit);
            writer.WriteBoolValue("allow_rebase_merge", AllowRebaseMerge);
            writer.WriteBoolValue("allow_squash_merge", AllowSquashMerge);
            writer.WriteBoolValue("auto_init", AutoInit);
            writer.WriteObjectValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_custom_properties>("custom_properties", CustomProperties);
            writer.WriteBoolValue("delete_branch_on_merge", DeleteBranchOnMerge);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("gitignore_template", GitignoreTemplate);
            writer.WriteBoolValue("has_downloads", HasDownloads);
            writer.WriteBoolValue("has_issues", HasIssues);
            writer.WriteBoolValue("has_projects", HasProjects);
            writer.WriteBoolValue("has_wiki", HasWiki);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteBoolValue("is_template", IsTemplate);
            writer.WriteStringValue("license_template", LicenseTemplate);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_message>("merge_commit_message", MergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_merge_commit_title>("merge_commit_title", MergeCommitTitle);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("private", Private);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_message>("squash_merge_commit_message", SquashMergeCommitMessage);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_squash_merge_commit_title>("squash_merge_commit_title", SquashMergeCommitTitle);
            writer.WriteIntValue("team_id", TeamId);
            writer.WriteBoolValue("use_squash_pr_title_as_default", UseSquashPrTitleAsDefault);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Repos.ReposPostRequestBody_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
