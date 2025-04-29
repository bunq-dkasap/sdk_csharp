using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class BirdeeInvestmentPortfolioGoalObject : BunqModel
    {
        /// <summary>
        /// The investment goal amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_target")]
        public AmountObject AmountTarget { get; set; }
        /// <summary>
        /// The investment goal end time.
        /// </summary>
        [JsonProperty(PropertyName = "time_end")]
        public string TimeEnd { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.AmountTarget != null)
            {
                return false;
            }
    
            if (this.TimeEnd != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static BirdeeInvestmentPortfolioGoalObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<BirdeeInvestmentPortfolioGoalObject>(json);
        }
    }
}
