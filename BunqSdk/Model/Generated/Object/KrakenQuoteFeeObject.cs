using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class KrakenQuoteFeeObject : BunqModel
    {
        /// <summary>
        /// Discount type for the fee.
        /// </summary>
        [JsonProperty(PropertyName = "fee_discount_type")]
        public string FeeDiscountType { get; set; }
        /// <summary>
        /// Promotion amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee")]
        public AmountObject AmountFee { get; set; }
        /// <summary>
        /// Amount of total fee paid in Kraken quote.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee_applied")]
        public AmountObject AmountFeeApplied { get; set; }
        /// <summary>
        /// Amount of fee visible to user in quote.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee_user")]
        public AmountObject AmountFeeUser { get; set; }
        /// <summary>
        /// Promotion amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee_default")]
        public AmountObject AmountFeeDefault { get; set; }
        /// <summary>
        /// Amount of fee margin applied for user..
        /// </summary>
        [JsonProperty(PropertyName = "fee_margin_user")]
        public string FeeMarginUser { get; set; }
        /// <summary>
        /// Title for this promotion.
        /// </summary>
        [JsonProperty(PropertyName = "fee_margin_applied")]
        public string FeeMarginApplied { get; set; }
        /// <summary>
        /// Eligible transaction type for this promotion.
        /// </summary>
        [JsonProperty(PropertyName = "fee_margin_default")]
        public string FeeMarginDefault { get; set; }
        /// <summary>
        /// Promotion amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_saved")]
        public AmountObject AmountSaved { get; set; }
        /// <summary>
        /// Promotion amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_saved_potential")]
        public AmountObject AmountSavedPotential { get; set; }
        /// <summary>
        /// The money amount previously included in spread, now moved to fee. This portion of fee is shown as Rate
        /// Guarantee.
        /// </summary>
        [JsonProperty(PropertyName = "amount_rate_guarantee")]
        public AmountObject AmountRateGuarantee { get; set; }
        /// <summary>
        /// The link for rate guarantee description.
        /// </summary>
        [JsonProperty(PropertyName = "url_rate_guarantee")]
        public string UrlRateGuarantee { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.FeeDiscountType != null)
            {
                return false;
            }
    
            if (this.AmountFee != null)
            {
                return false;
            }
    
            if (this.AmountFeeApplied != null)
            {
                return false;
            }
    
            if (this.AmountFeeUser != null)
            {
                return false;
            }
    
            if (this.AmountFeeDefault != null)
            {
                return false;
            }
    
            if (this.FeeMarginUser != null)
            {
                return false;
            }
    
            if (this.FeeMarginApplied != null)
            {
                return false;
            }
    
            if (this.FeeMarginDefault != null)
            {
                return false;
            }
    
            if (this.AmountSaved != null)
            {
                return false;
            }
    
            if (this.AmountSavedPotential != null)
            {
                return false;
            }
    
            if (this.AmountRateGuarantee != null)
            {
                return false;
            }
    
            if (this.UrlRateGuarantee != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static KrakenQuoteFeeObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<KrakenQuoteFeeObject>(json);
        }
    }
}
