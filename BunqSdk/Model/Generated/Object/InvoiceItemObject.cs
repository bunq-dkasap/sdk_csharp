using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class InvoiceItemObject : BunqModel
    {
        /// <summary>
        /// The id of the invoice item.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }
        /// <summary>
        /// The billing date of the item.
        /// </summary>
        [JsonProperty(PropertyName = "billing_date")]
        public string BillingDate { get; set; }
        /// <summary>
        /// The price description.
        /// </summary>
        [JsonProperty(PropertyName = "type_description")]
        public string TypeDescription { get; set; }
        /// <summary>
        /// The translated price description.
        /// </summary>
        [JsonProperty(PropertyName = "type_description_translated")]
        public string TypeDescriptionTranslated { get; set; }
        /// <summary>
        /// The unit item price excluding VAT.
        /// </summary>
        [JsonProperty(PropertyName = "unit_vat_exclusive")]
        public AmountObject UnitVatExclusive { get; set; }
        /// <summary>
        /// The unit item price including VAT.
        /// </summary>
        [JsonProperty(PropertyName = "unit_vat_inclusive")]
        public AmountObject UnitVatInclusive { get; set; }
        /// <summary>
        /// The VAT tax fraction.
        /// </summary>
        [JsonProperty(PropertyName = "vat")]
        public double? Vat { get; set; }
        /// <summary>
        /// The number of items priced.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public double? Quantity { get; set; }
        /// <summary>
        /// The item price excluding VAT.
        /// </summary>
        [JsonProperty(PropertyName = "total_vat_exclusive")]
        public AmountObject TotalVatExclusive { get; set; }
        /// <summary>
        /// The item price including VAT.
        /// </summary>
        [JsonProperty(PropertyName = "total_vat_inclusive")]
        public AmountObject TotalVatInclusive { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Id != null)
            {
                return false;
            }
    
            if (this.BillingDate != null)
            {
                return false;
            }
    
            if (this.TypeDescription != null)
            {
                return false;
            }
    
            if (this.TypeDescriptionTranslated != null)
            {
                return false;
            }
    
            if (this.UnitVatExclusive != null)
            {
                return false;
            }
    
            if (this.UnitVatInclusive != null)
            {
                return false;
            }
    
            if (this.Vat != null)
            {
                return false;
            }
    
            if (this.Quantity != null)
            {
                return false;
            }
    
            if (this.TotalVatExclusive != null)
            {
                return false;
            }
    
            if (this.TotalVatInclusive != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static InvoiceItemObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<InvoiceItemObject>(json);
        }
    }
}
