using System;
using System.Collections.Generic;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;
using Taviloglu.MilliPiyango.ApiClient.SuperLoto;

namespace Taviloglu.MilliPiyango.ApiClient.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var milliPiyangonClient = new MilliPiyangoApiClient();
            var result = milliPiyangonClient.SuperLoto.GetResult(new DateTime(2018, 10, 18));
            var newResult = milliPiyangonClient.Piyango.GetResult(new DateTime(2018, 1, 29));
            var prizem = milliPiyangonClient.Piyango.GetPrize(new DateTime(2018, 1, 29), new Piyango.PiyangoGuess(new List<int> { 6, 7, 1, 8, 1, 5 }));


            Console.Read();
        }
    }
}
