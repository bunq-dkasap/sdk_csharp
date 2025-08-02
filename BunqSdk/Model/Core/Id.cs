using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Core
{
    public class Id
    {
        [JsonProperty(PropertyName = "id")] public long IdLong { get; private set; }

        public Id(long idLong)
        {
            IdLong = idLong;
        }
    }
}