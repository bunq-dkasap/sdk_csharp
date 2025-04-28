using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Cashback payout item details.
    /// </summary>
    public class CashbackPayoutItemApiObject : BunqModel
    {
        /// <summary>
        /// The status of the cashback payout item.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// The amount of cashback earned.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public AmountObject Amount { get; set; }
        /// <summary>
        /// The cashback rate.
        /// </summary>
        [JsonProperty(PropertyName = "rate_applied")]
        public string RateApplied { get; set; }
        /// <summary>
        /// The transaction category that this cashback is for.
        /// </summary>
        [JsonProperty(PropertyName = "transaction_category")]
        public AdditionalTransactionInformationCategoryApiObject TransactionCategory { get; set; }
        /// <summary>
        /// The partner promotion that this cashback is for.
        /// </summary>
        [JsonProperty(PropertyName = "user_partner_promotion")]
        public UserPartnerPromotionCashbackApiObject UserPartnerPromotion { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.Amount != null)
            {
                return false;
            }
    
            if (this.RateApplied != null)
            {
                return false;
            }
    
            if (this.TransactionCategory != null)
            {
                return false;
            }
    
            if (this.UserPartnerPromotion != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static CashbackPayoutItemApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<CashbackPayoutItemApiObject>(json);
        }
    }
}
