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

            var resultReader = new ResultFileReader("TestData", "sayisal-{0:yyyyMMdd}.json");
            //var sayisalLotoClient = new SayisalLotoClient(resultReader);
            var sayisalLotoClient = new SayisalLotoClient();
            var lotoResult = sayisalLotoClient.GetResult(new DateTime(2018, 10, 24));
            var numbers = new List<int> { 1,19,28,35,45,49};
            var prize = sayisalLotoClient.GetPrize(lotoResult, new SayisalLotoGuess(numbers));



            resultReader = new ResultFileReader("TestData", "superloto-{0:yyyyMMdd}.json");
            var superLotoClient = new SuperLotoClient(resultReader);
            lotoResult = superLotoClient.GetResult(new DateTime(2018, 1, 25));
            numbers = new List<int> { 5, 12, 15, 35, 45, 49 };
            prize = superLotoClient.GetPrize(lotoResult, new SuperLotoGuess(numbers));


            resultReader = new ResultFileReader("TestData", "piyango-{0:yyyyMMdd}.json");
            var piyangoClient = new Piyango.PiyangoClient(resultReader);
            var piyangoResult = piyangoClient.GetResult(new DateTime(2018, 1, 29));
            numbers = new List<int> { 6,7, 1, 8, 1, 5 };
            prize = piyangoClient.GetPrize(piyangoResult, new Piyango.PiyangoGuess(numbers));

            Console.Read();
        }
    }
}
