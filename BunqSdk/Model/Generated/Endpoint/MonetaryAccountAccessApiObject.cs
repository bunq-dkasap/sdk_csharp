using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// You can use MonetaryAccountAccess to retrieve all MonetaryAccountAccessModels for the given MonetaryAccount
    /// </summary>
    public class MonetaryAccountAccessApiObject : BunqModel
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_ACCESS_TYPE = "access_type";
    
    
        /// <summary>
        /// The access type of the monetary account access.
        /// </summary>
        [JsonProperty(PropertyName = "access_type")]
        public string AccessType { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.AccessType != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static MonetaryAccountAccessApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<MonetaryAccountAccessApiObject>(json);
        }
    }
}
