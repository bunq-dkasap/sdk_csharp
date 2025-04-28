using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class CertificateObject : BunqModel
    {
        /// <summary>
        /// A single certificate in the chain in .PEM format.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string CertificateString { get; set; }
    
        public CertificateObject(string certificateString)
        {
            CertificateString = certificateString;
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.CertificateString != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static CertificateObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<CertificateObject>(json);
        }
    }
}
