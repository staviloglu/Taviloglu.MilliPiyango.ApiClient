using Newtonsoft.Json;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public class BuyukIkramiyeKazananIlIlceler
    {
        [JsonProperty("il")]
        public string Il { get; set; }
        [JsonProperty("ilView")]
        public string IlView { get; set; }
        [JsonProperty("ilce")]
        public string Ilce { get; set; }
        [JsonProperty("ilceView")]
        public string IlceView { get; set; }
    }
}
