using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient
    {
        public T GetResultFromFile<T>(string resultFilePath)
        {
            var json = File.ReadAllText(resultFilePath);

            return JsonConvert.DeserializeObject<T>(json);
        }


        private T GetResultFromWeb<T>(DateTime drawDate, string name, string prefix, string savePath = null)
        {
            if (drawDate == null)
            {
                throw new ArgumentNullException(nameof(drawDate));
            }

            var json = DownloadResultJson(drawDate, name, prefix);

            if (!string.IsNullOrWhiteSpace(savePath))
            {
                File.WriteAllText(savePath, json);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

       

        private static string DownloadResultJson(DateTime drawDate, string name, string prefix)
        {
            string json = string.Empty;

            using (var webClient = new WebClient())
            {
                json = webClient.DownloadString(
                    $"http://www.mpi.gov.tr/sonuclar/cekilisler/{name}/{prefix}{drawDate:yyyyMMdd}.json");
            }

            return json;
        }

        private decimal GetLotoPrize(LotoResult result, SixNumberGuess guess)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            if (guess == null)
            {
                throw new ArgumentNullException(nameof(guess));
            }


            var winningNumbers = Array.ConvertAll(result.Data.Rakamlar.Split('#'), int.Parse).OrderBy(a => a).ToList();

            int luckyNumberCount = 0;

            foreach (var number in guess.Numbers)
            {
                if (winningNumbers.Contains(number))
                {
                    luckyNumberCount++;
                }
            }

            if (luckyNumberCount < 3)
            {
                return 0m;
            }

            return result.Data.BilenKisiler.First(bk => bk.Tur == $"${luckyNumberCount}_BILEN").KisiBasinaDusenIkramiye;
        }
    }
}
