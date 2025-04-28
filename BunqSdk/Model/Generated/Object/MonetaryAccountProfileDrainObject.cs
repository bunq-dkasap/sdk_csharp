using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class MonetaryAccountProfileDrainObject : BunqModel
    {
        /// <summary>
        /// The status of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// The goal balance.
        /// </summary>
        [JsonProperty(PropertyName = "balance_preferred")]
        public AmountObject BalancePreferred { get; set; }
        /// <summary>
        /// The high threshold balance.
        /// </summary>
        [JsonProperty(PropertyName = "balance_threshold_high")]
        public AmountObject BalanceThresholdHigh { get; set; }
        /// <summary>
        /// The savings monetary account.
        /// </summary>
        [JsonProperty(PropertyName = "savings_account_alias")]
        public MonetaryAccountReference SavingsAccountAlias { get; set; }
    
        public MonetaryAccountProfileDrainObject(string status, AmountObject balancePreferred, AmountObject balanceThresholdHigh, MonetaryAccountReference savingsAccountAlias)
        {
            Status = status;
            BalancePreferred = balancePreferred;
            BalanceThresholdHigh = balanceThresholdHigh;
            SavingsAccountAlias = savingsAccountAlias;
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.BalancePreferred != null)
            {
                return false;
            }
    
            if (this.BalanceThresholdHigh != null)
            {
                return false;
            }
    
            if (this.SavingsAccountAlias != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static MonetaryAccountProfileDrainObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<MonetaryAccountProfileDrainObject>(json);
        }
    }
}
