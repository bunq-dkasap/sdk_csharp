using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class AvatarObject : BunqModel
    {
        /// <summary>
        /// The public UUID of the avatar.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }
        /// <summary>
        /// The public UUID of object this avatar is anchored to.
        /// </summary>
        [JsonProperty(PropertyName = "anchor_uuid")]
        public string AnchorUuid { get; set; }
        /// <summary>
        /// The actual image information of this avatar.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public List<ImageObject> Image { get; set; }
        /// <summary>
        /// The style (if applicable) for this Avatar.
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public string Style { get; set; }
    
        public AvatarObject(string uuid)
        {
            Uuid = uuid;
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Uuid != null)
            {
                return false;
            }
    
            if (this.AnchorUuid != null)
            {
                return false;
            }
    
            if (this.Image != null)
            {
                return false;
            }
    
            if (this.Style != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static AvatarObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<AvatarObject>(json);
        }
    }
}
