using Newtonsoft.Json;
using System.Collections.Generic;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public class LotoResultData
    {
        public string oid { get; set; }
        [JsonProperty("hafta")]
        public int hafta { get; set; }
        [JsonProperty("buyukIkramiyeKazananIl")]
        public string BuyukIkramiyeKazananIl { get; set; }
        [JsonProperty("cekilisTarihi")]
        public string CekilisTarihi { get; set; }
        [JsonProperty("cekilisTuru")]
        public string CekilisTuru { get; set; }
        [JsonProperty("rakamlar")]
        public string Rakamlar { get; set; }
        [JsonProperty("rakamlarNumaraSirasi")]
        public string RakamlarNumaraSirasi { get; set; }
        [JsonProperty("devretti")]
        public bool Devretti { get; set; }
        [JsonProperty("devirSayisi")]
        public int DevirSayisi { get; set; }
        [JsonProperty("BilenKisiler")]
        public List<BilenKisiler> BilenKisiler { get; set; }
        [JsonProperty("buyukIkrKazananIlIlceler")]
        public List<BuyukIkramiyeKazananIlIlceler> BuyukIkramiyeKazananIlIlceler { get; set; }
        [JsonProperty("kibrisHasilati")]
        public string KibrisHasilati { get; set; }
        [JsonProperty("devirTutari")]
        public decimal DevirTutari { get; set; }
        [JsonProperty("kolonSayisi")]
        public int kolonSayisi { get; set; }
        [JsonProperty("kdv")]
        public decimal KDV { get; set; }
        [JsonProperty("toplamHasilat")]
        public decimal ToplamHasilat { get; set; }
        [JsonProperty("hasilat")]
        public decimal Hasilat { get; set; }
        [JsonProperty("sov")]
        public decimal SOV { get; set; }
        [JsonProperty("ikramiyeEH")]
        public decimal IkramiyeEH { get; set; }
        [JsonProperty("buyukIkramiye")]
        public decimal BuyukIkramiye { get; set; }
        [JsonProperty("haftayaDevredenTutar")]
        public decimal HaftayaDevredenTutar { get; set; }
    }
}
