using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// The receipt the company employee has provided for a transaction.
    /// </summary>
    public class CompanyEmployeeCardReceiptApiObject : BunqModel
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_STATUS = "status";
    
    
        /// <summary>
        /// The status of the receipt.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Status != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static CompanyEmployeeCardReceiptApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<CompanyEmployeeCardReceiptApiObject>(json);
        }
    }
}
