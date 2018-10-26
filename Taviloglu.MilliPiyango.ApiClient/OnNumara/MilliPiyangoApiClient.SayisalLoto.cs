using System;
using System.Linq;
using Taviloglu.MilliPiyango.ApiClient.OnNumara;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient : IOnNumaraClient
    {
        public IOnNumaraClient OnNumara { get { return (IOnNumaraClient)this; } }

        decimal IOnNumaraClient.GetPrize(LotoResult result, OnNumaraGuess guess)
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

            if (luckyNumberCount < 6 && luckyNumberCount > 0)
            {
                return 0m;
            }

            if (luckyNumberCount == 0)
            {
                return result.Data.BilenKisiler.First(bk => bk.Tur == "$HIC").KisiBasinaDusenIkramiye;
            }

            return result.Data.BilenKisiler.First(bk => bk.Tur == $"${luckyNumberCount}_BILEN").KisiBasinaDusenIkramiye;
        }

        LotoResult IOnNumaraClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResultFromWeb<LotoResult>(drawDate, "onnumara", "", savePath);
        }
    }
}
