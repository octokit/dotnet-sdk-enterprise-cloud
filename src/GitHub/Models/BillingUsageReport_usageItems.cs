// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class BillingUsageReport_usageItems : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date of the usage line item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Date { get; set; }
#nullable restore
#else
        public string Date { get; set; }
#endif
        /// <summary>Discount amount of the usage line item.</summary>
        public double? DiscountAmount { get; set; }
        /// <summary>Gross amount of the usage line item.</summary>
        public double? GrossAmount { get; set; }
        /// <summary>Net amount of the usage line item.</summary>
        public double? NetAmount { get; set; }
        /// <summary>Name of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName { get; set; }
#nullable restore
#else
        public string OrganizationName { get; set; }
#endif
        /// <summary>Price per unit of the usage line item.</summary>
        public double? PricePerUnit { get; set; }
        /// <summary>Product name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Product { get; set; }
#nullable restore
#else
        public string Product { get; set; }
#endif
        /// <summary>Quantity of the usage line item.</summary>
        public int? Quantity { get; set; }
        /// <summary>Name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryName { get; set; }
#nullable restore
#else
        public string RepositoryName { get; set; }
#endif
        /// <summary>SKU name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sku { get; set; }
#nullable restore
#else
        public string Sku { get; set; }
#endif
        /// <summary>Unit type of the usage line item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitType { get; set; }
#nullable restore
#else
        public string UnitType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.BillingUsageReport_usageItems"/> and sets the default values.
        /// </summary>
        public BillingUsageReport_usageItems()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.BillingUsageReport_usageItems"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.BillingUsageReport_usageItems CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.BillingUsageReport_usageItems();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "date", n => { Date = n.GetStringValue(); } },
                { "discountAmount", n => { DiscountAmount = n.GetDoubleValue(); } },
                { "grossAmount", n => { GrossAmount = n.GetDoubleValue(); } },
                { "netAmount", n => { NetAmount = n.GetDoubleValue(); } },
                { "organizationName", n => { OrganizationName = n.GetStringValue(); } },
                { "pricePerUnit", n => { PricePerUnit = n.GetDoubleValue(); } },
                { "product", n => { Product = n.GetStringValue(); } },
                { "quantity", n => { Quantity = n.GetIntValue(); } },
                { "repositoryName", n => { RepositoryName = n.GetStringValue(); } },
                { "sku", n => { Sku = n.GetStringValue(); } },
                { "unitType", n => { UnitType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("date", Date);
            writer.WriteDoubleValue("discountAmount", DiscountAmount);
            writer.WriteDoubleValue("grossAmount", GrossAmount);
            writer.WriteDoubleValue("netAmount", NetAmount);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteDoubleValue("pricePerUnit", PricePerUnit);
            writer.WriteStringValue("product", Product);
            writer.WriteIntValue("quantity", Quantity);
            writer.WriteStringValue("repositoryName", RepositoryName);
            writer.WriteStringValue("sku", Sku);
            writer.WriteStringValue("unitType", UnitType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
