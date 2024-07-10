// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Pull Request Review Comments are comments on a portion of the Pull Request&apos;s diff.
    /// </summary>
    public class PullRequestReviewComment : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The text of the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>The SHA of the commit to which the comment applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The diff of the line that the comment refers to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiffHunk { get; set; }
#nullable restore
#else
        public string DiffHunk { get; set; }
#endif
        /// <summary>HTML URL for the pull request review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The ID of the pull request review comment.</summary>
        public long? Id { get; set; }
        /// <summary>The comment ID to reply to.</summary>
        public int? InReplyToId { get; set; }
        /// <summary>The line of the blob to which the comment applies. The last line of the range for a multi-line comment</summary>
        public int? Line { get; set; }
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequestReviewComment__links? Links { get; set; }
#nullable restore
#else
        public PullRequestReviewComment__links Links { get; set; }
#endif
        /// <summary>The node ID of the pull request review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The SHA of the original commit to which the comment applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalCommitId { get; set; }
#nullable restore
#else
        public string OriginalCommitId { get; set; }
#endif
        /// <summary>The line of the blob to which the comment applies. The last line of the range for a multi-line comment</summary>
        public int? OriginalLine { get; set; }
        /// <summary>The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.</summary>
        public int? OriginalPosition { get; set; }
        /// <summary>The first line of the range for a multi-line comment.</summary>
        public int? OriginalStartLine { get; set; }
        /// <summary>The relative path of the file to which the comment applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.</summary>
        public int? Position { get; set; }
        /// <summary>The ID of the pull request review to which the comment belongs.</summary>
        public long? PullRequestReviewId { get; set; }
        /// <summary>URL for the pull request that the review comment belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullRequestUrl { get; set; }
#nullable restore
#else
        public string PullRequestUrl { get; set; }
#endif
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public ReactionRollup Reactions { get; set; }
#endif
        /// <summary>The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment</summary>
        public PullRequestReviewComment_side? Side { get; set; }
        /// <summary>The first line of the range for a multi-line comment.</summary>
        public int? StartLine { get; set; }
        /// <summary>The side of the first line of the range for a multi-line comment.</summary>
        public PullRequestReviewComment_start_side? StartSide { get; set; }
        /// <summary>The level at which the comment is targeted, can be a diff line or a file.</summary>
        public PullRequestReviewComment_subject_type? SubjectType { get; set; }
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>URL for the pull request review comment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? User { get; set; }
#nullable restore
#else
        public SimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PullRequestReviewComment"/> and sets the default values.
        /// </summary>
        public PullRequestReviewComment()
        {
            AdditionalData = new Dictionary<string, object>();
            Side = PullRequestReviewComment_side.RIGHT;
            StartSide = PullRequestReviewComment_start_side.RIGHT;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PullRequestReviewComment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequestReviewComment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequestReviewComment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"body_html", n => { BodyHtml = n.GetStringValue(); } },
                {"body_text", n => { BodyText = n.GetStringValue(); } },
                {"commit_id", n => { CommitId = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"diff_hunk", n => { DiffHunk = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"in_reply_to_id", n => { InReplyToId = n.GetIntValue(); } },
                {"line", n => { Line = n.GetIntValue(); } },
                {"_links", n => { Links = n.GetObjectValue<PullRequestReviewComment__links>(PullRequestReviewComment__links.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"original_commit_id", n => { OriginalCommitId = n.GetStringValue(); } },
                {"original_line", n => { OriginalLine = n.GetIntValue(); } },
                {"original_position", n => { OriginalPosition = n.GetIntValue(); } },
                {"original_start_line", n => { OriginalStartLine = n.GetIntValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"position", n => { Position = n.GetIntValue(); } },
                {"pull_request_review_id", n => { PullRequestReviewId = n.GetLongValue(); } },
                {"pull_request_url", n => { PullRequestUrl = n.GetStringValue(); } },
                {"reactions", n => { Reactions = n.GetObjectValue<ReactionRollup>(ReactionRollup.CreateFromDiscriminatorValue); } },
                {"side", n => { Side = n.GetEnumValue<PullRequestReviewComment_side>(); } },
                {"start_line", n => { StartLine = n.GetIntValue(); } },
                {"start_side", n => { StartSide = n.GetEnumValue<PullRequestReviewComment_start_side>(); } },
                {"subject_type", n => { SubjectType = n.GetEnumValue<PullRequestReviewComment_subject_type>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("diff_hunk", DiffHunk);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteIntValue("in_reply_to_id", InReplyToId);
            writer.WriteIntValue("line", Line);
            writer.WriteObjectValue<PullRequestReviewComment__links>("_links", Links);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("original_commit_id", OriginalCommitId);
            writer.WriteIntValue("original_line", OriginalLine);
            writer.WriteIntValue("original_position", OriginalPosition);
            writer.WriteIntValue("original_start_line", OriginalStartLine);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("position", Position);
            writer.WriteLongValue("pull_request_review_id", PullRequestReviewId);
            writer.WriteStringValue("pull_request_url", PullRequestUrl);
            writer.WriteObjectValue<ReactionRollup>("reactions", Reactions);
            writer.WriteEnumValue<PullRequestReviewComment_side>("side", Side);
            writer.WriteIntValue("start_line", StartLine);
            writer.WriteEnumValue<PullRequestReviewComment_start_side>("start_side", StartSide);
            writer.WriteEnumValue<PullRequestReviewComment_subject_type>("subject_type", SubjectType);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<SimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}