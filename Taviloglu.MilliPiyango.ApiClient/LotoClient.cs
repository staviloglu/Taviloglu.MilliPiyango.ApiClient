using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public abstract class LotoClient : Client<LotoResult>
    {
        /// <summary>
        /// initializes a new instance of the class SayisalLotoClient
        /// </summary>
        /// <param name="resultReader"></param>
        public LotoClient(IResultReader resultReader) : base(resultReader) { }
        
        public decimal GetPrize(LotoResult result, LotoGuess guess)
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

        public decimal GetPrize(DateTime drawDate, LotoGuess guess)
        {
            var result = GetResult(drawDate);
            return GetPrize(result, guess);
        }

    }
}
