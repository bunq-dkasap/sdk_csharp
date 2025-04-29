using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Endpoint for interacting with the birdee investment portfolio balance..
    /// </summary>
    public class BirdeeInvestmentPortfolioBalanceApiObject : BunqModel
    {
        /// <summary>
        /// The current valuation of the portfolio, minus any amount pending withdrawal.
        /// </summary>
        [JsonProperty(PropertyName = "amount_available")]
        public AmountObject AmountAvailable { get; set; }
        /// <summary>
        /// The total amount deposited.
        /// </summary>
        [JsonProperty(PropertyName = "amount_deposit_total")]
        public AmountObject AmountDepositTotal { get; set; }
        /// <summary>
        /// The total amount withdrawn.
        /// </summary>
        [JsonProperty(PropertyName = "amount_withdrawal_total")]
        public AmountObject AmountWithdrawalTotal { get; set; }
        /// <summary>
        /// The total fee amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee_total")]
        public AmountObject AmountFeeTotal { get; set; }
        /// <summary>
        /// The difference between the netto deposited amount and the current valuation.
        /// </summary>
        [JsonProperty(PropertyName = "amount_profit")]
        public AmountObject AmountProfit { get; set; }
        /// <summary>
        /// The amount that's sent to Birdee, but pending investment on the portfolio.
        /// </summary>
        [JsonProperty(PropertyName = "amount_deposit_pending")]
        public AmountObject AmountDepositPending { get; set; }
        /// <summary>
        /// The amount that's sent to Birdee, but pending withdrawal.
        /// </summary>
        [JsonProperty(PropertyName = "amount_withdrawal_pending")]
        public AmountObject AmountWithdrawalPending { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.AmountAvailable != null)
            {
                return false;
            }
    
            if (this.AmountDepositTotal != null)
            {
                return false;
            }
    
            if (this.AmountWithdrawalTotal != null)
            {
                return false;
            }
    
            if (this.AmountFeeTotal != null)
            {
                return false;
            }
    
            if (this.AmountProfit != null)
            {
                return false;
            }
    
            if (this.AmountDepositPending != null)
            {
                return false;
            }
    
            if (this.AmountWithdrawalPending != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static BirdeeInvestmentPortfolioBalanceApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<BirdeeInvestmentPortfolioBalanceApiObject>(json);
        }
    }
}
