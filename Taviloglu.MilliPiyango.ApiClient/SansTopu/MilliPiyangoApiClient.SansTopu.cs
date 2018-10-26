using System;
using System.Linq;
using Taviloglu.MilliPiyango.ApiClient.SansTopu;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient : ISansTopuClient
    {
        public ISansTopuClient SansTopu { get { return (ISansTopuClient)this; } }

        decimal ISansTopuClient.GetPrize(LotoResult result, SansTopuGuess guess)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            if (guess == null)
            {
                throw new ArgumentNullException(nameof(guess));
            }


            var numbers = Array.ConvertAll(result.Data.Rakamlar.Split('#'), int.Parse).ToList();

            var winningNumbers = numbers.GetRange(0, 5);
            var plusOne = numbers[5];

            int luckyNumberCount = 0;

            foreach (var number in guess.Numbers)
            {
                if (winningNumbers.Contains(number))
                {
                    luckyNumberCount++;
                }
            }

            bool gotPlusOne = guess.PlusOne == plusOne;

            if (gotPlusOne)
            {
                return result.Data.BilenKisiler.First(bk => bk.Tur == $"${luckyNumberCount}_1_BILEN").KisiBasinaDusenIkramiye;
            }
            else
            {
                if (luckyNumberCount < 3)
                {
                    return 0m;
                }

                return result.Data.BilenKisiler.First(bk => bk.Tur == $"${luckyNumberCount}_BILEN").KisiBasinaDusenIkramiye;
            }
        }

        LotoResult ISansTopuClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResultFromWeb<LotoResult>(drawDate, "sanstopu", "", savePath);
        }
    }
}
