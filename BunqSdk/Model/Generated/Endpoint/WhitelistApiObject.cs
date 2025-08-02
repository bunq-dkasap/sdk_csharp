using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Whitelist a Request so that when one comes in, it is automatically accepted.
    /// </summary>
    public class WhitelistApiObject : BunqModel
    {
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static WhitelistApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<WhitelistApiObject>(json);
        }
    }
}
