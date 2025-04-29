using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class TransferwiseRequirementFieldGroupValuesAllowedObject : BunqModel
    {
        /// <summary>
        /// The key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        /// <summary>
        /// The label.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Key != null)
            {
                return false;
            }
    
            if (this.Name != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static TransferwiseRequirementFieldGroupValuesAllowedObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<TransferwiseRequirementFieldGroupValuesAllowedObject>(json);
        }
    }
}
