using System;
using System.Collections.Generic;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;
using Taviloglu.MilliPiyango.ApiClient.SuperLoto;
using Taviloglu.MilliPiyango.ApiClient.Extensions;

namespace Taviloglu.MilliPiyango.ApiClient.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var milliPiyangonClient = new MilliPiyangoApiClient();
            //var result = milliPiyangonClient.SuperLoto.GetResult(new DateTime(2018, 10, 18));
            //var newResult = milliPiyangonClient.Piyango.GetResult(new DateTime(2018, 1, 29));
            //var prizem = milliPiyangonClient.Piyango.GetPrize(new DateTime(2018, 1, 29), new Piyango.PiyangoGuess(new List<int> { 6, 7, 1, 8, 1, 5 }));



            //var sansTopuResult = milliPiyangonClient.SansTopu.GetResult(new DateTime(2018, 10, 17));
            //var sansTopuPrize = milliPiyangonClient.SansTopu.GetPrize(sansTopuResult, new SansTopu.SansTopuGuess(new List<int> { 19, 26, 18, 3, 5 }, 5));

            //var sansTopuPrize2 = milliPiyangonClient.SansTopu.GetPrize(new DateTime(2018, 10, 17), new SansTopu.SansTopuGuess(new List<int> { 19, 26, 18, 3, 5 }, 5));

            var onNumaraResult = milliPiyangonClient.OnNumara.GetResult(new DateTime(2018, 10, 15),"onnumara-20181015.json");
            var onNumaraPrize = milliPiyangonClient.OnNumara.GetPrize(onNumaraResult, new OnNumara.OnNumaraGuess(new List<int> { 1, 8, 14, 24, 25, 35, 41, 9, 10, 11 }));
            onNumaraPrize = milliPiyangonClient.OnNumara.GetPrize(new DateTime(2018, 10, 15), new OnNumara.OnNumaraGuess(new List<int> { 1, 8, 14, 24, 25, 35, 41, 9, 10, 11 }));

            Console.Read();
        }
    }
}
