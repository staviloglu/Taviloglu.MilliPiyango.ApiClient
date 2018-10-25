using Newtonsoft.Json;
using System.Collections.Generic;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public class PiyangoResult
    {
        [JsonProperty("cekilisAdi")]
        public string CekilisAdi { get; set; }
        [JsonProperty("cekilisTarihi")]
        public string CekilisTarihi { get; set; }
        [JsonProperty("haneSayisi")]
        public int HaneSayisi { get; set; }
        [JsonProperty("sonuclar")]
        public List<Sonuclar> Sonuclar { get; set; }
        [JsonProperty("buyukIkrKazananIlIlceler")]
        public List<BuyukIkramiyeKazananIlIlceler> BuyukIkrKazananIlIlceler { get; set; }
    }

    public class Sonuclar
    {
        [JsonProperty("haneSayisi")]
        public int HaneSayisi { get; set; }
        [JsonProperty("tip")]
        public string Tip { get; set; }
        [JsonProperty("ikramiye")]
        public decimal Ikramiye { get; set; }
        [JsonProperty("numaralar")]
        public List<string> Numaralar { get; set; }
    }
}
