// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Enterprises.Item.AuditLog.Streams.Item
{
    /// <summary>The audit log streaming provider. The name is case sensitive.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum WithStream_PutRequestBody_stream_type
    {
        [EnumMember(Value = "Azure Blob Storage")]
        #pragma warning disable CS1591
        AzureBlobStorage,
        #pragma warning restore CS1591
        [EnumMember(Value = "Azure Event Hubs")]
        #pragma warning disable CS1591
        AzureEventHubs,
        #pragma warning restore CS1591
        [EnumMember(Value = "Amazon S3")]
        #pragma warning disable CS1591
        AmazonS3,
        #pragma warning restore CS1591
        [EnumMember(Value = "Splunk")]
        #pragma warning disable CS1591
        Splunk,
        #pragma warning restore CS1591
        [EnumMember(Value = "HTTPS Event Collector")]
        #pragma warning disable CS1591
        HTTPSEventCollector,
        #pragma warning restore CS1591
        [EnumMember(Value = "Google Cloud Storage")]
        #pragma warning disable CS1591
        GoogleCloudStorage,
        #pragma warning restore CS1591
        [EnumMember(Value = "Datadog")]
        #pragma warning disable CS1591
        Datadog,
        #pragma warning restore CS1591
    }
}
