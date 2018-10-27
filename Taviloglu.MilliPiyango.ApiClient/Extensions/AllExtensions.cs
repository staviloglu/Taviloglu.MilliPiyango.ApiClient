using System;
using Taviloglu.MilliPiyango.ApiClient.OnNumara;
using Taviloglu.MilliPiyango.ApiClient.Piyango;
using Taviloglu.MilliPiyango.ApiClient.SansTopu;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;
using Taviloglu.MilliPiyango.ApiClient.SuperLoto;

namespace Taviloglu.MilliPiyango.ApiClient.Extensions
{
    public static class AllExtensions
    {
        public static decimal GetPrize(this IPiyangoClient client, DateTime drawDate, PiyangoGuess guess)
        {
            var result = client.GetResult(drawDate);
            return client.GetPrize(result, guess);
        }

        public static decimal GetPrize(this ISayisalLotoClient client, DateTime drawDate, SayisalLotoGuess guess)
        {
            var result = client.GetResult(drawDate);
            return client.GetPrize(result, guess);
        }

        public static decimal GetPrize(this ISuperLotoClient client, DateTime drawDate, SuperLotoGuess guess)
        {
            var result = client.GetResult(drawDate);
            return client.GetPrize(result, guess);
        }

        public static decimal GetPrize(this ISansTopuClient client, DateTime drawDate, SansTopuGuess guess)
        {
            var result = client.GetResult(drawDate);
            return client.GetPrize(result, guess);
        }

        public static decimal GetPrize(this IOnNumaraClient client, DateTime drawDate, OnNumaraGuess guess)
        {
            var result = client.GetResult(drawDate);
            return client.GetPrize(result, guess);
        }
    }
}
