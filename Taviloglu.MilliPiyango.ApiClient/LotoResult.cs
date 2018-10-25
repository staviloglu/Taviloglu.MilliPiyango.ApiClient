using Newtonsoft.Json;
using System;
using System.Text;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public class LotoResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("data")]
        public LotoResultData Data { get; set; }
    }

    public class BilenKisiler
    {
        public string oid { get; set; }
        [JsonProperty("kisiBasinaDusenIkramiye")]
        public decimal KisiBasinaDusenIkramiye { get; set; }
        [JsonProperty("kisiSayisi")]
        public int KisiSayisi { get; set; }
        [JsonProperty("tur")]
        public string Tur { get; set; }
    }
}
