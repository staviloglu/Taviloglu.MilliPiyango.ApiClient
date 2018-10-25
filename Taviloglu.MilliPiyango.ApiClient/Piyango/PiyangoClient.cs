using System;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public class PiyangoClient : Client<PiyangoResult>
    {

        public PiyangoClient(IResultReader resultReader) : base(resultReader) { }

        public PiyangoClient() : base(new PiyangoResultWebReader()) { }

        public decimal GetPrize(PiyangoResult result, PiyangoGuess guess)
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
    }
}
