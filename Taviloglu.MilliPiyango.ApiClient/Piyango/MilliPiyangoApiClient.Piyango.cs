﻿using System;
using Taviloglu.MilliPiyango.ApiClient.Piyango;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient : IPiyangoClient
    {
        public IPiyangoClient Piyango { get { return (IPiyangoClient)this; } }

        decimal IPiyangoClient.GetPrize(PiyangoResult result, PiyangoGuess guess)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            if (guess == null)
            {
                throw new ArgumentNullException(nameof(guess));
            }

            var prize = 0m;

            foreach (var sonuc in result.Sonuclar)
            {
                var index = (guess.Numbers.Count - sonuc.HaneSayisi) % guess.Numbers.Count;

                var numbersToCheck = guess.Numbers.GetRange(index, sonuc.HaneSayisi);
                var myNumber = string.Join("", numbersToCheck);

                if (sonuc.Numaralar.Contains(myNumber))
                {
                    prize += sonuc.Ikramiye;
                }
            }

            return prize;
        }

        

        PiyangoResult IPiyangoClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResultFromWeb<PiyangoResult>(drawDate, "piyango", "", savePath);
        }
    }
}
