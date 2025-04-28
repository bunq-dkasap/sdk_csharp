using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class PointerObject : BunqModel
    {
        /// <summary>
        /// The alias type, can be: EMAIL|PHONE_NUMBER|IBAN.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        /// <summary>
        /// The alias value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        /// <summary>
        /// The alias name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// The pointer service. Only required for external counterparties.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }
    
        public PointerObject(string type, string value)
        {
            Type = type;
            Value = value;
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Type != null)
            {
                return false;
            }
    
            if (this.Value != null)
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
        public static PointerObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<PointerObject>(json);
        }
    }
}
