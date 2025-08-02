using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class HealthCheckResultObject : BunqModel
    {
        /// <summary>
        /// The result status of the health check.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// The entries on which the current status is based.
        /// </summary>
        [JsonProperty(PropertyName = "allEntry")]
        public List<HealthCheckResultEntryObject> AllEntry { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.AllEntry != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static HealthCheckResultObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<HealthCheckResultObject>(json);
        }
    }
}
