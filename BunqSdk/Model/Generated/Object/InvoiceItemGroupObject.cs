using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class InvoiceItemGroupObject : BunqModel
    {
        /// <summary>
        /// The type of the invoice item group.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        /// <summary>
        /// The description of the type of the invoice item group.
        /// </summary>
        [JsonProperty(PropertyName = "type_description")]
        public string TypeDescription { get; set; }
        /// <summary>
        /// The translated description of the type of the invoice item group.
        /// </summary>
        [JsonProperty(PropertyName = "type_description_translated")]
        public string TypeDescriptionTranslated { get; set; }
        /// <summary>
        /// The identifier of the invoice item group.
        /// </summary>
        [JsonProperty(PropertyName = "instance_description")]
        public string InstanceDescription { get; set; }
        /// <summary>
        /// The unit item price excluding VAT.
        /// </summary>
        [JsonProperty(PropertyName = "product_vat_exclusive")]
        public AmountObject ProductVatExclusive { get; set; }
        /// <summary>
        /// The unit item price including VAT.
        /// </summary>
        [JsonProperty(PropertyName = "product_vat_inclusive")]
        public AmountObject ProductVatInclusive { get; set; }
        /// <summary>
        /// The invoice items in the group.
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        public List<InvoiceItemObject> Item { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Type != null)
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
    
            if (this.InstanceDescription != null)
            {
                return false;
            }
    
            if (this.ProductVatExclusive != null)
            {
                return false;
            }
    
            if (this.ProductVatInclusive != null)
            {
                return false;
            }
    
            if (this.Item != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static InvoiceItemGroupObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<InvoiceItemGroupObject>(json);
        }
    }
}
