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
    public partial class RunnerGroupsOrg : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allows_public_repositories property</summary>
        public bool? AllowsPublicRepositories { get; set; }
        /// <summary>The default property</summary>
        public bool? Default { get; set; }
        /// <summary>The hosted_runners_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostedRunnersUrl { get; set; }
#nullable restore
#else
        public string HostedRunnersUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public double? Id { get; set; }
        /// <summary>The inherited property</summary>
        public bool? Inherited { get; set; }
        /// <summary>The inherited_allows_public_repositories property</summary>
        public bool? InheritedAllowsPublicRepositories { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.</summary>
        public bool? RestrictedToWorkflows { get; set; }
        /// <summary>The runners_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunnersUrl { get; set; }
#nullable restore
#else
        public string RunnersUrl { get; set; }
#endif
        /// <summary>Link to the selected repositories resource for this runner group. Not present unless visibility was set to `selected`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectedRepositoriesUrl { get; set; }
#nullable restore
#else
        public string SelectedRepositoriesUrl { get; set; }
#endif
        /// <summary>List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SelectedWorkflows { get; set; }
#nullable restore
#else
        public List<string> SelectedWorkflows { get; set; }
#endif
        /// <summary>The visibility property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.</summary>
        public bool? WorkflowRestrictionsReadOnly { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RunnerGroupsOrg"/> and sets the default values.
        /// </summary>
        public RunnerGroupsOrg()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RunnerGroupsOrg"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RunnerGroupsOrg CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RunnerGroupsOrg();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allows_public_repositories", n => { AllowsPublicRepositories = n.GetBoolValue(); } },
                { "default", n => { Default = n.GetBoolValue(); } },
                { "hosted_runners_url", n => { HostedRunnersUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetDoubleValue(); } },
                { "inherited", n => { Inherited = n.GetBoolValue(); } },
                { "inherited_allows_public_repositories", n => { InheritedAllowsPublicRepositories = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "restricted_to_workflows", n => { RestrictedToWorkflows = n.GetBoolValue(); } },
                { "runners_url", n => { RunnersUrl = n.GetStringValue(); } },
                { "selected_repositories_url", n => { SelectedRepositoriesUrl = n.GetStringValue(); } },
                { "selected_workflows", n => { SelectedWorkflows = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "visibility", n => { Visibility = n.GetStringValue(); } },
                { "workflow_restrictions_read_only", n => { WorkflowRestrictionsReadOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allows_public_repositories", AllowsPublicRepositories);
            writer.WriteBoolValue("default", Default);
            writer.WriteStringValue("hosted_runners_url", HostedRunnersUrl);
            writer.WriteDoubleValue("id", Id);
            writer.WriteBoolValue("inherited", Inherited);
            writer.WriteBoolValue("inherited_allows_public_repositories", InheritedAllowsPublicRepositories);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("restricted_to_workflows", RestrictedToWorkflows);
            writer.WriteStringValue("runners_url", RunnersUrl);
            writer.WriteStringValue("selected_repositories_url", SelectedRepositoriesUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("selected_workflows", SelectedWorkflows);
            writer.WriteStringValue("visibility", Visibility);
            writer.WriteBoolValue("workflow_restrictions_read_only", WorkflowRestrictionsReadOnly);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
