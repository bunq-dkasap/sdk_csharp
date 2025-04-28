using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class NotificationUrlObject : BunqModel
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_url")]
        public string TargetUrl { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public string EventType { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public NotificationAnchorObjectObject Object { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.TargetUrl != null)
            {
                return false;
            }
    
            if (this.Category != null)
            {
                return false;
            }
    
            if (this.EventType != null)
            {
                return false;
            }
    
            if (this.Object != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static NotificationUrlObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<NotificationUrlObject>(json);
        }
    }
}
